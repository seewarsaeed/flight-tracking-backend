using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Reservedflights = new HashSet<Reservedflight>();
        }

        public decimal Flight_Id { get; set; }
        public string? Flight_Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Numberofemptyseats { get; set; }
        public decimal? Numberofreservedseats { get; set; }
        public DateTime? Departure_Datetime { get; set; }
        public DateTime? Arrival_Datetime { get; set; }
        public string? Arrival_Status { get; set; }
        public decimal? Additionalcost { get; set; }
        public string? Image_Name { get; set; }
        public decimal? Departure_Airport_Id { get; set; }
        public decimal? Arrival_Airport_Id { get; set; }

        public virtual Airport? ArrivalAirport { get; set; }
        public virtual Airport? DepartureAirport { get; set; }
        public virtual ICollection<Reservedflight> Reservedflights { get; set; }
    }
}
