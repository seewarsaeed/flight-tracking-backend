using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.DTO
{
    public class Report
    {
        public string? UserName { get; set; }
        public string? DepartureAirportName { get; set; }
        public string? DepartureLocation { get; set; }
        public string? ArrivalAirportName { get; set; }
        public string? ArrivalLocation { get; set; }
        public string? FlightName { get; set; }
        public float? Price { get; set; }
        public decimal? NumberOfEmptySeats { get; set; }
        public decimal? NumberOfReservedSeats { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public float? AdditionalCost { get; set; }
        public decimal? NumberOfSeats { get; set; }
        public string? PaidStatus { get; set; }

    }
}
