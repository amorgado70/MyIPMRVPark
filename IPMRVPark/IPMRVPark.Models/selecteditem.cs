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
    
    public partial class selecteditem
    {
        public long ID { get; set; }
        public long idSession { get; set; }
        public Nullable<long> idIPMEvent { get; set; }
        public Nullable<long> idRVSite { get; set; }
        public Nullable<long> idCustomer { get; set; }
        public Nullable<long> idStaff { get; set; }
        public bool isSiteChecked { get; set; }
        public System.DateTime checkInDate { get; set; }
        public System.DateTime checkOutDate { get; set; }
        public Nullable<long> idReservationItem { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ipmevent ipmevent { get; set; }
        public virtual placeinmap placeinmap { get; set; }
        public virtual reservationitem reservationitem { get; set; }
        public virtual session session { get; set; }
        public virtual staff staff { get; set; }
    }
}
