using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Payments = new HashSet<Payment>();
        }

        public decimal Card_Id { get; set; }
        public string? Cvv { get; set; }
        public DateTime? Expire_Date { get; set; }
        public decimal? Balance { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
