//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class address
    {
        public int idAddress { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string provinceCode { get; set; }
        public string postalCode { get; set; }
        public string countryCode { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual countrycode countrycode1 { get; set; }
        public virtual provincecode provincecode1 { get; set; }
    }
}
