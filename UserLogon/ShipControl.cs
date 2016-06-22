using System;
using System.ComponentModel;

namespace ZOV.Tools
{
    public enum ShipControlField
    {
        DontShowField,
        ShowField
    }



[Flags]
    public enum ShipControl
    {
        [Description(""), Category("DontShowField")]
        None = 0,
        [Description("AdvancePaynemt"), Category("ShowField")]
        AdvancePaynemt = 1 << 0,
        [Description("Completed"), Category("ShowField")]
        Completed = 1 << 1,
        [Description("FinalPayment"), Category("ShowField")]
        FinalPayment = 1 << 2,
        [Description("Invoiced"), Category("ShowField")]
        Invoiced = 1 << 3,
        [Description("Paid"), Category("ShowField")]
        Paid = 1 << 4,
        [Description("Shiped"), Category("ShowField")]
        Shiped = 1 << 5,
        [Description("ROForShips"), Category("DontShowField")]
        ROForShips = 1 << 6
    }

}