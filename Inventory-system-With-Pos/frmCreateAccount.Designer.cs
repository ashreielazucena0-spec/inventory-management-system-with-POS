namespace inventory_management_system_with_POS
{
    partial class frmCreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbposition = new System.Windows.Forms.ComboBox();
            this.picToggleConfirm = new System.Windows.Forms.PictureBox();
            this.picTogglePassword = new System.Windows.Forms.PictureBox();
            this.picPhoneIcon = new System.Windows.Forms.PictureBox();
            this.picPositionIcon = new System.Windows.Forms.PictureBox();
            this.picGenderIcon = new System.Windows.Forms.PictureBox();
            this.picEmailIcon = new System.Windows.Forms.PictureBox();
            this.picSubmitIcon = new System.Windows.Forms.PictureBox();
            this.picUsernameIcon = new System.Windows.Forms.PictureBox();
            this.picNameIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToggleConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPositionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenderIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 122);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::inventory_management_system_with_POS.Properties.Resources.add_user__1_;
            this.picLogo.Location = new System.Drawing.Point(82, 39);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 70);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(250, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Account";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtFullName.Location = new System.Drawing.Point(118, 194);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(240, 36);
            this.txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtUsername.Location = new System.Drawing.Point(118, 263);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 36);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.Location = new System.Drawing.Point(66, 329);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(264, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(66, 405);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(264, 36);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 248);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(111, 733);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 59);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Create account";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lnkLogin
            // 
            this.lnkLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(332, 763);
            this.lnkLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(166, 16);
            this.lnkLogin.TabIndex = 13;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Already Have an Account?";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPhone.Location = new System.Drawing.Point(118, 619);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 36);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEmail.Location = new System.Drawing.Point(118, 688);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 36);
            this.txtEmail.TabIndex = 18;
            // 
            // cmbgender
            // 
            this.cmbgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(118, 473);
            this.cmbgender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(240, 37);
            this.cmbgender.TabIndex = 20;
            this.cmbgender.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbgender_DrawItem);
            // 
            // cmbposition
            // 
            this.cmbposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbposition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbposition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cmbposition.FormattingEnabled = true;
            this.cmbposition.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Inventory Staff",
            "Manager"});
            this.cmbposition.Location = new System.Drawing.Point(118, 550);
            this.cmbposition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbposition.Name = "cmbposition";
            this.cmbposition.Size = new System.Drawing.Size(240, 37);
            this.cmbposition.TabIndex = 21;
            this.cmbposition.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbposition_DrawItem);
            // 
            // picToggleConfirm
            // 
            this.picToggleConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picToggleConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.picToggleConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picToggleConfirm.Image = global::inventory_management_system_with_POS.Properties.Resources.eye;
            this.picToggleConfirm.Location = new System.Drawing.Point(294, 407);
            this.picToggleConfirm.Name = "picToggleConfirm";
            this.picToggleConfirm.Size = new System.Drawing.Size(32, 32);
            this.picToggleConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToggleConfirm.TabIndex = 28;
            this.picToggleConfirm.TabStop = false;
            this.picToggleConfirm.Click += new System.EventHandler(this.picToggleConfirm_Click);
            // 
            // picTogglePassword
            // 
            this.picTogglePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTogglePassword.BackColor = System.Drawing.SystemColors.Window;
            this.picTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTogglePassword.Image = global::inventory_management_system_with_POS.Properties.Resources.eye;
            this.picTogglePassword.Location = new System.Drawing.Point(294, 331);
            this.picTogglePassword.Name = "picTogglePassword";
            this.picTogglePassword.Size = new System.Drawing.Size(32, 32);
            this.picTogglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTogglePassword.TabIndex = 27;
            this.picTogglePassword.TabStop = false;
            this.picTogglePassword.Click += new System.EventHandler(this.picTogglePassword_Click);
            // 
            // picPhoneIcon
            // 
            this.picPhoneIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoneIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.telephone;
            this.picPhoneIcon.Location = new System.Drawing.Point(63, 619);
            this.picPhoneIcon.Name = "picPhoneIcon";
            this.picPhoneIcon.Size = new System.Drawing.Size(53, 36);
            this.picPhoneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoneIcon.TabIndex = 33;
            this.picPhoneIcon.TabStop = false;
            // 
            // picPositionIcon
            // 
            this.picPositionIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPositionIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.briefcase;
            this.picPositionIcon.Location = new System.Drawing.Point(63, 550);
            this.picPositionIcon.Name = "picPositionIcon";
            this.picPositionIcon.Size = new System.Drawing.Size(53, 36);
            this.picPositionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPositionIcon.TabIndex = 32;
            this.picPositionIcon.TabStop = false;
            // 
            // picGenderIcon
            // 
            this.picGenderIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGenderIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picGenderIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.sex;
            this.picGenderIcon.Location = new System.Drawing.Point(63, 473);
            this.picGenderIcon.Name = "picGenderIcon";
            this.picGenderIcon.Size = new System.Drawing.Size(53, 36);
            this.picGenderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGenderIcon.TabIndex = 31;
            this.picGenderIcon.TabStop = false;
            // 
            // picEmailIcon
            // 
            this.picEmailIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEmailIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.mail;
            this.picEmailIcon.Location = new System.Drawing.Point(63, 688);
            this.picEmailIcon.Name = "picEmailIcon";
            this.picEmailIcon.Size = new System.Drawing.Size(53, 36);
            this.picEmailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmailIcon.TabIndex = 26;
            this.picEmailIcon.TabStop = false;
            // 
            // picSubmitIcon
            // 
            this.picSubmitIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSubmitIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picSubmitIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.add_user;
            this.picSubmitIcon.Location = new System.Drawing.Point(118, 746);
            this.picSubmitIcon.Name = "picSubmitIcon";
            this.picSubmitIcon.Size = new System.Drawing.Size(45, 46);
            this.picSubmitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSubmitIcon.TabIndex = 25;
            this.picSubmitIcon.TabStop = false;
            // 
            // picUsernameIcon
            // 
            this.picUsernameIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsernameIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picUsernameIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.user1;
            this.picUsernameIcon.Location = new System.Drawing.Point(63, 263);
            this.picUsernameIcon.Name = "picUsernameIcon";
            this.picUsernameIcon.Size = new System.Drawing.Size(53, 36);
            this.picUsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsernameIcon.TabIndex = 30;
            this.picUsernameIcon.TabStop = false;
            // 
            // picNameIcon
            // 
            this.picNameIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNameIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picNameIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.user1;
            this.picNameIcon.Location = new System.Drawing.Point(63, 194);
            this.picNameIcon.Name = "picNameIcon";
            this.picNameIcon.Size = new System.Drawing.Size(53, 36);
            this.picNameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNameIcon.TabIndex = 29;
            this.picNameIcon.TabStop = false;
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 810);
            this.ControlBox = false;
            this.Controls.Add(this.picToggleConfirm);
            this.Controls.Add(this.picTogglePassword);
            this.Controls.Add(this.picPhoneIcon);
            this.Controls.Add(this.picPositionIcon);
            this.Controls.Add(this.picGenderIcon);
            this.Controls.Add(this.picEmailIcon);
            this.Controls.Add(this.picSubmitIcon);
            this.Controls.Add(this.cmbposition);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picUsernameIcon);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picNameIcon);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateAccount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToggleConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPositionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNameIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbposition;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picSubmitIcon;
        private System.Windows.Forms.PictureBox picEmailIcon;
        private System.Windows.Forms.PictureBox picTogglePassword;
        private System.Windows.Forms.PictureBox picToggleConfirm;
        private System.Windows.Forms.PictureBox picNameIcon;
        private System.Windows.Forms.PictureBox picUsernameIcon;
        private System.Windows.Forms.PictureBox picGenderIcon;
        private System.Windows.Forms.PictureBox picPositionIcon;
        private System.Windows.Forms.PictureBox picPhoneIcon;
    }
}