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
    
    public partial class Locations
    {
        public Locations()
        {
            this.Flights = new HashSet<Flights>();
            this.Flights1 = new HashSet<Flights>();
        }
    
        public int LocationId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string ThumbnailImageFile { get; set; }
        public string TimeZoneId { get; set; }
    
        public virtual ICollection<Flights> Flights { get; set; }
        public virtual ICollection<Flights> Flights1 { get; set; }
    }
}
