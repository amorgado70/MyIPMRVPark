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
    
    public partial class payment_view
    {
        public long id { get; set; }
        public decimal selectionTotal { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public string reasonforpayment { get; set; }
        public string sites { get; set; }
        public long idCustomer { get; set; }
        public string fullName { get; set; }
        public string mainPhone { get; set; }
    }
}
