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
    public partial class frmMainform : Form
    {
        private string currentUser = string.Empty;
        private string currentAccId = string.Empty;
        private string currentRole = string.Empty;
        public frmMainform()
        {
            InitializeComponent();
            ToolStripItem dashboardButton = SafeUi.FindItem(this, "btnDashboard");
            if (dashboardButton != null) dashboardButton.Click += (s, e) => OpenChildForm(new frmDashboard());
            manageStockToolStripMenuItem.Click += (s, e) => OpenChildForm(new frmManageStock(currentAccId));
            damagedProductToolStripMenuItem.Click += (s, e) => OpenChildForm(new frmDamagedProduct(currentAccId));
            manageReportsToolStripMenuItem.Click += (s, e) => OpenChildForm(new frmManageReports());
        }


        public frmMainform(string username) : this()
        {
            currentUser = username ?? string.Empty;
        }


        public frmMainform(string username, string accId, string role) : this(username)
        {
            currentAccId = accId ?? string.Empty;
            currentRole = role ?? string.Empty;

            accid.Text = currentAccId;
            accname.Text = currentUser;

        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            SafeUi.SetText(this, "lblClock", DateTime.Now.ToLongTimeString());
            SafeUi.SetText(this, "lblDate", DateTime.Now.ToLongDateString());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log Out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var loginForm = new loiginfrm();
                loginForm.Show();
                this.Hide();
            }


        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }


        private void systemAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var acc = new frmaccount(currentAccId, currentRole);
            OpenChildForm(acc);


        }
        private List<Form> _openChildForm = new List<Form>();

        private void OpenChildForm(Form childForm)
        {

            foreach (Control control in pnlContent.Controls.OfType<Form>().ToList())
            {
                control.Dispose();
            }

            pnlContent.Controls.Clear();
            _openChildForm.Clear();


            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;


            pnlContent.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();

            _openChildForm.Add(childForm);
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            var pos = new frmPOS(currentAccId);
            OpenChildForm(pos);
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manprod = new frmmanageproduct(currentAccId);
            OpenChildForm(manprod);

        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageSupplier());
        }

        private void expiredProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exp = new frmExpiredProducts();
            OpenChildForm(exp);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Form child in _openChildForm.ToList())
            {
                child.Dispose();
            }

            pnlContent.Controls.Clear();
            _openChildForm.Clear();

            pnlContent.Visible = true;
            pnlContent.BringToFront();
        }
    }
}