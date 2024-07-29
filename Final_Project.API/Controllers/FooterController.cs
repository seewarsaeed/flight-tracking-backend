using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterController : ControllerBase
    {
        private readonly IFooterService footerService;
        public FooterController(IFooterService footerService)
        {
            this.footerService = footerService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public Footer UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Footer item = new Footer();
            item.Logo = fileName;
            return item;
        }

        [HttpGet]
        public List<Footer> GetAllFooter()
        {
            return footerService.GetAllFooter();
        }

        [HttpPost]
        public void CreateFooter(Footer footer)
        {
             footerService.CreateFooter(footer);
        }

        [HttpPut]
        public void UpdateFooter(Footer footer)
        {
             footerService.UpdateFooter(footer);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteFooter(int id)
        {
             footerService.DeleteFooter(id);
        }

        [HttpGet]
        [Route("GetFooterById/{id}")]
        public Footer GetFooterById(int id)
        {
            return footerService.GetFooterById(id);
        }

    }
}
