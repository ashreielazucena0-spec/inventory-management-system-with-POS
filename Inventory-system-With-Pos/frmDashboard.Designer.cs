namespace inventory_management_system_with_POS
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.TableLayoutPanel cardsPanel;

        private System.Windows.Forms.Panel pnlActiveProducts;
        private System.Windows.Forms.Label lblActiveProductsIcon;
        private System.Windows.Forms.Label lblActiveProductsTitle;
        private System.Windows.Forms.Label lblProductsValue;
        private System.Windows.Forms.Label lblActiveProductsCaption;

        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockIcon;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStockCaption;

        private System.Windows.Forms.Panel pnlTodaySales;
        private System.Windows.Forms.Label lblTodaySalesIcon;
        private System.Windows.Forms.Label lblTodaySalesTitle;
        private System.Windows.Forms.Label lblTodaySalesValue;
        private System.Windows.Forms.Label lblTodaySalesCaption;

        private System.Windows.Forms.Panel pnlExpiring;
        private System.Windows.Forms.Label lblExpiringIcon;
        private System.Windows.Forms.Label lblExpiringTitle;
        private System.Windows.Forms.Label lblExpiringValue;
        private System.Windows.Forms.Label lblExpiringCaption;

        private System.Windows.Forms.TableLayoutPanel splitPanel;

        private System.Windows.Forms.Panel pnlRecentSales;
        private System.Windows.Forms.Panel recentSalesHeader;
        private System.Windows.Forms.Label lblRecentSalesTitle;
        private System.Windows.Forms.DataGridView gridRecentSales;
        private System.Windows.Forms.Label lblRecentSalesEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCashierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;

        private System.Windows.Forms.Panel pnlLowStockList;
        private System.Windows.Forms.Panel lowStockHeader;
        private System.Windows.Forms.Label lblLowStockListTitle;
        private System.Windows.Forms.DataGridView gridLowStock;
        private System.Windows.Forms.Label lblLowStockEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentQuantity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlActiveProducts = new System.Windows.Forms.Panel();
            this.lblActiveProductsCaption = new System.Windows.Forms.Label();
            this.lblProductsValue = new System.Windows.Forms.Label();
            this.lblActiveProductsTitle = new System.Windows.Forms.Label();
            this.lblActiveProductsIcon = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockCaption = new System.Windows.Forms.Label();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStockIcon = new System.Windows.Forms.Label();
            this.pnlTodaySales = new System.Windows.Forms.Panel();
            this.lblTodaySalesCaption = new System.Windows.Forms.Label();
            this.lblTodaySalesValue = new System.Windows.Forms.Label();
            this.lblTodaySalesTitle = new System.Windows.Forms.Label();
            this.lblTodaySalesIcon = new System.Windows.Forms.Label();
            this.pnlExpiring = new System.Windows.Forms.Panel();
            this.lblExpiringCaption = new System.Windows.Forms.Label();
            this.lblExpiringValue = new System.Windows.Forms.Label();
            this.lblExpiringTitle = new System.Windows.Forms.Label();
            this.lblExpiringIcon = new System.Windows.Forms.Label();
            this.splitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRecentSales = new System.Windows.Forms.Panel();
            this.gridRecentSales = new System.Windows.Forms.DataGridView();
            this.colSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCashierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentSalesEmpty = new System.Windows.Forms.Label();
            this.recentSalesHeader = new System.Windows.Forms.Panel();
            this.lblRecentSalesTitle = new System.Windows.Forms.Label();
            this.pnlLowStockList = new System.Windows.Forms.Panel();
            this.gridLowStock = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLowStockEmpty = new System.Windows.Forms.Label();
            this.lowStockHeader = new System.Windows.Forms.Panel();
            this.lblLowStockListTitle = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.cardsPanel.SuspendLayout();
            this.pnlActiveProducts.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlTodaySales.SuspendLayout();
            this.pnlExpiring.SuspendLayout();
            this.splitPanel.SuspendLayout();
            this.pnlRecentSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentSales)).BeginInit();
            this.recentSalesHeader.SuspendLayout();
            this.pnlLowStockList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLowStock)).BeginInit();
            this.lowStockHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.header.Controls.Add(this.btnRefresh);
            this.header.Controls.Add(this.lblSubtitle);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 82);
            this.header.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1064, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "⟳  Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSubtitle.Location = new System.Drawing.Point(29, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(268, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Overview of your sales and inventory";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(28, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // cardsPanel
            // 
            this.cardsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cardsPanel.ColumnCount = 4;
            this.cardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsPanel.Controls.Add(this.pnlActiveProducts, 0, 0);
            this.cardsPanel.Controls.Add(this.pnlLowStock, 1, 0);
            this.cardsPanel.Controls.Add(this.pnlTodaySales, 2, 0);
            this.cardsPanel.Controls.Add(this.pnlExpiring, 3, 0);
            this.cardsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardsPanel.Location = new System.Drawing.Point(0, 82);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 12);
            this.cardsPanel.RowCount = 1;
            this.cardsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsPanel.Size = new System.Drawing.Size(1200, 128);
            this.cardsPanel.TabIndex = 1;
            // 
            // pnlActiveProducts
            // 
            this.pnlActiveProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlActiveProducts.Controls.Add(this.lblActiveProductsCaption);
            this.pnlActiveProducts.Controls.Add(this.lblProductsValue);
            this.pnlActiveProducts.Controls.Add(this.lblActiveProductsTitle);
            this.pnlActiveProducts.Controls.Add(this.lblActiveProductsIcon);
            this.pnlActiveProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActiveProducts.Location = new System.Drawing.Point(28, 28);
            this.pnlActiveProducts.Margin = new System.Windows.Forms.Padding(8);
            this.pnlActiveProducts.Name = "pnlActiveProducts";
            this.pnlActiveProducts.Size = new System.Drawing.Size(274, 80);
            this.pnlActiveProducts.TabIndex = 0;
            // 
            // lblActiveProductsCaption
            // 
            this.lblActiveProductsCaption.AutoSize = true;
            this.lblActiveProductsCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblActiveProductsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblActiveProductsCaption.Location = new System.Drawing.Point(95, 60);
            this.lblActiveProductsCaption.Name = "lblActiveProductsCaption";
            this.lblActiveProductsCaption.Size = new System.Drawing.Size(152, 19);
            this.lblActiveProductsCaption.TabIndex = 3;
            this.lblActiveProductsCaption.Text = "Total items in inventory";
            // 
            // lblProductsValue
            // 
            this.lblProductsValue.AutoSize = true;
            this.lblProductsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblProductsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblProductsValue.Location = new System.Drawing.Point(190, 10);
            this.lblProductsValue.Name = "lblProductsValue";
            this.lblProductsValue.Size = new System.Drawing.Size(37, 50);
            this.lblProductsValue.TabIndex = 2;
            this.lblProductsValue.Text = "-";
            // 
            // lblActiveProductsTitle
            // 
            this.lblActiveProductsTitle.AutoSize = true;
            this.lblActiveProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActiveProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblActiveProductsTitle.Location = new System.Drawing.Point(55, 0);
            this.lblActiveProductsTitle.Name = "lblActiveProductsTitle";
            this.lblActiveProductsTitle.Size = new System.Drawing.Size(129, 21);
            this.lblActiveProductsTitle.TabIndex = 1;
            this.lblActiveProductsTitle.Text = "Active products";
            // 
            // lblActiveProductsIcon
            // 
            this.lblActiveProductsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblActiveProductsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblActiveProductsIcon.ForeColor = System.Drawing.Color.White;
            this.lblActiveProductsIcon.Location = new System.Drawing.Point(16, 14);
            this.lblActiveProductsIcon.Name = "lblActiveProductsIcon";
            this.lblActiveProductsIcon.Size = new System.Drawing.Size(36, 36);
            this.lblActiveProductsIcon.TabIndex = 0;
            this.lblActiveProductsIcon.Text = "📦";
            this.lblActiveProductsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.pnlLowStock.Controls.Add(this.lblLowStockCaption);
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.lblLowStockIcon);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(318, 28);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(8);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(274, 80);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStockCaption
            // 
            this.lblLowStockCaption.AutoSize = true;
            this.lblLowStockCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLowStockCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLowStockCaption.Location = new System.Drawing.Point(110, 60);
            this.lblLowStockCaption.Name = "lblLowStockCaption";
            this.lblLowStockCaption.Size = new System.Drawing.Size(140, 19);
            this.lblLowStockCaption.TabIndex = 3;
            this.lblLowStockCaption.Text = "Products running low";
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLowStockValue.Location = new System.Drawing.Point(147, 10);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(37, 50);
            this.lblLowStockValue.TabIndex = 2;
            this.lblLowStockValue.Text = "-";
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(58, 0);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(85, 21);
            this.lblLowStockTitle.TabIndex = 1;
            this.lblLowStockTitle.Text = "Low stock";
            // 
            // lblLowStockIcon
            // 
            this.lblLowStockIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblLowStockIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblLowStockIcon.ForeColor = System.Drawing.Color.White;
            this.lblLowStockIcon.Location = new System.Drawing.Point(16, 14);
            this.lblLowStockIcon.Name = "lblLowStockIcon";
            this.lblLowStockIcon.Size = new System.Drawing.Size(36, 36);
            this.lblLowStockIcon.TabIndex = 0;
            this.lblLowStockIcon.Text = "⚠";
            this.lblLowStockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTodaySales
            // 
            this.pnlTodaySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlTodaySales.Controls.Add(this.lblTodaySalesCaption);
            this.pnlTodaySales.Controls.Add(this.lblTodaySalesValue);
            this.pnlTodaySales.Controls.Add(this.lblTodaySalesTitle);
            this.pnlTodaySales.Controls.Add(this.lblTodaySalesIcon);
            this.pnlTodaySales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodaySales.Location = new System.Drawing.Point(608, 28);
            this.pnlTodaySales.Margin = new System.Windows.Forms.Padding(8);
            this.pnlTodaySales.Name = "pnlTodaySales";
            this.pnlTodaySales.Size = new System.Drawing.Size(274, 80);
            this.pnlTodaySales.TabIndex = 2;
            // 
            // lblTodaySalesCaption
            // 
            this.lblTodaySalesCaption.AutoSize = true;
            this.lblTodaySalesCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTodaySalesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTodaySalesCaption.Location = new System.Drawing.Point(127, 60);
            this.lblTodaySalesCaption.Name = "lblTodaySalesCaption";
            this.lblTodaySalesCaption.Size = new System.Drawing.Size(131, 19);
            this.lblTodaySalesCaption.TabIndex = 3;
            this.lblTodaySalesCaption.Text = "Total sales for today";
            // 
            // lblTodaySalesValue
            // 
            this.lblTodaySalesValue.AutoSize = true;
            this.lblTodaySalesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTodaySalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTodaySalesValue.Location = new System.Drawing.Point(170, 14);
            this.lblTodaySalesValue.Name = "lblTodaySalesValue";
            this.lblTodaySalesValue.Size = new System.Drawing.Size(37, 50);
            this.lblTodaySalesValue.TabIndex = 2;
            this.lblTodaySalesValue.Text = "-";
            // 
            // lblTodaySalesTitle
            // 
            this.lblTodaySalesTitle.AutoSize = true;
            this.lblTodaySalesTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTodaySalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTodaySalesTitle.Location = new System.Drawing.Point(54, 0);
            this.lblTodaySalesTitle.Name = "lblTodaySalesTitle";
            this.lblTodaySalesTitle.Size = new System.Drawing.Size(108, 21);
            this.lblTodaySalesTitle.TabIndex = 1;
            this.lblTodaySalesTitle.Text = "Today\'s sales";
            // 
            // lblTodaySalesIcon
            // 
            this.lblTodaySalesIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblTodaySalesIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblTodaySalesIcon.ForeColor = System.Drawing.Color.White;
            this.lblTodaySalesIcon.Location = new System.Drawing.Point(16, 14);
            this.lblTodaySalesIcon.Name = "lblTodaySalesIcon";
            this.lblTodaySalesIcon.Size = new System.Drawing.Size(36, 36);
            this.lblTodaySalesIcon.TabIndex = 0;
            this.lblTodaySalesIcon.Text = "🛒";
            this.lblTodaySalesIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlExpiring
            // 
            this.pnlExpiring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlExpiring.Controls.Add(this.lblExpiringCaption);
            this.pnlExpiring.Controls.Add(this.lblExpiringValue);
            this.pnlExpiring.Controls.Add(this.lblExpiringTitle);
            this.pnlExpiring.Controls.Add(this.lblExpiringIcon);
            this.pnlExpiring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpiring.Location = new System.Drawing.Point(898, 28);
            this.pnlExpiring.Margin = new System.Windows.Forms.Padding(8);
            this.pnlExpiring.Name = "pnlExpiring";
            this.pnlExpiring.Size = new System.Drawing.Size(274, 80);
            this.pnlExpiring.TabIndex = 3;
            // 
            // lblExpiringCaption
            // 
            this.lblExpiringCaption.AutoSize = true;
            this.lblExpiringCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblExpiringCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblExpiringCaption.Location = new System.Drawing.Point(43, 60);
            this.lblExpiringCaption.Name = "lblExpiringCaption";
            this.lblExpiringCaption.Size = new System.Drawing.Size(158, 19);
            this.lblExpiringCaption.TabIndex = 3;
            this.lblExpiringCaption.Text = "Products near expiration";
            // 
            // lblExpiringValue
            // 
            this.lblExpiringValue.AutoSize = true;
            this.lblExpiringValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblExpiringValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblExpiringValue.Location = new System.Drawing.Point(131, 21);
            this.lblExpiringValue.Name = "lblExpiringValue";
            this.lblExpiringValue.Size = new System.Drawing.Size(37, 50);
            this.lblExpiringValue.TabIndex = 2;
            this.lblExpiringValue.Text = "-";
            // 
            // lblExpiringTitle
            // 
            this.lblExpiringTitle.AutoSize = true;
            this.lblExpiringTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblExpiringTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblExpiringTitle.Location = new System.Drawing.Point(52, 0);
            this.lblExpiringTitle.Name = "lblExpiringTitle";
            this.lblExpiringTitle.Size = new System.Drawing.Size(159, 21);
            this.lblExpiringTitle.TabIndex = 1;
            this.lblExpiringTitle.Text = "Expiring within 30d";
            // 
            // lblExpiringIcon
            // 
            this.lblExpiringIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblExpiringIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblExpiringIcon.ForeColor = System.Drawing.Color.White;
            this.lblExpiringIcon.Location = new System.Drawing.Point(16, 14);
            this.lblExpiringIcon.Name = "lblExpiringIcon";
            this.lblExpiringIcon.Size = new System.Drawing.Size(36, 36);
            this.lblExpiringIcon.TabIndex = 0;
            this.lblExpiringIcon.Text = "📅";
            this.lblExpiringIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitPanel
            // 
            this.splitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.splitPanel.ColumnCount = 2;
            this.splitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.splitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.splitPanel.Controls.Add(this.pnlRecentSales, 0, 0);
            this.splitPanel.Controls.Add(this.pnlLowStockList, 1, 0);
            this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanel.Location = new System.Drawing.Point(0, 210);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Padding = new System.Windows.Forms.Padding(20, 8, 20, 20);
            this.splitPanel.RowCount = 1;
            this.splitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.splitPanel.Size = new System.Drawing.Size(1200, 550);
            this.splitPanel.TabIndex = 2;
            // 
            // pnlRecentSales
            // 
            this.pnlRecentSales.BackColor = System.Drawing.Color.White;
            this.pnlRecentSales.Controls.Add(this.gridRecentSales);
            this.pnlRecentSales.Controls.Add(this.lblRecentSalesEmpty);
            this.pnlRecentSales.Controls.Add(this.recentSalesHeader);
            this.pnlRecentSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentSales.Location = new System.Drawing.Point(20, 8);
            this.pnlRecentSales.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlRecentSales.Name = "pnlRecentSales";
            this.pnlRecentSales.Padding = new System.Windows.Forms.Padding(1);
            this.pnlRecentSales.Size = new System.Drawing.Size(630, 522);
            this.pnlRecentSales.TabIndex = 0;
            // 
            // gridRecentSales
            // 
            this.gridRecentSales.ColumnHeadersHeight = 29;
            this.gridRecentSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleId,
            this.colCreatedAt,
            this.colCashierId,
            this.colTotalAmount});
            this.gridRecentSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecentSales.Location = new System.Drawing.Point(1, 49);
            this.gridRecentSales.Name = "gridRecentSales";
            this.gridRecentSales.RowHeadersVisible = false;
            this.gridRecentSales.RowHeadersWidth = 51;
            this.gridRecentSales.Size = new System.Drawing.Size(628, 472);
            this.gridRecentSales.TabIndex = 1;
            // 
            // colSaleId
            // 
            this.colSaleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSaleId.HeaderText = "Sale ID";
            this.colSaleId.MinimumWidth = 6;
            this.colSaleId.Name = "colSaleId";
            this.colSaleId.ReadOnly = true;
            this.colSaleId.Width = 87;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCreatedAt.HeaderText = "Date/Time";
            this.colCreatedAt.MinimumWidth = 6;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            this.colCreatedAt.Width = 111;
            // 
            // colCashierId
            // 
            this.colCashierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCashierId.HeaderText = "Cashier";
            this.colCashierId.MinimumWidth = 6;
            this.colCashierId.Name = "colCashierId";
            this.colCashierId.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTotalAmount.HeaderText = "Total";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Width = 71;
            // 
            // lblRecentSalesEmpty
            // 
            this.lblRecentSalesEmpty.BackColor = System.Drawing.Color.White;
            this.lblRecentSalesEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecentSalesEmpty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRecentSalesEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRecentSalesEmpty.Location = new System.Drawing.Point(1, 49);
            this.lblRecentSalesEmpty.Name = "lblRecentSalesEmpty";
            this.lblRecentSalesEmpty.Size = new System.Drawing.Size(628, 472);
            this.lblRecentSalesEmpty.TabIndex = 2;
            this.lblRecentSalesEmpty.Text = "No recent sales found\r\n\r\nSales will appear here once you make a transaction.";
            this.lblRecentSalesEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentSalesEmpty.Visible = false;
            // 
            // recentSalesHeader
            // 
            this.recentSalesHeader.BackColor = System.Drawing.Color.White;
            this.recentSalesHeader.Controls.Add(this.lblRecentSalesTitle);
            this.recentSalesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentSalesHeader.Location = new System.Drawing.Point(1, 1);
            this.recentSalesHeader.Name = "recentSalesHeader";
            this.recentSalesHeader.Size = new System.Drawing.Size(628, 48);
            this.recentSalesHeader.TabIndex = 0;
            // 
            // lblRecentSalesTitle
            // 
            this.lblRecentSalesTitle.AutoSize = true;
            this.lblRecentSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRecentSalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblRecentSalesTitle.Location = new System.Drawing.Point(18, 15);
            this.lblRecentSalesTitle.Name = "lblRecentSalesTitle";
            this.lblRecentSalesTitle.Size = new System.Drawing.Size(117, 25);
            this.lblRecentSalesTitle.TabIndex = 0;
            this.lblRecentSalesTitle.Text = "Recent sales";
            // 
            // pnlLowStockList
            // 
            this.pnlLowStockList.BackColor = System.Drawing.Color.White;
            this.pnlLowStockList.Controls.Add(this.gridLowStock);
            this.pnlLowStockList.Controls.Add(this.lblLowStockEmpty);
            this.pnlLowStockList.Controls.Add(this.lowStockHeader);
            this.pnlLowStockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStockList.Location = new System.Drawing.Point(666, 8);
            this.pnlLowStockList.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlLowStockList.Name = "pnlLowStockList";
            this.pnlLowStockList.Padding = new System.Windows.Forms.Padding(1);
            this.pnlLowStockList.Size = new System.Drawing.Size(514, 522);
            this.pnlLowStockList.TabIndex = 1;
            // 
            // gridLowStock
            // 
            this.gridLowStock.ColumnHeadersHeight = 29;
            this.gridLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colBarcode,
            this.colCurrentQuantity});
            this.gridLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLowStock.Location = new System.Drawing.Point(1, 49);
            this.gridLowStock.Name = "gridLowStock";
            this.gridLowStock.RowHeadersVisible = false;
            this.gridLowStock.RowHeadersWidth = 51;
            this.gridLowStock.Size = new System.Drawing.Size(512, 472);
            this.gridLowStock.TabIndex = 1;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.HeaderText = "Product";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colBarcode
            // 
            this.colBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBarcode.HeaderText = "Barcode";
            this.colBarcode.MinimumWidth = 6;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            this.colBarcode.Width = 95;
            // 
            // colCurrentQuantity
            // 
            this.colCurrentQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCurrentQuantity.HeaderText = "Qty";
            this.colCurrentQuantity.MinimumWidth = 6;
            this.colCurrentQuantity.Name = "colCurrentQuantity";
            this.colCurrentQuantity.ReadOnly = true;
            this.colCurrentQuantity.Width = 64;
            // 
            // lblLowStockEmpty
            // 
            this.lblLowStockEmpty.BackColor = System.Drawing.Color.White;
            this.lblLowStockEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowStockEmpty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLowStockEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLowStockEmpty.Location = new System.Drawing.Point(1, 49);
            this.lblLowStockEmpty.Name = "lblLowStockEmpty";
            this.lblLowStockEmpty.Size = new System.Drawing.Size(512, 472);
            this.lblLowStockEmpty.TabIndex = 2;
            this.lblLowStockEmpty.Text = "No low stock items\r\n\r\nThere are no products with low stock at the moment.";
            this.lblLowStockEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLowStockEmpty.Visible = false;
            // 
            // lowStockHeader
            // 
            this.lowStockHeader.BackColor = System.Drawing.Color.White;
            this.lowStockHeader.Controls.Add(this.lblLowStockListTitle);
            this.lowStockHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lowStockHeader.Location = new System.Drawing.Point(1, 1);
            this.lowStockHeader.Name = "lowStockHeader";
            this.lowStockHeader.Size = new System.Drawing.Size(512, 48);
            this.lowStockHeader.TabIndex = 0;
            // 
            // lblLowStockListTitle
            // 
            this.lblLowStockListTitle.AutoSize = true;
            this.lblLowStockListTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLowStockListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLowStockListTitle.Location = new System.Drawing.Point(18, 15);
            this.lblLowStockListTitle.Name = "lblLowStockListTitle";
            this.lblLowStockListTitle.Size = new System.Drawing.Size(196, 25);
            this.lblLowStockListTitle.TabIndex = 0;
            this.lblLowStockListTitle.Text = "Lowest stock on hand";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.ControlBox = false;
            this.Controls.Add(this.splitPanel);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.cardsPanel.ResumeLayout(false);
            this.pnlActiveProducts.ResumeLayout(false);
            this.pnlActiveProducts.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlTodaySales.ResumeLayout(false);
            this.pnlTodaySales.PerformLayout();
            this.pnlExpiring.ResumeLayout(false);
            this.pnlExpiring.PerformLayout();
            this.splitPanel.ResumeLayout(false);
            this.pnlRecentSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentSales)).EndInit();
            this.recentSalesHeader.ResumeLayout(false);
            this.recentSalesHeader.PerformLayout();
            this.pnlLowStockList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLowStock)).EndInit();
            this.lowStockHeader.ResumeLayout(false);
            this.lowStockHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}