using System;
using System.Windows.Forms;

namespace librarydb_app
{
    internal static class Program
    {
        public static LoginForm loginForm;
        public static AdminForm adminForm;
        public static RegularForm regularForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            adminForm = new AdminForm();
            regularForm = new RegularForm();
            Application.Run(loginForm = new LoginForm());
        }
    }
}
