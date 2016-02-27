﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPMRVPark.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ipmrvparkEntities : DbContext
    {
        public ipmrvparkEntities()
            : base("name=ipmrvparkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<checkinout> checkinouts { get; set; }
        public DbSet<coordinate> coordinates { get; set; }
        public DbSet<countrycode> countrycodes { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<ipmevent> ipmevents { get; set; }
        public DbSet<outofservice> outofservices { get; set; }
        public DbSet<partymember> partymembers { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<paymentmode> paymentmodes { get; set; }
        public DbSet<person> people { get; set; }
        public DbSet<placemarkpolygon> placemarkpolygons { get; set; }
        public DbSet<powersupply> powersupplies { get; set; }
        public DbSet<provincecode> provincecodes { get; set; }
        public DbSet<reservationitem> reservationitems { get; set; }
        public DbSet<reservationitem_partymember> reservationitem_partymember { get; set; }
        public DbSet<reservationorder> reservationorders { get; set; }
        public DbSet<siterate> siterates { get; set; }
        public DbSet<sitesize> sitesizes { get; set; }
        public DbSet<sitetype> sitetypes { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<customer_view> customer_view { get; set; }
        public DbSet<reservation_view> reservation_view { get; set; }
        public DbSet<rvsite_coord_view> rvsite_coord_view { get; set; }
        public DbSet<rvsite_status_view> rvsite_status_view { get; set; }
    }
}