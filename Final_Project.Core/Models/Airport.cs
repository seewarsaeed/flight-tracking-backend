using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Airport
    {
        public Airport()
        {
            FlightArrivalAirports = new HashSet<Flight>();
            FlightDepartureAirports = new HashSet<Flight>();
        }

        public decimal Airport_Id { get; set; }
        public string? Airport_Name { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Flight> FlightArrivalAirports { get; set; }
        public virtual ICollection<Flight> FlightDepartureAirports { get; set; }
    }
}
