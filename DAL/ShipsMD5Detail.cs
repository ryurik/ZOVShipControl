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
    
    public partial class ShipsMD5Detail
    {
        public int ShipsMD5DetailID { get; set; }
        public Nullable<int> ShipsMD5ID { get; set; }
        public string ShipNumber { get; set; }
        public string Customer { get; set; }
        public string LegalName { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string FilePath { get; set; }
        public bool AdvancePaynemt { get; set; }
        public bool Completed { get; set; }
        public bool FinalPayment { get; set; }
        public bool Invoiced { get; set; }
        public bool Paid { get; set; }
        public bool Shiped { get; set; }
    
        public virtual ShipsMD5 ShipsMD5 { get; set; }
    }
}