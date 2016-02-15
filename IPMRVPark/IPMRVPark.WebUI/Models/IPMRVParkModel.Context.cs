﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPMRVPark.WebUI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ipmrvparkDbContext : DbContext
    {
        public ipmrvparkDbContext()
            : base("name=ipmrvparkDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<address> addresses { get; set; }
        public DbSet<checkinout> checkinouts { get; set; }
        public DbSet<coordinate> coordinates { get; set; }
        public DbSet<countrycode> countrycodes { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<member> members { get; set; }
        public DbSet<outofservice> outofservices { get; set; }
        public DbSet<party> parties { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<paymentmode> paymentmodes { get; set; }
        public DbSet<person> people { get; set; }
        public DbSet<placemarkpolygon> placemarkpolygons { get; set; }
        public DbSet<powersupply> powersupplies { get; set; }
        public DbSet<provincecode> provincecodes { get; set; }
        public DbSet<reservationeach> reservationeaches { get; set; }
        public DbSet<reservationgroup> reservationgroups { get; set; }
        public DbSet<rvsite> rvsites { get; set; }
        public DbSet<siterate> siterates { get; set; }
        public DbSet<sitesize> sitesizes { get; set; }
        public DbSet<sitetype> sitetypes { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<styleurl> styleurls { get; set; }
        public DbSet<tempcountry> tempcountries { get; set; }
        public DbSet<tempperson> temppersons { get; set; }
        public DbSet<temppersonorig> temppersonorigs { get; set; }
        public DbSet<tempprovince> tempprovinces { get; set; }
        public DbSet<temprvsite> temprvsites { get; set; }
        public DbSet<tempstyleurl> tempstyleurls { get; set; }
        public DbSet<customer_view> customer_view { get; set; }
        public DbSet<rvsite_coord_view> rvsite_coord_view { get; set; }
    }
}
