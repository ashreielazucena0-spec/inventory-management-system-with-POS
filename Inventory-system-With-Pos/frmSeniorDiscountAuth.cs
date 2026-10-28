using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    
    public partial class frmSeniorDiscountAuth : Form
    {
        private const int MaxAttempts = 5;
        private int _attempts = 0;

        public string ApprovedByAccId { get; private set; }
        public string ApprovedByName { get; private set; }

        public frmSeniorDiscountAuth()
        {
            InitializeComponent();
        }

        private void frmSeniorDiscountAuth_Load(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

       
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ValidateScan();
            }
        }

        private void ValidateScan()
        {
            string scanned = txtBarcode.Text.Trim();
            txtBarcode.Clear();
            if (scanned.Length == 0) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    
                    const string query = @"SELECT acc_id, acc_name, acc_type, user_status
                                            FROM tbl_account
                                            WHERE acc_id = @accId
                                            LIMIT 1";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@accId", scanned);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                RegisterFailure("Badge not recognized. Please scan a valid Manager/Admin ID.");
                                return;
                            }

                            string accType = reader["acc_type"] == DBNull.Value ? "" : reader["acc_type"].ToString();
                            string status = reader["user_status"] == DBNull.Value ? "Active" : reader["user_status"].ToString();
                            string accId = reader["acc_id"].ToString();
                            string accName = reader["acc_name"] == DBNull.Value ? accId : reader["acc_name"].ToString();

                            if (!status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                            {
                                RegisterFailure($"\"{accName}\"'s account is not active.");
                                return;
                            }

                            bool isManagerOrAdmin =
                                accType.Equals("Manager", StringComparison.OrdinalIgnoreCase) ||
                                accType.Equals("Admin", StringComparison.OrdinalIgnoreCase);

                            if (!isManagerOrAdmin)
                            {
                                RegisterFailure("This badge is not a Manager or Admin account. Discount not approved.");
                                return;
                            }

                            ApprovedByAccId = accId;
                            ApprovedByName = accName;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                RegisterFailure("Could not verify that badge.\r\n" + ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void RegisterFailure(string message)
        {
            _attempts++;
            SafeUi.SetText(this, "lblStatus", message);
            SafeUi.SetVisible(this, "lblStatus", true);

            if (_attempts >= MaxAttempts)
            {
                SafeUi.SetText(this, "lblStatus", "Too many failed attempts. Closing.");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            txtBarcode.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
