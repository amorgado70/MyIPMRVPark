//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class checkinout
    {
        public long ID { get; set; }
        public long idReservationItem { get; set; }
        public long idRVSite { get; set; }
        public Nullable<System.DateTime> checkInDate { get; set; }
        public Nullable<System.DateTime> checkOutDate { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual placeinmap placeinmap { get; set; }
        public virtual reservationitem reservationitem { get; set; }
    }
}
