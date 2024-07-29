using Final_Project.Core.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Final_Project.Core.Models;
namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundController : ControllerBase
    {
        private readonly IBackgroundService backgroundService;
        public BackgroundController(IBackgroundService backgroundService)
        {
            this.backgroundService = backgroundService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public Background UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Background item = new Background();
            item.Image_Name = fileName;
            return item;
        }
        [HttpGet]
        public List<Background> GetAllBackground()
        {
            return backgroundService.GetAllBackground();
        }
        [HttpPost]
        public void CreateBackground(Background background)
        {
            backgroundService.CreateBackground(background);
        }
        [HttpPut]
        public void UpdateBackground(Background background)
        {
            backgroundService.UpdateBackground(background);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteBackground(int id)
        {
            backgroundService.DeleteBackground(id);
        }
        [HttpGet]
        [Route("GetBackgroundById/{id}")]
        public Background GetBackgroundById(int id)
        {
            return backgroundService.GetBackgroundById(id);
        }
    }
}
