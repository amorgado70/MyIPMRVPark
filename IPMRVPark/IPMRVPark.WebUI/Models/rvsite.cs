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
    
    public partial class rvsite
    {
        public rvsite()
        {
            this.checkinouts = new HashSet<checkinout>();
            this.outofservices = new HashSet<outofservice>();
            this.reservationeaches = new HashSet<reservationeach>();
        }
    
        public string idRVSite { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual ICollection<checkinout> checkinouts { get; set; }
        public virtual ICollection<outofservice> outofservices { get; set; }
        public virtual placemarkpolygon placemarkpolygon { get; set; }
        public virtual ICollection<reservationeach> reservationeaches { get; set; }
    }
}