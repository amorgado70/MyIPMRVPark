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
    
    public partial class sitetype
    {
        public sitetype()
        {
            this.siterates = new HashSet<siterate>();
        }
    
        public string idSiteType { get; set; }
        public int idSiteSize { get; set; }
        public int idPowerSupply { get; set; }
        public Nullable<bool> isUnserviced { get; set; }
        public Nullable<bool> isForHandicapped { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual powersupply powersupply { get; set; }
        public virtual ICollection<siterate> siterates { get; set; }
        public virtual sitesize sitesize { get; set; }
    }
}
