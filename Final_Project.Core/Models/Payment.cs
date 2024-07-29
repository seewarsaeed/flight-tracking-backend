using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Payment
    {
        public decimal Payment_Id { get; set; }
        public decimal? Card_Id { get; set; }
        public decimal? User_Id { get; set; }

        public virtual Bank? Card { get; set; }
        public virtual User? User { get; set; }
    }
}
