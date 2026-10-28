using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    // Writes diagnostic details to a log file next to the app.
    // Logging must never throw, so every step is guarded.
    public static class ErrorLogger
    {
        private static readonly object _lock = new object();

        public static string LogFolder
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs"); }
        }

        public static string LogFilePath
        {
            get { return Path.Combine(LogFolder, "error-" + DateTime.Now.ToString("yyyy-MM-dd") + ".log"); }
        }

        public static void Log(Exception ex, string context)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + (context ?? "(no context)"));
                sb.AppendLine(ex == null ? "(no exception)" : ex.ToString());
                sb.AppendLine(new string('-', 70));

                lock (_lock)
                {
                    Directory.CreateDirectory(LogFolder);
                    File.AppendAllText(LogFilePath, sb.ToString(), Encoding.UTF8);
                }
            }
            catch
            {
                // Last resort: never let logging crash the app.
            }
        }

        // Logs the error and shows a safe, short message to the user.
        public static void LogAndShow(Exception ex, string context, string userMessage, string caption)
        {
            Log(ex, context);
            try
            {
                MessageBox.Show(
                    userMessage + "\r\n\r\nThe problem was recorded in the error log.",
                    caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // Ignore UI failures while reporting.
            }
        }

        // Application-level safety net. Call once at startup.
        public static void RegisterGlobalHandlers()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (s, e) =>
                LogAndShow(e.Exception, "Application.ThreadException",
                    "An unexpected error occurred. Your last action may not have completed.",
                    "Unexpected Error");

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                Log(ex, "AppDomain.UnhandledException (terminating=" + e.IsTerminating + ")");
                if (e.IsTerminating)
                {
                    try
                    {
                        MessageBox.Show(
                            "A fatal error occurred and the application must close.\r\n\r\nDetails were saved to:\r\n" + LogFilePath,
                            "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch { }
                }
            };

            System.Threading.Tasks.TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                Log(e.Exception, "TaskScheduler.UnobservedTaskException");
                e.SetObserved();
            };
        }
    }
}
