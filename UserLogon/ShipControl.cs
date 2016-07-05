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
        [Description("AdvancePayment"), Category("ShowField")]
        AdvancePayment = 1 << 0,
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


    [Flags]
    public enum ShipControlDetails
    {
        [Description("ReadOnly"), Category("DontShowField")]
        ShipsMD5DetailID = 0,
        [Description("ReadOnly"), Category("ShowField")]
        ShipsMD5ID = 1 << 0,
        [Description("ReadOnly"), Category("ShowField")]
        ShipNumber = 1 << 1,
        [Description("Editable"), Category("ShowField")]
        Customer = 1 << 2,
        [Description("ReadOnly"), Category("ShowField")]
        LegalName = 1 << 3,
        [Description("ReadOnly"), Category("ShowField")]
        ShipDate = 1 << 4,
        [Description("ReadOnly"), Category("ShowField")]
        FilePath = 1 << 5,
        [Description("Editable"), Category("ShowField")]
        AdvancePayment = 1 << 6,
        [Description("Editable"), Category("ShowField")]
        Completed = 1 << 7,
        [Description("Editable"), Category("ShowField")]
        FinalPayment = 1 << 8,
        [Description("Editable"), Category("ShowField")]
        Invoiced = 1 << 9,
        [Description("Editable"), Category("ShowField")]
        Paid = 1 << 10,
        [Description("Editable"), Category("ShowField")]
        Shiped = 1 << 11,
        [Description("ReadOnly"), Category("DontShowField")]
        AddTime = 1 << 12,
        [Description("ReadOnly"), Category("DontShowField")]
        AdvancePaymentDate = 1 << 13,
        [Description("ReadOnly"), Category("DontShowField")]
        AdvancePaymentUserID = 1 << 14,
        [Description("ReadOnly"), Category("DontShowField")]
        CompletedDate = 1 << 15,
        [Description("ReadOnly"), Category("DontShowField")]
        CompletedUserID = 1 << 16,
        [Description("ReadOnly"), Category("DontShowField")]
        FinalPaymentDate = 1 << 17,
        [Description("ReadOnly"), Category("DontShowField")]
        FinalPaymentUserID = 1 << 18,
        [Description("ReadOnly"), Category("DontShowField")]
        InvoicedDate = 1 << 19,
        [Description("ReadOnly"), Category("DontShowField")]
        InvoicedUserID = 1 << 20,
        [Description("ReadOnly"), Category("DontShowField")]
        PaidDate = 1 << 21,
        [Description("ReadOnly"), Category("DontShowField")]
        PaidUserID = 1 << 22,
        [Description("ReadOnly"), Category("DontShowField")]
        ShipedUserID = 1 << 23,
        [Description("ReadOnly"), Category("DontShowField")]
        ShipsMD5 = 1 << 24,
    }

}