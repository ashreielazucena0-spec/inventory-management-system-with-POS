using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace inventory_management_system_with_POS
{
    public partial class add : Form
    {

        private static readonly string[] DefaultCategories =
        {
            "Beverages", "Snacks", "Instant Food", "Canned Goods",
            "Candies & Chocolates", "Dairy & Chilled", "Frozen Foods",
            "Cooking Essentials", "Personal Care", "Household",
            "Baby Products", "Pet Supplies", "School & Office"
        };


        private readonly string _currentAccId;

        private string _editProductId = "";
        private bool IsEditMode => !string.IsNullOrWhiteSpace(_editProductId);


        public event EventHandler ProductSaved;

        // LoadForEdit() can run before the form's Load event has populated the
        // category/supplier combo boxes (ShowDialog() hasn't been called yet),
        // so the desired selection is stashed here and applied once the combo
        // boxes actually have items.
        private string _pendingCategoryId;
        private string _pendingSupplierId;

        public add(string currentAccId)
        {
            InitializeComponent();
            ApplyStyle();
            _currentAccId = currentAccId ?? "";
        }

        // Kept for designer/back-compat; always prefer add(string currentAccId).
        public add() : this("")
        {
        }

        /// <summary>
        /// Prepares a new-product entry, typically after a Manage Stock barcode
        /// scan that did not match any existing item. Quantity starts at 1 so
        /// the first stock-in is ready as soon as details are saved.
        /// </summary>
        public void PrepareNewProduct(string barcode)
        {
            _editProductId = "";
            _pendingCategoryId = null;
            _pendingSupplierId = null;

            SafeUi.SetText(this, "lblTitle", "ADD PRODUCT");
            SafeUi.SetText(this, "lblSubtitle", "Fill in the details below to add this item to stock.");
            SafeUi.SetText(this, "lblStockQty", "Initial Stock Qty");
            btnSave.Text = "+  Add";
            txtStockQty.Text = "1";

            if (!string.IsNullOrWhiteSpace(barcode))
                txtBarcode.Text = barcode.Trim();
        }

        /// <summary>
        /// Switches the form into edit mode and pre-fills it with the given product's data.
        /// Call ShowDialog() afterwards; it returns DialogResult.OK if changes were saved.
        /// </summary>
        public void LoadForEdit(string productId)
        {
            _editProductId = productId;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string query = @"SELECT product_name, barcode, category_id, supplier_id,
                                                   cost_price, selling_price
                                            FROM tbl_product WHERE product_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBarcode.Text = reader["barcode"] == DBNull.Value ? "" : reader["barcode"].ToString();
                                txtName.Text = reader["product_name"].ToString();
                                txtPurchasePrice.Text = Convert.ToDecimal(reader["cost_price"]).ToString("0.00", CultureInfo.InvariantCulture);
                                txtSellingPrice.Text = Convert.ToDecimal(reader["selling_price"]).ToString("0.00", CultureInfo.InvariantCulture);

                                _pendingCategoryId = reader["category_id"].ToString();
                                _pendingSupplierId = reader["supplier_id"] == DBNull.Value ? "" : reader["supplier_id"].ToString();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load product for editing.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // In edit mode you can optionally restock while editing, but the
            // quantity always starts at 0 so saving never adds stock by accident.
            SafeUi.SetText(this, "lblTitle", "EDIT PRODUCT");
            SafeUi.SetText(this, "lblSubtitle", "Update the details below and save your changes.");
            SafeUi.SetText(this, "lblStockQty", "Add Stock (optional)");
            txtStockQty.Text = "0";
            btnSave.Text = "\u2713  Save";
        }


        private void add_Load(object sender, EventArgs e)
        {
            dtpExpiry.MinDate = DateTime.Today;
            dtpExpiry.Value = DateTime.Today.AddYears(1);

            LoadCategories();
            LoadSuppliers();

            if (_pendingCategoryId != null) SelectComboValue(cboCategory, _pendingCategoryId);
            if (_pendingSupplierId != null) SelectComboValue(cboSupplier, _pendingSupplierId);

            Styles.Placeholder(txtBarcode, "Enter barcode...");
            Styles.Placeholder(txtName, "Enter product name...");
            Styles.Placeholder(txtPurchasePrice, "Enter purchase price...");
            Styles.Placeholder(txtSellingPrice, "Enter selling price...");

            // Ready for a scanner or manual typing the moment the form opens.
            txtBarcode.Focus();
        }


        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                HandleBarcodeScanned();
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            txtBarcode.Focus();
            txtBarcode.SelectAll();
        }

        private void HandleBarcodeScanned()
        {
            string barcode = txtBarcode.Text.Trim();
            if (barcode.Length == 0)
            {
                txtName.Focus();
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string query = "SELECT product_id, product_name FROM tbl_product WHERE barcode = @barcode";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string existingId = reader["product_id"].ToString();
                                string existingName = reader["product_name"].ToString();
                                reader.Close();

                                if (IsEditMode && existingId == _editProductId)
                                {

                                    txtName.Focus();
                                    return;
                                }

                                var result = MessageBox.Show(
                                    $"This barcode already belongs to \"{existingName}\" ({existingId}).\r\n\r\nOpen that product for editing instead?",
                                    "Barcode already exists",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    LoadForEdit(existingId);
                                }
                                else
                                {
                                    txtBarcode.Clear();
                                    txtBarcode.Focus();
                                }
                                return;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not look up that barcode.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txtStockQty.Text = "1";
            txtName.Focus();
        }

        // ---------------------------------------------------------------
        // Numeric-only guards for price/quantity fields
        // ---------------------------------------------------------------
        private void txtStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ---------------------------------------------------------------
        // Category / Supplier dropdowns
        // ---------------------------------------------------------------
        private class ComboOption
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        private void LoadCategories()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    long count = (long)new MySqlCommand("SELECT COUNT(*) FROM tbl_category", conn).ExecuteScalar();
                    if (count == 0)
                    {
                        foreach (string name in DefaultCategories)
                        {
                            InsertCategory(conn, name);
                        }
                    }

                    cboCategory.Items.Clear();
                    const string query = "SELECT category_id, category_name FROM tbl_category ORDER BY category_name";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboCategory.Items.Add(new ComboOption { Id = reader["category_id"].ToString(), Name = reader["category_name"].ToString() });
                        }
                    }

                    if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load categories.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertCategory(MySqlConnection conn, string name)
        {
            string newId = GenerateNextId(conn, "tbl_category", "category_id", "CAT-", 4);
            const string insert = "INSERT INTO tbl_category (category_id, category_name) VALUES (@id, @name)";
            using (var cmd = new MySqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@id", newId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    cboSupplier.Items.Clear();
                    cboSupplier.Items.Add(new ComboOption { Id = "", Name = "(No supplier)" });

                    const string query = "SELECT supplier_id, supplier_name FROM tbl_supplier ORDER BY supplier_name";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboSupplier.Items.Add(new ComboOption { Id = reader["supplier_id"].ToString(), Name = reader["supplier_name"].ToString() });
                        }
                    }

                    cboSupplier.SelectedIndex = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load suppliers.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectComboValue(ComboBox combo, string id)
        {
            foreach (var item in combo.Items)
            {
                if (item is ComboOption opt && opt.Id == id)
                {
                    combo.SelectedItem = opt;
                    return;
                }
            }
        }

        // ---------------------------------------------------------------
        // Save / Cancel
        // ---------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode) UpdateProduct();
            else CreateProduct();
        }

        private bool ValidateForm(out decimal costPrice, out decimal sellingPrice, out int quantity)
        {
            costPrice = 0; sellingPrice = 0; quantity = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!(cboCategory.SelectedItem is ComboOption))
            {
                MessageBox.Show("Please select a category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPurchasePrice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out costPrice) || costPrice < 0)
            {
                MessageBox.Show("Please enter a valid purchase price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurchasePrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSellingPrice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out sellingPrice) || sellingPrice < 0)
            {
                MessageBox.Show("Please enter a valid selling price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSellingPrice.Focus();
                return false;
            }

            if (!int.TryParse(string.IsNullOrWhiteSpace(txtStockQty.Text) ? "0" : txtStockQty.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockQty.Focus();
                return false;
            }

            return true;
        }

        private void CreateProduct()
        {
            if (!ValidateForm(out decimal costPrice, out decimal sellingPrice, out int quantity)) return;

            string barcode = txtBarcode.Text.Trim();
            string name = txtName.Text.Trim();
            var category = (ComboOption)cboCategory.SelectedItem;
            var supplier = cboSupplier.SelectedItem as ComboOption;
            string supplierId = string.IsNullOrEmpty(supplier?.Id) ? null : supplier.Id;
            bool saved = false;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    if (barcode.Length > 0)
                    {
                        const string checkQuery = "SELECT COUNT(*) FROM tbl_product WHERE barcode = @barcode";
                        using (var checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@barcode", barcode);
                            long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("That barcode is already used by another product.",
                                    "Barcode unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBarcode.Focus();
                                return;
                            }
                        }
                    }

                    using (MySqlTransaction tx = conn.BeginTransaction())
                    {
                        string newProductId = GenerateNextId(conn, "tbl_product", "product_id", "PRD-", 4);

                        const string insertQuery = @"INSERT INTO tbl_product
                            (product_id, product_name, barcode, category_id, supplier_id, cost_price, selling_price, product_status)
                            VALUES (@id, @name, @barcode, @categoryId, @supplierId, @cost, @selling, 'Inactive')";

                        using (var cmd = new MySqlCommand(insertQuery, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", newProductId);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@barcode", barcode.Length == 0 ? (object)DBNull.Value : barcode);
                            cmd.Parameters.AddWithValue("@categoryId", category.Id);
                            cmd.Parameters.AddWithValue("@supplierId", supplierId == null ? (object)DBNull.Value : supplierId);
                            cmd.Parameters.AddWithValue("@cost", costPrice);
                            cmd.Parameters.AddWithValue("@selling", sellingPrice);
                            cmd.ExecuteNonQuery();
                        }

                        if (quantity > 0)
                        {
                            InsertStockIn(conn, tx, newProductId, quantity, costPrice, supplierId);
                        }

                        tx.Commit();
                        saved = true;
                    }
                }

                this.DialogResult = DialogResult.OK;
                ProductSaved?.Invoke(this, EventArgs.Empty);

                MessageBox.Show(
                    "Product registered in Manage Stock.\r\n\r\nIt will not appear in POS until you add it from Manage Product.",
                    "Stock registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Stay open (rather than closing) so the user can keep adding
                // products while watching the Manage Product list update live.
                ResetFormForNextEntry();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "add.btnSave (create product, database)");
                MessageBox.Show("Could not add the product.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Non-database failure (conversion, invalid selection, UI callback).
                if (saved)
                {
                    ErrorLogger.LogAndShow(ex, "add.btnSave (create product, after save)",
                        "The product WAS saved, but the screen could not finish refreshing. Please reopen the list.",
                        "Product Saved");
                }
                else
                {
                    ErrorLogger.LogAndShow(ex, "add.btnSave (create product)",
                        "Could not add the product because of an unexpected error. Nothing was saved.",
                        "Error");
                }
            }
        }

        // Clears the fields after a successful add so the form is ready to take
        // the next product, without closing (category/supplier are left as-is
        // since consecutive additions are often for the same category/supplier).
        private void ResetFormForNextEntry()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtPurchasePrice.Clear();
            txtSellingPrice.Clear();
            txtStockQty.Text = "0";
            dtpExpiry.Value = DateTime.Today.AddYears(1);
            txtBarcode.Focus();
        }

        private void UpdateProduct()
        {
            if (!ValidateForm(out decimal costPrice, out decimal sellingPrice, out int quantity)) return;

            string barcode = txtBarcode.Text.Trim();
            string name = txtName.Text.Trim();
            var category = (ComboOption)cboCategory.SelectedItem;
            var supplier = cboSupplier.SelectedItem as ComboOption;
            string supplierId = string.IsNullOrEmpty(supplier?.Id) ? null : supplier.Id;
            bool saved = false;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    if (barcode.Length > 0)
                    {
                        const string checkQuery = "SELECT COUNT(*) FROM tbl_product WHERE barcode = @barcode AND product_id <> @id";
                        using (var checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@barcode", barcode);
                            checkCmd.Parameters.AddWithValue("@id", _editProductId);
                            long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("That barcode is already used by another product.",
                                    "Barcode unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBarcode.Focus();
                                return;
                            }
                        }
                    }

                    using (MySqlTransaction tx = conn.BeginTransaction())
                    {
                        const string updateQuery = @"UPDATE tbl_product SET
                            product_name = @name, barcode = @barcode, category_id = @categoryId,
                            supplier_id = @supplierId, cost_price = @cost, selling_price = @selling
                            WHERE product_id = @id";

                        using (var cmd = new MySqlCommand(updateQuery, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@barcode", barcode.Length == 0 ? (object)DBNull.Value : barcode);
                            cmd.Parameters.AddWithValue("@categoryId", category.Id);
                            cmd.Parameters.AddWithValue("@supplierId", supplierId == null ? (object)DBNull.Value : supplierId);
                            cmd.Parameters.AddWithValue("@cost", costPrice);
                            cmd.Parameters.AddWithValue("@selling", sellingPrice);
                            cmd.Parameters.AddWithValue("@id", _editProductId);
                            cmd.ExecuteNonQuery();
                        }

                        if (quantity > 0)
                        {
                            InsertStockIn(conn, tx, _editProductId, quantity, costPrice, supplierId);
                        }

                        tx.Commit();
                        saved = true;
                    }
                }

                this.DialogResult = DialogResult.OK;
                ProductSaved?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "add.btnSave (update product, database)");
                MessageBox.Show("Could not update the product.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (saved)
                {
                    ErrorLogger.LogAndShow(ex, "add.btnSave (update product, after save)",
                        "The product WAS updated, but the screen could not finish refreshing. Please reopen the list.",
                        "Product Updated");
                }
                else
                {
                    ErrorLogger.LogAndShow(ex, "add.btnSave (update product)",
                        "Could not update the product because of an unexpected error. Nothing was changed.",
                        "Error");
                }
            }
        }


        private void InsertStockIn(MySqlConnection conn, MySqlTransaction tx, string productId, int quantity, decimal unitCost, string supplierId)
        {
            const string upsertQuery = @"INSERT INTO tbl_stock (product_id, quantity)
                VALUES (@productId, @qty)
                ON DUPLICATE KEY UPDATE quantity = quantity + VALUES(quantity)";

            using (var cmd = new MySqlCommand(upsertQuery, conn, tx))
            {
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.ExecuteNonQuery();
            }

            const string logQuery = @"INSERT INTO tbl_stock_log
                (product_id, movement_type, reason, quantity, batch_no, expiry_date, unit_cost, supplier_id, performed_by, remarks)
                VALUES (@productId, 'IN', 'PURCHASE', @qty, @batch, @expiry, @cost, @supplierId, @performedBy, @remarks)";

            using (var cmd = new MySqlCommand(logQuery, conn, tx))
            {
                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@batch", "BATCH-" + DateTime.Now.ToString("yyyyMMddHHmmss"));
                cmd.Parameters.AddWithValue("@expiry", dtpExpiry.Value.Date);
                cmd.Parameters.AddWithValue("@cost", unitCost);
                cmd.Parameters.AddWithValue("@supplierId", supplierId == null ? (object)DBNull.Value : supplierId);
                cmd.Parameters.AddWithValue("@performedBy", string.IsNullOrEmpty(_currentAccId) ? (object)DBNull.Value : _currentAccId);
                cmd.Parameters.AddWithValue("@remarks", IsEditMode ? "Restock while editing" : "Initial stock via Manage Stock");
                cmd.ExecuteNonQuery();
            }
        }

        // Generic "PREFIX-0001" style ID generator shared by product/category ids.
        private string GenerateNextId(MySqlConnection conn, string table, string column, string prefix, int digits)
        {
            string query = $"SELECT {column} FROM {table} WHERE {column} LIKE @prefix " +
                            $"ORDER BY CAST(SUBSTRING({column}, {prefix.Length + 1}) AS UNSIGNED) DESC LIMIT 1";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@prefix", prefix + "%");
                object result = cmd.ExecuteScalar();
                int nextNumber = 1;

                if (result != null)
                {
                    string lastId = result.ToString();
                    string numericPart = lastId.Substring(prefix.Length);
                    if (int.TryParse(numericPart, out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                return prefix + nextNumber.ToString(new string('0', digits));
            }
        }

        // ---------------------------------------------------------------
        // ---------------------------------------------------------------
        // Appearance
        // ---------------------------------------------------------------
        // Colours, fonts and shapes are defined in Theme.cs / Styles.cs.
        // This method only states WHICH style each control uses, so none of
        // the save / edit logic above depends on it.
        // ---------------------------------------------------------------
        private void ApplyStyle()
        {
            // Header banner and sidebar: gradient backgrounds.
            panelBanner.Paint += (s, e) => Styles.Gradient(e.Graphics, panelBanner.ClientRectangle, Theme.PrimaryDeep, Theme.Primary);
            Styles.RoundCorners(panelSidebar, 18);
            panelSidebar.Paint += (s, e) => Styles.Gradient(e.Graphics, panelSidebar.ClientRectangle, Theme.SurfaceAlt, Theme.PrimaryTint);

            // Small icon chips beside each field (the emoji is stored in the panel's Tag).
            foreach (Panel chip in new[]
            {
                pnlIconName, pnlIconCategory, pnlIconPurchase, pnlIconSelling,
                pnlIconSupplier, pnlIconExpiry, pnlIconStock
            })
            {
                Panel target = chip;
                target.Paint += (s, e) => Styles.IconChip(e.Graphics, target.ClientRectangle, (string)target.Tag);
            }
            pnlIconBarcode.Paint += (s, e) => Styles.BarcodeChip(e.Graphics, pnlIconBarcode.ClientRectangle);

            // White rounded boxes behind each input.
            foreach (Panel field in new[]
            {
                pnlInputBarcode, pnlInputName, pnlInputCategory, pnlInputPurchase,
                pnlInputSelling, pnlInputSupplier, pnlInputExpiry, pnlInputStock
            })
            {
                Panel target = field;
                target.Paint += (s, e) => Styles.RoundedField(e.Graphics, target, Theme.RadiusMedium);
            }

            // Buttons.
            Styles.PrimaryButton(btnSave, Theme.RadiusMedium);
            Styles.PrimaryButton(btnScan, Theme.RadiusSmall);
            Styles.OutlineButton(btnCancel, Theme.RadiusMedium);
            Styles.GhostButton(btnClose, panelTitleBar.BackColor);

            // Thin separator line above the footer.
            panelFooter.Paint += (s, e) =>
            {
                using (var pen = new Pen(Theme.Border))
                    e.Graphics.DrawLine(pen, 0, 0, panelFooter.Width, 0);
            };
        }
    }
}
