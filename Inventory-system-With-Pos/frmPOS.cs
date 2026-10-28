using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmPOS : Form
    {
        private readonly string _currentAccId;

        private class CartLine
        {
            public string ProductId;
            public string ProductName;
            public decimal UnitPrice;
            public int Quantity;
            public int AvailableStock;
            public decimal LineTotal => UnitPrice * Quantity;
        }

        private readonly List<CartLine> _cart = new List<CartLine>();
        private bool _paymentInProgress;

        // Last completed sale, for printing/reprinting.
        private List<CartLine> _lastReceiptLines = new List<CartLine>();
        private string _lastReceiptSaleId = "";
        private decimal _lastReceiptSubtotal;
        private decimal _lastReceiptVat;
        private decimal _lastReceiptTotal;
        private decimal _lastReceiptAmountPaid;
        private decimal _lastReceiptChange;
        private decimal _lastReceiptDiscount;
        private string _lastReceiptDiscountApprover = "";
        private string _lastReceiptRemarks = "";

        private const decimal SeniorDiscountRate = 0.20m;
        private const decimal VatRate = 0.12m;
        private bool _seniorDiscountApplied = false;
        private string _seniorDiscountApproverId = "";
        private string _seniorDiscountApproverName = "";

        // Store details printed on the receipt.
        private const string StoreName = "Azucena Convenient Store";
        private const string StoreAddressLine1 = "Elpidio Quirino st, Sumadat,";
        private const string StoreAddressLine2 = "Dumalinao, ZDS";
        private const string StorePhone = "Tel: 09163983310";

        // Characters per line on the 58mm receipt.
        private const int ReceiptLineWidth = 28;

        public frmPOS() : this("")
        {
        }

        public frmPOS(string currentAccId)
        {
            InitializeComponent();
            _currentAccId = currentAccId ?? "";

            
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return;
            }

            txtCashTendered.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Layout += (s, e) => FitCashTenderedBox();
            Shown += (s, e) => FitCashTenderedBox();

            SetupSummaryGrid();
            SetupKeyboard();

          
            gridCart.RowsAdded += (s, e) => RecalculateSummary();
            gridCart.RowsRemoved += (s, e) => RecalculateSummary();
            gridCart.CellValueChanged += (s, e) => RecalculateSummary();

            
            gridCart.CellEndEdit -= gridCart_CellEndEdit;
            gridCart.CellEndEdit += gridCart_CellEndEdit;

            gridCart.EditingControlShowing -= gridCart_EditingControlShowing;
            gridCart.EditingControlShowing += gridCart_EditingControlShowing;
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            Styles.ReadOnlyGrid(gridProducts);
            gridProducts.AlternatingRowsDefaultCellStyle.BackColor = Theme.SurfaceAlt;

            
            gridCart.ReadOnly = false;
            gridCart.AllowUserToAddRows = false;
            gridCart.MultiSelect = false;
            gridCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCart.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            gridCart.AlternatingRowsDefaultCellStyle.BackColor = Theme.SurfaceAlt;

            ApplyLargeFonts();
            SetupTabOrder();

            LoadProducts();
            UpdateSeniorDiscountUI();
            SetupPlaceholders();
            SetupIcons();
            UpdateEmptyCartState();

            // Ready to scan.
            ActiveControl = txtBarcode;
        }

        // Bigger fonts for readability.
        private void ApplyLargeFonts()
        {
            const string face = "Segoe UI";
            var body = new Font(face, 12F);
            var bodyBold = new Font(face, 12F, FontStyle.Bold);

            foreach (var grid in new[] { gridProducts, gridCart })
            {
                grid.DefaultCellStyle.Font = body;
                grid.ColumnHeadersDefaultCellStyle.Font = bodyBold;
                grid.ColumnHeadersHeight = 44;
                grid.RowTemplate.Height = 42;
            }
            colCartQty.DefaultCellStyle.Font = new Font(face, 14F, FontStyle.Bold);

            txtBarcode.Font = new Font(face, 14F);
            txtProductSearch.Font = new Font(face, 14F);
            txtRemarks.Font = body;
            txtCashTendered.Font = new Font(face, 18F, FontStyle.Bold);

            foreach (var b in new[] { btnAddToCart, btnRemove, btnClearCart, btnSeniorDiscount })
                b.Font = bodyBold;
            btnPay.Font = new Font(face, 12F, FontStyle.Bold);

            lblStoreName.Font = new Font(face, 22F, FontStyle.Bold);
            lblProductListTitle.Font = new Font(face, 14F, FontStyle.Bold);
            lblOrderTitle.Font = new Font(face, 14F, FontStyle.Bold);
            lblClock.Font = new Font(face, 13F, FontStyle.Bold);
            lblDate.Font = new Font(face, 10F);
            lblCashTendered.Font = bodyBold;
            lblDiscountStatus.Font = new Font(face, 11F);
            labelEmpty.Font = new Font(face, 14F, FontStyle.Bold);
            labelEmptyHint.Font = new Font(face, 11F);

            // Align label with the taller cash box.
            FitCashTenderedBox();
            lblCashTendered.Top = txtCashTendered.Top +
                (txtCashTendered.Height - lblCashTendered.Height) / 2;
        }

        // Fits the cash box between its label and the Pay button.
        // Bigger gap = box ends further left.
        private void FitCashTenderedBox()
        {
            const int gapToPayButton = 40;

            txtCashTendered.Left = lblCashTendered.Right + 8;
            txtCashTendered.Width = Math.Max(100,
                btnPay.Left - gapToPayButton - txtCashTendered.Left);
        }

        // Tab order follows the cashier's flow; shortcut buttons are skipped.
        private void SetupTabOrder()
        {
            txtBarcode.TabIndex = 1;
            txtProductSearch.TabIndex = 2;
            gridProducts.TabIndex = 3;
            gridCart.TabIndex = 4;
            txtCashTendered.TabIndex = 5;
            txtRemarks.TabIndex = 6;
            btnPay.TabIndex = 7;

            btnAddToCart.TabStop = false;
            btnRemove.TabStop = false;
            btnClearCart.TabStop = false;
            btnSeniorDiscount.TabStop = false;
            gridSummary.TabStop = false;
        }

        
        private void SetupKeyboard()
        {
            KeyPreview = true;
            txtProductSearch.KeyDown += txtProductSearch_KeyDown;
            txtCashTendered.KeyDown += txtCashTendered_KeyDown;

            var tips = new ToolTip();
            tips.SetToolTip(txtBarcode, "F2");
            tips.SetToolTip(txtProductSearch, "F3");
            tips.SetToolTip(txtCashTendered, "F4");
            tips.SetToolTip(gridCart, "F5");
            tips.SetToolTip(btnSeniorDiscount, "F6");
            tips.SetToolTip(btnRemove, "F7");
            tips.SetToolTip(btnClearCart, "F8");
            tips.SetToolTip(btnAddToCart, "F9");
            tips.SetToolTip(txtRemarks, "F10");
            tips.SetToolTip(btnPay, "F12");
        }

        private void FocusBox(Control c)
        {
            c.Focus();
            if (c is TextBox tb) tb.SelectAll();
        }

        private void FocusCart()
        {
            gridCart.Focus();
            if (gridCart.Rows.Count > 0 && gridCart.CurrentCell == null)
                gridCart.CurrentCell = gridCart.Rows[0].Cells[colCartQty.Index];
        }

        private void AddProductRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= gridProducts.Rows.Count) return;

            gridProducts.ClearSelection();
            gridProducts.CurrentCell = gridProducts.Rows[rowIndex].Cells[colProdName.Index];
            gridProducts.Rows[rowIndex].Selected = true;

            btnAddToCart_Click(this, EventArgs.Empty);

            txtProductSearch.Clear();
            FocusBox(txtBarcode);
        }

        // Enter adds top match; Down jumps to the list.
        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                AddProductRow(0);
            }
            else if (e.KeyCode == Keys.Down && gridProducts.Rows.Count > 0)
            {
                e.Handled = e.SuppressKeyPress = true;
                gridProducts.Focus();
            }
        }

        // Enter pays; Up goes back to barcode.
        private void txtCashTendered_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                btnPay_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = e.SuppressKeyPress = true;
                FocusBox(txtBarcode);
            }
        }

        // F7: removes the selected cart line.
        private void RemoveSelectedCartItem()
        {
            if (_cart.Count == 0) return;

            if (gridCart.SelectedRows.Count == 0 && gridCart.CurrentRow != null)
                gridCart.CurrentRow.Selected = true;

            btnRemove_Click(this, EventArgs.Empty);
            if (_cart.Count == 0) FocusBox(txtBarcode);
        }

        // F11: reprints the last receipt.
        private void ReprintLastReceipt()
        {
            if (_lastReceiptLines == null || _lastReceiptLines.Count == 0)
            {
                MessageBox.Show("There is no previous receipt to reprint yet.", "Reprint Receipt",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintReceipt();
        }

        // F1: shows keyboard shortcuts.
        private void ShowShortcutHelp()
        {
            MessageBox.Show(
                "F1   Show this help\r\n" +
                "F2   Barcode box  (Esc also works)\r\n" +
                "F3   Product search\r\n" +
                "F4   Cash tendered\r\n" +
                "F5   Cart grid\r\n" +
                "F6   Senior / PWD discount\r\n" +
                "F7   Remove selected cart item\r\n" +
                "F8   Clear cart\r\n" +
                "F9   Add highlighted product to cart\r\n" +
                "F10  Remarks\r\n" +
                "F11  Reprint last receipt\r\n" +
                "F12  Pay and print",
                "Keyboard Shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // F-key and grid key handling (grids consume keys before KeyDown).
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1: ShowShortcutHelp(); return true;
                case Keys.F2:
                case Keys.Escape: FocusBox(txtBarcode); return true;
                case Keys.F3: FocusBox(txtProductSearch); return true;
                case Keys.F4: FocusBox(txtCashTendered); return true;
                case Keys.F5: FocusCart(); return true;
                case Keys.F6: btnSeniorDiscount.PerformClick(); return true;
                case Keys.F7: RemoveSelectedCartItem(); return true;
                case Keys.F8: btnClearCart.PerformClick(); return true;
                case Keys.F9: btnAddToCart.PerformClick(); return true;
                case Keys.F10: FocusBox(txtRemarks); return true;
                case Keys.F11: ReprintLastReceipt(); return true;
                case Keys.F12: btnPay.PerformClick(); return true;
            }

            // Product list: Enter adds; Up on first row goes to search.
            if (ActiveControl == gridProducts)
            {
                if (keyData == Keys.Enter)
                {
                    AddProductRow(gridProducts.CurrentRow?.Index ?? -1);
                    return true;
                }
                if (keyData == Keys.Up && gridProducts.CurrentRow != null
                    && gridProducts.CurrentRow.Index == 0)
                {
                    FocusBox(txtProductSearch);
                    return true;
                }
            }
            // Cart: Enter edits qty; Delete removes the line.
            else if (ActiveControl == gridCart && !gridCart.IsCurrentCellInEditMode)
            {
                if (keyData == Keys.Enter && gridCart.CurrentRow != null)
                {
                    gridCart.CurrentCell = gridCart.CurrentRow.Cells[colCartQty.Index];
                    gridCart.BeginEdit(true);
                    return true;
                }
                if (keyData == Keys.Delete && gridCart.SelectedRows.Count > 0)
                {
                    btnRemove_Click(this, EventArgs.Empty);
                    if (_cart.Count == 0) FocusBox(txtBarcode);
                    return true;
                }
                if (keyData == Keys.Up && gridCart.CurrentRow != null
                    && gridCart.CurrentRow.Index == 0)
                {
                    FocusBox(txtBarcode);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SetupPlaceholders()
        {
            Styles.Placeholder(txtProductSearch, "Scan or enter product name / barcode...", 36, true);
            Styles.Placeholder(txtBarcode, "Enter barcode...", 40, true);
            Styles.Placeholder(txtCashTendered, "Enter amount...", 0, true);
            Styles.Placeholder(txtRemarks, "Remarks (optional)", 30, true);
        }

        private void UpdateEmptyCartState()
        {
            bool isEmpty = _cart.Count == 0;
            SafeUi.SetVisible(this, "pictureBoxEmptyCart", isEmpty);
            SafeUi.SetVisible(this, "labelEmpty", isEmpty);
            SafeUi.SetVisible(this, "labelEmptyHint", isEmpty);
        }

        private void SetupIcons()
        {
            PosIcons.AttachPictureIcons(this);

            PosIcons.SetButtonIcon(btnAddToCart, PosIcons.DrawPlusGlyph, 18);
            PosIcons.SetButtonIcon(btnRemove, PosIcons.DrawTrashGlyph, 18);
            PosIcons.SetButtonIcon(btnClearCart, PosIcons.DrawBroomGlyph, 18);
            PosIcons.SetButtonIcon(btnSeniorDiscount, PosIcons.DrawPersonGlyph, 16);
            PosIcons.SetButtonIcon(btnPay, PosIcons.DrawCardGlyph, 22);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            SafeUi.SetText(this, "lblClock", DateTime.Now.ToLongTimeString());
            SafeUi.SetText(this, "lblDate", DateTime.Now.ToLongDateString());
        }

        private void LoadProducts(string searchText = "")
        {
            try
            {
                gridProducts.Rows.Clear();

                const string query = @"SELECT p.product_id, p.barcode, p.product_name, p.selling_price,
                                               COALESCE(s.current_quantity, 0) AS current_quantity
                                        FROM tbl_product p
                                        LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                                        WHERE p.product_status = 'Active'
                                          AND (p.product_name LIKE @search OR p.barcode LIKE @search)
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
                                Convert.ToDecimal(reader["selling_price"]).ToString("0.00"),
                                reader["current_quantity"].ToString()
                            );

                            // Product id kept on the row.
                            gridProducts.Rows[rowIndex].Tag = reader["product_id"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to load products.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmPOS.LoadProducts",
                    "Unable to display the product list (a product record may contain invalid data).",
                    "Load Error");
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtProductSearch.Text);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (txtBarcode.Text.Trim().Length == 0)
                {
                    if (_cart.Count > 0) FocusBox(txtCashTendered);
                }
                else
                {
                    ScanBarcode();
                }
            }
            else if (e.KeyCode == Keys.Down && gridCart.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                FocusCart();
            }
        }

        private void ScanBarcode()
        {
            string barcode = txtBarcode.Text.Trim();
            txtBarcode.Clear();
            if (barcode.Length == 0) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string query = @"SELECT p.product_id, p.product_name, p.selling_price,
                                                   COALESCE(s.current_quantity, 0) AS current_quantity
                                            FROM tbl_product p
                                            LEFT JOIN vw_product_stock s ON s.product_id = p.product_id
                                            WHERE p.barcode = @barcode AND p.product_status = 'Active'";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show($"No active product found for barcode \"{barcode}\".",
                                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            AddToCart(
                                reader["product_id"].ToString(),
                                reader["product_name"].ToString(),
                                Convert.ToDecimal(reader["selling_price"]),
                                Convert.ToInt32(reader["current_quantity"]));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Could not look up that barcode.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmPOS.barcode lookup",
                    "Could not process that barcode (the product record may contain invalid data).",
                    "Barcode Error");
            }
            finally
            {
                txtBarcode.Focus();
            }
        }

        // Adds the highlighted product to the cart.
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to add.", "Add to Cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = gridProducts.SelectedRows[0];
            string productId = row.Tag?.ToString();
            string productName = row.Cells[1].Value?.ToString() ?? "";

            string priceText = Convert.ToString(row.Cells[2].Value, CultureInfo.InvariantCulture);
            string stockText = Convert.ToString(row.Cells[3].Value, CultureInfo.InvariantCulture);

            if (string.IsNullOrWhiteSpace(productId) ||
                !decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price) || price < 0 ||
                !int.TryParse(stockText, NumberStyles.Integer, CultureInfo.InvariantCulture, out int stock) || stock < 0)
            {
                MessageBox.Show("That product has invalid data (id, price, or stock) and cannot be added.\r\n\r\nPlease refresh the list or check the product record.",
                    "Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddToCart(productId, productName, price, stock);
        }

        // Adds one unit to the cart after a stock check.
        private void AddToCart(string productId, string productName, decimal unitPrice, int availableStock)
        {
            var existing = _cart.FirstOrDefault(c => c.ProductId == productId);

            if (existing != null)
            {
                if (existing.Quantity + 1 > availableStock)
                {
                    MessageBox.Show($"Only {availableStock} unit(s) of \"{productName}\" left in stock.",
                        "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existing.Quantity += 1;
                existing.AvailableStock = availableStock;
            }
            else
            {
                if (availableStock <= 0)
                {
                    MessageBox.Show($"\"{productName}\" is out of stock.",
                        "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _cart.Add(new CartLine
                {
                    ProductId = productId,
                    ProductName = productName,
                    UnitPrice = unitPrice,
                    Quantity = 1,
                    AvailableStock = availableStock
                });
            }

            RefreshCartGrid();
        }

        // Redraws the cart grid from the cart list.
        private void RefreshCartGrid()
        {
            gridCart.Rows.Clear();
            foreach (var line in _cart)
            {
                int rowIndex = gridCart.Rows.Add(
                    line.ProductName,
                    line.Quantity,
                    "\u20B1" + line.LineTotal.ToString("N2"));
                gridCart.Rows[rowIndex].Tag = line.ProductId;
            }

            UpdateEmptyCartState();
            RecalculateSummary();
        }

        // Qty cell accepts digits only.
        private void gridCart_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridCart.CurrentCell == null || gridCart.CurrentCell.ColumnIndex != colCartQty.Index) return;

            if (e.Control is TextBox editBox)
            {
                editBox.KeyPress -= QtyEditingControl_KeyPress;
                editBox.KeyPress += QtyEditingControl_KeyPress;
            }
        }

        private void QtyEditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // After a qty edit: validate against stock, update line total.
        private void gridCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != colCartQty.Index) return;
            if (e.RowIndex < 0 || e.RowIndex >= gridCart.Rows.Count) return;

            DataGridViewRow row = gridCart.Rows[e.RowIndex];
            string productId = row.Tag?.ToString();
            var line = _cart.FirstOrDefault(c => c.ProductId == productId);
            if (line == null) return;

            string input = row.Cells[colCartQty.Index].Value?.ToString().Trim();

            if (!int.TryParse(input, out int newQty) || newQty <= 0)
            {
                MessageBox.Show("Quantity must be a whole number of 1 or more.", "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells[colCartQty.Index].Value = line.Quantity;
                return;
            }

            if (newQty > line.AvailableStock)
            {
                MessageBox.Show($"Only {line.AvailableStock} unit(s) of \"{line.ProductName}\" left in stock.",
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells[colCartQty.Index].Value = line.Quantity;
                return;
            }

            line.Quantity = newQty;
            row.Cells[colCartTotal.Index].Value = "\u20B1" + line.LineTotal.ToString("N2");
            RecalculateSummary();
        }

        // Removes the selected cart line.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a cart item to remove.", "Remove Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string productId = gridCart.SelectedRows[0].Tag?.ToString();
            var line = _cart.FirstOrDefault(c => c.ProductId == productId);
            if (line != null) _cart.Remove(line);

            RefreshCartGrid();
        }

        // Clears the cart (with confirmation); resets discount and remarks.
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            using (var confirm = new frmConfirmDialog("Clear Cart", "Remove all items from the current order?"))
            {
                if (confirm.ShowDialog(this) != DialogResult.Yes) return;
            }

            _cart.Clear();
            ClearSeniorDiscount();
            txtRemarks.Clear();
            RefreshCartGrid();
            txtBarcode.Focus();
        }

        // Applies Senior/PWD discount (needs approval) or removes it.
        private void btnSeniorDiscount_Click(object sender, EventArgs e)
        {
            if (_seniorDiscountApplied)
            {
                using (var confirm = new frmConfirmDialog("Remove Discount",
                    "Remove the Senior Citizen / PWD discount from this order?"))
                {
                    if (confirm.ShowDialog(this) != DialogResult.Yes) return;
                }

                ClearSeniorDiscount();
                RecalculateSummary();
                return;
            }

            if (_cart.Count == 0)
            {
                MessageBox.Show("Add items to the cart before applying a discount.", "Point of Sale",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var auth = new frmSeniorDiscountAuth())
            {
                if (auth.ShowDialog(this) == DialogResult.OK)
                {
                    _seniorDiscountApplied = true;
                    _seniorDiscountApproverId = auth.ApprovedByAccId;
                    _seniorDiscountApproverName = auth.ApprovedByName;

                    UpdateSeniorDiscountUI();
                    RecalculateSummary();
                }
            }

            txtBarcode.Focus();
        }

        private void ClearSeniorDiscount()
        {
            _seniorDiscountApplied = false;
            _seniorDiscountApproverId = "";
            _seniorDiscountApproverName = "";
            UpdateSeniorDiscountUI();
        }

        private void UpdateSeniorDiscountUI()
        {
            if (_seniorDiscountApplied)
            {
                btnSeniorDiscount.Text = "Remove Senior/PWD Discount";
                btnSeniorDiscount.BackColor = Theme.Danger;
                SafeUi.SetText(this, "lblDiscountStatus", $"Approved by {_seniorDiscountApproverId}");
            }
            else
            {
                btnSeniorDiscount.Text = "Senior Citizen / PWD Discount";
                btnSeniorDiscount.BackColor = Theme.Warning;
                SafeUi.SetText(this, "lblDiscountStatus", "Not applied");
            }
        }

        private decimal CurrentDiscount(decimal subtotal)
        {
            return _seniorDiscountApplied ? Math.Round(subtotal * SeniorDiscountRate, 2) : 0m;
        }

        private void SetupSummaryGrid()
        {
            gridSummary.Columns.Clear();
            gridSummary.Rows.Clear();

            gridSummary.Columns.Add("Description", "Description");
            gridSummary.Columns.Add("Amount", "Amount");

            gridSummary.DefaultCellStyle.Font = new Font("Segoe UI", 13F);

            gridSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridSummary.RowTemplate.Height = 36;

            gridSummary.Rows.Add("SUBTOTAL", "\u20B10.00");
            gridSummary.Rows.Add("DISCOUNT", "\u20B10.00");
            gridSummary.Rows.Add("VAT (12%)", "\u20B10.00");
            gridSummary.Rows.Add("TOTAL", "\u20B10.00");

            gridSummary.ColumnHeadersVisible = false;
            gridSummary.RowHeadersVisible = false;

            gridSummary.AllowUserToAddRows = false;
            gridSummary.ReadOnly = true;

            gridSummary.ScrollBars = ScrollBars.None;

            gridSummary.Columns["Description"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            gridSummary.Columns["Amount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            gridSummary.Columns["Description"].Width = 150;
            gridSummary.Columns["Amount"].Width = 160;

            foreach (DataGridViewRow row in gridSummary.Rows)
                row.Height = 36;

            // TOTAL row is larger and highlighted.
            gridSummary.Rows[3].DefaultCellStyle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            gridSummary.Rows[3].DefaultCellStyle.BackColor = Theme.SuccessTint;
            gridSummary.Rows[3].DefaultCellStyle.ForeColor = Theme.NavyDark;
            gridSummary.Rows[3].Height = 46;

            ResizeSummaryGridToFitRows();
        }

        private void ResizeSummaryGridToFitRows()
        {
            int rowsHeight = gridSummary.Rows
                .Cast<DataGridViewRow>()
                .Sum(r => r.Height);

            int borders = gridSummary.Rows.Count + 1;
            int headerHeight = gridSummary.ColumnHeadersVisible
                ? gridSummary.ColumnHeadersHeight
                : 0;

            panelSummary.Height = rowsHeight + borders + headerHeight;
            panelSummary.Width = gridSummary.Columns["Description"].Width
                                + gridSummary.Columns["Amount"].Width
                                + borders;
        }

        private decimal CurrentTotal()
        {
            return _cart.Sum(c => c.LineTotal);
        }

        // VAT is computed after the discount.
        private decimal CurrentVat(decimal subtotal, decimal discount)
        {
            return Math.Round((subtotal - discount) * VatRate, 2);
        }

        // Recomputes subtotal, discount, VAT and total.
        private void RecalculateSummary()
        {
            decimal subtotal = CurrentTotal();
            decimal discount = CurrentDiscount(subtotal);
            decimal vat = CurrentVat(subtotal, discount);
            decimal total = subtotal - discount + vat;

            gridSummary.Rows[0].Cells[1].Value = "\u20B1" + subtotal.ToString("N2");
            gridSummary.Rows[1].Cells[1].Value = "\u20B1" + discount.ToString("N2");
            gridSummary.Rows[2].Cells[1].Value = "\u20B1" + vat.ToString("N2");
            gridSummary.Rows[3].Cells[1].Value = "\u20B1" + total.ToString("N2");
        }

        // Cash box: digits and one decimal point only.
        private void txtCashTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtCashTendered.Text.Contains(".")) return;
            e.Handled = true;
        }

        // Validates payment, saves sale, prints receipt, resets for next customer.
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("The cart is empty.", "Point of Sale",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Focus();
                return;
            }

            decimal subtotal = CurrentTotal();
            decimal discount = CurrentDiscount(subtotal);
            decimal vat = CurrentVat(subtotal, discount);
            decimal total = subtotal - discount + vat;

            if (!decimal.TryParse(txtCashTendered.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal amountPaid))
            {
                MessageBox.Show("Please enter the cash tendered.", "Point of Sale",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCashTendered.Focus();
                return;
            }

            // Reject negative and absurd amounts (likely typos).
            const decimal MaxCashTendered = 10000000m;
            if (amountPaid < 0 || amountPaid > MaxCashTendered)
            {
                MessageBox.Show("Please enter a valid cash amount (0 to " + MaxCashTendered.ToString("N0", CultureInfo.InvariantCulture) + ").",
                    "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCashTendered.Focus();
                return;
            }

            if (amountPaid < total)
            {
                MessageBox.Show("The amount tendered is less than the total due.", "Insufficient Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCashTendered.Focus();
                return;
            }

            decimal change = amountPaid - total;

            // Block double-clicks / repeated F12 while a sale is being saved.
            if (_paymentInProgress) return;
            _paymentInProgress = true;
            btnPay.Enabled = false;

            try
            {
                string saleId;
                try
                {
                    saleId = CompleteSale(subtotal, discount, vat, total, amountPaid, change);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadProductsSafe();
                    return;
                }
                catch (MySqlException ex)
                {
                    ErrorLogger.Log(ex, "frmPOS.btnPay_Click -> CompleteSale (database)");
                    MessageBox.Show("Could not complete the sale. No sale was saved.\r\n\r\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    ErrorLogger.Log(ex, "frmPOS.btnPay_Click -> CompleteSale (unexpected)");
                    MessageBox.Show(
                        "An unexpected error stopped the sale.\r\n\r\n" + ex.Message +
                        "\r\n\r\nBefore trying again, check the sales report to make sure the sale was not recorded.",
                        "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Copy the sale for printing/reprinting.
                    _lastReceiptLines = _cart.Select(c => new CartLine
                    {
                        ProductId = c.ProductId,
                        ProductName = c.ProductName,
                        UnitPrice = c.UnitPrice,
                        Quantity = c.Quantity,
                        AvailableStock = c.AvailableStock
                    }).ToList();
                    _lastReceiptSaleId = saleId;
                    _lastReceiptSubtotal = subtotal;
                    _lastReceiptVat = vat;
                    _lastReceiptDiscount = discount;
                    _lastReceiptDiscountApprover = _seniorDiscountApplied ? _seniorDiscountApproverId : "";
                    _lastReceiptTotal = total;
                    _lastReceiptAmountPaid = amountPaid;
                    _lastReceiptChange = change;
                    _lastReceiptRemarks = txtRemarks.Text.Trim();

                    string discountLine = discount > 0 ? $"Discount: -\u20B1{discount:0.00} (Senior/PWD)\r\n" : "";
                    MessageBox.Show(
                        $"Sale {saleId} completed.\r\n\r\n{discountLine}VAT (12%): \u20B1{vat:0.00}\r\nTotal: \u20B1{total:0.00}\r\nCash: {amountPaid:0.00}\r\nChange: \u20B1{change:0.00}",
                        "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PrintReceipt();
                }
                catch (Exception ex)
                {
                    ErrorLogger.Log(ex, "frmPOS.btnPay_Click -> post-sale UI (sale " + saleId + " already saved)");
                    MessageBox.Show(
                        "Sale " + saleId + " WAS saved, but something went wrong afterwards.\r\n\r\n" + ex.Message +
                        "\r\n\r\nDo NOT charge this customer again. Press F11 to reprint the receipt.",
                        "Sale Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    ResetAfterSale();
                }
            }
            finally
            {
                _paymentInProgress = false;
                btnPay.Enabled = true;
            }
        }

        private void ResetAfterSale()
        {
            try { _cart.Clear(); } catch (Exception ex) { ErrorLogger.Log(ex, "ResetAfterSale: clear cart"); }
            try { ClearSeniorDiscount(); } catch (Exception ex) { ErrorLogger.Log(ex, "ResetAfterSale: clear discount"); }
            try { RefreshCartGrid(); } catch (Exception ex) { ErrorLogger.Log(ex, "ResetAfterSale: refresh cart"); }
            try { txtCashTendered.Clear(); txtRemarks.Clear(); } catch (Exception ex) { ErrorLogger.Log(ex, "ResetAfterSale: clear inputs"); }
            LoadProductsSafe();
            try { txtBarcode.Focus(); } catch { }
        }

        private void LoadProductsSafe()
        {
            try { LoadProducts(txtProductSearch.Text); }
            catch (Exception ex) { ErrorLogger.Log(ex, "LoadProductsSafe"); }
        }

        private string CompleteSale(decimal subtotal, decimal discount, decimal vat, decimal total, decimal amountPaid, decimal change)
        {
            using (var conn = DBConnection.GetConnection())
            using (var tx = conn.BeginTransaction())
            {
                // Lock and re-read live stock from the database.
                foreach (var line in _cart)
                {
                    const string stockQuery = "SELECT quantity FROM tbl_stock WHERE product_id = @id FOR UPDATE";
                    using (var cmd = new MySqlCommand(stockQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@id", line.ProductId);
                        object result = cmd.ExecuteScalar();
                        int available = result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                        if (available < line.Quantity)
                        {
                            tx.Rollback();
                            throw new InvalidOperationException(
                                $"\"{line.ProductName}\" only has {available} unit(s) left. Please adjust the cart.");
                        }
                    }
                }

                string saleId = GenerateNextSaleId(conn, tx);

                const string insertSale = @"INSERT INTO tbl_sale
                    (sale_id, cashier_id, subtotal, discount_amount, discount_type, discount_approved_by, tax_amount, total_amount, amount_paid, change_due, payment_method, sale_status)
                    VALUES (@id, @cashier, @subtotal, @discount, @discountType, @discountApprover, @vat, @total, @paid, @change, 'Cash', 'Completed')";

                using (var cmd = new MySqlCommand(insertSale, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", saleId);
                    cmd.Parameters.AddWithValue("@cashier", string.IsNullOrEmpty(_currentAccId) ? (object)DBNull.Value : _currentAccId);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@vat", vat);
                    cmd.Parameters.AddWithValue("@discountType", discount > 0 ? "Senior/PWD" : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@discountApprover", discount > 0 && !string.IsNullOrEmpty(_seniorDiscountApproverId)
                        ? (object)_seniorDiscountApproverId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@paid", amountPaid);
                    cmd.Parameters.AddWithValue("@change", change);
                    cmd.ExecuteNonQuery();
                }

                // Per item: save line, deduct stock, log movement.
                foreach (var line in _cart)
                {
                    const string insertItem = @"INSERT INTO tbl_sale_item
                        (sale_id, product_id, quantity, unit_price, line_discount, line_total)
                        VALUES (@saleId, @productId, @qty, @price, 0, @lineTotal)";

                    using (var cmd = new MySqlCommand(insertItem, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@saleId", saleId);
                        cmd.Parameters.AddWithValue("@productId", line.ProductId);
                        cmd.Parameters.AddWithValue("@qty", line.Quantity);
                        cmd.Parameters.AddWithValue("@price", line.UnitPrice);
                        cmd.Parameters.AddWithValue("@lineTotal", line.LineTotal);
                        cmd.ExecuteNonQuery();
                    }

                    const string deductStock = "UPDATE tbl_stock SET quantity = quantity - @qty WHERE product_id = @productId";
                    using (var cmd = new MySqlCommand(deductStock, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@qty", line.Quantity);
                        cmd.Parameters.AddWithValue("@productId", line.ProductId);
                        cmd.ExecuteNonQuery();
                    }

                    const string insertLog = @"INSERT INTO tbl_stock_log
                        (product_id, movement_type, reason, quantity, reference_id, performed_by, remarks)
                        VALUES (@productId, 'OUT', 'SALE', @qty, @saleId, @performedBy, 'POS sale')";

                    using (var cmd = new MySqlCommand(insertLog, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@productId", line.ProductId);
                        cmd.Parameters.AddWithValue("@qty", line.Quantity);
                        cmd.Parameters.AddWithValue("@saleId", saleId);
                        cmd.Parameters.AddWithValue("@performedBy", string.IsNullOrEmpty(_currentAccId) ? (object)DBNull.Value : _currentAccId);
                        cmd.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                return saleId;
            }
        }

        // Returns the next sale id (SALE-000001 format).
        private string GenerateNextSaleId(MySqlConnection conn, MySqlTransaction tx)
        {
            const string query = @"SELECT sale_id FROM tbl_sale
                                    WHERE sale_id LIKE 'SALE-%'
                                    ORDER BY CAST(SUBSTRING(sale_id, 6) AS UNSIGNED) DESC LIMIT 1";

            using (var cmd = new MySqlCommand(query, conn, tx))
            {
                object result = cmd.ExecuteScalar();
                int nextNumber = 1;

                if (result != null)
                {
                    string lastId = result.ToString();
                    if (int.TryParse(lastId.Substring(5), out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                return "SALE-" + nextNumber.ToString("D6");
            }
        }

        // Prints the receipt on the default 58mm thermal printer.
        private void PrintReceipt()
        {
            try
            {
                using (var doc = new PrintDocument())
                {
                    // 58mm paper; bigger right margin pulls text left.
                    doc.DefaultPageSettings.PaperSize = new PaperSize("Receipt58mm", 228, 1100);
                    doc.DefaultPageSettings.Margins = new Margins(4, 30, 8, 8);
                    doc.PrintPage += ReceiptDocument_PrintPage;

                    doc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The sale was saved, but the receipt could not be printed.\r\n\r\n" + ex.Message,
                    "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Draws the receipt line by line.
        private void ReceiptDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // No anti-aliasing: thermal printers are black/white only.
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            g.SmoothingMode = SmoothingMode.None;

            // Bold monospaced fonts keep columns aligned and print darker.
            using (var fontNormal = new Font("Consolas", 8F, FontStyle.Bold))
            using (var fontBold = new Font("Consolas", 8F, FontStyle.Bold))
            using (var fontHeader = new Font("Consolas", 9.5F, FontStyle.Bold))
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float width = e.MarginBounds.Width;

                // Draws a line twice (slight offset) for darker print, then moves down.
                void WriteLine(string text, Font font, StringAlignment align = StringAlignment.Near)
                {
                    var format = new StringFormat { Alignment = align, FormatFlags = StringFormatFlags.NoWrap };
                    float lineHeight = font.GetHeight(g) + 2;
                    var rect = new RectangleF(x, y, width, lineHeight + 4);

                    g.DrawString(text, font, Brushes.Black, rect, format);
                    rect.X += 0.5f;
                    g.DrawString(text, font, Brushes.Black, rect, format);

                    y += lineHeight;
                }

                void WriteCentered(string text, Font font) => WriteLine(text, font, StringAlignment.Center);

                void WriteDivider() => WriteLine(new string('-', ReceiptLineWidth), fontNormal);

                // Left and right text on one line.
                string PadRow(string left, string right)
                {
                    int space = ReceiptLineWidth - left.Length - right.Length;
                    if (space < 1) space = 1;
                    return left + new string(' ', space) + right;
                }

                // Trims long text to fit one line.
                string WrapLeft(string text, int maxWidth)
                {
                    if (text.Length <= maxWidth) return text;
                    return text.Substring(0, Math.Max(0, maxWidth - 1)) + ".";
                }

                // Store header
                WriteCentered(StoreName, fontHeader);
                WriteCentered(StoreAddressLine1, fontNormal);
                WriteCentered(StoreAddressLine2, fontNormal);
                WriteCentered(StorePhone, fontNormal);
                WriteDivider();

                // Sale info
                WriteLine("Sale No: " + _lastReceiptSaleId, fontNormal);
                WriteLine("Date:    " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), fontNormal);
                WriteLine("Cashier: " + (string.IsNullOrEmpty(_currentAccId) ? "N/A" : _currentAccId), fontNormal);
                WriteDivider();

                // Items
                foreach (var line in _lastReceiptLines)
                {
                    WriteLine(WrapLeft(line.ProductName, ReceiptLineWidth), fontBold);

                    string qtyPrice = $"{line.Quantity} x {line.UnitPrice:0.00}";
                    string lineTotal = line.LineTotal.ToString("0.00");
                    WriteLine(PadRow(qtyPrice, lineTotal), fontNormal);
                }

                WriteDivider();

                // Totals
                WriteLine(PadRow("SUBTOTAL", _lastReceiptSubtotal.ToString("0.00")), fontNormal);
                if (_lastReceiptDiscount > 0)
                {
                    WriteLine(PadRow("DISCOUNT (SC/PWD)", "-" + _lastReceiptDiscount.ToString("0.00")), fontNormal);
                    if (!string.IsNullOrEmpty(_lastReceiptDiscountApprover))
                    {
                        WriteLine("Approved by: " + _lastReceiptDiscountApprover, fontNormal);
                    }
                }
                WriteLine(PadRow("VAT (12%)", _lastReceiptVat.ToString("0.00")), fontNormal);
                WriteLine(PadRow("TOTAL", _lastReceiptTotal.ToString("0.00")), fontBold);
                WriteLine(PadRow("CASH", _lastReceiptAmountPaid.ToString("0.00")), fontNormal);
                WriteLine(PadRow("CHANGE", _lastReceiptChange.ToString("0.00")), fontNormal);

                if (!string.IsNullOrEmpty(_lastReceiptRemarks))
                {
                    WriteDivider();
                    WriteLine("Remarks: " + WrapLeft(_lastReceiptRemarks, ReceiptLineWidth - 9), fontNormal);
                }

                WriteDivider();

                WriteCentered("Thank you for your purchase!", fontNormal);
                WriteLine(" ", fontNormal);
                WriteLine(" ", fontNormal);
            }

            e.HasMorePages = false;
        }
    }
}