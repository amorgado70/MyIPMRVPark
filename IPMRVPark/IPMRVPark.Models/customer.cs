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
    
    public partial class customer
    {
        public customer()
        {
            this.reservationorders = new HashSet<reservationorder>();
        }
    
        public int idCustomer { get; set; }
        public string cellPhone { get; set; }
        public string homePhone { get; set; }
        public string faxNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string provinceCode { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual countrycode countrycode1 { get; set; }
        public virtual person person { get; set; }
        public virtual provincecode provincecode1 { get; set; }
        public virtual ICollection<reservationorder> reservationorders { get; set; }
    }
}
