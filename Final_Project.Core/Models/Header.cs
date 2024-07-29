using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Header
    {
        public Header()
        {
            Homes = new HashSet<Home>();
        }

        public decimal Header_Id { get; set; }
        public string? Header_Logo { get; set; }
        public string? Header_Title { get; set; }
        public string? Website_Name { get; set; }

        public virtual ICollection<Home> Homes { get; set; }
    }
}
