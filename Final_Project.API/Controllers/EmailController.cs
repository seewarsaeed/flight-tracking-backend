using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Final_Project.API.Models;
namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("send-email")]
        public IActionResult SendEmail([FromBody] EmailRequest emailRequest)
        {
            // Extract email parameters from the request
            string toEmail = emailRequest.ToEmail;
            string subject = emailRequest.Subject;
            string body = emailRequest.Body;
            byte[] pdfAttachment = emailRequest.PdfAttachment;
            // Send the email
            _emailService.SendEmail(toEmail, subject, body,pdfAttachment);

            return Ok();
        }

    }
}
