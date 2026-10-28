namespace inventory_management_system_with_POS
{
    partial class frmmanageproduct
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSearchCard = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblSearchCaption = new System.Windows.Forms.Label();
            this.pnlGridWrapper = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.pnlEmptyState = new System.Windows.Forms.Panel();
            this.lblEmptySubtitle = new System.Windows.Forms.Label();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.lblEmptyIcon = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooterWrapper = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnToggleStatus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlSelectedBadge = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSelectedCaption = new System.Windows.Forms.Label();
            this.lblSelectedIcon = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlSearchCard.SuspendLayout();
            this.pnlGridWrapper.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlEmptyState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.pnlFooterWrapper.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlSelectedBadge.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 116);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSubtitle.Location = new System.Drawing.Point(102, 66);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(387, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Choose which stocked products appear in POS.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(117, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(368, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MANAGE PRODUCT";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.lblLogoIcon);
            this.pnlLogo.Location = new System.Drawing.Point(32, 34);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(52, 52);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogoIcon
            // 
            this.lblLogoIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.lblLogoIcon.Location = new System.Drawing.Point(0, 0);
            this.lblLogoIcon.Name = "lblLogoIcon";
            this.lblLogoIcon.Size = new System.Drawing.Size(52, 52);
            this.lblLogoIcon.TabIndex = 0;
            this.lblLogoIcon.Text = "▣";
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.pnlSearchCard);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 116);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(32, 20, 32, 16);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 96);
            this.pnlToolbar.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(936, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+   Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlSearchCard
            // 
            this.pnlSearchCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlSearchCard.Controls.Add(this.txtSearch);
            this.pnlSearchCard.Controls.Add(this.lblSearchIcon);
            this.pnlSearchCard.Controls.Add(this.lblSearchCaption);
            this.pnlSearchCard.Location = new System.Drawing.Point(32, 20);
            this.pnlSearchCard.Name = "pnlSearchCard";
            this.pnlSearchCard.Size = new System.Drawing.Size(888, 60);
            this.pnlSearchCard.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearch.Location = new System.Drawing.Point(44, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(820, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(16, 19);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(27, 25);
            this.lblSearchIcon.TabIndex = 2;
            this.lblSearchIcon.Text = "⌕";
            // 
            // lblSearchCaption
            // 
            this.lblSearchCaption.AutoSize = true;
            this.lblSearchCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearchCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.lblSearchCaption.Location = new System.Drawing.Point(-2000, -2000);
            this.lblSearchCaption.Name = "lblSearchCaption";
            this.lblSearchCaption.Size = new System.Drawing.Size(150, 21);
            this.lblSearchCaption.TabIndex = 3;
            this.lblSearchCaption.Text = "SEARCH PRODUCT";
            this.lblSearchCaption.Visible = false;
            // 
            // pnlGridWrapper
            // 
            this.pnlGridWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlGridWrapper.Controls.Add(this.pnlGridCard);
            this.pnlGridWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridWrapper.Location = new System.Drawing.Point(0, 212);
            this.pnlGridWrapper.Name = "pnlGridWrapper";
            this.pnlGridWrapper.Padding = new System.Windows.Forms.Padding(32, 4, 32, 4);
            this.pnlGridWrapper.Size = new System.Drawing.Size(1100, 469);
            this.pnlGridWrapper.TabIndex = 2;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.pnlEmptyState);
            this.pnlGridCard.Controls.Add(this.gridProducts);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(32, 4);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridCard.Size = new System.Drawing.Size(1036, 461);
            this.pnlGridCard.TabIndex = 0;
            // 
            // pnlEmptyState
            // 
            this.pnlEmptyState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmptyState.BackColor = System.Drawing.Color.White;
            this.pnlEmptyState.Controls.Add(this.lblEmptySubtitle);
            this.pnlEmptyState.Controls.Add(this.lblEmptyTitle);
            this.pnlEmptyState.Controls.Add(this.lblEmptyIcon);
            this.pnlEmptyState.Location = new System.Drawing.Point(318, 140);
            this.pnlEmptyState.Name = "pnlEmptyState";
            this.pnlEmptyState.Size = new System.Drawing.Size(400, 180);
            this.pnlEmptyState.TabIndex = 1;
            this.pnlEmptyState.Visible = false;
            // 
            // lblEmptySubtitle
            // 
            this.lblEmptySubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmptySubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmptySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmptySubtitle.Location = new System.Drawing.Point(0, 128);
            this.lblEmptySubtitle.Name = "lblEmptySubtitle";
            this.lblEmptySubtitle.Size = new System.Drawing.Size(400, 40);
            this.lblEmptySubtitle.TabIndex = 2;
            this.lblEmptySubtitle.Text = "Start by adding a new product or search for an existing one.";
            this.lblEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmptyTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEmptyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblEmptyTitle.Location = new System.Drawing.Point(0, 96);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(400, 30);
            this.lblEmptyTitle.TabIndex = 1;
            this.lblEmptyTitle.Text = "No products found";
            this.lblEmptyTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptyIcon
            // 
            this.lblEmptyIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmptyIcon.Font = new System.Drawing.Font("Segoe UI", 34F);
            this.lblEmptyIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblEmptyIcon.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyIcon.Name = "lblEmptyIcon";
            this.lblEmptyIcon.Size = new System.Drawing.Size(400, 90);
            this.lblEmptyIcon.TabIndex = 0;
            this.lblEmptyIcon.Text = "▣";
            this.lblEmptyIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.ColumnHeadersHeight = 46;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarcode,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.gridProducts.Location = new System.Drawing.Point(1, 1);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 42;
            this.gridProducts.Size = new System.Drawing.Size(1034, 459);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellDoubleClick);
            this.gridProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridProducts_CellFormatting);
            this.gridProducts.SelectionChanged += new System.EventHandler(this.gridProducts_SelectionChanged);
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "BARCODE";
            this.colBarcode.MinimumWidth = 6;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            this.colBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBarcode.Width = 130;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "PRODUCT NAME";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "CATEGORY";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCategory.Width = 140;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "PRICE";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.Width = 110;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "STOCK";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStock.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.Width = 120;
            // 
            // pnlFooterWrapper
            // 
            this.pnlFooterWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlFooterWrapper.Controls.Add(this.pnlFooter);
            this.pnlFooterWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterWrapper.Location = new System.Drawing.Point(0, 681);
            this.pnlFooterWrapper.Name = "pnlFooterWrapper";
            this.pnlFooterWrapper.Padding = new System.Windows.Forms.Padding(32, 4, 32, 20);
            this.pnlFooterWrapper.Size = new System.Drawing.Size(1100, 94);
            this.pnlFooterWrapper.TabIndex = 3;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnToggleStatus);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Controls.Add(this.btnEdit);
            this.pnlFooter.Controls.Add(this.pnlSelectedBadge);
            this.pnlFooter.Controls.Add(this.lblSelectedCaption);
            this.pnlFooter.Controls.Add(this.lblSelectedIcon);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(32, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1036, 70);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnToggleStatus
            // 
            this.btnToggleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleStatus.BackColor = System.Drawing.Color.White;
            this.btnToggleStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnToggleStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnToggleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnToggleStatus.Location = new System.Drawing.Point(610, 13);
            this.btnToggleStatus.Name = "btnToggleStatus";
            this.btnToggleStatus.Size = new System.Drawing.Size(144, 44);
            this.btnToggleStatus.TabIndex = 0;
            this.btnToggleStatus.Text = "Set Status";
            this.btnToggleStatus.UseVisualStyleBackColor = false;
            this.btnToggleStatus.Click += new System.EventHandler(this.btnToggleStatus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Location = new System.Drawing.Point(898, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "✖   Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnEdit.Location = new System.Drawing.Point(766, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✎   Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlSelectedBadge
            // 
            this.pnlSelectedBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.pnlSelectedBadge.Controls.Add(this.lblSelected);
            this.pnlSelectedBadge.Location = new System.Drawing.Point(184, 18);
            this.pnlSelectedBadge.Name = "pnlSelectedBadge";
            this.pnlSelectedBadge.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.pnlSelectedBadge.Size = new System.Drawing.Size(240, 34);
            this.pnlSelectedBadge.TabIndex = 2;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoEllipsis = true;
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.lblSelected.Location = new System.Drawing.Point(14, 6);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(212, 22);
            this.lblSelected.TabIndex = 0;
            this.lblSelected.Text = "N/A";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedCaption
            // 
            this.lblSelectedCaption.AutoSize = true;
            this.lblSelectedCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSelectedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSelectedCaption.Location = new System.Drawing.Point(49, 28);
            this.lblSelectedCaption.Name = "lblSelectedCaption";
            this.lblSelectedCaption.Size = new System.Drawing.Size(129, 21);
            this.lblSelectedCaption.TabIndex = 1;
            this.lblSelectedCaption.Text = "Selected Product:";
            // 
            // lblSelectedIcon
            // 
            this.lblSelectedIcon.AutoSize = true;
            this.lblSelectedIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSelectedIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblSelectedIcon.Location = new System.Drawing.Point(20, 21);
            this.lblSelectedIcon.Name = "lblSelectedIcon";
            this.lblSelectedIcon.Size = new System.Drawing.Size(28, 30);
            this.lblSelectedIcon.TabIndex = 3;
            this.lblSelectedIcon.Text = "≡";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(202, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 797);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 1);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 797);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 797);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 1);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 1);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // frmmanageproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1100, 775);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGridWrapper);
            this.Controls.Add(this.pnlFooterWrapper);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmmanageproduct";
            this.Load += new System.EventHandler(this.frmmanageproduct_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlSearchCard.ResumeLayout(false);
            this.pnlSearchCard.PerformLayout();
            this.pnlGridWrapper.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            this.pnlEmptyState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.pnlFooterWrapper.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlSelectedBadge.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlSearchCard;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblSearchCaption;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Panel pnlGridWrapper;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.Panel pnlEmptyState;
        private System.Windows.Forms.Label lblEmptyIcon;
        private System.Windows.Forms.Label lblEmptyTitle;
        private System.Windows.Forms.Label lblEmptySubtitle;

        private System.Windows.Forms.Panel pnlFooterWrapper;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblSelectedIcon;
        private System.Windows.Forms.Label lblSelectedCaption;
        private System.Windows.Forms.Panel pnlSelectedBadge;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnToggleStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}