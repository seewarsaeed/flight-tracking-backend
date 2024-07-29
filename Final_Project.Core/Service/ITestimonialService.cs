using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface ITestimonialService
    {
        List<Testimonial> GetAllTestimonials();

        Testimonial GetTestimonialById(int id);

        void CreateTestimonial(Testimonial testimonial);

        void UpdateTestimonial(Testimonial testimonial);

        void DeleteTestimonial(int id);
    }
}
