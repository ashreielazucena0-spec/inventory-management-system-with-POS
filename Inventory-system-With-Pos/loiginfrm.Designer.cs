    namespace inventory_management_system_with_POS
{
    partial class loiginfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loiginfrm));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.lblFormTitle = new System.Windows.Forms.ToolStripLabel();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lnkSignUp = new System.Windows.Forms.LinkLabel();
            this.pnlPasswordField = new System.Windows.Forms.Panel();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            this.pnlUsernameField = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.toolBar.SuspendLayout();
            this.pnlPasswordField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            this.pnlUsernameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFormTitle,
            this.btnExit});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(696, 27);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolBar";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(95, 24);
            this.lblFormTitle.Text = "LOGIN FORM";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::inventory_management_system_with_POS.Properties.Resources.reject;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 24);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.ToolTipText = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(355, 284);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "username";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBanner.Location = new System.Drawing.Point(0, 27);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(325, 606);
            this.pnlBanner.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtUsername.Location = new System.Drawing.Point(-1, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(268, 36);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(346, 393);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.Location = new System.Drawing.Point(-3, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(271, 36);
            this.txtPassword.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(346, 503);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(158, 29);
            this.chkShowPassword.TabIndex = 7;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(335, 536);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 43);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(476, 536);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.Location = new System.Drawing.Point(354, 199);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(239, 30);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Login to your account";
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Location = new System.Drawing.Point(331, 582);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(193, 25);
            this.lblNoAccount.TabIndex = 11;
            this.lblNoAccount.Text = "Dont have an account?";
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.Location = new System.Drawing.Point(513, 582);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(75, 25);
            this.lnkSignUp.TabIndex = 12;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Sign Up";
            this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);
            // 
            // pnlPasswordField
            // 
            this.pnlPasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPasswordField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPasswordField.Controls.Add(this.picPasswordIcon);
            this.pnlPasswordField.Controls.Add(this.txtPassword);
            this.pnlPasswordField.Location = new System.Drawing.Point(350, 437);
            this.pnlPasswordField.Name = "pnlPasswordField";
            this.pnlPasswordField.Size = new System.Drawing.Size(316, 43);
            this.pnlPasswordField.TabIndex = 13;
            // 
            // picPasswordIcon
            // 
            this.picPasswordIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.padlock;
            this.picPasswordIcon.Location = new System.Drawing.Point(274, 4);
            this.picPasswordIcon.Name = "picPasswordIcon";
            this.picPasswordIcon.Size = new System.Drawing.Size(38, 36);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPasswordIcon.TabIndex = 7;
            this.picPasswordIcon.TabStop = false;
            // 
            // pnlUsernameField
            // 
            this.pnlUsernameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsernameField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUsernameField.Controls.Add(this.picUserIcon);
            this.pnlUsernameField.Controls.Add(this.txtUsername);
            this.pnlUsernameField.Location = new System.Drawing.Point(351, 325);
            this.pnlUsernameField.Name = "pnlUsernameField";
            this.pnlUsernameField.Size = new System.Drawing.Size(315, 40);
            this.pnlUsernameField.TabIndex = 14;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::inventory_management_system_with_POS.Properties.Resources.user1;
            this.picUserIcon.Location = new System.Drawing.Point(273, 3);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(42, 39);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserIcon.TabIndex = 5;
            this.picUserIcon.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(359, 232);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 25);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome Back";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = global::inventory_management_system_with_POS.Properties.Resources.account;
            this.picLogo.Location = new System.Drawing.Point(439, 43);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(131, 142);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // loiginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 633);
            this.ControlBox = false;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lnkSignUp);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.pnlPasswordField);
            this.Controls.Add(this.pnlUsernameField);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loiginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loiginfrm_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.pnlPasswordField.ResumeLayout(false);
            this.pnlPasswordField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            this.pnlUsernameField.ResumeLayout(false);
            this.pnlUsernameField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripLabel lblFormTitle;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkSignUp;
        private System.Windows.Forms.Panel pnlPasswordField;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.Panel pnlUsernameField;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Label lblWelcome;
    }
}