using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Airport
    {
        public Airport()
        {
            FlightArrivalAirports = new HashSet<Flight>();
            FlightDepartureAirports = new HashSet<Flight>();
        }

        public decimal AirportId { get; set; }
        public string? AirportName { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Flight> FlightArrivalAirports { get; set; }
        public virtual ICollection<Flight> FlightDepartureAirports { get; set; }
    }
}
