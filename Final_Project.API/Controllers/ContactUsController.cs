using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }

        [HttpGet]
        public List<Contactu> GetAllContactUs()
        {
            return contactUsService.GetAllContactUs();
        }

        [HttpPost]
        public void CreateContactUs(Contactu contactUs)
        {
             contactUsService.CreateContactUs(contactUs);
        }

        [HttpPut]
        public void UpdateContactUs(Contactu contactUs)
        {
             contactUsService.UpdateContactUs(contactUs);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteContactUs(int id)
        {
             contactUsService.DeleteContactUs(id);
        }

        [HttpGet]
        [Route("GetContactUsById/{id}")]
        public Contactu GetContactUsById(int id)
        {
            return contactUsService.GetContactUsById(id);
        }
    }
}
