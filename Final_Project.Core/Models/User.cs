using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class User
    {
        public User()
        {
            Homes = new HashSet<Home>();
            Payments = new HashSet<Payment>();
            Reservedflights = new HashSet<Reservedflight>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal User_Id { get; set; }
        public string? User_Name { get; set; }
        public string? Password { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Image_Name { get; set; }
        public string? Email { get; set; }
        public decimal? Role_Id { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Home> Homes { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Reservedflight> Reservedflights { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
