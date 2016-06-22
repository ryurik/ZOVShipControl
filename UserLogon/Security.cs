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
        public static int ZOVReminderUsersID { get; set; }
        public static string UserName { get; set; }
        public static int Permissions { get; set; }
        public static bool IsAdmin { get; set; }
        public static bool ReadOnly { get; set; }
        public static ShipControl ShipControl { get; set; }

        public static Dictionary<ShipControl, string> ValuesAndDescriptions = new Dictionary<ShipControl, string>();

        public static bool ReadOnlyForShips { get{return ((ShipControl & ShipControl.ROForShips) == ShipControl.ROForShips);} }
    }
}
