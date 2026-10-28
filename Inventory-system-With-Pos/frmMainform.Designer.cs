namespace inventory_management_system_with_POS
{
    partial class frmMainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainform));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnDashboard = new System.Windows.Forms.ToolStripButton();
            this.btnPOS = new System.Windows.Forms.ToolStripButton();
            this.ddManagement = new System.Windows.Forms.ToolStripDropDownButton();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.expiredProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damagedProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.systemAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblUserIdCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.accid = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAccountName = new System.Windows.Forms.ToolStripStatusLabel();
            this.accname = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblClock);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1501, 101);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = Theme.Input;
            this.lblDate.Location = new System.Drawing.Point(11, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(142, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "DISPLAY DATE";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = Theme.Hero24;
            this.lblClock.Location = new System.Drawing.Point(3, 8);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(277, 48);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "DISPLAY TIME";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // toolMenu
            // 
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnDashboard,
            this.btnPOS,
            this.ddManagement,
            this.ddReport,
            this.ddSettings});
            this.toolMenu.Location = new System.Drawing.Point(0, 101);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(1501, 31);
            this.toolMenu.TabIndex = 3;
            this.toolMenu.Text = "toolMenu";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::inventory_management_system_with_POS.Properties.Resources.home1;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(74, 28);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Image = global::inventory_management_system_with_POS.Properties.Resources.dashboard;
            this.btnDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(106, 28);
            this.btnDashboard.Text = "Dashboard";
            // 
            // btnPOS
            // 
            this.btnPOS.Image = global::inventory_management_system_with_POS.Properties.Resources.point_of_sale;
            this.btnPOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(116, 28);
            this.btnPOS.Text = "Point of Sale";
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // ddManagement
            // 
            this.ddManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductToolStripMenuItem,
            this.manageStockToolStripMenuItem,
            this.manageSupplierToolStripMenuItem});
            this.ddManagement.Image = global::inventory_management_system_with_POS.Properties.Resources.management__1_;
            this.ddManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddManagement.Name = "ddManagement";
            this.ddManagement.Size = new System.Drawing.Size(131, 28);
            this.ddManagement.Text = "Management";
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.manageProductToolStripMenuItem.Text = "Manage product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // manageStockToolStripMenuItem
            // 
            this.manageStockToolStripMenuItem.Name = "manageStockToolStripMenuItem";
            this.manageStockToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.manageStockToolStripMenuItem.Text = "Manage Stock";
            // 
            // manageSupplierToolStripMenuItem
            // 
            this.manageSupplierToolStripMenuItem.Name = "manageSupplierToolStripMenuItem";
            this.manageSupplierToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.manageSupplierToolStripMenuItem.Text = "Manage Supplier";
            this.manageSupplierToolStripMenuItem.Click += new System.EventHandler(this.manageSupplierToolStripMenuItem_Click);
            // 
            // ddReport
            // 
            this.ddReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expiredProductToolStripMenuItem,
            this.damagedProductToolStripMenuItem,
            this.manageReportsToolStripMenuItem});
            this.ddReport.Image = global::inventory_management_system_with_POS.Properties.Resources.report;
            this.ddReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddReport.Name = "ddReport";
            this.ddReport.Size = new System.Drawing.Size(88, 28);
            this.ddReport.Text = "Report";
            // 
            // expiredProductToolStripMenuItem
            // 
            this.expiredProductToolStripMenuItem.Name = "expiredProductToolStripMenuItem";
            this.expiredProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.expiredProductToolStripMenuItem.Text = "Expired Product";
            this.expiredProductToolStripMenuItem.Click += new System.EventHandler(this.expiredProductToolStripMenuItem_Click);
            // 
            // damagedProductToolStripMenuItem
            // 
            this.damagedProductToolStripMenuItem.Name = "damagedProductToolStripMenuItem";
            this.damagedProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.damagedProductToolStripMenuItem.Text = "Damaged Product";
            // 
            // manageReportsToolStripMenuItem
            // 
            this.manageReportsToolStripMenuItem.Name = "manageReportsToolStripMenuItem";
            this.manageReportsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageReportsToolStripMenuItem.Text = "Manage Reports";
            // 
            // ddSettings
            // 
            this.ddSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemAccountsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitAppToolStripMenuItem});
            this.ddSettings.Image = global::inventory_management_system_with_POS.Properties.Resources.settings;
            this.ddSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddSettings.Name = "ddSettings";
            this.ddSettings.Size = new System.Drawing.Size(96, 28);
            this.ddSettings.Text = "Settings";
            // 
            // systemAccountsToolStripMenuItem
            // 
            this.systemAccountsToolStripMenuItem.Name = "systemAccountsToolStripMenuItem";
            this.systemAccountsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.systemAccountsToolStripMenuItem.Text = "System Accounts";
            this.systemAccountsToolStripMenuItem.Click += new System.EventHandler(this.systemAccountsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitAppToolStripMenuItem.Text = "Exit App";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserIdCaption,
            this.accid,
            this.lblAccountName,
            this.accname});
            this.statusBar.Location = new System.Drawing.Point(0, 577);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1501, 26);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "User ID:";
            // 
            // lblUserIdCaption
            // 
            this.lblUserIdCaption.Name = "lblUserIdCaption";
            this.lblUserIdCaption.Size = new System.Drawing.Size(60, 20);
            this.lblUserIdCaption.Text = "User ID:";
            // 
            // accid
            // 
            this.accid.ForeColor = System.Drawing.Color.Red;
            this.accid.Name = "accid";
            this.accid.Size = new System.Drawing.Size(99, 20);
            this.accid.Text = "display acc id";
            // 
            // lblAccountName
            // 
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(107, 20);
            this.lblAccountName.Text = "Account Name";
            // 
            // accname
            // 
            this.accname.ForeColor = System.Drawing.Color.Red;
            this.accname.Name = "accname";
            this.accname.Size = new System.Drawing.Size(123, 20);
            this.accname.Text = "display acc name";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 132);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1501, 445);
            this.pnlContent.TabIndex = 5;
            // 
            // frmMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 603);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = Theme.Caption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnDashboard;
        private System.Windows.Forms.ToolStripButton btnPOS;
        private System.Windows.Forms.ToolStripDropDownButton ddManagement;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ddReport;
        private System.Windows.Forms.ToolStripMenuItem expiredProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damagedProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ddSettings;
        private System.Windows.Forms.ToolStripMenuItem systemAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblUserIdCaption;
        private System.Windows.Forms.ToolStripStatusLabel accid;
        private System.Windows.Forms.ToolStripStatusLabel lblAccountName;
        private System.Windows.Forms.ToolStripStatusLabel accname;
        private System.Windows.Forms.Panel pnlContent;
    }
}