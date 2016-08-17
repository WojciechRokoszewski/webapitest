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
    
    public partial class Flights
    {
        public Flights()
        {
            this.FlightSchedules = new HashSet<FlightSchedules>();
        }
    
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public int FrequentFlyerMiles { get; set; }
        public Nullable<int> Source_LocationId { get; set; }
        public Nullable<int> Destination_LocationId { get; set; }
    
        public virtual Locations Locations { get; set; }
        public virtual Locations Locations1 { get; set; }
        public virtual ICollection<FlightSchedules> FlightSchedules { get; set; }
    }
}