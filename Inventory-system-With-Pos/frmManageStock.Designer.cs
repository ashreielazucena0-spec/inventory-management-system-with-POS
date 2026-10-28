using System.Drawing;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    partial class frmManageStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used by the designer.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Palette

        // Header
        private Panel header;
        private Panel pnlHeaderIcon;
        private Label lblHeaderIconGlyph;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;

        // Content layout
        private TableLayoutPanel contentLayout;

        // Search row
        private Panel searchPanel;
        private Panel pnlSearchBox;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Button btnScan;

        // Grid card
        private Panel gridCard;
        private DataGridView gridStock;
        private Panel pnlEmptyState;
        private TableLayoutPanel emptyLayout;
        private Label lblEmptyIcon;
        private Label lblEmptyTitle;
        private Label lblEmptySubtitle;

        // Adjustment card
        private Panel adjustCard;
        private Panel pnlAdjustIcon;
        private Label lblAdjustIconGlyph;
        private Label lblAdjustTitle;
        private Label lblAdjustSubtitle;
        private Label lblFieldProduct;
        private Panel pnlSelectedBox;
        private Label lblSelected;
        private Label lblFieldDirection;
        private ComboBox cboDirection;
        private Label lblFieldReason;
        private ComboBox cboReason;
        private Label lblFieldQuantity;
        private TextBox txtQuantity;
        private Button btnApply;
        private Label lblFieldRemarks;
        private TextBox txtRemarks;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.lblHeaderIconGlyph = new System.Windows.Forms.Label();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.gridCard = new System.Windows.Forms.Panel();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmptyState = new System.Windows.Forms.Panel();
            this.emptyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmptyIcon = new System.Windows.Forms.Label();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.lblEmptySubtitle = new System.Windows.Forms.Label();
            this.adjustCard = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblFieldRemarks = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblFieldQuantity = new System.Windows.Forms.Label();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.lblFieldReason = new System.Windows.Forms.Label();
            this.cboDirection = new System.Windows.Forms.ComboBox();
            this.lblFieldDirection = new System.Windows.Forms.Label();
            this.pnlSelectedBox = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblFieldProduct = new System.Windows.Forms.Label();
            this.lblAdjustSubtitle = new System.Windows.Forms.Label();
            this.lblAdjustTitle = new System.Windows.Forms.Label();
            this.pnlAdjustIcon = new System.Windows.Forms.Panel();
            this.lblAdjustIconGlyph = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.pnlEmptyState.SuspendLayout();
            this.emptyLayout.SuspendLayout();
            this.adjustCard.SuspendLayout();
            this.pnlSelectedBox.SuspendLayout();
            this.pnlAdjustIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = Theme.Navy;
            this.header.Controls.Add(this.lblHeaderSubtitle);
            this.header.Controls.Add(this.lblHeaderTitle);
            this.header.Controls.Add(this.pnlHeaderIcon);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1120, 92);
            this.header.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = Theme.Body;
            this.lblHeaderSubtitle.ForeColor = Theme.BorderStrong;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(83, 49);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(206, 21);
            this.lblHeaderSubtitle.TabIndex = 2;
            this.lblHeaderSubtitle.Text = "Keep track of your inventory";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = Theme.Title;
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(82, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(180, 35);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Manage Stock";
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.BackColor = Theme.NavyMid;
            this.pnlHeaderIcon.Controls.Add(this.lblHeaderIconGlyph);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(24, 24);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(44, 44);
            this.pnlHeaderIcon.TabIndex = 0;
            // 
            // lblHeaderIconGlyph
            // 
            this.lblHeaderIconGlyph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderIconGlyph.Font = Theme.Glyph16;
            this.lblHeaderIconGlyph.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIconGlyph.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderIconGlyph.Name = "lblHeaderIconGlyph";
            this.lblHeaderIconGlyph.Size = new System.Drawing.Size(44, 44);
            this.lblHeaderIconGlyph.TabIndex = 0;
            this.lblHeaderIconGlyph.Text = "";
            this.lblHeaderIconGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentLayout
            // 
            this.contentLayout.BackColor = Theme.Page;
            this.contentLayout.ColumnCount = 1;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.Controls.Add(this.searchPanel, 0, 0);
            this.contentLayout.Controls.Add(this.gridCard, 0, 1);
            this.contentLayout.Controls.Add(this.adjustCard, 0, 2);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(0, 92);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.contentLayout.RowCount = 3;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.contentLayout.Size = new System.Drawing.Size(1120, 728);
            this.contentLayout.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.pnlSearchBox);
            this.searchPanel.Controls.Add(this.btnScan);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(24, 20);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1072, 46);
            this.searchPanel.TabIndex = 0;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchBox.BackColor = System.Drawing.Color.White;
            this.pnlSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Controls.Add(this.lblSearchIcon);
            this.pnlSearchBox.Location = new System.Drawing.Point(0, 4);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(936, 38);
            this.pnlSearchBox.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = Theme.Large;
            this.txtSearch.ForeColor = Theme.TextStrong;
            this.txtSearch.Location = new System.Drawing.Point(48, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(872, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Font = Theme.Glyph11;
            this.lblSearchIcon.ForeColor = Theme.TextHint;
            this.lblSearchIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(24, 24);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.BackColor = Theme.Primary;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = Theme.BodyBold;
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(952, -14);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(120, 70);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Search  ▾";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // gridCard
            // 
            this.gridCard.BackColor = System.Drawing.Color.White;
            this.gridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridCard.Controls.Add(this.gridStock);
            this.gridCard.Controls.Add(this.pnlEmptyState);
            this.gridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCard.Location = new System.Drawing.Point(24, 82);
            this.gridCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.gridCard.Name = "gridCard";
            this.gridCard.Padding = new System.Windows.Forms.Padding(2);
            this.gridCard.Size = new System.Drawing.Size(1072, 386);
            this.gridCard.TabIndex = 1;
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStock.BackgroundColor = System.Drawing.Color.White;
            this.gridStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Theme.SurfaceAlt;
            dataGridViewCellStyle8.Font = Theme.Body;
            dataGridViewCellStyle8.ForeColor = Theme.NavyDark;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Theme.SurfaceAlt;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridStock.ColumnHeadersHeight = 40;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.barcode,
            this.category_name,
            this.current_quantity,
            this.total_added,
            this.total_sold,
            this.cost_price,
            this.stock_value});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = Theme.Body;
            dataGridViewCellStyle14.ForeColor = Theme.TextBody;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 6, 0);
            dataGridViewCellStyle14.SelectionBackColor = Theme.PrimaryTint;
            dataGridViewCellStyle14.SelectionForeColor = Theme.NavyDark;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStock.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStock.EnableHeadersVisualStyles = false;
            this.gridStock.GridColor = Theme.Page;
            this.gridStock.Location = new System.Drawing.Point(2, 2);
            this.gridStock.MultiSelect = false;
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersVisible = false;
            this.gridStock.RowHeadersWidth = 51;
            this.gridStock.RowTemplate.Height = 38;
            this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStock.Size = new System.Drawing.Size(1066, 380);
            this.gridStock.TabIndex = 0;
            this.gridStock.SelectionChanged += new System.EventHandler(this.gridStock_SelectionChanged);
            // 
            // product_name
            // 
            this.product_name.FillWeight = 30F;
            this.product_name.HeaderText = "Product";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // barcode
            // 
            this.barcode.FillWeight = 18F;
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // category_name
            // 
            this.category_name.FillWeight = 16F;
            this.category_name.HeaderText = "Category";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // current_quantity
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.current_quantity.DefaultCellStyle = dataGridViewCellStyle9;
            this.current_quantity.FillWeight = 12F;
            this.current_quantity.HeaderText = "Current stock";
            this.current_quantity.MinimumWidth = 6;
            this.current_quantity.Name = "current_quantity";
            this.current_quantity.ReadOnly = true;
            // 
            // total_added
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_added.DefaultCellStyle = dataGridViewCellStyle10;
            this.total_added.FillWeight = 12F;
            this.total_added.HeaderText = "Total added";
            this.total_added.MinimumWidth = 6;
            this.total_added.Name = "total_added";
            this.total_added.ReadOnly = true;
            // 
            // total_sold
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_sold.DefaultCellStyle = dataGridViewCellStyle11;
            this.total_sold.FillWeight = 12F;
            this.total_sold.HeaderText = "Total sold";
            this.total_sold.MinimumWidth = 6;
            this.total_sold.Name = "total_sold";
            this.total_sold.ReadOnly = true;
            // 
            // cost_price
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cost_price.DefaultCellStyle = dataGridViewCellStyle12;
            this.cost_price.FillWeight = 12F;
            this.cost_price.HeaderText = "Cost price";
            this.cost_price.MinimumWidth = 6;
            this.cost_price.Name = "cost_price";
            this.cost_price.ReadOnly = true;
            // 
            // stock_value
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.stock_value.DefaultCellStyle = dataGridViewCellStyle13;
            this.stock_value.FillWeight = 12F;
            this.stock_value.HeaderText = "Stock value";
            this.stock_value.MinimumWidth = 6;
            this.stock_value.Name = "stock_value";
            this.stock_value.ReadOnly = true;
            // 
            // pnlEmptyState
            // 
            this.pnlEmptyState.BackColor = System.Drawing.Color.White;
            this.pnlEmptyState.Controls.Add(this.emptyLayout);
            this.pnlEmptyState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmptyState.Location = new System.Drawing.Point(2, 2);
            this.pnlEmptyState.Name = "pnlEmptyState";
            this.pnlEmptyState.Size = new System.Drawing.Size(1066, 380);
            this.pnlEmptyState.TabIndex = 1;
            this.pnlEmptyState.Visible = false;
            // 
            // emptyLayout
            // 
            this.emptyLayout.ColumnCount = 1;
            this.emptyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.emptyLayout.Controls.Add(this.lblEmptyIcon, 0, 0);
            this.emptyLayout.Controls.Add(this.lblEmptyTitle, 0, 1);
            this.emptyLayout.Controls.Add(this.lblEmptySubtitle, 0, 2);
            this.emptyLayout.Location = new System.Drawing.Point(354, 136);
            this.emptyLayout.Name = "emptyLayout";
            this.emptyLayout.RowCount = 3;
            this.emptyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.emptyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.emptyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.emptyLayout.Size = new System.Drawing.Size(360, 112);
            this.emptyLayout.TabIndex = 0;
            // 
            // lblEmptyIcon
            // 
            this.lblEmptyIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptyIcon.Font = Theme.Glyph36;
            this.lblEmptyIcon.ForeColor = Theme.BorderStrong;
            this.lblEmptyIcon.Location = new System.Drawing.Point(3, 0);
            this.lblEmptyIcon.Name = "lblEmptyIcon";
            this.lblEmptyIcon.Size = new System.Drawing.Size(354, 56);
            this.lblEmptyIcon.TabIndex = 0;
            this.lblEmptyIcon.Text = "";
            this.lblEmptyIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptyTitle.Font = Theme.Heading;
            this.lblEmptyTitle.ForeColor = Theme.NavyDark;
            this.lblEmptyTitle.Location = new System.Drawing.Point(3, 56);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(354, 32);
            this.lblEmptyTitle.TabIndex = 1;
            this.lblEmptyTitle.Text = "No products found";
            this.lblEmptyTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptySubtitle
            // 
            this.lblEmptySubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptySubtitle.Font = Theme.Body;
            this.lblEmptySubtitle.ForeColor = Theme.TextMuted;
            this.lblEmptySubtitle.Location = new System.Drawing.Point(3, 88);
            this.lblEmptySubtitle.Name = "lblEmptySubtitle";
            this.lblEmptySubtitle.Size = new System.Drawing.Size(354, 24);
            this.lblEmptySubtitle.TabIndex = 2;
            this.lblEmptySubtitle.Text = "Start by scanning a product or adding a new one.";
            this.lblEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adjustCard
            // 
            this.adjustCard.BackColor = System.Drawing.Color.White;
            this.adjustCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustCard.Controls.Add(this.txtRemarks);
            this.adjustCard.Controls.Add(this.lblFieldRemarks);
            this.adjustCard.Controls.Add(this.btnApply);
            this.adjustCard.Controls.Add(this.txtQuantity);
            this.adjustCard.Controls.Add(this.lblFieldQuantity);
            this.adjustCard.Controls.Add(this.cboReason);
            this.adjustCard.Controls.Add(this.lblFieldReason);
            this.adjustCard.Controls.Add(this.cboDirection);
            this.adjustCard.Controls.Add(this.lblFieldDirection);
            this.adjustCard.Controls.Add(this.pnlSelectedBox);
            this.adjustCard.Controls.Add(this.lblFieldProduct);
            this.adjustCard.Controls.Add(this.lblAdjustSubtitle);
            this.adjustCard.Controls.Add(this.lblAdjustTitle);
            this.adjustCard.Controls.Add(this.pnlAdjustIcon);
            this.adjustCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjustCard.Location = new System.Drawing.Point(27, 487);
            this.adjustCard.Name = "adjustCard";
            this.adjustCard.Size = new System.Drawing.Size(1066, 218);
            this.adjustCard.TabIndex = 2;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = Theme.Body;
            this.txtRemarks.Location = new System.Drawing.Point(20, 166);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(1026, 29);
            this.txtRemarks.TabIndex = 13;
            // 
            // lblFieldRemarks
            // 
            this.lblFieldRemarks.AutoSize = true;
            this.lblFieldRemarks.Font = Theme.CaptionBold;
            this.lblFieldRemarks.ForeColor = Theme.TextMuted;
            this.lblFieldRemarks.Location = new System.Drawing.Point(20, 146);
            this.lblFieldRemarks.Name = "lblFieldRemarks";
            this.lblFieldRemarks.Size = new System.Drawing.Size(80, 20);
            this.lblFieldRemarks.TabIndex = 12;
            this.lblFieldRemarks.Text = "REMARKS";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = Theme.Success;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = Theme.BodyBold;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(688, 94);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(180, 32);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "✓   Apply adjustment";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = Theme.Body;
            this.txtQuantity.Location = new System.Drawing.Point(578, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(90, 29);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFieldQuantity
            // 
            this.lblFieldQuantity.AutoSize = true;
            this.lblFieldQuantity.Font = Theme.CaptionBold;
            this.lblFieldQuantity.ForeColor = Theme.TextMuted;
            this.lblFieldQuantity.Location = new System.Drawing.Point(578, 76);
            this.lblFieldQuantity.Name = "lblFieldQuantity";
            this.lblFieldQuantity.Size = new System.Drawing.Size(86, 20);
            this.lblFieldQuantity.TabIndex = 9;
            this.lblFieldQuantity.Text = "QUANTITY";
            // 
            // cboReason
            // 
            this.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReason.Font = Theme.Body;
            this.cboReason.Items.AddRange(new object[] {
            "ADJUSTMENT",
            "RECOUNT",
            "RETURN",
            "DAMAGED"});
            this.cboReason.Location = new System.Drawing.Point(412, 96);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(150, 29);
            this.cboReason.TabIndex = 8;
            // 
            // lblFieldReason
            // 
            this.lblFieldReason.AutoSize = true;
            this.lblFieldReason.Font = Theme.CaptionBold;
            this.lblFieldReason.ForeColor = Theme.TextMuted;
            this.lblFieldReason.Location = new System.Drawing.Point(412, 76);
            this.lblFieldReason.Name = "lblFieldReason";
            this.lblFieldReason.Size = new System.Drawing.Size(69, 20);
            this.lblFieldReason.TabIndex = 7;
            this.lblFieldReason.Text = "REASON";
            // 
            // cboDirection
            // 
            this.cboDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDirection.Font = Theme.Body;
            this.cboDirection.Items.AddRange(new object[] {
            "Stock in (+)",
            "Stock out (-)"});
            this.cboDirection.Location = new System.Drawing.Point(266, 96);
            this.cboDirection.Name = "cboDirection";
            this.cboDirection.Size = new System.Drawing.Size(130, 29);
            this.cboDirection.TabIndex = 6;
            // 
            // lblFieldDirection
            // 
            this.lblFieldDirection.AutoSize = true;
            this.lblFieldDirection.Font = Theme.CaptionBold;
            this.lblFieldDirection.ForeColor = Theme.TextMuted;
            this.lblFieldDirection.Location = new System.Drawing.Point(266, 76);
            this.lblFieldDirection.Name = "lblFieldDirection";
            this.lblFieldDirection.Size = new System.Drawing.Size(89, 20);
            this.lblFieldDirection.TabIndex = 5;
            this.lblFieldDirection.Text = "DIRECTION";
            // 
            // pnlSelectedBox
            // 
            this.pnlSelectedBox.BackColor = Theme.SurfaceAlt;
            this.pnlSelectedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedBox.Controls.Add(this.lblSelected);
            this.pnlSelectedBox.Location = new System.Drawing.Point(20, 96);
            this.pnlSelectedBox.Name = "pnlSelectedBox";
            this.pnlSelectedBox.Size = new System.Drawing.Size(230, 36);
            this.pnlSelectedBox.TabIndex = 4;
            // 
            // lblSelected
            // 
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelected.Font = Theme.Body;
            this.lblSelected.ForeColor = Theme.TextBody;
            this.lblSelected.Location = new System.Drawing.Point(0, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Padding = new System.Windows.Forms.Padding(10, 0, 6, 0);
            this.lblSelected.Size = new System.Drawing.Size(228, 34);
            this.lblSelected.TabIndex = 0;
            this.lblSelected.Text = "Selected product: none";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFieldProduct
            // 
            this.lblFieldProduct.AutoSize = true;
            this.lblFieldProduct.Font = Theme.CaptionBold;
            this.lblFieldProduct.ForeColor = Theme.TextMuted;
            this.lblFieldProduct.Location = new System.Drawing.Point(20, 76);
            this.lblFieldProduct.Name = "lblFieldProduct";
            this.lblFieldProduct.Size = new System.Drawing.Size(79, 20);
            this.lblFieldProduct.TabIndex = 3;
            this.lblFieldProduct.Text = "PRODUCT";
            // 
            // lblAdjustSubtitle
            // 
            this.lblAdjustSubtitle.AutoSize = true;
            this.lblAdjustSubtitle.Font = Theme.Body;
            this.lblAdjustSubtitle.ForeColor = Theme.TextMuted;
            this.lblAdjustSubtitle.Location = new System.Drawing.Point(62, 37);
            this.lblAdjustSubtitle.Name = "lblAdjustSubtitle";
            this.lblAdjustSubtitle.Size = new System.Drawing.Size(338, 20);
            this.lblAdjustSubtitle.TabIndex = 2;
            this.lblAdjustSubtitle.Text = "Select a product and enter the adjustment details.";
            // 
            // lblAdjustTitle
            // 
            this.lblAdjustTitle.AutoSize = true;
            this.lblAdjustTitle.Font = Theme.LargeBold;
            this.lblAdjustTitle.ForeColor = Theme.NavyDark;
            this.lblAdjustTitle.Location = new System.Drawing.Point(62, 14);
            this.lblAdjustTitle.Name = "lblAdjustTitle";
            this.lblAdjustTitle.Size = new System.Drawing.Size(247, 25);
            this.lblAdjustTitle.TabIndex = 1;
            this.lblAdjustTitle.Text = "Record a stock adjustment";
            // 
            // pnlAdjustIcon
            // 
            this.pnlAdjustIcon.BackColor = Theme.PrimaryTint;
            this.pnlAdjustIcon.Controls.Add(this.lblAdjustIconGlyph);
            this.pnlAdjustIcon.Location = new System.Drawing.Point(20, 16);
            this.pnlAdjustIcon.Name = "pnlAdjustIcon";
            this.pnlAdjustIcon.Size = new System.Drawing.Size(32, 32);
            this.pnlAdjustIcon.TabIndex = 0;
            // 
            // lblAdjustIconGlyph
            // 
            this.lblAdjustIconGlyph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdjustIconGlyph.Font = Theme.Glyph12;
            this.lblAdjustIconGlyph.ForeColor = Theme.Primary;
            this.lblAdjustIconGlyph.Location = new System.Drawing.Point(0, 0);
            this.lblAdjustIconGlyph.Name = "lblAdjustIconGlyph";
            this.lblAdjustIconGlyph.Size = new System.Drawing.Size(32, 32);
            this.lblAdjustIconGlyph.TabIndex = 0;
            this.lblAdjustIconGlyph.Text = "";
            this.lblAdjustIconGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Theme.Page;
            this.ClientSize = new System.Drawing.Size(1120, 820);
            this.ControlBox = false;
            this.Controls.Add(this.contentLayout);
            this.Controls.Add(this.header);
            this.Font = Theme.Body;
            this.Name = "frmManageStock";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            this.contentLayout.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.pnlEmptyState.ResumeLayout(false);
            this.emptyLayout.ResumeLayout(false);
            this.adjustCard.ResumeLayout(false);
            this.adjustCard.PerformLayout();
            this.pnlSelectedBox.ResumeLayout(false);
            this.pnlAdjustIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn category_name;
        private DataGridViewTextBoxColumn current_quantity;
        private DataGridViewTextBoxColumn total_added;
        private DataGridViewTextBoxColumn total_sold;
        private DataGridViewTextBoxColumn cost_price;
        private DataGridViewTextBoxColumn stock_value;
    }
}