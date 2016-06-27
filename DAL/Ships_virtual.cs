
namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    public partial class ShipsMD5
    {
        public virtual ZOVReminderUsers AdvancePaynemtUser { get; set; }                
    }


    public partial class ShipsMD5EntityFrameWork : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // https://habrahabr.ru/post/174709/
            modelBuilder.Entity<ShipsMD5>().HasRequired(p => p.AdvancePaynemtUser); // Say that AdvancePaynemtUser was Requried for ShipsMD5
            modelBuilder.Entity<ShipsMD5>().HasRequired(p => p.AdvancePaynemtUser).WithMany(b => b.ShipsMD5);
            //modelBuilder.Entity<ZOVReminderUsers>().Map
        }
    }


    public partial class ZOVReminderUsers
    {
        public virtual ICollection<ShipsMD5Detail> ShipsMD5Detail { get; set; }
        public virtual ICollection<ShipsMD5> ShipsMD5 { get; set; }
    }

}
