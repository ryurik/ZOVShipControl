﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShipsMD5EntityFrameWork : DbContext
    {
        public ShipsMD5EntityFrameWork()
            : base("name=ShipsMD5EntityFrameWork")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ShipsMD5> ShipsMD5 { get; set; }
        public virtual DbSet<ShipsMD5Detail> ShipsMD5Detail { get; set; }
    }
}
