using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    public partial class frmaccount : Form
    {
        private const string AdminRole = "Admin";
        private const string SearchPlaceholder = "Search account";

        private string _currentAccId = string.Empty;
        private string _currentRole = string.Empty;

        public frmaccount()
        {
            InitializeComponent();

            gridAccounts.AutoGenerateColumns = false;

            Styles.Placeholder(txtSearch, SearchPlaceholder);
        }

        public frmaccount(string currentAccId, string currentRole) : this()
        {
            _currentAccId = currentAccId ?? string.Empty;
            _currentRole = currentRole ?? string.Empty;
        }

        private bool IsAdmin => string.Equals((_currentRole ?? string.Empty).Trim(), AdminRole, StringComparison.OrdinalIgnoreCase);

        private void frmaccount_Load(object sender, EventArgs e)
        {
            LoadAccounts();

            try
            {
                if (!string.IsNullOrEmpty(DBConnection.DatabaseName))
                {
                    SafeUi.SetText(this, "label1", SafeUi.GetText(this, "label1") + " - " + DBConnection.DatabaseName);
                }
            }
            catch (Exception ex)
            {
                // Cosmetic title only; record it but don't interrupt the user.
                ErrorLogger.Log(ex, "frmaccount_Load: set title text");
            }

            gridAccounts.ReadOnly = true;

            btnEdit.Enabled = true;
            btnDelete.Enabled = IsAdmin;

            LoadCurrentUserFooter();

            SafeUi.SetText(this, "lblDateTime", DateTime.Now.ToString("MM/dd/yyyy   hh:mm tt"));
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            SafeUi.SetText(this, "lblDateTime", DateTime.Now.ToString("MM/dd/yyyy   hh:mm tt"));
        }

        private void LoadCurrentUserFooter()
        {
            SafeUi.SetText(this, "lblUserIdValue", string.IsNullOrEmpty(_currentAccId) ? "-" : _currentAccId);
            SafeUi.SetText(this, "lblAccNameValue", "-");

            if (string.IsNullOrEmpty(_currentAccId))
                return;

            try
            {
                const string query = "SELECT acc_name FROM tbl_account WHERE acc_id = @acc_id;";

                using (MySqlConnection conn = DBConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@acc_id", _currentAccId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        SafeUi.SetText(this, "lblAccNameValue", result.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                // Footer label only; record it but don't interrupt the user.
                ErrorLogger.Log(ex, "frmaccount.LoadCurrentUserFooter");
            }
        }

        private void LoadAccounts(string searchText = "")
        {
            try
            {
               
                const string query = @"SELECT acc_id, acc_name, acc_type, gender, user_name,
                           '********' AS pass_word, created_at, phone, email
                    FROM tbl_account
                    WHERE acc_id LIKE @search
                       OR acc_name LIKE @search
                       OR acc_type LIKE @search
                       OR gender LIKE @search
                       OR user_name LIKE @search
                       OR phone LIKE @search
                       OR email LIKE @search
                    ORDER BY created_at DESC, acc_id ASC;";

                DataTable table = new DataTable();

                using (MySqlConnection conn = DBConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    string search = searchText == null ? "" : searchText.Trim();
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }

                gridAccounts.DataSource = table;
                gridAccounts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load accounts.\r\n\r\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void gridAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gridAccounts.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAccounts(GetSearchText());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                MessageBox.Show(
                    "Only an Admin account can delete accounts.",
                    "Permission denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (gridAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an account to delete.",
                    "Delete Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = gridAccounts.SelectedRows[0];
            string accountId = Convert.ToString(selectedRow.Cells["colAccId"].Value);
            string accountName = Convert.ToString(selectedRow.Cells["colAccName"].Value);

            if (string.IsNullOrWhiteSpace(accountId))
                return;

            if (string.Equals(accountId, _currentAccId, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You can't delete the account you're currently logged in as. " +
                    "Log in as a different Admin account to delete this one.",
                    "Delete Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this account?\r\n\r\n" +
                "Account ID: " + accountId + "\r\n" +
                "Account Name: " + accountName,
                "Delete Account",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                const string query = "DELETE FROM tbl_account WHERE acc_id = @acc_id;";

                using (MySqlConnection conn = DBConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@acc_id", accountId);

                    int affectedRows = cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        affectedRows > 0
                            ? "Account deleted successfully."
                            : "The selected account no longer exists.",
                        "Delete Account",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadAccounts(GetSearchText());
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show(
                    "This account cannot be deleted because it is already being used by other records " +
                    "(such as sales, stock-in, stock-out, activity logs, or login history).",
                    "Delete Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete the account.\r\n\r\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAccounts(GetSearchText());
        }

        // Returns "" while the placeholder text is showing, so the placeholder
        // is never used as a search filter (which would hide every row).
        private string GetSearchText()
        {
            string text = txtSearch.Text.Trim();
            return string.Equals(text, SearchPlaceholder, StringComparison.Ordinal) ? string.Empty : text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account to edit.", "Edit Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = gridAccounts.SelectedRows[0];
            string accID = Convert.ToString(selectedRow.Cells["colAccId"].Value);

            if (string.IsNullOrWhiteSpace(accID))
                return;

            bool isOwnAccount = string.Equals(accID, _currentAccId, StringComparison.OrdinalIgnoreCase);

            if (!IsAdmin && !isOwnAccount)
            {
                MessageBox.Show(
                    "You can only edit your own account. Only an Admin can edit other accounts.",
                    "Permission denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string accName = "", accType = "", gender = "", username = "", phone = "", email = "";

                const string query = @"SELECT acc_name, acc_type, gender, user_name, phone, email
                        FROM tbl_account
                        WHERE acc_id = @acc_id;";

                using (MySqlConnection conn = DBConnection.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@acc_id", accID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            accName = reader["acc_name"].ToString();
                            accType = reader["acc_type"].ToString();
                            gender = reader["gender"].ToString();
                            username = reader["user_name"].ToString();
                            phone = reader["phone"] == DBNull.Value ? "" : reader["phone"].ToString();
                            email = reader["email"] == DBNull.Value ? "" : reader["email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("The selected account no longer exists.", "Edit Account",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccounts(GetSearchText());
                            return;
                        }
                    }
                }

                using (frmCreateAccount fEdit = new frmCreateAccount())
                {
                    fEdit.LoadForEdit(accID, accName, username, gender, accType, phone, email);

                    if (!IsAdmin)
                    {
                        fEdit.LockRoleField();
                    }

                    if (fEdit.ShowDialog() == DialogResult.OK)
                    {
                        LoadAccounts(GetSearchText());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to edit the account.\r\n\r\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}