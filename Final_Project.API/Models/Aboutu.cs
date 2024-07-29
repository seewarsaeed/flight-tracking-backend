using System;
using System.Collections.Generic;

namespace Final_Project.API.Models
{
    public partial class Aboutu
    {
        public Aboutu()
        {
            Homes = new HashSet<Home>();
        }

        public decimal About_Us_Id { get; set; }
        public string? Image_Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
