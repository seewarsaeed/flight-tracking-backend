using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Contactu
    {
        public Contactu()
        {
            Homes = new HashSet<Home>();
        }

        public decimal Contact_Us_Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
