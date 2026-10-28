using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Last-resort safety net: log unexpected errors instead of crashing silently.
            ErrorLogger.RegisterGlobalHandlers();

            try
            {
                Application.Run(new loiginfrm());
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex, "Program.Main");
                MessageBox.Show(
                    "The application hit a fatal error and must close.\r\n\r\nDetails were saved to:\r\n" + ErrorLogger.LogFilePath,
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
