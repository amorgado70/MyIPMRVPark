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
        public int idCheckInOut { get; set; }
        public int idReservationGroup { get; set; }
        public int idReservationEach { get; set; }
        public string idRVSite { get; set; }
        public Nullable<System.DateTime> arrivalDate { get; set; }
        public Nullable<System.DateTime> departureDate { get; set; }
    
        public virtual reservationeach reservationeach { get; set; }
        public virtual rvsite rvsite { get; set; }
    }
}
