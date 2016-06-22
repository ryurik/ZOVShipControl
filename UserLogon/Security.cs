using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using UserLogon;

namespace ZOV.Tools
{
    public static class Security
    {
        private static bool isAdmin;
        public static int ZOVReminderUsersID { get; set; }
        public static string UserName { get; set; }
        public static int Permissions { get; set; }

        public static bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
                if (!value) return;
                foreach (var sc in Enum.GetValues(typeof(ShipControl)))
                {
                    if ((ShipControl)sc != ShipControl.ROForShips)
                        ShipControl = ShipControl | (ShipControl)sc;
                }
            }
        }

        public static bool ReadOnly { get; set; }
        public static ShipControl ShipControl { get; set; }

        public static Dictionary<ShipControl, string[]> ValuesAndDescriptions = new Dictionary<ShipControl, string[]>();

        public static bool ReadOnlyForShips { get{return (((ShipControl & ShipControl.ROForShips) == ShipControl.ROForShips) && !IsAdmin);} }
    }
}
