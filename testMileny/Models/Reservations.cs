//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testMileny.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservations
    {
        public int ReservationId { get; set; }
        public int TravelerId { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public string ConfirmationCode { get; set; }
        public int DepartFlightScheduleID { get; set; }
        public Nullable<int> ReturnFlightScheduleID { get; set; }
    
        public virtual Trips Trips { get; set; }
        public virtual Trips Trips1 { get; set; }
    }
}