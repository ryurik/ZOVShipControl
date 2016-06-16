using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipControl.Forms;
using ZOV.Tools;

namespace ShipControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Security.IsAdmin)
                OpenChildForms(typeof(ShipsMD5Form), "Контроль отгрузок");
        }

        private void menuToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }
        public void ExitApp()
        {
            Environment.Exit(0);
        }

        private void menuToolStripMenuItemShipsControl_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(ShipsMD5Form), "Контроль отгрузок");
        }


        private void OpenChildForms(Type frmType, String caption, FormWindowState formWindowState = FormWindowState.Minimized)
        {
            if (findWindow(frmType, caption) != null)
            {
                return;
            }

            Type[] types = new Type[0];
            //types[0] = typeof(int);
            //types[0] = null;
            // Get the public instance constructor that takes NO Paramters - default constructor (an integer parameter).
            ConstructorInfo constructorInfoObj = frmType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public, null,
                CallingConventions.HasThis, types, null);
            if (constructorInfoObj != null)
            {
                object[] i = new object[0];
                var f = constructorInfoObj.Invoke(i);
                if (f is Form)
                {
                    (f as Form).MdiParent = this;
                    if (formWindowState != FormWindowState.Minimized)
                    {
                        (f as Form).WindowState = formWindowState;
                    }
                    (f as Form).Text = caption;
                    (f as Form).Show();
                }
            }

        }

        private object findWindow(Type frmType, string caption, bool bringToFront = true)
        {
            foreach (Form c in MdiChildren)
            {
                if ((c.GetType() == frmType) && (c.Text.ToLower().Equals(caption.ToLower())))
                {
                    if (bringToFront)
                    {
                        c.BringToFront();
                    }
                    return c;
                }
            }
            return null;
        }

        private void ShowInfo()
        {

            StringBuilder sb = new StringBuilder();
            foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value != ""))
            {
                if ((Security.ShipControl & a.Key) == a.Key)
                {
                    sb.Append(a);
                    sb.AppendLine();
                }
            }

            MessageBox.Show(String.Format("{0}", sb), "Контроль отгрузок", MessageBoxButtons.OK);
        }

        private void menuItemToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            //throw new Exception("1");
            ShowInfo();
        }

    }
}
