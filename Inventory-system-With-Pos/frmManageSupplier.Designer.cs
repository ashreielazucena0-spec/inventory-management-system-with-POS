namespace inventory_management_system_with_POS
{
    partial class frmManageSupplier
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.badgeLogo = new inventory_management_system_with_POS.IconBadge();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlSearchRow = new System.Windows.Forms.Panel();
            this.searchBox = new inventory_management_system_with_POS.SearchBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlFooterHost = new System.Windows.Forms.Panel();
            this.pnlFooter = new inventory_management_system_with_POS.RoundedPanel();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlSelected = new inventory_management_system_with_POS.RoundedPanel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlGridHost = new System.Windows.Forms.Panel();
            this.pnlGridCard = new inventory_management_system_with_POS.RoundedPanel();
            this.pnlEmpty = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEmptyContent = new System.Windows.Forms.Panel();
            this.glyphEmpty = new inventory_management_system_with_POS.IconGlyph();
            this.lblEmptyTitle = new System.Windows.Forms.Label();
            this.lblEmptySub = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlSearchRow.SuspendLayout();
            this.pnlFooterHost.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlSelected.SuspendLayout();
            this.pnlGridHost.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlEmpty.SuspendLayout();
            this.pnlEmptyContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.pnlHeader.Controls.Add(this.badgeLogo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 116);
            this.pnlHeader.TabIndex = 3;
            // 
            // badgeLogo
            // 
            this.badgeLogo.CircleColor = Theme.Surface;
            this.badgeLogo.CornerRadius = 8;
            this.badgeLogo.Icon = inventory_management_system_with_POS.IconKind.Clipboard;
            this.badgeLogo.IconColor = Theme.NavyMid;
            this.badgeLogo.Location = new System.Drawing.Point(32, 32);
            this.badgeLogo.Name = "badgeLogo";
            this.badgeLogo.Size = new System.Drawing.Size(52, 52);
            this.badgeLogo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = Theme.Display;
            this.lblTitle.ForeColor = Theme.Surface;
            this.lblTitle.Location = new System.Drawing.Point(100, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MANAGE SUPPLIER";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = Theme.Large;
            this.lblSubtitle.ForeColor = Theme.BorderStrong;
            this.lblSubtitle.Location = new System.Drawing.Point(102, 68);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Add, edit and remove the suppliers your products come from.";
            // 
            // pnlSearchRow
            // 
            this.pnlSearchRow.BackColor = Theme.Page;
            this.pnlSearchRow.Controls.Add(this.searchBox);
            this.pnlSearchRow.Controls.Add(this.btnAdd);
            this.pnlSearchRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchRow.Location = new System.Drawing.Point(0, 116);
            this.pnlSearchRow.Name = "pnlSearchRow";
            this.pnlSearchRow.Size = new System.Drawing.Size(1100, 90);
            this.pnlSearchRow.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(32, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(864, 44);
            this.searchBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = Theme.PrimaryDark;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = Theme.LargeBold;
            this.btnAdd.ForeColor = Theme.Surface;
            this.btnAdd.Location = new System.Drawing.Point(912, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+  Add Supplier";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pnlFooterHost
            // 
            this.pnlFooterHost.BackColor = Theme.Page;
            this.pnlFooterHost.Controls.Add(this.pnlFooter);
            this.pnlFooterHost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterHost.Location = new System.Drawing.Point(0, 676);
            this.pnlFooterHost.Name = "pnlFooterHost";
            this.pnlFooterHost.Padding = new System.Windows.Forms.Padding(32, 0, 32, 20);
            this.pnlFooterHost.Size = new System.Drawing.Size(1100, 84);
            this.pnlFooterHost.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = Theme.Surface;
            this.pnlFooter.BorderColor = Theme.Border;
            this.pnlFooter.CornerRadius = 0;
            this.pnlFooter.Controls.Add(this.lblCount);
            this.pnlFooter.Controls.Add(this.pnlSelected);
            this.pnlFooter.Controls.Add(this.btnEdit);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(32, 0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1036, 64);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Font = Theme.BodyBold;
            this.lblCount.ForeColor = Theme.TextMuted;
            this.lblCount.Location = new System.Drawing.Point(20, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(150, 64);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "0 suppliers";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSelected
            // 
            this.pnlSelected.BackColor = Theme.PrimaryTint;
            this.pnlSelected.CornerRadius = 8;
            this.pnlSelected.Controls.Add(this.lblSelected);
            this.pnlSelected.Location = new System.Drawing.Point(180, 12);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.pnlSelected.Size = new System.Drawing.Size(340, 40);
            this.pnlSelected.TabIndex = 1;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoEllipsis = true;
            this.lblSelected.BackColor = Theme.PrimaryTint;
            this.lblSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelected.Font = Theme.BodyBold;
            this.lblSelected.ForeColor = Theme.PrimaryDeep;
            this.lblSelected.Location = new System.Drawing.Point(14, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(312, 40);
            this.lblSelected.TabIndex = 0;
            this.lblSelected.Text = "No supplier selected";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = Theme.Surface;
            this.btnEdit.FlatAppearance.BorderColor = Theme.Primary;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = Theme.BodyBold;
            this.btnEdit.ForeColor = Theme.Primary;
            this.btnEdit.Location = new System.Drawing.Point(768, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = Theme.DangerTint;
            this.btnDelete.FlatAppearance.BorderColor = Theme.DangerSoft;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = Theme.BodyBold;
            this.btnDelete.ForeColor = Theme.Danger;
            this.btnDelete.Location = new System.Drawing.Point(900, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // pnlGridHost
            // 
            this.pnlGridHost.BackColor = Theme.Page;
            this.pnlGridHost.Controls.Add(this.pnlGridCard);
            this.pnlGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridHost.Location = new System.Drawing.Point(0, 206);
            this.pnlGridHost.Name = "pnlGridHost";
            this.pnlGridHost.Padding = new System.Windows.Forms.Padding(32, 0, 32, 16);
            this.pnlGridHost.Size = new System.Drawing.Size(1100, 470);
            this.pnlGridHost.TabIndex = 0;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = Theme.Surface;
            this.pnlGridCard.BorderColor = Theme.Border;
            this.pnlGridCard.CornerRadius = 0;
            this.pnlGridCard.Controls.Add(this.pnlEmpty);
            this.pnlGridCard.Controls.Add(this.dgvSuppliers);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(32, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGridCard.Size = new System.Drawing.Size(1036, 454);
            this.pnlGridCard.TabIndex = 0;
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmpty.BackColor = Theme.Surface;
            this.pnlEmpty.ColumnCount = 1;
            this.pnlEmpty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmpty.Controls.Add(this.pnlEmptyContent, 0, 0);
            this.pnlEmpty.Location = new System.Drawing.Point(1, 47);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.RowCount = 1;
            this.pnlEmpty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmpty.Size = new System.Drawing.Size(1034, 406);
            this.pnlEmpty.TabIndex = 1;
            // 
            // pnlEmptyContent
            // 
            this.pnlEmptyContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEmptyContent.BackColor = Theme.Surface;
            this.pnlEmptyContent.Controls.Add(this.glyphEmpty);
            this.pnlEmptyContent.Controls.Add(this.lblEmptyTitle);
            this.pnlEmptyContent.Controls.Add(this.lblEmptySub);
            this.pnlEmptyContent.Location = new System.Drawing.Point(307, 147);
            this.pnlEmptyContent.Name = "pnlEmptyContent";
            this.pnlEmptyContent.Size = new System.Drawing.Size(420, 112);
            this.pnlEmptyContent.TabIndex = 0;
            // 
            // glyphEmpty
            // 
            this.glyphEmpty.Icon = inventory_management_system_with_POS.IconKind.Clipboard;
            this.glyphEmpty.IconColor = Theme.BorderStrong;
            this.glyphEmpty.Location = new System.Drawing.Point(188, 0);
            this.glyphEmpty.Name = "glyphEmpty";
            this.glyphEmpty.Size = new System.Drawing.Size(44, 44);
            this.glyphEmpty.TabIndex = 0;
            // 
            // lblEmptyTitle
            // 
            this.lblEmptyTitle.Font = Theme.Heading;
            this.lblEmptyTitle.ForeColor = Theme.TextBody;
            this.lblEmptyTitle.Location = new System.Drawing.Point(0, 56);
            this.lblEmptyTitle.Name = "lblEmptyTitle";
            this.lblEmptyTitle.Size = new System.Drawing.Size(420, 26);
            this.lblEmptyTitle.TabIndex = 1;
            this.lblEmptyTitle.Text = "No suppliers found";
            this.lblEmptyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptySub
            // 
            this.lblEmptySub.Font = Theme.Body;
            this.lblEmptySub.ForeColor = Theme.TextMuted;
            this.lblEmptySub.Location = new System.Drawing.Point(0, 84);
            this.lblEmptySub.Name = "lblEmptySub";
            this.lblEmptySub.Size = new System.Drawing.Size(420, 22);
            this.lblEmptySub.TabIndex = 2;
            this.lblEmptySub.Text = "Start by adding a new supplier or search for an existing one.";
            this.lblEmptySub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.BackgroundColor = Theme.Surface;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Theme.NavyMid;
            dataGridViewCellStyle1.Font = Theme.BodyBold;
            dataGridViewCellStyle1.ForeColor = Theme.Surface;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Theme.NavyMid;
            dataGridViewCellStyle1.SelectionForeColor = Theme.Surface;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeight = 46;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSupplierId,
            this.colSupplierName,
            this.colContactPerson,
            this.colPhone,
            this.colEmail,
            this.colAddress});
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = Theme.Border;
            this.dgvSuppliers.Location = new System.Drawing.Point(1, 1);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(1034, 452);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellDoubleClick);
            this.dgvSuppliers.SelectionChanged += new System.EventHandler(this.dgvSuppliers_SelectionChanged);
            // 
            // colSupplierId
            // 
            this.colSupplierId.HeaderText = "SUPPLIER ID";
            this.colSupplierId.MinimumWidth = 100;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.Width = 120;
            // 
            // colSupplierName
            // 
            this.colSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplierName.FillWeight = 130F;
            this.colSupplierName.HeaderText = "SUPPLIER NAME";
            this.colSupplierName.MinimumWidth = 140;
            this.colSupplierName.Name = "colSupplierName";
            // 
            // colContactPerson
            // 
            this.colContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactPerson.FillWeight = 100F;
            this.colContactPerson.HeaderText = "CONTACT PERSON";
            this.colContactPerson.MinimumWidth = 110;
            this.colContactPerson.Name = "colContactPerson";
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "PHONE";
            this.colPhone.MinimumWidth = 110;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 140;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.FillWeight = 120F;
            this.colEmail.HeaderText = "EMAIL";
            this.colEmail.MinimumWidth = 140;
            this.colEmail.Name = "colEmail";
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.FillWeight = 150F;
            this.colAddress.HeaderText = "ADDRESS";
            this.colAddress.MinimumWidth = 140;
            this.colAddress.Name = "colAddress";
            // 
            // frmManageSupplier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = Theme.Page;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.pnlGridHost);
            this.Controls.Add(this.pnlFooterHost);
            this.Controls.Add(this.pnlSearchRow);
            this.Controls.Add(this.pnlHeader);
            this.Font = Theme.Body;
            this.Name = "frmManageSupplier";
            this.Text = "Manage Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageSupplier_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearchRow.ResumeLayout(false);
            this.pnlFooterHost.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlSelected.ResumeLayout(false);
            this.pnlGridHost.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            this.pnlEmpty.ResumeLayout(false);
            this.pnlEmptyContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private inventory_management_system_with_POS.IconBadge badgeLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlSearchRow;
        private SearchBox searchBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlFooterHost;
        private inventory_management_system_with_POS.RoundedPanel pnlFooter;
        private System.Windows.Forms.Label lblCount;
        private inventory_management_system_with_POS.RoundedPanel pnlSelected;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlGridHost;
        private inventory_management_system_with_POS.RoundedPanel pnlGridCard;
        private System.Windows.Forms.TableLayoutPanel pnlEmpty;
        private System.Windows.Forms.Panel pnlEmptyContent;
        private inventory_management_system_with_POS.IconGlyph glyphEmpty;
        private System.Windows.Forms.Label lblEmptyTitle;
        private System.Windows.Forms.Label lblEmptySub;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}