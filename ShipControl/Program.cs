using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ZOV.Tools.MyConnectionString.lastUserLogOn = (Properties.Settings.Default.cs_user);
            ZOV.Tools.MyConnectionString.set_Server(Properties.Settings.Default.ul_Server);
            ZOV.Tools.MyConnectionString.set_InitialCatalog(Properties.Settings.Default.ul_Catalog);
            Application.Run(new ZOV.Tools.frmLogin());



            Properties.Settings.Default.cs_user = ZOV.Tools.Security.UserName;
            Properties.Settings.Default.Save();

            Application.Run(new MainForm());
        }
    }
}
