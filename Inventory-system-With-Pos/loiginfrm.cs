using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{

    public partial class loiginfrm : Form
    {
        public loiginfrm()
        {
            InitializeComponent();
        }

        private void loiginfrm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.Text = "Show Password";
           
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
                chkShowPassword.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                chkShowPassword.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_name = txtUsername.Text.Trim();
            string pass_word = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(user_name) || string.IsNullOrWhiteSpace(pass_word))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string query = @"
                SELECT acc_id, acc_name, pass_word, acc_type, user_status
                FROM tbl_account
                WHERE user_name = @username
                LIMIT 1";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user_name);

                        string storedPassword = null;
                        string status = "Active";
                        string accName = user_name;
                        string accId = string.Empty;
                        string accType = string.Empty;
                        bool found = false;

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;
                                storedPassword = reader["pass_word"].ToString();
                                status = reader["user_status"] == DBNull.Value ? "Active" : reader["user_status"].ToString();
                                accName = reader["acc_name"] == DBNull.Value ? user_name : reader["acc_name"].ToString();
                                accId = reader["acc_id"] == DBNull.Value ? string.Empty : reader["acc_id"].ToString();
                                accType = reader["acc_type"] == DBNull.Value ? string.Empty : reader["acc_type"].ToString();
                            }
                        }

                        if (!found)
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtPassword.Clear();
                            txtUsername.Focus();
                            return;
                        }

                       
                        bool passwordOk;
                        bool needsRehash = false;

                        if (PasswordHelper.LooksHashed(storedPassword))
                        {
                            passwordOk = PasswordHelper.VerifyPassword(pass_word, storedPassword);
                        }
                        else
                        {
                            passwordOk = pass_word == storedPassword;
                            needsRehash = passwordOk;
                        }

                        if (!passwordOk)
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtPassword.Clear();
                            txtUsername.Focus();
                            return;
                        }

                        if (needsRehash)
                        {
                            string upgradedHash = PasswordHelper.HashPassword(pass_word);
                            const string upgradeQuery = "UPDATE tbl_account SET pass_word = @hash WHERE acc_id = @accId";

                            using (var upgradeCmd = new MySqlCommand(upgradeQuery, conn))
                            {
                                upgradeCmd.Parameters.AddWithValue("@hash", upgradedHash);
                                upgradeCmd.Parameters.AddWithValue("@accId", accId);
                                upgradeCmd.ExecuteNonQuery();
                            }
                        }

                        if (status == "Inactive")
                        {
                            MessageBox.Show(
                                "This account has been deactivated. Contact your administrator.",
                                "Account inactive",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        var main = new frmMainform(accName, accId, accType);
                        main.Show();
                        this.Hide();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Could not connect to the database:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount main = new frmCreateAccount();
            main.Show();
            this.Dispose();
        }
    }
}