using System;
using System.ComponentModel;

namespace ZOV.Tools
{
    [Flags]
    public enum ShipControl
    {
        [Description("")]
        None = 0,
        [Description("AdvancePaynemt")]
        AdvancePaynemt = 1 << 0,
        [Description("Completed")]
        Completed = 1 << 1,
        [Description("FinalPayment")]
        FinalPayment = 1 << 2,
        [Description("Invoiced")]
        Invoiced = 1 << 3,
        [Description("Paid")]
        Paid = 1 << 4,
        [Description("Shiped")]
        Shiped = 1 << 5,
        [Description("ROForShips")]
        ROForShips = 1 << 5
    }

}