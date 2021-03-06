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
    
    public partial class ipmevent
    {
        public ipmevent()
        {
            this.coordinates = new HashSet<coordinate>();
            this.fees = new HashSet<fee>();
            this.placeinmaps = new HashSet<placeinmap>();
            this.selecteditems = new HashSet<selecteditem>();
            this.sessions = new HashSet<session>();
            this.siterates = new HashSet<siterate>();
            this.sitetypes = new HashSet<sitetype>();
            this.styleurls = new HashSet<styleurl>();
        }
    
        public long ID { get; set; }
        public long year { get; set; }
        public string local { get; set; }
        public string description { get; set; }
        public string mapFileUrl { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string provinceCode { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public Nullable<System.DateTime> lastDateRefund { get; set; }
    
        public virtual ICollection<coordinate> coordinates { get; set; }
        public virtual ICollection<fee> fees { get; set; }
        public virtual ICollection<placeinmap> placeinmaps { get; set; }
        public virtual ICollection<selecteditem> selecteditems { get; set; }
        public virtual ICollection<session> sessions { get; set; }
        public virtual ICollection<siterate> siterates { get; set; }
        public virtual ICollection<sitetype> sitetypes { get; set; }
        public virtual ICollection<styleurl> styleurls { get; set; }
    }
}
