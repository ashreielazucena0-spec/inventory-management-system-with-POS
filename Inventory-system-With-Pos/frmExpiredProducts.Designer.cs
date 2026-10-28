namespace inventory_management_system_with_POS
{
    partial class frmExpiredProducts
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnPrint = new inventory_management_system_with_POS.IconButton();
            this.btnExportCsv = new inventory_management_system_with_POS.IconButton();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.badgeLogo = new inventory_management_system_with_POS.IconBadge();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnRefresh = new inventory_management_system_with_POS.IconButton();
            this.pnlDaysBox = new inventory_management_system_with_POS.FieldContainer();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.pnlCategoryBox = new inventory_management_system_with_POS.FieldContainer();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlSearch = new inventory_management_system_with_POS.SearchBox();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelCardExpired = new inventory_management_system_with_POS.RoundedPanel();
            this.lblExpiredValue = new System.Windows.Forms.Label();
            this.lblExpiredTitle = new System.Windows.Forms.Label();
            this.badgeExpired = new inventory_management_system_with_POS.IconBadge();
            this.panelCardExpiring = new inventory_management_system_with_POS.RoundedPanel();
            this.lblExpiringValue = new System.Windows.Forms.Label();
            this.lblExpiringTitle = new System.Windows.Forms.Label();
            this.badgeExpiring = new inventory_management_system_with_POS.IconBadge();
            this.panelCardValue = new inventory_management_system_with_POS.RoundedPanel();
            this.lblValueAtRiskValue = new System.Windows.Forms.Label();
            this.lblValueAtRiskTitle = new System.Windows.Forms.Label();
            this.badgeValueAtRisk = new inventory_management_system_with_POS.IconBadge();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmptyState = new System.Windows.Forms.Panel();
            this.lblEmptySubtitle = new System.Windows.Forms.Label();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.glyphEmptyState = new inventory_management_system_with_POS.IconGlyph();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblGenerated = new System.Windows.Forms.Label();
            this.glyphFooter = new inventory_management_system_with_POS.IconGlyph();
            this.panelHeader.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.pnlDaysBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.pnlCategoryBox.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.panelCardExpired.SuspendLayout();
            this.panelCardExpiring.SuspendLayout();
            this.panelCardValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelEmptyState.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelHeader.Controls.Add(this.btnPrint);
            this.panelHeader.Controls.Add(this.btnExportCsv);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.badgeLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 84);
            this.panelHeader.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.CornerRadius = 8;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.Icon = inventory_management_system_with_POS.IconKind.Print;
            this.btnPrint.IconColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1136, 26);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 32);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnExportCsv.CornerRadius = 8;
            this.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnExportCsv.Icon = inventory_management_system_with_POS.IconKind.Download;
            this.btnExportCsv.IconColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(983, 26);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(141, 32);
            this.btnExportCsv.TabIndex = 3;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSubtitle.Location = new System.Drawing.Point(90, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(191, 21);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Azucena Convenient Store";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(88, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Expired Products Report";
            // 
            // badgeLogo
            // 
            this.badgeLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.badgeLogo.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.badgeLogo.CornerRadius = 12;
            this.badgeLogo.Icon = inventory_management_system_with_POS.IconKind.Clipboard;
            this.badgeLogo.IconColor = System.Drawing.Color.White;
            this.badgeLogo.Location = new System.Drawing.Point(32, 20);
            this.badgeLogo.Name = "badgeLogo";
            this.badgeLogo.Size = new System.Drawing.Size(44, 44);
            this.badgeLogo.TabIndex = 0;
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.BackColor = System.Drawing.Color.White;
            this.panelFilters.Controls.Add(this.btnRefresh);
            this.panelFilters.Controls.Add(this.pnlDaysBox);
            this.panelFilters.Controls.Add(this.lblDays);
            this.panelFilters.Controls.Add(this.pnlCategoryBox);
            this.panelFilters.Controls.Add(this.lblCategory);
            this.panelFilters.Controls.Add(this.pnlSearch);
            this.panelFilters.Location = new System.Drawing.Point(0, 84);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1280, 64);
            this.panelFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRefresh.CornerRadius = 8;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnRefresh.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRefresh.Icon = inventory_management_system_with_POS.IconKind.Refresh;
            this.btnRefresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnRefresh.Location = new System.Drawing.Point(1136, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlDaysBox
            // 
            this.pnlDaysBox.BackColor = System.Drawing.Color.White;
            this.pnlDaysBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDaysBox.BorderThickness = 1;
            this.pnlDaysBox.Controls.Add(this.nudDays);
            this.pnlDaysBox.CornerRadius = 10;
            this.pnlDaysBox.Location = new System.Drawing.Point(834, 12);
            this.pnlDaysBox.Name = "pnlDaysBox";
            this.pnlDaysBox.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.pnlDaysBox.Size = new System.Drawing.Size(74, 40);
            this.pnlDaysBox.TabIndex = 4;
            // 
            // nudDays
            // 
            this.nudDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudDays.Location = new System.Drawing.Point(10, 4);
            this.nudDays.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(54, 29);
            this.nudDays.TabIndex = 0;
            this.nudDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDays.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDays.Location = new System.Drawing.Point(662, 23);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(182, 21);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "Expiring within (days):";
            // 
            // pnlCategoryBox
            // 
            this.pnlCategoryBox.BackColor = System.Drawing.Color.White;
            this.pnlCategoryBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlCategoryBox.BorderThickness = 1;
            this.pnlCategoryBox.Controls.Add(this.cboCategory);
            this.pnlCategoryBox.CornerRadius = 10;
            this.pnlCategoryBox.Location = new System.Drawing.Point(432, 12);
            this.pnlCategoryBox.Name = "pnlCategoryBox";
            this.pnlCategoryBox.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.pnlCategoryBox.Size = new System.Drawing.Size(210, 40);
            this.pnlCategoryBox.TabIndex = 2;
            // 
            // cboCategory
            // 
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(10, 4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(190, 29);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCategory.Location = new System.Drawing.Point(352, 23);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 21);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.CornerRadius = 10;
            this.pnlSearch.Location = new System.Drawing.Point(32, 15);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(36, 0, 10, 0);
            this.pnlSearch.Size = new System.Drawing.Size(300, 34);
            this.pnlSearch.TabIndex = 0;
            // 
            // tlpCards
            // 
            this.tlpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCards.BackColor = System.Drawing.Color.Transparent;
            this.tlpCards.ColumnCount = 5;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCards.Controls.Add(this.panelCardExpired, 0, 0);
            this.tlpCards.Controls.Add(this.panelCardExpiring, 2, 0);
            this.tlpCards.Controls.Add(this.panelCardValue, 4, 0);
            this.tlpCards.Location = new System.Drawing.Point(32, 170);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1216, 84);
            this.tlpCards.TabIndex = 5;
            // 
            // panelCardExpired
            // 
            this.panelCardExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelCardExpired.BorderColor = System.Drawing.Color.Transparent;
            this.panelCardExpired.BorderThickness = 1;
            this.panelCardExpired.Controls.Add(this.lblExpiredValue);
            this.panelCardExpired.Controls.Add(this.lblExpiredTitle);
            this.panelCardExpired.Controls.Add(this.badgeExpired);
            this.panelCardExpired.CornerRadius = 14;
            this.panelCardExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardExpired.Location = new System.Drawing.Point(0, 0);
            this.panelCardExpired.Margin = new System.Windows.Forms.Padding(0);
            this.panelCardExpired.Name = "panelCardExpired";
            this.panelCardExpired.Size = new System.Drawing.Size(389, 84);
            this.panelCardExpired.TabIndex = 2;
            // 
            // lblExpiredValue
            // 
            this.lblExpiredValue.AutoSize = true;
            this.lblExpiredValue.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiredValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblExpiredValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.lblExpiredValue.Location = new System.Drawing.Point(74, 34);
            this.lblExpiredValue.Name = "lblExpiredValue";
            this.lblExpiredValue.Size = new System.Drawing.Size(43, 50);
            this.lblExpiredValue.TabIndex = 2;
            this.lblExpiredValue.Text = "0";
            // 
            // lblExpiredTitle
            // 
            this.lblExpiredTitle.AutoSize = true;
            this.lblExpiredTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiredTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblExpiredTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.lblExpiredTitle.Location = new System.Drawing.Point(76, 16);
            this.lblExpiredTitle.Name = "lblExpiredTitle";
            this.lblExpiredTitle.Size = new System.Drawing.Size(103, 21);
            this.lblExpiredTitle.TabIndex = 1;
            this.lblExpiredTitle.Text = "Expired items";
            // 
            // badgeExpired
            // 
            this.badgeExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.badgeExpired.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.badgeExpired.CornerRadius = 0;
            this.badgeExpired.Icon = inventory_management_system_with_POS.IconKind.Calendar;
            this.badgeExpired.IconColor = System.Drawing.Color.White;
            this.badgeExpired.Location = new System.Drawing.Point(18, 20);
            this.badgeExpired.Name = "badgeExpired";
            this.badgeExpired.Size = new System.Drawing.Size(44, 44);
            this.badgeExpired.TabIndex = 0;
            // 
            // panelCardExpiring
            // 
            this.panelCardExpiring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.panelCardExpiring.BorderColor = System.Drawing.Color.Transparent;
            this.panelCardExpiring.BorderThickness = 1;
            this.panelCardExpiring.Controls.Add(this.lblExpiringValue);
            this.panelCardExpiring.Controls.Add(this.lblExpiringTitle);
            this.panelCardExpiring.Controls.Add(this.badgeExpiring);
            this.panelCardExpiring.CornerRadius = 14;
            this.panelCardExpiring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardExpiring.Location = new System.Drawing.Point(413, 0);
            this.panelCardExpiring.Margin = new System.Windows.Forms.Padding(0);
            this.panelCardExpiring.Name = "panelCardExpiring";
            this.panelCardExpiring.Size = new System.Drawing.Size(389, 84);
            this.panelCardExpiring.TabIndex = 3;
            // 
            // lblExpiringValue
            // 
            this.lblExpiringValue.AutoSize = true;
            this.lblExpiringValue.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiringValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblExpiringValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.lblExpiringValue.Location = new System.Drawing.Point(74, 34);
            this.lblExpiringValue.Name = "lblExpiringValue";
            this.lblExpiringValue.Size = new System.Drawing.Size(43, 50);
            this.lblExpiringValue.TabIndex = 2;
            this.lblExpiringValue.Text = "0";
            // 
            // lblExpiringTitle
            // 
            this.lblExpiringTitle.AutoSize = true;
            this.lblExpiringTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiringTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblExpiringTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.lblExpiringTitle.Location = new System.Drawing.Point(76, 16);
            this.lblExpiringTitle.Name = "lblExpiringTitle";
            this.lblExpiringTitle.Size = new System.Drawing.Size(104, 21);
            this.lblExpiringTitle.TabIndex = 1;
            this.lblExpiringTitle.Text = "Expiring soon";
            // 
            // badgeExpiring
            // 
            this.badgeExpiring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.badgeExpiring.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.badgeExpiring.CornerRadius = 0;
            this.badgeExpiring.Icon = inventory_management_system_with_POS.IconKind.Clock;
            this.badgeExpiring.IconColor = System.Drawing.Color.White;
            this.badgeExpiring.Location = new System.Drawing.Point(18, 20);
            this.badgeExpiring.Name = "badgeExpiring";
            this.badgeExpiring.Size = new System.Drawing.Size(44, 44);
            this.badgeExpiring.TabIndex = 0;
            // 
            // panelCardValue
            // 
            this.panelCardValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelCardValue.BorderColor = System.Drawing.Color.Transparent;
            this.panelCardValue.BorderThickness = 1;
            this.panelCardValue.Controls.Add(this.lblValueAtRiskValue);
            this.panelCardValue.Controls.Add(this.lblValueAtRiskTitle);
            this.panelCardValue.Controls.Add(this.badgeValueAtRisk);
            this.panelCardValue.CornerRadius = 14;
            this.panelCardValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardValue.Location = new System.Drawing.Point(826, 0);
            this.panelCardValue.Margin = new System.Windows.Forms.Padding(0);
            this.panelCardValue.Name = "panelCardValue";
            this.panelCardValue.Size = new System.Drawing.Size(390, 84);
            this.panelCardValue.TabIndex = 4;
            // 
            // lblValueAtRiskValue
            // 
            this.lblValueAtRiskValue.AutoSize = true;
            this.lblValueAtRiskValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValueAtRiskValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblValueAtRiskValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblValueAtRiskValue.Location = new System.Drawing.Point(74, 34);
            this.lblValueAtRiskValue.Name = "lblValueAtRiskValue";
            this.lblValueAtRiskValue.Size = new System.Drawing.Size(119, 50);
            this.lblValueAtRiskValue.TabIndex = 2;
            this.lblValueAtRiskValue.Text = "₱0.00";
            // 
            // lblValueAtRiskTitle
            // 
            this.lblValueAtRiskTitle.AutoSize = true;
            this.lblValueAtRiskTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblValueAtRiskTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValueAtRiskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblValueAtRiskTitle.Location = new System.Drawing.Point(76, 16);
            this.lblValueAtRiskTitle.Name = "lblValueAtRiskTitle";
            this.lblValueAtRiskTitle.Size = new System.Drawing.Size(94, 21);
            this.lblValueAtRiskTitle.TabIndex = 1;
            this.lblValueAtRiskTitle.Text = "Value at risk";
            // 
            // badgeValueAtRisk
            // 
            this.badgeValueAtRisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.badgeValueAtRisk.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.badgeValueAtRisk.CornerRadius = 0;
            this.badgeValueAtRisk.Icon = inventory_management_system_with_POS.IconKind.Tag;
            this.badgeValueAtRisk.IconColor = System.Drawing.Color.White;
            this.badgeValueAtRisk.Location = new System.Drawing.Point(18, 20);
            this.badgeValueAtRisk.Name = "badgeValueAtRisk";
            this.badgeValueAtRisk.Size = new System.Drawing.Size(44, 44);
            this.badgeValueAtRisk.TabIndex = 0;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colBarcode,
            this.colCategory,
            this.colBatch,
            this.colExpiry,
            this.colQty,
            this.colUnitCost,
            this.colValue,
            this.colCurrentStock,
            this.colStatus});
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridViewReport.Location = new System.Drawing.Point(32, 260);
            this.dataGridViewReport.MultiSelect = false;
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 34;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(1216, 474);
            this.dataGridViewReport.TabIndex = 5;
            this.dataGridViewReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewReport_CellFormatting);
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "Product  ↕";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "Barcode  ↕";
            this.colBarcode.MinimumWidth = 6;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            this.colBarcode.Width = 110;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category  ↕";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 140;
            // 
            // colBatch
            // 
            this.colBatch.HeaderText = "Batch no.  ↕";
            this.colBatch.MinimumWidth = 6;
            this.colBatch.Name = "colBatch";
            this.colBatch.ReadOnly = true;
            this.colBatch.Width = 140;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "Expiry date  ↕";
            this.colExpiry.MinimumWidth = 6;
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;
            this.colExpiry.Width = 120;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty  ↕";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 60;
            // 
            // colUnitCost
            // 
            this.colUnitCost.HeaderText = "Unit cost  ↕";
            this.colUnitCost.MinimumWidth = 6;
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.ReadOnly = true;
            this.colUnitCost.Width = 95;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value  ↕";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 95;
            // 
            // colCurrentStock
            // 
            this.colCurrentStock.HeaderText = "Current stock  ↕";
            this.colCurrentStock.MinimumWidth = 6;
            this.colCurrentStock.Name = "colCurrentStock";
            this.colCurrentStock.ReadOnly = true;
            this.colCurrentStock.Width = 110;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status  ↕";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;
            // 
            // panelEmptyState
            // 
            this.panelEmptyState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmptyState.BackColor = System.Drawing.Color.White;
            this.panelEmptyState.Controls.Add(this.lblEmptySubtitle);
            this.panelEmptyState.Controls.Add(this.lblEmptyTitle);
            this.panelEmptyState.Controls.Add(this.glyphEmptyState);
            this.panelEmptyState.Location = new System.Drawing.Point(32, 314);
            this.panelEmptyState.Name = "panelEmptyState";
            this.panelEmptyState.Size = new System.Drawing.Size(1216, 420);
            this.panelEmptyState.TabIndex = 6;
            this.panelEmptyState.Visible = false;
            this.panelEmptyState.Resize += new System.EventHandler(this.panelEmptyState_Resize);
            // 
            // lblEmptySubtitle
            // 
            this.lblEmptySubtitle.AutoSize = true;
            this.lblEmptySubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptySubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmptySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmptySubtitle.Location = new System.Drawing.Point(430, 236);
            this.lblEmptySubtitle.Name = "lblEmptySubtitle";
            this.lblEmptySubtitle.Size = new System.Drawing.Size(314, 21);
            this.lblEmptySubtitle.TabIndex = 2;
            this.lblEmptySubtitle.Text = "Try adjusting your filters or check back later.";
            this.lblEmptySubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.AutoSize = true;
            this.lblEmptyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEmptyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblEmptyTitle.Location = new System.Drawing.Point(468, 206);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(294, 30);
            this.lblEmptyTitle.TabIndex = 1;
            this.lblEmptyTitle.Text = "No expired products found";
            this.lblEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glyphEmptyState
            // 
            this.glyphEmptyState.BackColor = System.Drawing.Color.Transparent;
            this.glyphEmptyState.Icon = inventory_management_system_with_POS.IconKind.DocumentAlert;
            this.glyphEmptyState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.glyphEmptyState.Location = new System.Drawing.Point(576, 130);
            this.glyphEmptyState.Name = "glyphEmptyState";
            this.glyphEmptyState.Size = new System.Drawing.Size(64, 64);
            this.glyphEmptyState.StrokeWidth = 1.4F;
            this.glyphEmptyState.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelFooter.Controls.Add(this.lblTotalCount);
            this.panelFooter.Controls.Add(this.lblGenerated);
            this.panelFooter.Controls.Add(this.glyphFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 758);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1280, 34);
            this.panelFooter.TabIndex = 7;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalCount.Location = new System.Drawing.Point(1148, 8);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(117, 21);
            this.lblTotalCount.TabIndex = 2;
            this.lblTotalCount.Text = "0 items flagged";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGenerated
            // 
            this.lblGenerated.AutoSize = true;
            this.lblGenerated.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGenerated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGenerated.Location = new System.Drawing.Point(58, 8);
            this.lblGenerated.Name = "lblGenerated";
            this.lblGenerated.Size = new System.Drawing.Size(102, 21);
            this.lblGenerated.TabIndex = 1;
            this.lblGenerated.Text = "Generated —";
            // 
            // glyphFooter
            // 
            this.glyphFooter.BackColor = System.Drawing.Color.Transparent;
            this.glyphFooter.Icon = inventory_management_system_with_POS.IconKind.Calendar;
            this.glyphFooter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.glyphFooter.Location = new System.Drawing.Point(32, 8);
            this.glyphFooter.Name = "glyphFooter";
            this.glyphFooter.Size = new System.Drawing.Size(18, 18);
            this.glyphFooter.StrokeWidth = 1.6F;
            this.glyphFooter.TabIndex = 0;
            // 
            // frmExpiredProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 792);
            this.ControlBox = false;
            this.Controls.Add(this.panelEmptyState);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "frmExpiredProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmExpiredProducts_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.pnlDaysBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.pnlCategoryBox.ResumeLayout(false);
            this.tlpCards.ResumeLayout(false);
            this.panelCardExpired.ResumeLayout(false);
            this.panelCardExpired.PerformLayout();
            this.panelCardExpiring.ResumeLayout(false);
            this.panelCardExpiring.PerformLayout();
            this.panelCardValue.ResumeLayout(false);
            this.panelCardValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelEmptyState.ResumeLayout(false);
            this.panelEmptyState.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private inventory_management_system_with_POS.IconBadge badgeLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private inventory_management_system_with_POS.IconButton btnExportCsv;
        private inventory_management_system_with_POS.IconButton btnPrint;

        private System.Windows.Forms.Panel panelFilters;
        private inventory_management_system_with_POS.SearchBox pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private inventory_management_system_with_POS.FieldContainer pnlCategoryBox;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDays;
        private inventory_management_system_with_POS.FieldContainer pnlDaysBox;
        private System.Windows.Forms.NumericUpDown nudDays;
        private inventory_management_system_with_POS.IconButton btnRefresh;

        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private inventory_management_system_with_POS.RoundedPanel panelCardExpired;
        private inventory_management_system_with_POS.IconBadge badgeExpired;
        private System.Windows.Forms.Label lblExpiredTitle;
        private System.Windows.Forms.Label lblExpiredValue;

        private inventory_management_system_with_POS.RoundedPanel panelCardExpiring;
        private inventory_management_system_with_POS.IconBadge badgeExpiring;
        private System.Windows.Forms.Label lblExpiringTitle;
        private System.Windows.Forms.Label lblExpiringValue;

        private inventory_management_system_with_POS.RoundedPanel panelCardValue;
        private inventory_management_system_with_POS.IconBadge badgeValueAtRisk;
        private System.Windows.Forms.Label lblValueAtRiskTitle;
        private System.Windows.Forms.Label lblValueAtRiskValue;

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.Panel panelEmptyState;
        private inventory_management_system_with_POS.IconGlyph glyphEmptyState;
        private System.Windows.Forms.Label lblEmptyTitle;
        private System.Windows.Forms.Label lblEmptySubtitle;

        private System.Windows.Forms.Panel panelFooter;
        private inventory_management_system_with_POS.IconGlyph glyphFooter;
        private System.Windows.Forms.Label lblGenerated;
        private System.Windows.Forms.Label lblTotalCount;
    }
}