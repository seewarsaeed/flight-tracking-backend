using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Contactu
    {
        public Contactu()
        {
            Homes = new HashSet<Home>();
        }

        public decimal ContactUsId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
