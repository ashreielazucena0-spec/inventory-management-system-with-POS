using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmManageSupplier : Form
    {
        private const int GridHeaderHeight = 46;  
        public frmManageSupplier()
        {
            InitializeComponent();
            ApplyStyles();

            searchBox.TextBox.TextChanged += (s, e) => LoadSuppliers();
        }

        private void ApplyStyles()
        {
            searchBox.Padding = new Padding(36, 11, 10, 0);
            searchBox.TextBox.Font = Theme.Large;
            searchBox.TextBox.ForeColor = Theme.TextStrong;
            Styles.Placeholder(searchBox.TextBox, "Search by name, contact, phone, email or ID");

            Styles.PrimaryButton(btnAdd);
            btnAdd.BackColor = Theme.PrimaryDark;
            btnAdd.FlatAppearance.MouseOverBackColor = Theme.PrimaryDeep;
            btnAdd.FlatAppearance.MouseDownBackColor = Theme.PrimaryDeep;

            Styles.OutlineButton(btnEdit);

            Styles.DangerButton(btnDelete);
            btnDelete.BackColor = Theme.DangerTint;
            btnDelete.ForeColor = Theme.Danger;
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatAppearance.BorderColor = Theme.DangerSoft;
            btnDelete.FlatAppearance.MouseOverBackColor = Theme.DangerSoft;
            btnDelete.FlatAppearance.MouseDownBackColor = Theme.DangerSoft;

            Styles.Grid(dgvSuppliers);
            Styles.ReadOnlyGrid(dgvSuppliers);

            DataGridViewCellStyle head = dgvSuppliers.ColumnHeadersDefaultCellStyle;
            head.BackColor = Theme.NavyMid;
            head.ForeColor = Theme.Surface;
            head.SelectionBackColor = Theme.NavyMid;
            head.SelectionForeColor = Theme.Surface;
            head.Font = Theme.BodyBold;
            dgvSuppliers.ColumnHeadersHeight = GridHeaderHeight;
        }

        private void frmManageSupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditSelected();
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionChip();
        }

        private void LoadSuppliers(string selectId = null)
        {
            try
            {
                dgvSuppliers.Rows.Clear();

                const string query = @"SELECT supplier_id, supplier_name, contact_person, phone, email, address
                                       FROM tbl_supplier
                                       WHERE supplier_name   LIKE @search
                                          OR supplier_id     LIKE @search
                                          OR contact_person  LIKE @search
                                          OR phone           LIKE @search
                                          OR email           LIKE @search
                                          OR address         LIKE @search
                                       ORDER BY supplier_name ASC";

                using (var conn = DBConnection.GetConnection())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    string search = (searchBox.TextBox.Text ?? "").Trim();
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvSuppliers.Rows.Add(
                                Str(reader["supplier_id"]),
                                Str(reader["supplier_name"]),
                                Str(reader["contact_person"]),
                                Str(reader["phone"]),
                                Str(reader["email"]),
                                Str(reader["address"]));
                        }
                    }
                }

                int count = dgvSuppliers.Rows.Count;
                bool any = count > 0;
                bool searching = !string.IsNullOrWhiteSpace(searchBox.TextBox.Text);

                pnlEmpty.Visible = !any;
                lblCount.Text = count == 1 ? "1 supplier" : count + " suppliers";
                SafeUi.SetText(this, "lblEmptyTitle", searching ? "No suppliers found" : "No suppliers yet");
                SafeUi.SetText(this, "lblEmptySub", searching
                    ? "Try a different name, contact, phone, email or ID."
                    : "Click Add Supplier to create the first one.");

                dgvSuppliers.ClearSelection();
                if (any && selectId != null)
                {
                    foreach (DataGridViewRow row in dgvSuppliers.Rows)
                    {
                        if (string.Equals(Str(row.Cells[colSupplierId.Index].Value), selectId, StringComparison.OrdinalIgnoreCase))
                        {
                            row.Selected = true;
                            dgvSuppliers.CurrentCell = row.Cells[colSupplierName.Index];
                            break;
                        }
                    }
                }
                UpdateSelectionChip();
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmManageSupplier.LoadSuppliers (database)");
                MessageBox.Show("Unable to load suppliers.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmManageSupplier.LoadSuppliers",
                    "Unable to display the supplier list.", "Manage Supplier");
            }
        }

        private bool TryGetSelected(out SupplierInfo info)
        {
            info = null;
            if (dgvSuppliers.SelectedRows.Count == 0) return false;

            DataGridViewRow row = dgvSuppliers.SelectedRows[0];
            string id = Str(row.Cells[colSupplierId.Index].Value);
            if (string.IsNullOrEmpty(id)) return false;

            info = new SupplierInfo
            {
                Id = id,
                Name = Str(row.Cells[colSupplierName.Index].Value),
                ContactPerson = Str(row.Cells[colContactPerson.Index].Value),
                Phone = Str(row.Cells[colPhone.Index].Value),
                Email = Str(row.Cells[colEmail.Index].Value),
                Address = Str(row.Cells[colAddress.Index].Value)
            };
            return true;
        }

        private void UpdateSelectionChip()
        {
            SupplierInfo selected;
            lblSelected.Text = TryGetSelected(out selected)
                ? "Selected: " + selected.Name
                : "No supplier selected";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new SupplierEditDialog("Add Supplier", null))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    string newId = InsertSupplier(dlg.Result);
                    if (newId == null) return;

                    LoadSuppliers(newId);
                    MessageBox.Show("Supplier added.", "Manage Supplier",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    ErrorLogger.Log(ex, "frmManageSupplier.BtnAdd_Click (database)");
                    MessageBox.Show("Could not add the supplier.\r\n\r\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogAndShow(ex, "frmManageSupplier.BtnAdd_Click",
                        "Could not add the supplier because of an unexpected error.", "Manage Supplier");
                }
            }
        }

        private string InsertSupplier(SupplierInfo supplier)
        {
            using (var conn = DBConnection.GetConnection())
            {
                if (SupplierNameExists(conn, supplier.Name, null))
                {
                    MessageBox.Show("A supplier with that name already exists.", "Manage Supplier",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                string newId = NextSupplierId(conn);

                const string query = @"INSERT INTO tbl_supplier
                                         (supplier_id, supplier_name, contact_person, phone, email, address)
                                       VALUES (@id, @name, @contact, @phone, @email, @address)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@name", supplier.Name);
                    cmd.Parameters.AddWithValue("@contact", Db(supplier.ContactPerson));
                    cmd.Parameters.AddWithValue("@phone", Db(supplier.Phone));
                    cmd.Parameters.AddWithValue("@email", Db(supplier.Email));
                    cmd.Parameters.AddWithValue("@address", Db(supplier.Address));
                    cmd.ExecuteNonQuery();
                }
                return newId;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void EditSelected()
        {
            SupplierInfo current;
            if (!TryGetSelected(out current))
            {
                MessageBox.Show("Please select a supplier to edit.", "Manage Supplier",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SupplierEditDialog("Edit Supplier", current))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                SupplierInfo updated = dlg.Result;
                updated.Id = current.Id;
                if (updated.SameAs(current)) return;

                try
                {
                    if (!UpdateSupplier(updated)) return;

                    LoadSuppliers(updated.Id);
                    MessageBox.Show("Supplier updated.", "Manage Supplier",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    ErrorLogger.Log(ex, "frmManageSupplier.EditSelected (database)");
                    MessageBox.Show("Could not update the supplier.\r\n\r\n" + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogAndShow(ex, "frmManageSupplier.EditSelected",
                        "Could not update the supplier because of an unexpected error.", "Manage Supplier");
                }
            }
        }

        private bool UpdateSupplier(SupplierInfo supplier)
        {
            using (var conn = DBConnection.GetConnection())
            {
                if (SupplierNameExists(conn, supplier.Name, supplier.Id))
                {
                    MessageBox.Show("A supplier with that name already exists.", "Manage Supplier",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                const string query = @"UPDATE tbl_supplier
                                       SET supplier_name = @name, contact_person = @contact,
                                           phone = @phone, email = @email, address = @address
                                       WHERE supplier_id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", supplier.Name);
                    cmd.Parameters.AddWithValue("@contact", Db(supplier.ContactPerson));
                    cmd.Parameters.AddWithValue("@phone", Db(supplier.Phone));
                    cmd.Parameters.AddWithValue("@email", Db(supplier.Email));
                    cmd.Parameters.AddWithValue("@address", Db(supplier.Address));
                    cmd.Parameters.AddWithValue("@id", supplier.Id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SupplierInfo selected;
            if (!TryGetSelected(out selected))
            {
                MessageBox.Show("Please select a supplier to delete.", "Manage Supplier",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var confirm = new frmConfirmDialog("Delete Supplier",
                "Delete \"" + selected.Name + "\"? This cannot be undone."))
            {
                if (confirm.ShowDialog(this) != DialogResult.Yes) return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    long products = CountLinked(conn, "tbl_product", selected.Id);
                    long stockRecords = CountLinked(conn, "tbl_stock_log", selected.Id);

                    // Kept on purpose: deleting would blank the supplier on old products and stock records.
                    if (products > 0 || stockRecords > 0)
                    {
                        MessageBox.Show(
                            "\"" + selected.Name + "\" can't be deleted because it is used by " + products +
                            " product(s) and " + stockRecords + " stock record(s).\r\n\r\n" +
                            "Suppliers with products or stock history are kept so past records stay accurate. " +
                            "To stop using this supplier, change the supplier on those products instead.",
                            "Supplier In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (var cmd = new MySqlCommand("DELETE FROM tbl_supplier WHERE supplier_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selected.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadSuppliers();
                MessageBox.Show("Supplier deleted.", "Manage Supplier",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                ErrorLogger.Log(ex, "frmManageSupplier.BtnDelete_Click (database)");
                MessageBox.Show("Could not delete the supplier.\r\n\r\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogAndShow(ex, "frmManageSupplier.BtnDelete_Click",
                    "Could not delete the supplier because of an unexpected error.", "Manage Supplier");
            }
        }

        private static bool SupplierNameExists(MySqlConnection conn, string name, string excludeId)
        {
            string query = "SELECT COUNT(*) FROM tbl_supplier WHERE supplier_name = @name" +
                           (excludeId == null ? "" : " AND supplier_id <> @id");

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                if (excludeId != null) cmd.Parameters.AddWithValue("@id", excludeId);
                return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
            }
        }

        private static long CountLinked(MySqlConnection conn, string table, string supplierId)
        {
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM " + table + " WHERE supplier_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", supplierId);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        private static string NextSupplierId(MySqlConnection conn)
        {
            long best = 0;
            string prefix = "SUP-";
            int width = 4;
            bool found = false;

            using (var cmd = new MySqlCommand("SELECT supplier_id FROM tbl_supplier", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Match m = Regex.Match(Str(reader[0]).Trim(), @"^(.*?)(\d+)$");
                    if (!m.Success) continue;

                    long n;
                    if (!long.TryParse(m.Groups[2].Value, out n)) continue;

                    if (!found || n > best)
                    {
                        best = n;
                        prefix = m.Groups[1].Value;
                        width = m.Groups[2].Value.Length;
                        found = true;
                    }
                }
            }

            return prefix + (best + 1).ToString("D" + width);
        }

        private static object Db(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? (object)DBNull.Value : value.Trim();
        }

        private static string Str(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            byte[] bytes = value as byte[];
            if (bytes != null) return Encoding.UTF8.GetString(bytes);
            return Convert.ToString(value) ?? "";
        }
    }

    internal sealed class SupplierEditDialog : Form
    {
        private readonly TextBox _txtName = new TextBox();
        private readonly TextBox _txtContact = new TextBox();
        private readonly TextBox _txtPhone = new TextBox();
        private readonly TextBox _txtEmail = new TextBox();
        private readonly TextBox _txtAddress = new TextBox();
        private readonly Label _lblError = new Label();

        public SupplierInfo Result
        {
            get
            {
                return new SupplierInfo
                {
                    Name = _txtName.Text.Trim(),
                    ContactPerson = _txtContact.Text.Trim(),
                    Phone = _txtPhone.Text.Trim(),
                    Email = _txtEmail.Text.Trim(),
                    Address = _txtAddress.Text.Trim()
                };
            }
        }

        public SupplierEditDialog(string title, SupplierInfo current)
        {
            Text = title;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Theme.Page;
            Font = Theme.Body;
            ClientSize = new Size(520, 494);

            var banner = new Panel { Dock = DockStyle.Top, Height = 76, BackColor = Color.FromArgb(0, 102, 204) };
            banner.Controls.Add(new Label
            {
                Text = title,
                Font = Theme.Heading,
                ForeColor = Theme.Surface,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(24, 14)
            });
            banner.Controls.Add(new Label
            {
                Text = current == null ? "Enter the supplier's details." : "Supplier ID: " + current.Id,
                Font = Theme.Body,
                ForeColor = Theme.BorderStrong,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(24, 44)
            });
            Controls.Add(banner);

            AddField("Supplier name *", _txtName, 24, 96, 472, 38, 150, false);
            AddField("Contact person", _txtContact, 24, 166, 472, 38, 100, false);
            AddField("Phone", _txtPhone, 24, 236, 230, 38, 20, false);
            AddField("Email", _txtEmail, 266, 236, 230, 38, 100, false);
            AddField("Address", _txtAddress, 24, 306, 472, 64, 255, true);

            if (current != null)
            {
                _txtName.Text = current.Name;
                _txtContact.Text = current.ContactPerson;
                _txtPhone.Text = current.Phone;
                _txtEmail.Text = current.Email;
                _txtAddress.Text = current.Address;
            }

            _lblError.Font = Theme.Caption;
            _lblError.ForeColor = Theme.Danger;
            _lblError.AutoSize = true;
            _lblError.Location = new Point(24, 398);
            Controls.Add(_lblError);

            var btnSave = new Button { Text = "Save", Font = Theme.BodyBold, Size = new Size(100, 40), Location = new Point(284, 430) };
            var btnCancel = new Button { Text = "Cancel", Font = Theme.BodyBold, Size = new Size(100, 40), Location = new Point(396, 430) };
            Styles.PrimaryButton(btnSave);
            Styles.OutlineButton(btnCancel);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnSave.Click += (s, e) => TrySave();

            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            AcceptButton = btnSave;
            CancelButton = btnCancel;

            foreach (TextBox box in new[] { _txtName, _txtContact, _txtPhone, _txtEmail, _txtAddress })
                box.TextChanged += (s, e) => _lblError.Text = "";

            Shown += (s, e) => { _txtName.Focus(); _txtName.SelectAll(); };
        }

        private void AddField(string caption, TextBox box, int x, int y, int width, int height, int maxLength, bool multiline)
        {
            Controls.Add(new Label
            {
                Text = caption,
                Font = Theme.CaptionBold,
                ForeColor = Theme.TextMuted,
                AutoSize = true,
                Location = new Point(x, y)
            });

            var field = new FieldContainer
            {
                Location = new Point(x, y + 20),
                Size = new Size(width, height),
                Padding = multiline ? new Padding(10, 8, 10, 8) : new Padding(10, 8, 10, 4)
            };

            box.BorderStyle = BorderStyle.None;
            box.Font = Theme.Body;
            box.ForeColor = Theme.TextStrong;
            box.Dock = DockStyle.Fill;
            box.MaxLength = maxLength;
            box.Multiline = multiline;

            field.Controls.Add(box);
            Controls.Add(field);
        }

        private void TrySave()
        {
            if (string.IsNullOrWhiteSpace(_txtName.Text))
            {
                Fail("Please enter the supplier name.", _txtName);
                return;
            }

            string phone = _txtPhone.Text.Trim();
            if (phone.Length > 0 && !Regex.IsMatch(phone, @"^[0-9+()\-\s]+$"))
            {
                Fail("Phone can only contain digits, spaces and + ( ) -", _txtPhone);
                return;
            }

            string email = _txtEmail.Text.Trim();
            if (email.Length > 0 && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Fail("Please enter a valid email address.", _txtEmail);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Fail(string message, Control focus)
        {
            _lblError.Text = message;
            focus.Focus();
        }
    }

    internal sealed class SupplierInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public bool SameAs(SupplierInfo other)
        {
            return Same(Name, other.Name) && Same(ContactPerson, other.ContactPerson) &&
                   Same(Phone, other.Phone) && Same(Email, other.Email) && Same(Address, other.Address);
        }

        private static bool Same(string a, string b)
        {
            return string.Equals(a ?? "", b ?? "", StringComparison.Ordinal);
        }
    }
}