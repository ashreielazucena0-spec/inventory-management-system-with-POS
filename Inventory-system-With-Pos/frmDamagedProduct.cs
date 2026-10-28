using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    
    public partial class frmDamagedProduct : Form
    {
        private readonly string _currentAccId;

        // Totals of the history currently shown in the grid (used by Export).
        private int _totalQty;
        private decimal _totalValue;
        private readonly List<object[]> _historyRows = new List<object[]>();

        private class ProductOption
        {
            public string Id;
            public string Name;
            public decimal CostPrice;
            public override string ToString() => Name;
        }

        public frmDamagedProduct(string currentAccId)
        {
            _currentAccId = currentAccId ?? "";
            InitializeComponent();
        }

        public frmDamagedProduct() : this("") { }

        private void frmDamagedProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadHistory();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedItem is ProductOption p)
                txtUnitCost.Text = p.CostPrice.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void LoadProducts()
        {
            cboProduct.Items.Clear();
            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(
                    "SELECT product_id, product_name, cost_price FROM tbl_product WHERE product_status = 'Active' ORDER BY product_name", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboProduct.Items.Add(new ProductOption
                        {
                            Id = reader["product_id"].ToString(),
                            Name = reader["product_name"].ToString(),
                            CostPrice = Convert.ToDecimal(reader["cost_price"])
                        });
                    }
                }
                if (cboProduct.Items.Count > 0) cboProduct.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load products.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmDamagedProduct.LoadProducts",
                    "Unable to display the product list (a record may contain invalid data).",
                    "Damaged Product");
            }
        }

        private void LoadHistory()
        {
            try
            {
                gridHistory.Rows.Clear();
                _historyRows.Clear();
                int totalQty = 0;
                decimal totalValue = 0m;

                const string query = @"
                    SELECT sm.created_at, p.product_name, c.category_name,
                           sm.quantity, sm.unit_cost, sm.remarks
                    FROM tbl_stock_log sm
                    JOIN tbl_product p ON p.product_id = sm.product_id
                    LEFT JOIN tbl_category c ON c.category_id = p.category_id
                    WHERE sm.movement_type = 'OUT' AND sm.reason = 'DAMAGED'
                    ORDER BY sm.created_at DESC";

                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int qty = Convert.ToInt32(reader["quantity"]);
                        decimal unitCost = reader["unit_cost"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["unit_cost"]);
                        decimal value = qty * unitCost;
                        totalQty += qty;
                        totalValue += value;

                        DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                        string productName = reader["product_name"].ToString();
                        string category = reader["category_name"] == DBNull.Value ? "Uncategorized" : reader["category_name"].ToString();
                        string remarks = reader["remarks"] == DBNull.Value ? "" : reader["remarks"].ToString();

                        
                        _historyRows.Add(new object[] { createdAt, productName, category, qty, unitCost, value, remarks });

                        gridHistory.Rows.Add(
                            createdAt.ToString("yyyy-MM-dd HH:mm"),
                            productName,
                            category,
                            qty,
                            unitCost.ToString("0.00"),
                            value.ToString("0.00"),
                            remarks);
                    }
                }

                _totalQty = totalQty;
                _totalValue = totalValue;

                SafeUi.SetText(this, "lblTotalQty", $"Total units damaged: {totalQty}");
                SafeUi.SetText(this, "lblTotalValue", $"Total value lost: \u20B1{totalValue:0.00}");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load damage history.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmDamagedProduct.LoadHistory",
                    "Unable to display the damage history (a record may contain invalid data).",
                    "Damaged Product");
            }
            finally
            {
                RefreshEmptyState();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!(cboProduct.SelectedItem is ProductOption product))
            {
                MessageBox.Show("Please select a product.", "Damaged Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a whole number quantity greater than zero.", "Damaged Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Same currency rule as the rest of the app: invariant culture, e.g. 1234.50
            if (!decimal.TryParse(txtUnitCost.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal unitCost) || unitCost < 0)
            {
                MessageBox.Show("Enter a valid unit cost (use a period for decimals, e.g. 125.50).", "Damaged Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitCost.Focus();
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var tx = conn.BeginTransaction())
                {
                    int available;
                    const string lockQuery = "SELECT quantity FROM tbl_stock WHERE product_id = @id FOR UPDATE";
                    using (var cmd = new MySqlCommand(lockQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@id", product.Id);
                        object result = cmd.ExecuteScalar();
                        available = result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    }

                    if (available < quantity)
                    {
                        tx.Rollback();
                        MessageBox.Show($"Only {available} unit(s) currently in stock. Cannot damage {quantity}.",
                            "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Stock = Stock - Damaged Quantity, applied directly.
                    const string deductQuery = "UPDATE tbl_stock SET quantity = quantity - @qty WHERE product_id = @productId";
                    using (var cmd = new MySqlCommand(deductQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@productId", product.Id);
                        cmd.ExecuteNonQuery();
                    }

                    const string logQuery = @"
                        INSERT INTO tbl_stock_log
                            (product_id, movement_type, reason, quantity, unit_cost, performed_by, remarks)
                        VALUES (@productId, 'OUT', 'DAMAGED', @qty, @unitCost, @performedBy, @remarks)";

                    using (var cmd = new MySqlCommand(logQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@productId", product.Id);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@unitCost", unitCost);
                        cmd.Parameters.AddWithValue("@performedBy", string.IsNullOrEmpty(_currentAccId) ? (object)DBNull.Value : _currentAccId);
                        cmd.Parameters.AddWithValue("@remarks", string.IsNullOrEmpty(txtRemarks.Text.Trim()) ? (object)DBNull.Value : txtRemarks.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }

                MessageBox.Show("Damage recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Clear();
                txtRemarks.Clear();
                LoadHistory();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmDamagedProduct.btnRecord_Click (database)");
                MessageBox.Show("Could not record the damage.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // The transaction rolls back automatically when its connection is disposed.
                ErrorLogger.LogAndShow(ex, "frmDamagedProduct.btnRecord_Click",
                    "The damage record hit an unexpected error. Please check the damage history before trying again.",
                    "Damaged Product");
            }
        }

        // ---------- Export to Excel (.xlsx, formatted) ----------

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_historyRows.Count == 0)
            {
                MessageBox.Show("There are no damage records to export.",
                    "Export Damaged Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Damaged Products";
                dlg.Filter = "Excel workbook (*.xlsx)|*.xlsx";
                dlg.FileName = $"DamagedProducts_{DateTime.Today:yyyy-MM-dd}.xlsx";
                dlg.DefaultExt = "xlsx";
                dlg.AddExtension = true;
                dlg.OverwritePrompt = true;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    WriteHistoryWorkbook(dlg.FileName);
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
                    // Workbook-generation or data-conversion failure: no success message.
                    ErrorLogger.LogAndShow(ex, "frmDamagedProduct.btnExport_Click",
                        "The report could not be created because of an unexpected error. No file was saved.",
                        "Export Error");
                    return;
                }

                var open = MessageBox.Show("Damage history exported successfully.\r\n\r\nOpen the file now?",
                    "Export Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (open == DialogResult.Yes)
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo(dlg.FileName) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The file was saved but could not be opened.\r\n\r\n" + ex.Message,
                            "Export Damaged Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void WriteHistoryWorkbook(string path)
        {
            var wb = new XlsxWorkbook();
            var sheet = wb.AddSheet("Damaged Products");

            sheet.Title("Damaged Products Report", 7);
            sheet.Subtitle("Generated " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            sheet.Blank();
            sheet.KeyValue("Total units damaged", _totalQty, XlsxKind.Integer);
            sheet.KeyValue("Total value lost", _totalValue, XlsxKind.Money);
            sheet.Blank();

            sheet.Table(
                new[] { "Date", "Product", "Category", "Qty", "Unit cost", "Value lost", "Remarks" },
                _historyRows,
                new[] { XlsxKind.DateTime, XlsxKind.Text, XlsxKind.Text, XlsxKind.Integer, XlsxKind.Money, XlsxKind.Money, XlsxKind.Text },
                new[] { 3, 5 },      // total the Qty and Value lost columns
                true);               // filter buttons + frozen header row

            wb.Save(path);
        }

        // ---------- Empty-state placeholder (shown when gridHistory has no rows) ----------

        private void RefreshEmptyState()
        {
            bool hasRows = gridHistory.Rows.Count > 0;
            emptyStatePanel.Visible = !hasRows;
            gridHistory.Visible = hasRows;

            if (!hasRows)
            {
                CenterEmptyStateContent();
            }
        }

        private void emptyStatePanel_Resize(object sender, EventArgs e)
        {
            CenterEmptyStateContent();
        }

        private void CenterEmptyStateContent()
        {
            int panelWidth = emptyStatePanel.ClientSize.Width;
            int panelHeight = emptyStatePanel.ClientSize.Height;

            Label icon = SafeUi.Find<Label>(this, "lblEmptyIcon");
            Label badge = SafeUi.Find<Label>(this, "lblEmptyBadge");
            Label title = SafeUi.Find<Label>(this, "lblEmptyTitle");
            Label subtitle = SafeUi.Find<Label>(this, "lblEmptySubtitle");

            if (icon != null)
                icon.Location = new System.Drawing.Point((panelWidth - icon.Width) / 2, panelHeight / 2 - 78);
            if (badge != null && icon != null)
                badge.Location = new System.Drawing.Point(
                    icon.Right - badge.Width - 4,
                    icon.Bottom - badge.Height - 4);
            if (title != null)
                title.Location = new System.Drawing.Point((panelWidth - title.Width) / 2, panelHeight / 2 + 10);
            if (subtitle != null)
                subtitle.Location = new System.Drawing.Point((panelWidth - subtitle.Width) / 2, panelHeight / 2 + 40);
        }
    }
}