using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    public partial class frmExpiredProducts : Form
    {
        private class CategoryOption
        {
            public string Id;
            public string Name;
            public override string ToString() => Name;
        }

        private class ReportRow
        {
            public string ProductName;
            public string Barcode;
            public string CategoryName;
            public string BatchNo;
            public DateTime ExpiryDate;
            public int Quantity;
            public decimal UnitCost;
            public decimal Value => Quantity * UnitCost;
            public int CurrentStock;
            public string Status; // "Expired" or "Expiring Soon"
        }

        private List<ReportRow> _rows = new List<ReportRow>();

        public frmExpiredProducts()
        {
            InitializeComponent();

            // The export button now produces a formatted Excel workbook
            // (the name btnExportCsv is kept so the designer wiring still works).
            btnExportCsv.Text = "Export Excel";

            // The search box is a composite control (rounded panel + icon +
            // borderless TextBox); wire the inner TextBox up the same way
            // the designer used to wire txtSearch directly.
            txtSearch = pnlSearch.TextBox;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmExpiredProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadReport();
        }

        // ---------------------------------------------------------------
        // Filters
        // ---------------------------------------------------------------
        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add(new CategoryOption { Id = "", Name = "All categories" });

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(
                    "SELECT category_id, category_name FROM tbl_category ORDER BY category_name ASC", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboCategory.Items.Add(new CategoryOption
                        {
                            Id = reader["category_id"].ToString(),
                            Name = reader["category_name"].ToString()
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load categories.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmExpiredProducts.LoadCategories",
                    "Unable to load the category filter.", "Expired Products");
            }

            cboCategory.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadReport();
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) => LoadReport();
        private void nudDays_ValueChanged(object sender, EventArgs e) => LoadReport();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadReport();

        // Keep the empty-state message centered inside its panel whenever
        // the form (and therefore the anchored panel) is resized.
        private void panelEmptyState_Resize(object sender, EventArgs e)
        {
            SafeUi.CenterHorizontally(this, "glyphEmptyState", panelEmptyState);
            SafeUi.CenterHorizontally(this, "lblEmptyTitle", panelEmptyState);
            SafeUi.CenterHorizontally(this, "lblEmptySubtitle", panelEmptyState);
        }

        // ---------------------------------------------------------------
        // Report data
        // ---------------------------------------------------------------
        // A batch's remaining quantity isn't tracked separately from a
        // product's overall stock (sales don't record which batch they
        // came from), so this reads every incoming batch with an expiry
        // date and flags it Expired / Expiring Soon based on that date.
        // "Current stock" is the product's overall remaining quantity,
        // shown alongside so a cashier can see whether it's still on
        // the shelf at all.
        private void LoadReport()
        {
            _rows.Clear();
            dataGridViewReport.Rows.Clear();

            int days = (int)nudDays.Value;
            string search = (txtSearch.Text ?? "").Trim();
            string categoryId = (cboCategory.SelectedItem as CategoryOption)?.Id ?? "";

            const string query = @"
                SELECT p.product_name, p.barcode, c.category_name,
                       sm.batch_no, sm.expiry_date, sm.quantity, sm.unit_cost,
                       COALESCE(vs.current_quantity, 0) AS current_stock
                FROM tbl_stock_log sm
                JOIN tbl_product p ON p.product_id = sm.product_id
                LEFT JOIN tbl_category c ON c.category_id = p.category_id
                LEFT JOIN vw_product_stock vs ON vs.product_id = sm.product_id
                WHERE sm.movement_type = 'IN'
                  AND sm.expiry_date IS NOT NULL
                  AND sm.expiry_date <= DATE_ADD(CURDATE(), INTERVAL @days DAY)
                  AND (p.product_name LIKE @search OR p.barcode LIKE @search)
                  AND (@categoryId = '' OR p.category_id = @categoryId)
                ORDER BY sm.expiry_date ASC";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@days", days);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var expiry = Convert.ToDateTime(reader["expiry_date"]);
                            var row = new ReportRow
                            {
                                ProductName = reader["product_name"].ToString(),
                                Barcode = reader["barcode"] == DBNull.Value ? "" : reader["barcode"].ToString(),
                                CategoryName = reader["category_name"] == DBNull.Value ? "Uncategorized" : reader["category_name"].ToString(),
                                BatchNo = reader["batch_no"] == DBNull.Value ? "" : reader["batch_no"].ToString(),
                                ExpiryDate = expiry,
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                UnitCost = reader["unit_cost"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["unit_cost"]),
                                CurrentStock = Convert.ToInt32(reader["current_stock"]),
                                Status = expiry.Date < DateTime.Today ? "Expired" : "Expiring Soon"
                            };
                            _rows.Add(row);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load the expired products report.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                // Bad or unexpected values in the data (dates, quantities, costs).
                _rows.Clear();
                ErrorLogger.LogAndShow(ex, "frmExpiredProducts.LoadReport (reading data)",
                    "Unable to read the expired products data (a record may contain an invalid date, quantity, or cost).",
                    "Expired Products");
                return;
            }

            try
            {
            foreach (var row in _rows)
            {
                dataGridViewReport.Rows.Add(
                    row.ProductName,
                    row.Barcode,
                    row.CategoryName,
                    row.BatchNo,
                    row.ExpiryDate.ToString("yyyy-MM-dd"),
                    row.Quantity,
                    row.UnitCost.ToString("₱0.00"),
                    row.Value.ToString("₱0.00"),
                    row.CurrentStock,
                    row.Status);
            }

            panelEmptyState.Visible = _rows.Count == 0;
            if (panelEmptyState.Visible)
            {
                panelEmptyState.BringToFront();
                panelEmptyState_Resize(this, EventArgs.Empty);
            }

            RefreshSummary();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmExpiredProducts.LoadReport (display)",
                    "Unable to display the expired products report.", "Expired Products");
            }
        }

        private void RefreshSummary()
        {
            int expiredCount = _rows.Count(r => r.Status == "Expired");
            int expiringCount = _rows.Count(r => r.Status == "Expiring Soon");
            decimal valueAtRisk = _rows.Sum(r => r.Value);

            SafeUi.SetText(this, "lblExpiredValue", expiredCount.ToString());
            SafeUi.SetText(this, "lblExpiringValue", expiringCount.ToString());
            SafeUi.SetText(this, "lblValueAtRiskValue", valueAtRisk.ToString("₱0.00"));

            SafeUi.SetText(this, "lblGenerated", "Generated " + DateTime.Now.ToString("MMM d, yyyy h:mm tt"));
            SafeUi.SetText(this, "lblTotalCount", $"{_rows.Count} item{(_rows.Count == 1 ? "" : "s")} flagged");
        }

        // Color-code rows: red tint for already-expired batches, amber
        // tint for batches expiring within the selected window.
        private void dataGridViewReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _rows.Count) return;

            var row = _rows[e.RowIndex];
            var gridRow = dataGridViewReport.Rows[e.RowIndex];

            // Colours come from Theme: red = already expired, orange = expiring soon.
            if (row.Status == "Expired")
                Styles.StatusRow(gridRow, Theme.DangerDark, Theme.DangerTint, Theme.DangerSoft);
            else
                Styles.StatusRow(gridRow, Theme.WarningDark, Theme.WarningTint, Theme.WarningSoft);

            if (e.ColumnIndex == colStatus.Index && e.Value != null)
            {
                e.CellStyle.Font = Theme.BodyBold;
            }
        }

        // ---------------------------------------------------------------
        // Export (Excel) / Print
        // ---------------------------------------------------------------
        // Wired to btnExportCsv in the designer; now writes a formatted .xlsx.
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (_rows.Count == 0)
            {
                MessageBox.Show("There's nothing to export.", "Export Excel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog
            {
                Title = "Export Expired Products",
                Filter = "Excel workbook (*.xlsx)|*.xlsx",
                FileName = "expired_products_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx",
                DefaultExt = "xlsx",
                AddExtension = true,
                OverwritePrompt = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            })
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    WriteReportWorkbook(dialog.FileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Could not save the file. If it is open in Excel, close it and try again.\r\n\r\n" + ex.Message,
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("You don't have permission to save to that location.\r\n\r\n" + ex.Message,
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogAndShow(ex, "frmExpiredProducts.btnExportCsv_Click",
                        "The report could not be created because of an unexpected error. No file was saved.",
                        "Export Error");
                    return;
                }

                var open = MessageBox.Show("Report exported successfully.\r\n\r\nOpen the file now?",
                    "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (open == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo(dialog.FileName) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The file was saved but could not be opened.\r\n\r\n" + ex.Message,
                            "Export Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void WriteReportWorkbook(string path)
        {
            int days = (int)nudDays.Value;
            string category = (cboCategory.SelectedItem as CategoryOption)?.Name ?? "All categories";
            string search = (txtSearch.Text ?? "").Trim();

            // Describe the filters so the printout explains what it contains.
            string filters = $"Expiring within {days} day{(days == 1 ? "" : "s")}  |  {category}";
            if (search.Length > 0) filters += $"  |  Search: \"{search}\"";

            int expiredCount = _rows.Count(r => r.Status == "Expired");
            int expiringCount = _rows.Count(r => r.Status == "Expiring Soon");
            decimal valueAtRisk = _rows.Sum(r => r.Value);

            var wb = new XlsxWorkbook();
            var sheet = wb.AddSheet("Expired Products");

            sheet.Title("Expired Products Report", 10);
            sheet.Subtitle("Azucena Convenient Store  |  Generated " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            sheet.Subtitle("Filters: " + filters);
            sheet.Blank();
            sheet.KeyValue("Expired items", expiredCount, XlsxKind.Integer);
            sheet.KeyValue("Expiring soon", expiringCount, XlsxKind.Integer);
            sheet.KeyValue("Value at risk", valueAtRisk, XlsxKind.Money);
            sheet.Blank();

            var data = new List<object[]>();
            foreach (var r in _rows)
            {
                data.Add(new object[]
                {
                    r.ProductName, r.Barcode, r.CategoryName, r.BatchNo, r.ExpiryDate.Date,
                    r.Quantity, r.UnitCost, r.Value, r.CurrentStock, r.Status
                });
            }

            sheet.Table(
                new[] { "Product", "Barcode", "Category", "Batch No", "Expiry Date", "Qty", "Unit Cost", "Value", "Current Stock", "Status" },
                data,
                new[]
                {
                    XlsxKind.Text, XlsxKind.Text, XlsxKind.Text, XlsxKind.Text, XlsxKind.Date,
                    XlsxKind.Integer, XlsxKind.Money, XlsxKind.Money, XlsxKind.Integer, XlsxKind.Status
                },
                new[] { 5, 7 },     // total Qty and Value (not Current stock: it repeats per batch)
                true);              // filter buttons + frozen header row

            wb.Save(path);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_rows.Count == 0)
            {
                MessageBox.Show("There's nothing to print.", "Print",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var doc = new PrintDocument())
                {
                    _printRowIndex = 0;
                    doc.DefaultPageSettings.Landscape = true;
                    doc.PrintPage += PrintDocument_PrintPage;
                    doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not print the report.\r\n\r\n" + ex.Message,
                    "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int _printRowIndex;

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;

            // Print fonts live in Theme (shared, so they are not disposed here).
            Font fontTitle = Theme.PrintTitle;
            Font fontHeader = Theme.PrintHeader;
            Font fontBody = Theme.PrintBody;
            {
                // Column layout (relative offsets from x).
                float[] colOffset = { 0, 180, 320, 440, 590, 670, 720, 800, 890, 980 };
                string[] headers = { "Product", "Category", "Batch no.", "Expiry", "Qty", "Cost", "Value", "Stock", "Status", "" };

                if (_printRowIndex == 0)
                {
                    g.DrawString("Expired Products Report", fontTitle, Brushes.Black, x, y);
                    y += 26;
                    g.DrawString("Generated " + DateTime.Now.ToString("MMM d, yyyy h:mm tt"), fontBody, Brushes.Gray, x, y);
                    y += 24;
                }

                for (int c = 0; c < headers.Length - 1; c++)
                {
                    g.DrawString(headers[c], fontHeader, Brushes.Black, x + colOffset[c], y);
                }
                y += 18;
                g.DrawLine(Pens.Black, x, y, x + width, y);
                y += 4;

                float bottomLimit = e.MarginBounds.Bottom;

                while (_printRowIndex < _rows.Count)
                {
                    if (y + 18 > bottomLimit)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    var row = _rows[_printRowIndex];
                    g.DrawString(Truncate(row.ProductName, 24), fontBody, Brushes.Black, x + colOffset[0], y);
                    g.DrawString(Truncate(row.CategoryName, 18), fontBody, Brushes.Black, x + colOffset[1], y);
                    g.DrawString(Truncate(row.BatchNo, 20), fontBody, Brushes.Black, x + colOffset[2], y);
                    g.DrawString(row.ExpiryDate.ToString("yyyy-MM-dd"), fontBody, Brushes.Black, x + colOffset[3], y);
                    g.DrawString(row.Quantity.ToString(), fontBody, Brushes.Black, x + colOffset[4], y);
                    g.DrawString(row.UnitCost.ToString("0.00"), fontBody, Brushes.Black, x + colOffset[5], y);
                    g.DrawString(row.Value.ToString("0.00"), fontBody, Brushes.Black, x + colOffset[6], y);
                    g.DrawString(row.CurrentStock.ToString(), fontBody, Brushes.Black, x + colOffset[7], y);
                    g.DrawString(row.Status, fontBody, row.Status == "Expired" ? Brushes.DarkRed : Brushes.DarkGoldenrod, x + colOffset[8], y);

                    y += 18;
                    _printRowIndex++;
                }

                e.HasMorePages = false;
            }
        }

        private static string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text) || text.Length <= maxLength) return text;
            return text.Substring(0, maxLength - 1) + "\u2026";
        }
    }
}