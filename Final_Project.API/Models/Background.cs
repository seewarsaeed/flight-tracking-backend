using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Background
    {
        public Background()
        {
            Homes = new HashSet<Home>();
        }

        public decimal BackgroundId { get; set; }
        public string? ImageName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
