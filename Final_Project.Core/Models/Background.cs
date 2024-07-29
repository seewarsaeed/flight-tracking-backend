using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Background
    {
        public Background()
        {
            Homes = new HashSet<Home>();
        }

        public decimal Background_Id { get; set; }
        public string? Image_Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
