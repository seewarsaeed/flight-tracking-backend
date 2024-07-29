using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }

        [HttpGet]
        public List<Testimonial> GetAllTestimonials()
        {
            return testimonialService.GetAllTestimonials();
        }

        [HttpGet]
        [Route("GetTestimonialById/{id}")]
        public Testimonial GetTestimonialById(int id)
        {
            return testimonialService.GetTestimonialById(id);
        }

        [HttpPost]
        public void CreateTestimonial(Testimonial testimonial)
        {
             testimonialService.CreateTestimonial(testimonial);
        }

        [HttpPut]
        public void UpdateTestimonial(Testimonial testimonial)
        {
             testimonialService.UpdateTestimonial(testimonial);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteTestimonial(int id)
        {
             testimonialService.DeleteTestimonial(id);
        }
    }
}
