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
            this.placeinmaps = new HashSet<placeinmap>();
            this.siterates = new HashSet<siterate>();
        }
    
        public long ID { get; set; }
        public long idIPMEvent { get; set; }
        public long idSiteSize { get; set; }
        public long idService { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public Nullable<long> idStyleUrl { get; set; }
    
        public virtual ipmevent ipmevent { get; set; }
        public virtual ICollection<placeinmap> placeinmaps { get; set; }
        public virtual service service { get; set; }
        public virtual ICollection<siterate> siterates { get; set; }
        public virtual sitesize sitesize { get; set; }
        public virtual styleurl styleurl { get; set; }
    }
}
