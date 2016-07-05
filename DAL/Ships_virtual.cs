
namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    public partial class ShipsMD5
    {
        //public virtual ZOVReminderUsers AdvancePaymentUser { get; set; }                
    }

    public partial class ShipsMD5Detail
    {
        //public virtual ZOVReminderUsers AdvancePaymentUser { get; set; }
        //public virtual ZOVReminderUsers CompletedUser { get; set; }
    }


    public partial class ZOVReminderUsers
    {
        //public virtual ICollection<ShipsMD5Detail> ShipsMD5Detail { get; set; }
        //public virtual ICollection<ShipsMD5> ShipsMD5 { get; set; }
    }

    public partial class ShipsMD5EntityFrameWork : DbContext
    {

    }


}
