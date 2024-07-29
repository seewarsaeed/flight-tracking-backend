using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Testimonial
    {
        public decimal Testimonial_Id { get; set; }
        public string? Name { get; set; }
        public string? Feedback { get; set; }
        public string? Status { get; set; }
        public decimal? User_Id { get; set; }

        public virtual User? User { get; set; }
    }
}
