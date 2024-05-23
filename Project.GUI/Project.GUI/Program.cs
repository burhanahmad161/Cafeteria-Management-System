using Project.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AdminLoginDL.loadAdminData();
            UserLoginDL.loadData();
            GivenRatingDL.loadReview();
            ProductDL.loadItems();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new begin());
        }
    }
}
