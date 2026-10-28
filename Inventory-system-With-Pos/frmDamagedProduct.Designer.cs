namespace inventory_management_system_with_POS
{
    partial class frmDamagedProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderRightIcon;

        private System.Windows.Forms.Panel recordPanel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnRecord;

        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblQtyIcon;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblValueIcon;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnExport;

        private System.Windows.Forms.Panel gridHost;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;

        private System.Windows.Forms.Panel emptyStatePanel;
        private System.Windows.Forms.Label lblEmptyIcon;
        private System.Windows.Forms.Label lblEmptyBadge;
        private System.Windows.Forms.Label lblEmptyTitle;
        private System.Windows.Forms.Label lblEmptySubtitle;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.lblHeaderRightIcon = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.recordPanel = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblValueIcon = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblQtyIcon = new System.Windows.Forms.Label();
            this.gridHost = new System.Windows.Forms.Panel();
            this.emptyStatePanel = new System.Windows.Forms.Panel();
            this.lblEmptySubtitle = new System.Windows.Forms.Label();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.lblEmptyBadge = new System.Windows.Forms.Label();
            this.lblEmptyIcon = new System.Windows.Forms.Label();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header.SuspendLayout();
            this.recordPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.gridHost.SuspendLayout();
            this.emptyStatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.lblHeaderRightIcon);
            this.header.Controls.Add(this.lblHeaderSubtitle);
            this.header.Controls.Add(this.lblHeaderTitle);
            this.header.Controls.Add(this.lblHeaderIcon);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1150, 96);
            this.header.TabIndex = 0;
            // 
            // lblHeaderRightIcon
            // 
            this.lblHeaderRightIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderRightIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblHeaderRightIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblHeaderRightIcon.Location = new System.Drawing.Point(1078, 24);
            this.lblHeaderRightIcon.Name = "lblHeaderRightIcon";
            this.lblHeaderRightIcon.Size = new System.Drawing.Size(48, 48);
            this.lblHeaderRightIcon.TabIndex = 3;
            this.lblHeaderRightIcon.Text = "📋";
            this.lblHeaderRightIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(86, 54);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(280, 25);
            this.lblHeaderSubtitle.TabIndex = 2;
            this.lblHeaderSubtitle.Text = "Record damaged / write-off stock";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(84, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(266, 40);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Damaged Product";
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(24, 22);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(48, 48);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "📦";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordPanel
            // 
            this.recordPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recordPanel.Controls.Add(this.btnRecord);
            this.recordPanel.Controls.Add(this.lblRemarks);
            this.recordPanel.Controls.Add(this.txtRemarks);
            this.recordPanel.Controls.Add(this.lblUnitCost);
            this.recordPanel.Controls.Add(this.txtUnitCost);
            this.recordPanel.Controls.Add(this.lblQuantity);
            this.recordPanel.Controls.Add(this.txtQuantity);
            this.recordPanel.Controls.Add(this.lblProduct);
            this.recordPanel.Controls.Add(this.cboProduct);
            this.recordPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordPanel.Location = new System.Drawing.Point(0, 96);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.Size = new System.Drawing.Size(1150, 150);
            this.recordPanel.TabIndex = 1;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(950, 38);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(170, 46);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "⬤  Record damage";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblRemarks.Location = new System.Drawing.Point(20, 82);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(75, 21);
            this.lblRemarks.TabIndex = 7;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtRemarks.Location = new System.Drawing.Point(20, 106);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(1110, 31);
            this.txtRemarks.TabIndex = 8;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUnitCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblUnitCost.Location = new System.Drawing.Point(510, 16);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(78, 21);
            this.lblUnitCost.TabIndex = 4;
            this.lblUnitCost.Text = "Unit cost";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.BackColor = System.Drawing.Color.White;
            this.txtUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitCost.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUnitCost.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtUnitCost.Location = new System.Drawing.Point(510, 40);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(150, 31);
            this.txtUnitCost.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblQuantity.Location = new System.Drawing.Point(340, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtQuantity.Location = new System.Drawing.Point(340, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 31);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblProduct.Location = new System.Drawing.Point(20, 16);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(70, 21);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product";
            // 
            // cboProduct
            // 
            this.cboProduct.BackColor = System.Drawing.Color.White;
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProduct.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboProduct.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(20, 40);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(300, 31);
            this.cboProduct.TabIndex = 1;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.summaryPanel.Controls.Add(this.btnExport);
            this.summaryPanel.Controls.Add(this.lblTotalValue);
            this.summaryPanel.Controls.Add(this.lblValueIcon);
            this.summaryPanel.Controls.Add(this.lblTotalQty);
            this.summaryPanel.Controls.Add(this.lblQtyIcon);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.summaryPanel.Location = new System.Drawing.Point(0, 246);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(1150, 46);
            this.summaryPanel.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(970, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 34);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblTotalValue.Location = new System.Drawing.Point(330, 13);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(198, 25);
            this.lblTotalValue.TabIndex = 3;
            this.lblTotalValue.Text = "Total value lost: ₱0.00";
            // 
            // lblValueIcon
            // 
            this.lblValueIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblValueIcon.Location = new System.Drawing.Point(300, 10);
            this.lblValueIcon.Name = "lblValueIcon";
            this.lblValueIcon.Size = new System.Drawing.Size(26, 26);
            this.lblValueIcon.TabIndex = 2;
            this.lblValueIcon.Text = "🏷️";
            this.lblValueIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.ForeColor = System.Drawing.Color.White;
            this.lblTotalQty.Location = new System.Drawing.Point(50, 13);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(205, 25);
            this.lblTotalQty.TabIndex = 1;
            this.lblTotalQty.Text = "Total units damaged: 0";
            // 
            // lblQtyIcon
            // 
            this.lblQtyIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblQtyIcon.Location = new System.Drawing.Point(20, 10);
            this.lblQtyIcon.Name = "lblQtyIcon";
            this.lblQtyIcon.Size = new System.Drawing.Size(26, 26);
            this.lblQtyIcon.TabIndex = 0;
            this.lblQtyIcon.Text = "🪙";
            this.lblQtyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridHost
            // 
            this.gridHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.gridHost.Controls.Add(this.emptyStatePanel);
            this.gridHost.Controls.Add(this.gridHistory);
            this.gridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHost.Location = new System.Drawing.Point(0, 292);
            this.gridHost.Name = "gridHost";
            this.gridHost.Padding = new System.Windows.Forms.Padding(20, 12, 20, 20);
            this.gridHost.Size = new System.Drawing.Size(1150, 468);
            this.gridHost.TabIndex = 3;
            // 
            // emptyStatePanel
            // 
            this.emptyStatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.emptyStatePanel.Controls.Add(this.lblEmptySubtitle);
            this.emptyStatePanel.Controls.Add(this.lblEmptyTitle);
            this.emptyStatePanel.Controls.Add(this.lblEmptyBadge);
            this.emptyStatePanel.Controls.Add(this.lblEmptyIcon);
            this.emptyStatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyStatePanel.Location = new System.Drawing.Point(20, 12);
            this.emptyStatePanel.Name = "emptyStatePanel";
            this.emptyStatePanel.Size = new System.Drawing.Size(1110, 436);
            this.emptyStatePanel.TabIndex = 1;
            this.emptyStatePanel.Resize += new System.EventHandler(this.emptyStatePanel_Resize);
            // 
            // lblEmptySubtitle
            // 
            this.lblEmptySubtitle.AutoSize = true;
            this.lblEmptySubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEmptySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmptySubtitle.Location = new System.Drawing.Point(0, 0);
            this.lblEmptySubtitle.Name = "lblEmptySubtitle";
            this.lblEmptySubtitle.Size = new System.Drawing.Size(377, 25);
            this.lblEmptySubtitle.TabIndex = 3;
            this.lblEmptySubtitle.Text = "Recorded damaged products will appear here.";
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.AutoSize = true;
            this.lblEmptyTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEmptyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblEmptyTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(194, 30);
            this.lblEmptyTitle.TabIndex = 2;
            this.lblEmptyTitle.Text = "No records found";
            // 
            // lblEmptyBadge
            // 
            this.lblEmptyBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEmptyBadge.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblEmptyBadge.ForeColor = System.Drawing.Color.White;
            this.lblEmptyBadge.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyBadge.Name = "lblEmptyBadge";
            this.lblEmptyBadge.Size = new System.Drawing.Size(24, 24);
            this.lblEmptyBadge.TabIndex = 1;
            this.lblEmptyBadge.Text = "!";
            this.lblEmptyBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyIcon
            // 
            this.lblEmptyIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 38F);
            this.lblEmptyIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEmptyIcon.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyIcon.Name = "lblEmptyIcon";
            this.lblEmptyIcon.Size = new System.Drawing.Size(96, 88);
            this.lblEmptyIcon.TabIndex = 0;
            this.lblEmptyIcon.Text = "📦";
            this.lblEmptyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridHistory
            // 
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.gridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.gridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHistory.ColumnHeadersHeight = 40;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreatedAt,
            this.colProductName,
            this.colCategoryName,
            this.colQuantity,
            this.colUnitCost,
            this.colValue,
            this.colRemarks});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHistory.EnableHeadersVisualStyles = false;
            this.gridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.gridHistory.Location = new System.Drawing.Point(20, 12);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ReadOnly = true;
            this.gridHistory.RowHeadersVisible = false;
            this.gridHistory.RowHeadersWidth = 51;
            this.gridHistory.RowTemplate.Height = 36;
            this.gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistory.Size = new System.Drawing.Size(1110, 436);
            this.gridHistory.TabIndex = 0;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Date";
            this.colCreatedAt.MinimumWidth = 6;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colCategoryName
            // 
            this.colCategoryName.HeaderText = "Category";
            this.colCategoryName.MinimumWidth = 6;
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitCost
            // 
            this.colUnitCost.HeaderText = "Unit cost";
            this.colUnitCost.MinimumWidth = 6;
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value lost";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colRemarks
            // 
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.MinimumWidth = 6;
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            // 
            // frmDamagedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1150, 760);
            this.ControlBox = false;
            this.Controls.Add(this.gridHost);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.recordPanel);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "frmDamagedProduct";
            this.Load += new System.EventHandler(this.frmDamagedProduct_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.recordPanel.ResumeLayout(false);
            this.recordPanel.PerformLayout();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.gridHost.ResumeLayout(false);
            this.emptyStatePanel.ResumeLayout(false);
            this.emptyStatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}