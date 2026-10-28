using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmCreateAccount : Form
    {
        private string _editAccId = "";
        private bool IsEditMode => !string.IsNullOrWhiteSpace(_editAccId);

        private bool _pwdVisible = false;
        private bool _confirmPwdVisible = false;

        public frmCreateAccount()
        {
            InitializeComponent();
            SetupPlaceholders();
        }

        // Grey hint text inside empty boxes (drawn by Windows, so .Text stays truly empty).
        private void SetupPlaceholders()
        {
            Styles.Placeholder(txtFullName, "Name");
            Styles.Placeholder(txtUsername, "Username");
            Styles.Placeholder(txtPassword, "Password");
            Styles.Placeholder(txtConfirmPassword, "Confirm Password");
            Styles.Placeholder(txtPhone, "Phone Number");
            Styles.Placeholder(txtEmail, "Email");

           
            ShowPassword(txtPassword, false); 
            ShowPassword(txtConfirmPassword, false);
        }

        private static void ShowPassword(TextBox box, bool visible)
        {
            box.PasswordChar = visible ? '\0' : '•';
          
        }

        public void LoadForEdit(string accId, string accName, string username, string gender, string accType, string phone, string email)
        {
            _editAccId = accId;

            txtFullName.Text = accName;
            txtUsername.Text = username;
            txtPhone.Text = phone ?? "";
            txtEmail.Text = email ?? "";

            cmbgender.SelectedItem = cmbgender.Items
                .Cast<object>()
                .FirstOrDefault(i => string.Equals(i.ToString(), gender, StringComparison.OrdinalIgnoreCase));

            cmbposition.SelectedItem = cmbposition.Items
                .Cast<object>()
                .FirstOrDefault(i => string.Equals(i.ToString(), accType, StringComparison.OrdinalIgnoreCase));

            txtPassword.Clear();
            txtConfirmPassword.Clear();
            SafeUi.SetText(this, "lblError", "");

            SafeUi.SetText(this, "lblTitle", "Update Account");
            btnSubmit.Text = "Update";
        }

        public void LockRoleField()
        {
            cmbposition.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswords();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswords();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsEditMode)
                UpdateAccount();
            else
                CreateAccount();
        }

        private void CreateAccount()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                cmbgender.SelectedIndex == -1 ||
                cmbposition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill up all fields first!",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                SafeUi.SetText(this, "lblError", "Passwords do not match");
                txtConfirmPassword.Focus();
                return;
            }

            SafeUi.SetText(this, "lblError", "");

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string gender = cmbgender.SelectedItem.ToString();
            string role = cmbposition.SelectedItem.ToString();
            string phone = txtPhone.Text.Trim();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {

                    const string checkQuery = "SELECT COUNT(*) FROM tbl_account WHERE user_name = @username";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("That username is already taken. Please choose another.",
                                "Username unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }
                    }

                    string newAccId = GenerateNextAccId(conn);
                    string passwordHash = PasswordHelper.HashPassword(password);

                    const string insertQuery = "INSERT INTO tbl_account " +
                        "(acc_id, acc_name, user_name, pass_word, gender, acc_type, phone, email) " +
                        "VALUES (@accId, @accName, @userName, @passWord, @gender, @accType, @phone, @email)";

                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@accId", newAccId);
                        insertCmd.Parameters.AddWithValue("@accName", fullName);
                        insertCmd.Parameters.AddWithValue("@userName", username);
                        insertCmd.Parameters.AddWithValue("@passWord", passwordHash);
                        insertCmd.Parameters.AddWithValue("@gender", gender);
                        insertCmd.Parameters.AddWithValue("@accType", role);
                        insertCmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        insertCmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account created successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                loiginfrm login = new loiginfrm();
                login.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmCreateAccount.CreateAccount (database)");
                MessageBox.Show("Could not create the account:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmCreateAccount.CreateAccount",
                    "Could not create the account because of an unexpected error.",
                    "Create Account");
            }
        }

        private void UpdateAccount()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                cmbgender.SelectedIndex == -1 ||
                cmbposition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill up all fields first!",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool changingPassword = !string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtConfirmPassword.Text);
            if (changingPassword && txtPassword.Text != txtConfirmPassword.Text)
            {
                SafeUi.SetText(this, "lblError", "Passwords do not match");
                txtConfirmPassword.Focus();
                return;
            }

            SafeUi.SetText(this, "lblError", "");

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string gender = cmbgender.SelectedItem.ToString();
            string role = cmbposition.SelectedItem.ToString();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    const string checkQuery = "SELECT COUNT(*) FROM tbl_account WHERE user_name = @username AND acc_id <> @accId";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@accId", _editAccId);
                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("That username is already taken. Please choose another.",
                                "Username unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }
                    }

                    string updateQuery = "UPDATE tbl_account SET " +
                        "acc_name = @accName, user_name = @userName, gender = @gender, " +
                        "acc_type = @accType, phone = @phone, email = @email" +
                        (changingPassword ? ", pass_word = @passWord" : "") +
                        " WHERE acc_id = @accId";

                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@accName", fullName);
                        updateCmd.Parameters.AddWithValue("@userName", username);
                        updateCmd.Parameters.AddWithValue("@gender", gender);
                        updateCmd.Parameters.AddWithValue("@accType", role);
                        updateCmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        updateCmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        updateCmd.Parameters.AddWithValue("@accId", _editAccId);

                        if (changingPassword)
                        {
                            string passwordHash = PasswordHelper.HashPassword(txtPassword.Text);
                            updateCmd.Parameters.AddWithValue("@passWord", passwordHash);
                        }

                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmCreateAccount.UpdateAccount (database)");
                MessageBox.Show("Could not update the account:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmCreateAccount.UpdateAccount",
                    "Could not update the account because of an unexpected error.",
                    "Update Account");
            }
        }


        private string GenerateNextAccId(MySqlConnection conn)
        {
            const string query = "SELECT acc_id FROM tbl_account " +
                                  "WHERE acc_id LIKE 'ACC-%' " +
                                  "ORDER BY CAST(SUBSTRING(acc_id, 5) AS UNSIGNED) DESC LIMIT 1";

            using (var cmd = new MySqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                int nextNumber = 1;

                if (result != null)
                {
                    string lastId = result.ToString();
                    string numericPart = lastId.Substring(4);
                    if (int.TryParse(numericPart, out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                return "ACC-" + nextNumber.ToString("D3");
            }
        }

        private void ValidatePasswords()
        {
            string pwd = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (!string.IsNullOrEmpty(confirm) && pwd != confirm)
            {
                SafeUi.SetText(this, "lblError", "Passwords do not match");
            }
            else
            {
                SafeUi.SetText(this, "lblError", string.Empty);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loiginfrm main = new loiginfrm();
            main.Show();
            this.Hide();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            var txt = txtPhone.Text;
            if (string.IsNullOrEmpty(txt)) return;

            var digits = new string(txt.Where(char.IsDigit).ToArray());
            if (digits != txt)
            {
                var selStart = txtPhone.SelectionStart;
                txtPhone.Text = digits;
                txtPhone.SelectionStart = Math.Min(digits.Length, selStart > 0 ? selStart - 1 : digits.Length);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Eye icon next to the Password field: click to reveal, click again to hide.
        private void picTogglePassword_Click(object sender, EventArgs e)
        {
            _pwdVisible = !_pwdVisible;
            SafeUi.Run<PictureBox>(this, "picTogglePassword", p => p.Image = _pwdVisible ? Properties.Resources.eye_open : Properties.Resources.eye);
            ShowPassword(txtPassword, _pwdVisible);
        }

        // Eye icon next to the Confirm Password field: click to reveal, click again to hide.
        private void picToggleConfirm_Click(object sender, EventArgs e)
        {
            _confirmPwdVisible = !_confirmPwdVisible;
            SafeUi.Run<PictureBox>(this, "picToggleConfirm", p => p.Image = _confirmPwdVisible ? Properties.Resources.eye_open : Properties.Resources.eye);
            ShowPassword(txtConfirmPassword, _confirmPwdVisible);
        }

        // Paints "Gender" in gray when nothing is selected yet.
        private void cmbgender_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboWithPlaceholder(cmbgender, e, "Gender");
        }

        // Paints "Position" in gray when nothing is selected yet.
        private void cmbposition_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboWithPlaceholder(cmbposition, e, "Position");
        }

        private void DrawComboWithPlaceholder(ComboBox combo, DrawItemEventArgs e, string placeholder)
        {
            e.DrawBackground();

            string text;
            Color color;

            if (e.Index >= 0)
            {
                text = combo.Items[e.Index].ToString();
                color = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                    ? SystemColors.HighlightText
                    : SystemColors.WindowText;
            }
            else if (combo.SelectedIndex == -1)
            {
                text = placeholder;
                color = Theme.TextHint;
            }
            else
            {
                text = combo.Items[combo.SelectedIndex].ToString();
                color = SystemColors.WindowText;
            }

            using (var brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(text, combo.Font, brush,
                    new PointF(e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - combo.Font.Height) / 2f));
            }

            e.DrawFocusRectangle();
        }

    }
}