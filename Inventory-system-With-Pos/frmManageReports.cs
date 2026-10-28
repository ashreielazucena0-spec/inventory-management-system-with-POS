using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
   
    public partial class frmManageReports : Form
    {
        
        private bool _hasReport;
        private DateTime _reportFrom;
        private DateTime _reportTo;
        private decimal _reportRevenue;
        private int _reportTxns;
        private int _reportItems;
        private readonly List<object[]> _salesRows = new List<object[]>();
        private readonly List<object[]> _topRows = new List<object[]>();

        public frmManageReports()
        {
            InitializeComponent();
            WireVisualPolish();

            dtpFrom.Value = DateTime.Today.AddDays(-6);
            dtpTo.Value = DateTime.Today;
            this.Load += (s, e) => RunReport();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunReport();
        }

        private void RunReport()
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            if (from > to)
            {
                MessageBox.Show("The \"From\" date must be on or before the \"To\" date.", "Manage Reports",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    decimal revenue = 0m;
                    int txns = 0;

                    using (var cmd = new MySqlCommand(@"
                        SELECT COUNT(*) AS txns, COALESCE(SUM(total_amount), 0) AS revenue
                        FROM tbl_sale
                        WHERE sale_status = 'Completed' AND created_at BETWEEN @from AND @to", conn))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txns = Convert.ToInt32(reader["txns"]);
                                revenue = Convert.ToDecimal(reader["revenue"]);
                            }
                        }
                    }

                    int itemsSold;
                    using (var cmd = new MySqlCommand(@"
                        SELECT COALESCE(SUM(si.quantity), 0)
                        FROM tbl_sale_item si
                        JOIN tbl_sale s ON s.sale_id = si.sale_id
                        WHERE s.sale_status = 'Completed' AND s.created_at BETWEEN @from AND @to", conn))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                        itemsSold = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    lblRevenueValue.Text = $"\u20B1{revenue:0.00}";
                    lblTxnsValue.Text = txns.ToString();
                    lblItemsValue.Text = itemsSold.ToString();
                    lblAvgValue.Text = txns == 0 ? "\u20B10.00" : $"\u20B1{(revenue / txns):0.00}";

                    gridSales.Rows.Clear();
                    _salesRows.Clear();
                    using (var cmd = new MySqlCommand(@"
                        SELECT sale_id, created_at, cashier_id, payment_method, total_amount
                        FROM tbl_sale
                        WHERE sale_status = 'Completed' AND created_at BETWEEN @from AND @to
                        ORDER BY created_at DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string saleId = reader["sale_id"].ToString();
                                DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                                string cashier = reader["cashier_id"] == DBNull.Value ? "" : reader["cashier_id"].ToString();
                                string payment = reader["payment_method"].ToString();
                                decimal saleTotal = Convert.ToDecimal(reader["total_amount"]);

                                // Typed copy of the row for the Excel export.
                                _salesRows.Add(new object[] { saleId, createdAt, cashier, payment, saleTotal });

                                gridSales.Rows.Add(
                                    saleId,
                                    createdAt.ToString("yyyy-MM-dd HH:mm"),
                                    cashier,
                                    payment,
                                    saleTotal.ToString("0.00"));
                            }
                        }
                    }

                    gridTopProducts.Rows.Clear();
                    _topRows.Clear();
                    using (var cmd = new MySqlCommand(@"
                        SELECT p.product_name, SUM(si.quantity) AS qty_sold, SUM(si.line_total) AS revenue
                        FROM tbl_sale_item si
                        JOIN tbl_sale s ON s.sale_id = si.sale_id
                        JOIN tbl_product p ON p.product_id = si.product_id
                        WHERE s.sale_status = 'Completed' AND s.created_at BETWEEN @from AND @to
                        GROUP BY p.product_id, p.product_name
                        ORDER BY qty_sold DESC
                        LIMIT 10", conn))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                int qtySold = Convert.ToInt32(reader["qty_sold"]);
                                decimal productRevenue = Convert.ToDecimal(reader["revenue"]);

                             
                                _topRows.Add(new object[] { productName, qtySold, productRevenue });

                                gridTopProducts.Rows.Add(
                                    productName,
                                    qtySold.ToString(),
                                    productRevenue.ToString("0.00"));
                            }
                        }
                    }

                  
                    pnlSalesEmpty.Visible = gridSales.Rows.Count == 0;
                    pnlSalesEmpty.BringToFront();
                    pnlProductsEmpty.Visible = gridTopProducts.Rows.Count == 0;
                    pnlProductsEmpty.BringToFront();

                   
                    _reportFrom = from;
                    _reportTo = to.Date;
                    _reportRevenue = revenue;
                    _reportTxns = txns;
                    _reportItems = itemsSold;
                    _hasReport = true;
                }
            }
            catch (MySqlException ex)
            {
                _hasReport = false;
                MessageBox.Show("Unable to run the report.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
               
                _hasReport = false;
                ErrorLogger.LogAndShow(ex, "frmManageReports.RunReport",
                    "Unable to build the report (a record may contain an invalid date, amount, or quantity).",
                    "Manage Reports");
            }
        }

       

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!_hasReport || (_salesRows.Count == 0 && _topRows.Count == 0))
            {
                MessageBox.Show("There is no report data to export. Pick a date range and run the report first.",
                    "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string defaultName = $"SalesReport_{_reportFrom:yyyy-MM-dd}_to_{_reportTo:yyyy-MM-dd}.xlsx";

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Sales Report";
                dlg.Filter = "Excel workbook (*.xlsx)|*.xlsx";
                dlg.FileName = defaultName;
                dlg.DefaultExt = "xlsx";
                dlg.AddExtension = true;
                dlg.OverwritePrompt = true;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    WriteReportWorkbook(dlg.FileName);
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
                    ErrorLogger.LogAndShow(ex, "frmManageReports.btnExport_Click",
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
                        Process.Start(new ProcessStartInfo(dlg.FileName) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The file was saved but could not be opened.\r\n\r\n" + ex.Message,
                            "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void WriteReportWorkbook(string path)
        {
            string period = $"{_reportFrom:yyyy-MM-dd} to {_reportTo:yyyy-MM-dd}";
            string generated = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            var wb = new XlsxWorkbook();

            
            var summary = wb.AddSheet("Summary");
            summary.Title("Sales Report", 2);
            summary.Subtitle("Generated " + generated);
            summary.Blank();
            summary.KeyValue("Period", period, XlsxKind.Text);
            summary.KeyValue("Total revenue", _reportRevenue, XlsxKind.Money);
            summary.KeyValue("Transactions", _reportTxns, XlsxKind.Integer);
            summary.KeyValue("Items sold", _reportItems, XlsxKind.Integer);
            summary.KeyValue("Average sale", _reportTxns == 0 ? 0m : _reportRevenue / _reportTxns, XlsxKind.Money);

           
            var sales = wb.AddSheet("Transactions");
            sales.Title("Transactions", 5);
            sales.Subtitle("Period: " + period);
            sales.Blank();
            sales.Table(
                new[] { "Sale ID", "Date/Time", "Cashier", "Payment", "Total" },
                _salesRows,
                new[] { XlsxKind.Text, XlsxKind.DateTime, XlsxKind.Text, XlsxKind.Text, XlsxKind.Money },
                new[] { 4 },
                true);

           
            var top = wb.AddSheet("Top Products");
            top.Title("Top-selling products", 3);
            top.Subtitle("Period: " + period);
            top.Blank();
            top.Table(
                new[] { "Product", "Qty sold", "Revenue" },
                _topRows,
                new[] { XlsxKind.Text, XlsxKind.Integer, XlsxKind.Money },
                new[] { 1, 2 },
                true);

            wb.Save(path);
        }

       
        private void WireVisualPolish()
        {
            Styles.Card(topCard, 12);
            Styles.Card(salesCard, 12);
            Styles.Card(topBox, 12);

            foreach (var tile in new[] { cardRevenue, cardTxns, cardItems, cardAvg })
                Styles.RoundCorners(tile, 10);

            Styles.RoundCorners(pnlHeaderBadge, 12);
            Styles.RoundCorners(btnRun, 8);
            Styles.HoverColor(btnRun, Theme.Primary, Theme.PrimaryDark);

            Styles.RoundCorners(btnExport, 8);
            Styles.HoverColor(btnExport, Theme.NavyDark, Theme.PrimaryDark);

            Styles.BottomRule(salesCardHeader);
            Styles.BottomRule(topBoxHeader);
        }
    }
}