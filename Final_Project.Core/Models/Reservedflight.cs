using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Reservedflight
    {
        public decimal Reserved_Flights_Id { get; set; }
        public DateTime? Reservation_Date { get; set; }
        public string? Paid_Status { get; set; }
        public string? Email_Status { get; set; }
        public decimal? Numberofseats { get; set; }
        public decimal? Flight_Id { get; set; }
        public decimal? User_Id { get; set; }

        public virtual Flight? Flight { get; set; }
        public virtual User? User { get; set; }
    }
}
