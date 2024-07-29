using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        private readonly IHeaderService headerService;
        public HeaderController(IHeaderService headerService)
        {
            this.headerService = headerService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public Header UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Header item = new Header();
            item.Header_Logo = fileName;
            return item;
        }


        [HttpGet]
        public List<Header> GetAllHeader()
        {
            return headerService.GetAllHeader();
        }

        [HttpGet]
        [Route("GetHeaderById/{id}")]
        public Header GetHeaderById(int id)
        {
            return headerService.GetHeaderById(id);
        }

        [HttpPost]
        public void CreateHeader(Header header)
        {
             headerService.CreateHeader(header);
        }

        [HttpPut]
        public void UpdateHeader(Header header)
        {
             headerService.UpdateHeader(header);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteHeader(int id)
        {
             headerService.DeleteHeader(id);
        }
    }
}
