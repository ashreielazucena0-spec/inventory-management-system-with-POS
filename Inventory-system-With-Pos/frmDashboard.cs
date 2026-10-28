using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
        
    public partial class frmDashboard : Form
    {
        private const int LowStockThreshold = 10;
        private const int ExpiryWindowDays = 30;

        public frmDashboard()
        {
            InitializeComponent();

            
            foreach (DataGridView grid in new[] { gridRecentSales, gridLowStock })
            {
                Styles.Grid(grid);
                Styles.ReadOnlyGrid(grid);
            }

            foreach (string name in new[] { "lblActiveProductsIcon", "lblLowStockIcon", "lblTodaySalesIcon", "lblExpiringIcon" })
            {
                Label icon = SafeUi.Find<Label>(this, name);
                if (icon == null) continue;
                icon.TextAlign = ContentAlignment.MiddleCenter;
                Styles.Circle(icon);
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    SafeUi.SetText(this, "lblProductsValue", ExecuteScalarInt(conn,
                        "SELECT COUNT(*) FROM tbl_product WHERE product_status = 'Active'").ToString());

                    SafeUi.SetText(this, "lblLowStockValue", ExecuteScalarInt(conn, @"
                        SELECT COUNT(*) FROM tbl_product p
                        LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                        WHERE p.product_status = 'Active'
                          AND COALESCE(s.current_quantity, 0) <= " + LowStockThreshold).ToString());

                    using (var cmd = new MySqlCommand(@"
                        SELECT COUNT(*) AS txns, COALESCE(SUM(total_amount), 0) AS revenue
                        FROM tbl_sale
                        WHERE sale_status = 'Completed' AND DATE(created_at) = CURDATE()", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int txns = Convert.ToInt32(reader["txns"]);
                            decimal revenue = Convert.ToDecimal(reader["revenue"]);
                            SafeUi.SetText(this, "lblTodaySalesValue", $"\u20B1{revenue:0.00}");
                            SafeUi.SetText(this, "lblTodaySalesCaption", txns == 1 ? "1 transaction today" : $"{txns} transactions today");
                        }
                    }

                    using (var cmd = new MySqlCommand(@"
                        SELECT COUNT(DISTINCT sm.product_id) FROM tbl_stock_log sm
                        WHERE sm.movement_type = 'IN' AND sm.expiry_date IS NOT NULL
                          AND sm.expiry_date <= DATE_ADD(CURDATE(), INTERVAL " + ExpiryWindowDays + " DAY)", conn))
                    {
                        object expiringResult = cmd.ExecuteScalar();
                        int expiringCount = expiringResult == null || expiringResult == DBNull.Value ? 0 : Convert.ToInt32(expiringResult);
                        SafeUi.SetText(this, "lblExpiringValue", expiringCount.ToString());
                    }

                    gridRecentSales.Rows.Clear();
                    using (var cmd = new MySqlCommand(@"
                        SELECT sale_id, created_at, cashier_id, total_amount
                        FROM tbl_sale ORDER BY created_at DESC LIMIT 10", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gridRecentSales.Rows.Add(
                                reader["sale_id"].ToString(),
                                Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm"),
                                reader["cashier_id"] == DBNull.Value ? "" : reader["cashier_id"].ToString(),
                                Convert.ToDecimal(reader["total_amount"]).ToString("0.00"));
                        }
                    }
                    SafeUi.SetVisible(this, "lblRecentSalesEmpty", gridRecentSales.Rows.Count == 0);
                    gridRecentSales.Visible = gridRecentSales.Rows.Count > 0;

                    gridLowStock.Rows.Clear();
                    using (var cmd = new MySqlCommand(@"
                        SELECT p.product_name, p.barcode, COALESCE(s.current_quantity, 0) AS current_quantity
                        FROM tbl_product p
                        LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                        WHERE p.product_status = 'Active'
                        ORDER BY current_quantity ASC LIMIT 10", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gridLowStock.Rows.Add(
                                reader["product_name"].ToString(),
                                reader["barcode"] == DBNull.Value ? "" : reader["barcode"].ToString(),
                                reader["current_quantity"].ToString());
                        }
                    }
                    SafeUi.SetVisible(this, "lblLowStockEmpty", gridLowStock.Rows.Count == 0);
                    gridLowStock.Visible = gridLowStock.Rows.Count > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load dashboard data.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Bad values in the data or a UI update failure. Always log; only
                // show the message once so repeated refreshes don't spam the user.
                ErrorLogger.Log(ex, "frmDashboard.RefreshData");
                if (!_dashboardErrorShown)
                {
                    _dashboardErrorShown = true;
                    MessageBox.Show(
                        "Some dashboard figures could not be loaded because of unexpected data.\r\n\r\nThe problem was recorded in the error log.",
                        "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool _dashboardErrorShown;

        private int ExecuteScalarInt(MySqlConnection conn, string query)
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
            }
        }

    }
}