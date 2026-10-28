using System;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    /// <summary>
    /// Reusable custom confirmation dialog to replace MessageBox.Show for Yes/No prompts.
    /// Usage:
    ///   using (var dlg = new frmConfirmDialog("Confirm Delete", "Are you sure?"))
    ///   {
    ///       if (dlg.ShowDialog() == DialogResult.Yes) { ... }
    ///   }
    /// </summary>
    public partial class frmConfirmDialog : Form
    {
        public frmConfirmDialog(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            SafeUi.SetText(this, "lblTitle", title);
            SafeUi.SetText(this, "lblMessage", message);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
