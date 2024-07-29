using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Reservedflights = new HashSet<Reservedflight>();
        }

        public decimal FlightId { get; set; }
        public string? FlightName { get; set; }
        public decimal? Price { get; set; }
        public decimal? Numberofemptyseats { get; set; }
        public decimal? Numberofreservedseats { get; set; }
        public DateTime? DepartureDatetime { get; set; }
        public DateTime? ArrivalDatetime { get; set; }
        public string? Arrival_Status { get; set; }
        public decimal? Additionalcost { get; set; }
        public string? ImageName { get; set; }
        public decimal? DepartureAirportId { get; set; }
        public decimal? ArrivalAirportId { get; set; }

        public virtual Airport? ArrivalAirport { get; set; }
        public virtual Airport? DepartureAirport { get; set; }
        public virtual ICollection<Reservedflight> Reservedflights { get; set; }
    }
}
