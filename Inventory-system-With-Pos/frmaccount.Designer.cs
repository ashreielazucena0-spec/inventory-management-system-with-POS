namespace inventory_management_system_with_POS
{
    partial class frmaccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAccounts = new System.Windows.Forms.DataGridView();
            this.colAccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.gridCard = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.lblUserIdCaption = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblAccNameCaption = new System.Windows.Forms.Label();
            this.lblAccNameValue = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // colAccId
            // 
            this.colAccId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAccId.DataPropertyName = "acc_id";
            this.colAccId.HeaderText = "ACC. ID";
            this.colAccId.MinimumWidth = 6;
            this.colAccId.Name = "colAccId";
            // 
            // colAccName
            // 
            this.colAccName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAccName.DataPropertyName = "acc_name";
            this.colAccName.HeaderText = "ACCOUNT NAME";
            this.colAccName.MinimumWidth = 6;
            this.colAccName.Name = "colAccName";
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colType.DataPropertyName = "acc_type";
            this.colType.HeaderText = "TYPE";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            // 
            // colGender
            // 
            this.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGender.DataPropertyName = "gender";
            this.colGender.HeaderText = "GENDER";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            // 
            // colUsername
            // 
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUsername.DataPropertyName = "user_name";
            this.colUsername.HeaderText = "USERNAME";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPassword.DataPropertyName = "pass_word";
            this.colPassword.HeaderText = "PASSWORD";
            this.colPassword.MinimumWidth = 6;
            this.colPassword.Name = "colPassword";
            // 
            // colCreated
            // 
            this.colCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCreated.DataPropertyName = "created_at";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd HH:mm:ss";
            this.colCreated.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCreated.HeaderText = "CREATED";
            this.colCreated.MinimumWidth = 6;
            this.colCreated.Name = "colCreated";
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPhone.DataPropertyName = "phone";
            this.colPhone.HeaderText = "PHONE NUMBER";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "EMAIL";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.headerPanel.Controls.Add(this.picIcon);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 110);
            this.headerPanel.TabIndex = 3;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.user;
            this.picIcon.Location = new System.Drawing.Point(30, 25);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(60, 60);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(110, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Account";
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolbarPanel.Controls.Add(this.txtSearch);
            this.toolbarPanel.Controls.Add(this.btnEdit);
            this.toolbarPanel.Controls.Add(this.btnDelete);
            this.toolbarPanel.Controls.Add(this.btnRefresh);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 110);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Padding = new System.Windows.Forms.Padding(30, 12, 30, 12);
            this.toolbarPanel.Size = new System.Drawing.Size(1924, 64);
            this.toolbarPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearch.Location = new System.Drawing.Point(30, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(420, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.Location = new System.Drawing.Point(1620, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "✎  Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Location = new System.Drawing.Point(1732, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "✕  Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefresh.Location = new System.Drawing.Point(1854, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.gridPanel.Controls.Add(this.gridCard);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 174);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(30, 0, 30, 25);
            this.gridPanel.Size = new System.Drawing.Size(1924, 810);
            this.gridPanel.TabIndex = 0;
            // 
            // gridCard
            // 
            this.gridCard.BackColor = System.Drawing.Color.White;
            this.gridCard.Controls.Add(this.gridAccounts);
            this.gridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCard.Location = new System.Drawing.Point(30, 0);
            this.gridCard.Name = "gridCard";
            this.gridCard.Padding = new System.Windows.Forms.Padding(1);
            this.gridCard.Size = new System.Drawing.Size(1864, 785);
            this.gridCard.TabIndex = 0;
            // 
            // gridAccounts
            // 
            this.gridAccounts.AllowUserToAddRows = false;
            this.gridAccounts.AllowUserToDeleteRows = false;
            this.gridAccounts.AllowUserToResizeColumns = false;
            this.gridAccounts.AllowUserToResizeRows = false;
            this.gridAccounts.BackgroundColor = System.Drawing.Color.White;
            this.gridAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccId,
            this.colAccName,
            this.colType,
            this.colGender,
            this.colUsername,
            this.colPassword,
            this.colCreated,
            this.colPhone,
            this.colEmail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccounts.EnableHeadersVisualStyles = false;
            this.gridAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.gridAccounts.Location = new System.Drawing.Point(1, 1);
            this.gridAccounts.MultiSelect = false;
            this.gridAccounts.Name = "gridAccounts";
            this.gridAccounts.ReadOnly = true;
            this.gridAccounts.RowHeadersVisible = false;
            this.gridAccounts.RowHeadersWidth = 51;
            this.gridAccounts.RowTemplate.Height = 34;
            this.gridAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccounts.Size = new System.Drawing.Size(1862, 783);
            this.gridAccounts.TabIndex = 3;
            this.gridAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccounts_CellContentClick);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.footerPanel.Controls.Add(this.picUserIcon);
            this.footerPanel.Controls.Add(this.lblUserIdCaption);
            this.footerPanel.Controls.Add(this.lblUserIdValue);
            this.footerPanel.Controls.Add(this.lblAccNameCaption);
            this.footerPanel.Controls.Add(this.lblAccNameValue);
            this.footerPanel.Controls.Add(this.lblDateTime);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 984);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1924, 46);
            this.footerPanel.TabIndex = 1;
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUserIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.user1;
            this.picUserIcon.Location = new System.Drawing.Point(30, 13);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(20, 20);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 0;
            this.picUserIcon.TabStop = false;
            // 
            // lblUserIdCaption
            // 
            this.lblUserIdCaption.AutoSize = true;
            this.lblUserIdCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUserIdCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblUserIdCaption.Location = new System.Drawing.Point(58, 15);
            this.lblUserIdCaption.Name = "lblUserIdCaption";
            this.lblUserIdCaption.Size = new System.Drawing.Size(64, 21);
            this.lblUserIdCaption.TabIndex = 1;
            this.lblUserIdCaption.Text = "User ID:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.lblUserIdValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblUserIdValue.Location = new System.Drawing.Point(128, 15);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(16, 21);
            this.lblUserIdValue.TabIndex = 2;
            this.lblUserIdValue.Text = "-";
            // 
            // lblAccNameCaption
            // 
            this.lblAccNameCaption.AutoSize = true;
            this.lblAccNameCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAccNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblAccNameCaption.Location = new System.Drawing.Point(230, 15);
            this.lblAccNameCaption.Name = "lblAccNameCaption";
            this.lblAccNameCaption.Size = new System.Drawing.Size(115, 21);
            this.lblAccNameCaption.TabIndex = 3;
            this.lblAccNameCaption.Text = "Account Name:";
            // 
            // lblAccNameValue
            // 
            this.lblAccNameValue.AutoSize = true;
            this.lblAccNameValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAccNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblAccNameValue.Location = new System.Drawing.Point(351, 15);
            this.lblAccNameValue.Name = "lblAccNameValue";
            this.lblAccNameValue.Size = new System.Drawing.Size(16, 21);
            this.lblAccNameValue.TabIndex = 4;
            this.lblAccNameValue.Text = "-";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDateTime.Location = new System.Drawing.Point(1740, 15);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(16, 21);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "-";
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // frmaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1924, 1030);
            this.ControlBox = false;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmaccount_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            this.gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel gridCard;
        private System.Windows.Forms.DataGridView gridAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;

        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Label lblUserIdCaption;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.Label lblAccNameCaption;
        private System.Windows.Forms.Label lblAccNameValue;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer clockTimer;
    }

}