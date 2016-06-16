using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using DevExpress.Office.Utils;
using DevExpress.Utils;
using ZOV.Tools;

namespace ZOV.Tools
{
    public partial class frmLogin : Form
    {

        private int _tryAmount = 3;
        private bool _bAllowToClose;
        
        public frmLogin()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillDescriptions()
        {
            var enumType = typeof(ShipControl);


            // I will get all values and iterate through them    
            var enumValues = enumType.GetEnumValues();

            foreach (ShipControl value in enumValues)
            {
                var memInfo = enumType.GetMember(value.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)attributes[0]).Description;

                Security.ValuesAndDescriptions.Add(value, description ?? value.ToString());
            }                
        }

        private void FillComboBox()
        {
            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "dbo.spGetUserListByGroupId";

                comm.Parameters.AddWithValue("@groupId", UserLogon.Properties.Settings.Default.GroupID);
                SqlDataReader dataReader = comm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        comboBoxUsers.Properties.Items.Add(dataReader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("Отсутсвуют пользователи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExitApp();
                }
                if (MyConnectionString.lastUserLogOn != "")
                {
                    if (comboBoxUsers.Properties.Items.Contains(MyConnectionString.lastUserLogOn))
                    {
                        comboBoxUsers.Text = MyConnectionString.lastUserLogOn;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвует подключение к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApp();
            }
            
        }
        private void TryToLogin()
        {
            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
            
            if (textEditPwd.Text.Equals(String.Format("Ghjnjrjk{0}", DateTime.Now.Year.ToString())))
            {
                // Enter master password
                _bAllowToClose = true;
                Close();
                Security.ZOVReminderUsersID = 0;
                Security.UserName = "SuperАдмин";
                Security.IsAdmin = true;

                Security.ShipControl = ShipControl.None;
                foreach (var sc in Enum.GetValues(typeof (ShipControl)))
                {
                    Security.ShipControl = Security.ShipControl | (ShipControl) sc;
                }

                //Security.ShipControl = ShipControl.AdvancePaynemt | ShipControl.Completed | ShipControl.FinalPayment | ShipControl.Invoiced | ShipControl.Paid | ShipControl.Shiped;

                // needed admins rights
                return;
            }
            conn.Open();


            string pwdMD5 = ZOV.Tools.WorkWithHashes.GetHashString(textEditPwd.Text);

//            SqlCommand comm = new SqlCommand(String.Format("SELECT ZOVReminderUsersID, UserName, Permissions, ReadOnly, AdvancePaynemt, Completed, FinalPayment, Invoiced, Paid, Shiped FROM ZOVReminderUsers WHERE (LOWER(UserName)='{0}' AND PasswordMD5='{1}')", comboBoxUsers.Text.ToLower(), pwdMD5), conn);
            SqlCommand comm = new SqlCommand(String.Format("SELECT * FROM ZOVReminderUsers WHERE (LOWER(UserName)='{0}' AND PasswordMD5='{1}')", comboBoxUsers.Text.ToLower(), pwdMD5), conn);

            SqlDataReader dataReader = comm.ExecuteReader();

            if (!dataReader.HasRows)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                --_tryAmount;
                textEditPwd.Text = "";
                if (_tryAmount == 0)
                {
                    ExitApp();
                }
                else
                {
                    return;
                }
            }
            else
            {
                dataReader.Read();

                Security.ZOVReminderUsersID = dataReader.GetInt32(dataReader.GetOrdinal("ZOVReminderUsersID"));
                Security.UserName = dataReader.GetString(dataReader.GetOrdinal("UserName"));
                Security.IsAdmin = false;


                Security.ReadOnly = dataReader["ReadOnly"] == DBNull.Value ? true : dataReader.GetBoolean(dataReader.GetOrdinal("ReadOnly"));

                foreach (var a in Security.ValuesAndDescriptions.Where(a => a.Value != ""))
                {
                    Security.ShipControl = Security.ShipControl | (dataReader[a.Value] == DBNull.Value ? ShipControl.None : dataReader.GetBoolean(dataReader.GetOrdinal(a.Value)) ? a.Key : ShipControl.None);
                }

                dataReader.Close();
            }

            _bAllowToClose = true;
            Close();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitApp();
            //Environment.Exit(0);
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_bAllowToClose)
            {
                ExitApp();
            }
        }

        public void ExitApp()
        {
            Application.Exit();
//            Environment.Exit(0);
        }

        private void textEditPwd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    TryToLogin();
                    break;
                case Keys.Escape:
                    textEditPwd.Text = "";
                    break;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Size.Width, textEditPwd.Size.Height + textEditPwd.Top + 8  + panelControlButtons.Top);
            FillDescriptions();
        }
    }
}
