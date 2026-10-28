using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
   
    public partial class frmManageStock : Form
    {

        private readonly string _currentAccId;
        private add _addForm;

        public frmManageStock(string currentAccId)
        {
            _currentAccId = currentAccId ?? "";
            InitializeComponent();
            Styles.Placeholder(txtRemarks, "Optional remarks...");
            this.Load += (s, e) =>
            {
                if (cboDirection.Items.Count > 0) cboDirection.SelectedIndex = 0;
                if (cboReason.Items.Count > 0) cboReason.SelectedIndex = 0;
                LoadStock();
                txtSearch.Focus();
            };
            this.Disposed += (s, e) =>
            {
                _addForm?.Close();
                _addForm = null;
            };
        }

        public frmManageStock() : this("") { }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStock(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            IdentifyProduct(txtSearch.Text, offerAddIfMissing: true);
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            IdentifyProduct(txtSearch.Text, offerAddIfMissing: true);
        }

       
        private void IdentifyProduct(string rawInput, bool offerAddIfMissing)
        {
            string input = (rawInput ?? "").Trim();
            if (input.Length == 0)
            {
                MessageBox.Show("Scan a barcode or type a product name first.", "Identify Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            LoadStock(input);

            int matchRow = FindExactBarcodeRow(input);
            if (matchRow < 0 && gridStock.Rows.Count == 1)
                matchRow = 0;

            if (matchRow >= 0)
            {
                SelectStockRow(matchRow);
                cboDirection.SelectedIndex = 0;
                txtQuantity.Focus();
                return;
            }

            if (!offerAddIfMissing) return;

            var result = MessageBox.Show(
                $"No stock item matches \"{input}\".\r\n\r\nAdd this as a new product?",
                "Product not in stock",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                OpenAddProductForm(input);
        }

        private int FindExactBarcodeRow(string barcode)
        {
            for (int i = 0; i < gridStock.Rows.Count; i++)
            {
                string rowBarcode = gridStock.Rows[i].Cells["barcode"].Value?.ToString() ?? "";
                if (string.Equals(rowBarcode, barcode, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        private void SelectStockRow(int rowIndex)
        {
            gridStock.ClearSelection();
            if (rowIndex < 0 || rowIndex >= gridStock.Rows.Count) return;
            gridStock.Rows[rowIndex].Selected = true;
            if (gridStock.Rows[rowIndex].Cells.Count > 0)
                gridStock.CurrentCell = gridStock.Rows[rowIndex].Cells[0];
            UpdateSelectedLabel();
        }

        private void OpenAddProductForm(string barcodeHint)
        {
            if (_addForm == null || _addForm.IsDisposed)
            {
                _addForm = new add(_currentAccId);
                _addForm.ProductSaved += (s, e) =>
                {
                    if (this.IsDisposed) return;
                    LoadStock(txtSearch.Text);
                    if (!string.IsNullOrWhiteSpace(barcodeHint))
                    {
                        int row = FindExactBarcodeRow(barcodeHint.Trim());
                        if (row >= 0) SelectStockRow(row);
                    }
                };
                _addForm.FormClosed += (s, e) => { _addForm = null; };

                if (!string.IsNullOrWhiteSpace(barcodeHint))
                    _addForm.PrepareNewProduct(barcodeHint);

                PositionNextToThis(_addForm);
                _addForm.Show(this.TopLevelControl);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(barcodeHint))
                    _addForm.PrepareNewProduct(barcodeHint);
                _addForm.Activate();
            }
        }

        private void PositionNextToThis(Form form)
        {
            Point topRightOnScreen = this.PointToScreen(new Point(this.Width, 0));
            Rectangle screen = Screen.FromControl(this).WorkingArea;

            int x = topRightOnScreen.X + 8;
            int y = topRightOnScreen.Y;

            if (x + form.Width > screen.Right)
            {
                Point topLeftOnScreen = this.PointToScreen(Point.Empty);
                x = topLeftOnScreen.X - form.Width - 8;
                if (x < screen.Left) x = screen.Left;
            }

            if (y + form.Height > screen.Bottom)
                y = Math.Max(screen.Top, screen.Bottom - form.Height);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(x, y);
        }

        private void gridStock_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedLabel();
        }

        private void UpdateSelectedLabel()
        {
            if (gridStock.SelectedRows.Count == 0)
            {
                SafeUi.SetText(this, "lblSelected", "Selected product: none");
                return;
            }
            var row = gridStock.SelectedRows[0];
            SafeUi.SetText(this, "lblSelected", $"Selected product: {row.Cells["product_name"].Value}");
        }

        private string GetSelectedProductId()
        {
            if (gridStock.SelectedRows.Count == 0) return null;
            return gridStock.SelectedRows[0].Tag?.ToString();
        }

      
        public static System.Data.DataTable GetStockData(string searchText = "")
        {
            var table = new System.Data.DataTable();
            const string query = @"
                SELECT p.product_id, p.product_name, p.barcode, c.category_name,
                       p.cost_price, COALESCE(s.current_quantity, 0) AS current_quantity,
                       COALESCE(added.total_added, 0) AS total_added,
                       COALESCE(sold.total_sold, 0) AS total_sold
                FROM tbl_product p
                LEFT JOIN tbl_category c ON c.category_id = p.category_id
                LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                LEFT JOIN (
                    SELECT product_id, SUM(quantity) AS total_added
                    FROM tbl_stock_log WHERE movement_type = 'IN'
                    GROUP BY product_id
                ) added ON added.product_id = p.product_id
                LEFT JOIN (
                    SELECT product_id, SUM(quantity) AS total_sold
                    FROM tbl_stock_log WHERE movement_type = 'OUT' AND reason = 'SALE'
                    GROUP BY product_id
                ) sold ON sold.product_id = p.product_id
                WHERE (p.product_name LIKE @search OR p.barcode LIKE @search)
                ORDER BY p.product_name ASC";

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + (searchText ?? "").Trim() + "%");
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }

        private void LoadStock(string searchText = "")
        {
            try
            {
                gridStock.Rows.Clear();
                foreach (System.Data.DataRow row in GetStockData(searchText).Rows)
                {
                    decimal costPrice = Convert.ToDecimal(row["cost_price"]);
                    int qty = Convert.ToInt32(row["current_quantity"]);
                    int totalAdded = Convert.ToInt32(row["total_added"]);
                    int totalSold = Convert.ToInt32(row["total_sold"]);
                    int rowIndex = gridStock.Rows.Add(
                        row["product_name"].ToString(),
                        row["barcode"] == DBNull.Value ? "" : row["barcode"].ToString(),
                        row["category_name"] == DBNull.Value ? "Uncategorized" : row["category_name"].ToString(),
                        qty,
                        totalAdded,
                        totalSold,
                        costPrice.ToString("0.00"),
                        (costPrice * qty).ToString("0.00"));
                    gridStock.Rows[rowIndex].Tag = row["product_id"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load stock.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmManageStock.LoadStock",
                    "Unable to display the stock list (a record may contain invalid data).",
                    "Manage Stock");
            }
            finally
            {
                UpdateEmptyState();
            }
        }

        /// <summary>
        /// Shows the "No products found" placeholder in place of the grid
        /// whenever the current search has no matching rows, and swaps back
        /// to the grid as soon as rows exist again.
        /// </summary>
        private void UpdateEmptyState()
        {
            bool isEmpty = gridStock.Rows.Count == 0;
            pnlEmptyState.Visible = isEmpty;
            gridStock.Visible = !isEmpty;

            bool hasSearchText = !string.IsNullOrWhiteSpace(txtSearch.Text);
            SafeUi.SetText(this, "lblEmptySubtitle", hasSearchText
                ? "No matches for your search. Try a different name or barcode."
                : "Start by scanning a product or adding a new one.");
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            string productId = GetSelectedProductId();
            if (productId == null)
            {
                MessageBox.Show("Please select a product from the list first.", "Manage Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            const int MaxAdjustment = 1000000;
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0 || quantity > MaxAdjustment)
            {
                MessageBox.Show("Enter a whole number quantity between 1 and " + MaxAdjustment.ToString("N0") + ".", "Manage Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            if (cboDirection.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose Stock In or Stock Out.", "Manage Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDirection.Focus();
                return;
            }

            if (cboReason.SelectedItem == null)
            {
                MessageBox.Show("Please choose a reason for this adjustment.", "Manage Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboReason.Focus();
                return;
            }

            bool isStockIn = cboDirection.SelectedIndex == 0;
            string reason = cboReason.SelectedItem.ToString();
            string remarks = txtRemarks.Text.Trim();

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var tx = conn.BeginTransaction())
                {
                   
                    int available;
                    const string lockQuery = "SELECT quantity FROM tbl_stock WHERE product_id = @id FOR UPDATE";
                    using (var cmd = new MySqlCommand(lockQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        object result = cmd.ExecuteScalar();
                        available = result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    }

                    if (!isStockIn && available < quantity)
                    {
                        tx.Rollback();
                        MessageBox.Show($"Only {available} unit(s) currently in stock. Cannot remove {quantity}.",
                            "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int delta = isStockIn ? quantity : -quantity;
                    const string upsertQuery = @"
                        INSERT INTO tbl_stock (product_id, quantity) VALUES (@productId, @delta)
                        ON DUPLICATE KEY UPDATE quantity = quantity + VALUES(quantity)";
                    using (var cmd = new MySqlCommand(upsertQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@delta", delta);
                        cmd.ExecuteNonQuery();
                    }

                    // History only - not read back to determine quantity.
                    const string logQuery = @"
                        INSERT INTO tbl_stock_log
                            (product_id, movement_type, reason, quantity, performed_by, remarks)
                        VALUES (@productId, @type, @reason, @qty, @performedBy, @remarks)";
                    using (var cmd = new MySqlCommand(logQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@type", isStockIn ? "IN" : "OUT");
                        cmd.Parameters.AddWithValue("@reason", reason);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@performedBy", string.IsNullOrEmpty(_currentAccId) ? (object)DBNull.Value : _currentAccId);
                        cmd.Parameters.AddWithValue("@remarks", string.IsNullOrEmpty(remarks) ? (object)DBNull.Value : remarks);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }

                MessageBox.Show("Stock adjustment recorded.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtQuantity.Clear();
                txtRemarks.Clear();
                LoadStock(txtSearch.Text);
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmManageStock.BtnApply_Click (database)");
                MessageBox.Show("Could not record the adjustment.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmManageStock.BtnApply_Click",
                    "The stock adjustment hit an unexpected error. Please check the stock list before trying again.",
                    "Manage Stock");
            }
        }
    }
}