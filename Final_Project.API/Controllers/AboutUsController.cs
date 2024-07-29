using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            this.aboutUsService = aboutUsService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public Aboutu UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Aboutu item = new Aboutu();
            item.Image_Name = fileName;
            return item;
        }

        [HttpGet]
        public List<Aboutu> GetAllAboutUs()
        {
            return aboutUsService.GetAllAboutUs();
        }

        [HttpPost]
        public void CreateAboutUs(Aboutu aboutUs)
        {
            aboutUsService.CreateAboutUs(aboutUs);
        }

        [HttpPut]
        public void UpdateAboutUs(Aboutu aboutUs)
        {
             aboutUsService.UpdateAboutUs(aboutUs);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteAboutUs(int id)
        {
             aboutUsService.DeleteAboutUs(id);
        }

        [HttpGet]
        [Route("GetAboutUsById/{id}")]
        public Aboutu GetAboutUsById(int id)
        {
            return aboutUsService.GetAboutUsById(id);
        }
    }
}
