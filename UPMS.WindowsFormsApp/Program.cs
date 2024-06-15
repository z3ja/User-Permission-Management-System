using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.UI;
using UPMS.WindowsFormsApp.UI.PagesForm;
using UPMS.WindowsFormsApp.UI.PagesForm.PermissionPage;
using UPMS.WindowsFormsApp.UI.PagesForm.RolePage;

namespace UPMS.WindowsFormsApp
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
            Application.Run(new LoginForm());
        }
    }
}
