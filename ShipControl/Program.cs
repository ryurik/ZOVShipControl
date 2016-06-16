using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);


            ZOV.Tools.MyConnectionString.lastUserLogOn = (Properties.Settings.Default.cs_user);
            ZOV.Tools.MyConnectionString.set_Server(Properties.Settings.Default.ul_Server);
            ZOV.Tools.MyConnectionString.set_InitialCatalog(Properties.Settings.Default.ul_Catalog);
            Application.Run(new ZOV.Tools.frmLogin());



            Properties.Settings.Default.cs_user = ZOV.Tools.Security.UserName;
            Properties.Settings.Default.Save();


            Application.Run(new MainForm());
        }
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show(e.Message, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Trace.WriteLine(String.Format("Runtime terminating: {0}", args.IsTerminating));
        }
    }
}
