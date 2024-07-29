using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Footer
    {
        public Footer()
        {
            Homes = new HashSet<Home>();
        }

        public decimal Footer_Id { get; set; }
        public string? Logo { get; set; }
        public string? Brief { get; set; }
        public string? Location { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Linkstitle { get; set; }
        public string? Copyright { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
