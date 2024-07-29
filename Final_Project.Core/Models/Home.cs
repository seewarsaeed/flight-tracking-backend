using System;
using System.Collections.Generic;

namespace Final_Project.Core.Models
{
    public partial class Home
    {
        public decimal HomeId { get; set; }
        public decimal? HeaderId { get; set; }
        public decimal? AboutUsId { get; set; }
        public decimal? ContactUsId { get; set; }
        public decimal? FooterId { get; set; }
        public decimal? AdminUserId { get; set; }
        public decimal? BackgroundId { get; set; }

        public virtual Aboutu? AboutUs { get; set; }
        public virtual User? AdminUser { get; set; }
        public virtual Background? Background { get; set; }
        public virtual Contactu? ContactUs { get; set; }
        public virtual Footer? Footer { get; set; }
        public virtual Header? Header { get; set; }
    }
}
