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
    
    public partial class reservationgroup
    {
        public reservationgroup()
        {
            this.reservationeaches = new HashSet<reservationeach>();
        }
    
        public int idReservationGroup { get; set; }
        public int idCustomer { get; set; }
        public int idStaff { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<int> idPayment { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual payment payment { get; set; }
        public virtual ICollection<reservationeach> reservationeaches { get; set; }
        public virtual staff staff { get; set; }
    }
}
