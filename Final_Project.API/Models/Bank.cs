using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Payments = new HashSet<Payment>();
        }

        public decimal CardId { get; set; }
        public string? Cvv { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal? Balance { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
