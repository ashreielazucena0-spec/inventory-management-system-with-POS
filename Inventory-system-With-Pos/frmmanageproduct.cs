using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    public partial class frmmanageproduct : Form
    {
        private readonly string _currentAccId;

        private add _addForm;

        private bool _addFormIsEdit;

        public frmmanageproduct() : this("")
        {
        }

        public frmmanageproduct(string currentAccId)
        {
            InitializeComponent();
            _currentAccId = currentAccId ?? "";

            this.Disposed += (s, e) =>
            {
                _addForm?.Close();
                _addForm = null;
            };

            ApplyStyle();
        }

        
        private void ApplyStyle()
        {
            
            Styles.RoundCorners(pnlLogo, 12);
            Styles.RoundCorners(pnlSearchCard, 14);
            Styles.RoundCorners(pnlGridCard, Theme.RadiusLarge);
            Styles.RoundCorners(pnlFooter, Theme.RadiusLarge);
            Styles.RoundCorners(pnlSelectedBadge, Theme.RadiusLarge);

            
            Styles.RoundCorners(btnAdd, Theme.RadiusMedium);
            Styles.RoundCorners(btnEdit, Theme.RadiusMedium);
            Styles.RoundCorners(btnDelete, Theme.RadiusMedium);
            Styles.RoundCorners(btnToggleStatus, Theme.RadiusMedium);

            
            Styles.Placeholder(txtSearch, "Enter product name or barcode...");

            
            pnlGridCard.Resize += (s, e) => CenterEmptyState();
        }

        private void CenterEmptyState()
        {
            pnlEmptyState.Left = Math.Max(0, (pnlGridCard.ClientSize.Width - pnlEmptyState.Width) / 2);
            pnlEmptyState.Top = Math.Max(0, (pnlGridCard.ClientSize.Height - pnlEmptyState.Height) / 2);
        }


        private void frmmanageproduct_Load(object sender, EventArgs e)
        {
            Styles.ReadOnlyGrid(gridProducts);

            CenterEmptyState();
            LoadProducts();
            UpdateSelectedLabel();
        }

        private void LoadProducts(string searchText = "")
        {
            try
            {
                gridProducts.Rows.Clear();

                const string query = @"SELECT p.product_id, p.barcode, p.product_name, c.category_name,
                                               p.selling_price, p.product_status,
                                               COALESCE(s.current_quantity, 0) AS current_quantity
                                        FROM tbl_product p
                                        JOIN tbl_category c ON c.category_id = p.category_id
                                        LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                                        WHERE p.product_name LIKE @search
                                           OR p.barcode LIKE @search
                                           OR c.category_name LIKE @search
                                           OR p.product_id LIKE @search
                                        ORDER BY p.product_name ASC";

                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    string search = searchText == null ? "" : searchText.Trim();
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = gridProducts.Rows.Add(
                                reader["barcode"] == DBNull.Value ? "" : reader["barcode"].ToString(),
                                reader["product_name"].ToString(),
                                reader["category_name"].ToString(),
                                Convert.ToDecimal(reader["selling_price"]).ToString("0.00"),
                                reader["current_quantity"].ToString(),
                                reader["product_status"].ToString()
                            );

                            gridProducts.Rows[rowIndex].Tag = reader["product_id"].ToString();
                        }
                    }
                }

                gridProducts.ClearSelection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load products.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool hasProducts = gridProducts.Rows.Count > 0;
            pnlEmptyState.Visible = !hasProducts;
            if (!hasProducts)
            {
                bool searching = !string.IsNullOrWhiteSpace(searchText);
                SafeUi.SetText(this, "lblEmptyTitle", searching ? "No matching products" : "No products found");
                SafeUi.SetText(this, "lblEmptySubtitle", searching
                    ? "Try a different name, barcode, or category."
                    : "Start by adding a new product or search for an existing one.");
                CenterEmptyState();
                pnlEmptyState.BringToFront();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private void gridProducts_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedLabel();
        }

        private void gridProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != colStatus.Index || e.Value == null) return;

            string status = e.Value.ToString();
            var cellStyle = gridProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style;

            if (string.Equals(status, "Active", StringComparison.OrdinalIgnoreCase))
            {
                cellStyle.ForeColor = Theme.Success;
            }
            else
            {
                cellStyle.ForeColor = Theme.Danger;
            }
        }

        private void UpdateSelectedLabel()
        {
            if (gridProducts.SelectedRows.Count == 0)
            {
                SafeUi.SetText(this, "lblSelected", "N/A");
                btnToggleStatus.Text = "Set Status";
                return;
            }

            var row = gridProducts.SelectedRows[0];
            string code = row.Tag?.ToString() ?? "";
            string name = row.Cells[1].Value?.ToString() ?? "";
            SafeUi.SetText(this, "lblSelected", $"{code} - {name}");

            bool isActive = string.Equals(row.Cells[5].Value?.ToString(), "Active", StringComparison.OrdinalIgnoreCase);
            btnToggleStatus.Text = isActive ? "Deactivate" : "Activate";
        }

        private void SelectRowByProductId(string productId)
        {
            foreach (DataGridViewRow row in gridProducts.Rows)
            {
                if (row.Tag?.ToString() == productId)
                {
                    row.Selected = true;
                    gridProducts.CurrentCell = row.Cells[1];
                    return;
                }
            }
        }

        private string GetSelectedProductId()
        {
            if (gridProducts.SelectedRows.Count == 0) return null;
            return gridProducts.SelectedRows[0].Tag?.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenAddForm(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenSelectedForEdit();
        }

        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            string productId = GetSelectedProductId();
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please select a product first.", "Product Status",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = gridProducts.SelectedRows[0];
            string productName = row.Cells[1].Value?.ToString() ?? productId;
            bool isActive = string.Equals(row.Cells[5].Value?.ToString(), "Active", StringComparison.OrdinalIgnoreCase);
            string newStatus = isActive ? "Inactive" : "Active";

            if (isActive)
            {
                using (var confirm = new frmConfirmDialog("Deactivate Product",
                    $"Deactivate \"{productName}\"? It will no longer appear in the POS."))
                {
                    if (confirm.ShowDialog(this) != DialogResult.Yes) return;
                }
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string updateQuery = "UPDATE tbl_product SET product_status = @status WHERE product_id = @id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not change the product status.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadProducts(txtSearch.Text);
            SelectRowByProductId(productId);
            UpdateSelectedLabel();
        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) OpenSelectedForEdit();
        }

        private void OpenSelectedForEdit()
        {
            string productId = GetSelectedProductId();
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please select a product to edit.", "Edit Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OpenAddForm(productId);
        }

        private void OpenAddForm(string productIdToEdit)
        {
            bool isEdit = !string.IsNullOrEmpty(productIdToEdit);

            if (_addForm != null && !_addForm.IsDisposed && _addFormIsEdit != isEdit)
            {
                _addForm.Close();
                _addForm = null;
            }

            if (_addForm == null || _addForm.IsDisposed)
            {
                _addForm = new add(_currentAccId);
                _addFormIsEdit = isEdit;

                _addForm.ProductSaved += (s, e) =>
                {
                    if (!this.IsDisposed) LoadProducts(txtSearch.Text);
                };
                _addForm.FormClosed += (s, e) => { _addForm = null; };

                if (isEdit) _addForm.LoadForEdit(productIdToEdit);
                else _addForm.PrepareNewProduct(null);

                PositionNextToThis(_addForm);
                _addForm.Show(this.TopLevelControl);
            }
            else
            {
                if (isEdit) _addForm.LoadForEdit(productIdToEdit);
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
            {
                y = Math.Max(screen.Top, screen.Bottom - form.Height);
            }

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(x, y);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productId = GetSelectedProductId();
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please select a product to delete.", "Delete Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string productName = gridProducts.SelectedRows[0].Cells[1].Value?.ToString() ?? productId;

            using (var confirm = new frmConfirmDialog("Delete Product",
                $"Delete \"{productName}\"? This cannot be undone."))
            {
                if (confirm.ShowDialog(this) != DialogResult.Yes) return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string deleteQuery = "DELETE FROM tbl_product WHERE product_id = @id";
                    using (var cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                try
                {
                    using (var conn = DBConnection.GetConnection())
                    {
                        const string deactivateQuery = "UPDATE tbl_product SET product_status = 'Inactive' WHERE product_id = @id";
                        using (var cmd = new MySqlCommand(deactivateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        "This product is used by other records (stock history or past sales), " +
                        "so it can't be permanently deleted. It has been marked Inactive instead " +
                        "and will no longer appear in the POS.",
                        "Marked Inactive", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex2)
                {
                    MessageBox.Show("Could not delete or deactivate the product.\r\n\r\n" + ex2.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProducts(txtSearch.Text);
            UpdateSelectedLabel();
        }

    }
}