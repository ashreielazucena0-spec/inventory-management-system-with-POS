namespace inventory_management_system_with_POS
{
    partial class frmPOS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxStoreIcon = new System.Windows.Forms.PictureBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.panelClock = new System.Windows.Forms.Panel();
            this.pictureBoxClockIcon = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pictureBoxProductIcon = new System.Windows.Forms.PictureBox();
            this.lblProductListTitle = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pictureBoxOrderIcon = new System.Windows.Forms.PictureBox();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblCashTendered = new System.Windows.Forms.Label();
            this.lblDiscountStatus = new System.Windows.Forms.Label();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.labelEmptyHint = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtCashTendered = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colProdBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.colCartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSeniorDiscount = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBarcodeIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmptyCart = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemarksIcon = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoreIcon)).BeginInit();
            this.panelClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClockIcon)).BeginInit();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductIcon)).BeginInit();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrderIcon)).BeginInit();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcodeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemarksIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.pnlHeader.Controls.Add(this.pictureBoxStoreIcon);
            this.pnlHeader.Controls.Add(this.lblStoreName);
            this.pnlHeader.Controls.Add(this.panelClock);
            this.pnlHeader.Location = new System.Drawing.Point(8, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 83);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBoxStoreIcon
            // 
            this.pictureBoxStoreIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStoreIcon.Location = new System.Drawing.Point(17, 16);
            this.pictureBoxStoreIcon.Name = "pictureBoxStoreIcon";
            this.pictureBoxStoreIcon.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxStoreIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStoreIcon.TabIndex = 0;
            this.pictureBoxStoreIcon.TabStop = false;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(87, 14);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(560, 52);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "AZUCENA CONVENIENT STORE";
            // 
            // panelClock
            // 
            this.panelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.panelClock.Controls.Add(this.pictureBoxClockIcon);
            this.panelClock.Controls.Add(this.lblClock);
            this.panelClock.Controls.Add(this.lblDate);
            this.panelClock.Location = new System.Drawing.Point(951, 14);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(300, 55);
            this.panelClock.TabIndex = 3;
            // 
            // pictureBoxClockIcon
            // 
            this.pictureBoxClockIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClockIcon.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxClockIcon.Name = "pictureBoxClockIcon";
            this.pictureBoxClockIcon.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxClockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClockIcon.TabIndex = 0;
            this.pictureBoxClockIcon.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(59, 3);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(80, 30);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "--:--:--";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(59, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Loading date...";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.pnlProducts.Controls.Add(this.pictureBoxProductIcon);
            this.pnlProducts.Controls.Add(this.lblProductListTitle);
            this.pnlProducts.Location = new System.Drawing.Point(14, 154);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(670, 39);
            this.pnlProducts.TabIndex = 10;
            // 
            // pictureBoxProductIcon
            // 
            this.pictureBoxProductIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProductIcon.Location = new System.Drawing.Point(14, 9);
            this.pictureBoxProductIcon.Name = "pictureBoxProductIcon";
            this.pictureBoxProductIcon.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxProductIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductIcon.TabIndex = 0;
            this.pictureBoxProductIcon.TabStop = false;
            // 
            // lblProductListTitle
            // 
            this.lblProductListTitle.AutoSize = true;
            this.lblProductListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductListTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductListTitle.Location = new System.Drawing.Point(47, 4);
            this.lblProductListTitle.Name = "lblProductListTitle";
            this.lblProductListTitle.Size = new System.Drawing.Size(130, 32);
            this.lblProductListTitle.TabIndex = 1;
            this.lblProductListTitle.Text = "Product List";
            // 
            // pnlOrder
            // 
            this.pnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.pnlOrder.Controls.Add(this.pictureBoxOrderIcon);
            this.pnlOrder.Controls.Add(this.lblOrderTitle);
            this.pnlOrder.Location = new System.Drawing.Point(695, 154);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(569, 39);
            this.pnlOrder.TabIndex = 11;
            // 
            // pictureBoxOrderIcon
            // 
            this.pictureBoxOrderIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOrderIcon.Location = new System.Drawing.Point(14, 9);
            this.pictureBoxOrderIcon.Name = "pictureBoxOrderIcon";
            this.pictureBoxOrderIcon.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxOrderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrderIcon.TabIndex = 0;
            this.pictureBoxOrderIcon.TabStop = false;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.ForeColor = System.Drawing.Color.White;
            this.lblOrderTitle.Location = new System.Drawing.Point(47, 4);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(150, 32);
            this.lblOrderTitle.TabIndex = 1;
            this.lblOrderTitle.Text = "Current Order";
            // 
            // panelSummary
            // 
            this.panelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelSummary.Controls.Add(this.gridSummary);
            this.panelSummary.Location = new System.Drawing.Point(699, 562);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(315, 159);
            this.panelSummary.TabIndex = 22;
            // 
            // gridSummary
            // 
            this.gridSummary.AllowUserToResizeColumns = false;
            this.gridSummary.AllowUserToResizeRows = false;
            this.gridSummary.BackgroundColor = System.Drawing.Color.White;
            this.gridSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.gridSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSummary.ColumnHeadersHeight = 33;
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSummary.EnableHeadersVisualStyles = false;
            this.gridSummary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.gridSummary.Location = new System.Drawing.Point(0, 0);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.ReadOnly = true;
            this.gridSummary.RowHeadersVisible = false;
            this.gridSummary.RowHeadersWidth = 51;
            this.gridSummary.RowTemplate.Height = 36;
            this.gridSummary.Size = new System.Drawing.Size(315, 159);
            this.gridSummary.TabIndex = 0;
            this.gridSummary.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 725);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1280, 35);
            this.panelFooter.TabIndex = 23;
            // 
            // lblCashTendered
            // 
            this.lblCashTendered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCashTendered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.lblCashTendered.Location = new System.Drawing.Point(282, 652);
            this.lblCashTendered.Name = "lblCashTendered";
            this.lblCashTendered.Size = new System.Drawing.Size(130, 28);
            this.lblCashTendered.TabIndex = 21;
            this.lblCashTendered.Text = "Cash Tendered";
            // 
            // lblDiscountStatus
            // 
            this.lblDiscountStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscountStatus.AutoSize = true;
            this.lblDiscountStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDiscountStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDiscountStatus.Location = new System.Drawing.Point(12, 698);
            this.lblDiscountStatus.Name = "lblDiscountStatus";
            this.lblDiscountStatus.Size = new System.Drawing.Size(90, 25);
            this.lblDiscountStatus.TabIndex = 20;
            this.lblDiscountStatus.Text = "Not applied";
            // 
            // labelEmpty
            // 
            this.labelEmpty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelEmpty.Location = new System.Drawing.Point(894, 372);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(170, 32);
            this.labelEmpty.TabIndex = 13;
            this.labelEmpty.Text = "No items in order";
            // 
            // labelEmptyHint
            // 
            this.labelEmptyHint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmptyHint.AutoSize = true;
            this.labelEmptyHint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelEmptyHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelEmptyHint.Location = new System.Drawing.Point(869, 405);
            this.labelEmptyHint.Name = "labelEmptyHint";
            this.labelEmptyHint.Size = new System.Drawing.Size(220, 25);
            this.labelEmptyHint.TabIndex = 14;
            this.labelEmptyHint.Text = "Add products to start selling";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtProductSearch.Location = new System.Drawing.Point(18, 109);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(601, 38);
            this.txtProductSearch.TabIndex = 2;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBarcode.Location = new System.Drawing.Point(699, 109);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(560, 38);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // txtCashTendered
            // 
            this.txtCashTendered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCashTendered.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashTendered.Location = new System.Drawing.Point(420, 640);
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.Size = new System.Drawing.Size(93, 48);
            this.txtCashTendered.TabIndex = 5;
            this.txtCashTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashTendered_KeyPress);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.txtRemarks.Location = new System.Drawing.Point(432, 576);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(250, 34);
            this.txtRemarks.TabIndex = 6;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToResizeColumns = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProducts.ColumnHeadersHeight = 44;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdBarcode,
            this.colProdName,
            this.colProdPrice,
            this.colProdStock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.gridProducts.Location = new System.Drawing.Point(17, 197);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 42;
            this.gridProducts.Size = new System.Drawing.Size(664, 360);
            this.gridProducts.TabIndex = 3;
            // 
            // colProdBarcode
            // 
            this.colProdBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdBarcode.HeaderText = "Barcode";
            this.colProdBarcode.MinimumWidth = 6;
            this.colProdBarcode.Name = "colProdBarcode";
            this.colProdBarcode.ReadOnly = true;
            this.colProdBarcode.Width = 120;
            // 
            // colProdName
            // 
            this.colProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProdName.HeaderText = "Product";
            this.colProdName.MinimumWidth = 6;
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // colProdPrice
            // 
            this.colProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdPrice.HeaderText = "Price";
            this.colProdPrice.MinimumWidth = 6;
            this.colProdPrice.Name = "colProdPrice";
            this.colProdPrice.ReadOnly = true;
            this.colProdPrice.Width = 90;
            // 
            // colProdStock
            // 
            this.colProdStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdStock.HeaderText = "Stock";
            this.colProdStock.MinimumWidth = 6;
            this.colProdStock.Name = "colProdStock";
            this.colProdStock.ReadOnly = true;
            this.colProdStock.Width = 90;
            // 
            // gridCart
            // 
            this.gridCart.AllowUserToResizeColumns = false;
            this.gridCart.AllowUserToResizeRows = false;
            this.gridCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCart.BackgroundColor = System.Drawing.Color.White;
            this.gridCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            this.gridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCart.ColumnHeadersHeight = 44;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartProduct,
            this.colCartQty,
            this.colCartTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridCart.EnableHeadersVisualStyles = false;
            this.gridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.gridCart.Location = new System.Drawing.Point(699, 197);
            this.gridCart.Name = "gridCart";
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.RowHeadersWidth = 51;
            this.gridCart.RowTemplate.Height = 42;
            this.gridCart.Size = new System.Drawing.Size(560, 360);
            this.gridCart.TabIndex = 4;
            // 
            // colCartProduct
            // 
            this.colCartProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCartProduct.HeaderText = "Product";
            this.colCartProduct.MinimumWidth = 6;
            this.colCartProduct.Name = "colCartProduct";
            this.colCartProduct.ReadOnly = true;
            // 
            // colCartQty
            // 
            this.colCartQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.colCartQty.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCartQty.HeaderText = "Qty";
            this.colCartQty.MinimumWidth = 6;
            this.colCartQty.Name = "colCartQty";
            this.colCartQty.Width = 70;
            // 
            // colCartTotal
            // 
            this.colCartTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCartTotal.HeaderText = "Total";
            this.colCartTotal.MinimumWidth = 6;
            this.colCartTotal.Name = "colCartTotal";
            this.colCartTotal.ReadOnly = true;
            this.colCartTotal.Width = 110;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(8, 568);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(126, 56);
            this.btnAddToCart.TabIndex = 15;
            this.btnAddToCart.TabStop = false;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(140, 568);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 56);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay; 
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.Location = new System.Drawing.Point(298, 568);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(126, 56);
            this.btnClearCart.TabIndex = 17;
            this.btnClearCart.TabStop = false;
            this.btnClearCart.Text = "Clear";
            this.btnClearCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(524, 650);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(166, 72);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay and Print";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSeniorDiscount
            // 
            this.btnSeniorDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeniorDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSeniorDiscount.FlatAppearance.BorderSize = 0;
            this.btnSeniorDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeniorDiscount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSeniorDiscount.ForeColor = System.Drawing.Color.White;
            this.btnSeniorDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeniorDiscount.Location = new System.Drawing.Point(8, 630);
            this.btnSeniorDiscount.Name = "btnSeniorDiscount";
            this.btnSeniorDiscount.Size = new System.Drawing.Size(266, 64);
            this.btnSeniorDiscount.TabIndex = 19;
            this.btnSeniorDiscount.TabStop = false;
            this.btnSeniorDiscount.Text = "Discounts";
            this.btnSeniorDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeniorDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeniorDiscount.UseVisualStyleBackColor = false;
            this.btnSeniorDiscount.Click += new System.EventHandler(this.btnSeniorDiscount_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(23, 116);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchIcon.TabIndex = 8;
            this.pictureBoxSearchIcon.TabStop = false;
            // 
            // pictureBoxBarcodeIcon
            // 
            this.pictureBoxBarcodeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBarcodeIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBarcodeIcon.Location = new System.Drawing.Point(711, 116);
            this.pictureBoxBarcodeIcon.Name = "pictureBoxBarcodeIcon";
            this.pictureBoxBarcodeIcon.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBarcodeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarcodeIcon.TabIndex = 9;
            this.pictureBoxBarcodeIcon.TabStop = false;
            // 
            // pictureBoxEmptyCart
            // 
            this.pictureBoxEmptyCart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxEmptyCart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmptyCart.Location = new System.Drawing.Point(949, 318);
            this.pictureBoxEmptyCart.Name = "pictureBoxEmptyCart";
            this.pictureBoxEmptyCart.Size = new System.Drawing.Size(59, 47);
            this.pictureBoxEmptyCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmptyCart.TabIndex = 12;
            this.pictureBoxEmptyCart.TabStop = false;
            // 
            // pictureBoxRemarksIcon
            // 
            this.pictureBoxRemarksIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxRemarksIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRemarksIcon.Location = new System.Drawing.Point(441, 585);
            this.pictureBoxRemarksIcon.Name = "pictureBoxRemarksIcon";
            this.pictureBoxRemarksIcon.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRemarksIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRemarksIcon.TabIndex = 18;
            this.pictureBoxRemarksIcon.TabStop = false;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.pictureBoxSearchIcon);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pictureBoxBarcodeIcon);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.gridCart);
            this.Controls.Add(this.pictureBoxEmptyCart);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.labelEmptyHint);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.pictureBoxRemarksIcon);
            this.Controls.Add(this.btnSeniorDiscount);
            this.Controls.Add(this.lblDiscountStatus);
            this.Controls.Add(this.lblCashTendered);
            this.Controls.Add(this.txtCashTendered);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panelFooter);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStoreIcon)).EndInit();
            this.panelClock.ResumeLayout(false);
            this.panelClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClockIcon)).EndInit();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductIcon)).EndInit();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrderIcon)).EndInit();
            this.panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcodeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemarksIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ---------------------------------------------------------------
        // NOTE: The WinForms Designer parses InitializeComponent as a
        // declarative CodeDom tree (it does not execute your compiled
        // code), so it cannot resolve ANY call to a custom method from
        // inside InitializeComponent. Every control is therefore styled
        // with plain inline property assignments only.
        // ---------------------------------------------------------------

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel panelFooter;

        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblProductListTitle;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCashTendered;
        private System.Windows.Forms.Label lblDiscountStatus;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Label labelEmptyHint;

        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtCashTendered;
        private System.Windows.Forms.TextBox txtRemarks;

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.DataGridView gridSummary;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProdBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartTotal;

        public System.Windows.Forms.Timer clockTimer;

        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSeniorDiscount;

        private System.Windows.Forms.PictureBox pictureBoxStoreIcon;
        private System.Windows.Forms.PictureBox pictureBoxClockIcon;
        private System.Windows.Forms.PictureBox pictureBoxSearchIcon;
        private System.Windows.Forms.PictureBox pictureBoxBarcodeIcon;
        private System.Windows.Forms.PictureBox pictureBoxProductIcon;
        private System.Windows.Forms.PictureBox pictureBoxOrderIcon;
        private System.Windows.Forms.PictureBox pictureBoxEmptyCart;
        private System.Windows.Forms.PictureBox pictureBoxRemarksIcon;
    }
}