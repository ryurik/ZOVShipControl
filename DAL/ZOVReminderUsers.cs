//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZOVReminderUsers
    {
        public int ZOVReminderUsersID { get; set; }
        public string UserName { get; set; }
        public string PasswordMD5 { get; set; }
        public Nullable<int> Permissions { get; set; }
        public Nullable<System.DateTime> UserNameChange { get; set; }
        public Nullable<System.DateTime> PasswordChange { get; set; }
        public Nullable<System.DateTime> PermissionsChange { get; set; }
        public Nullable<System.DateTime> UserCreated { get; set; }
        public Nullable<System.DateTime> LastLogon { get; set; }
        public Nullable<System.DateTime> LastLogOff { get; set; }
        public Nullable<System.DateTime> LastEditTime { get; set; }
        public Nullable<bool> SendToAll { get; set; }
        public Nullable<bool> ReadOnly { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public bool AdvancePayment { get; set; }
        public bool Completed { get; set; }
        public bool FinalPayment { get; set; }
        public bool Invoiced { get; set; }
        public bool Paid { get; set; }
        public bool Shiped { get; set; }
        public bool ROForShips { get; set; }
    }
}
