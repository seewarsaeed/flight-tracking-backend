using Microsoft.Extensions.Configuration;
using MimeKit;
using MailKit.Net.Smtp;
using Final_Project.Core.Service;

namespace Final_Project.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string toEmail, string subject, string body, byte[] attachment)
        {
            var emailSettings = _configuration.GetSection("MailSettings");
            var host = emailSettings["Host"];
            var port = int.Parse(emailSettings["Port"]);
            var userName = emailSettings["UserName"];
            var password = emailSettings["Password"];
            var fromEmail = emailSettings["SenderEmail"];
            var fromName = emailSettings["SenderName"];

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(fromName, fromEmail));
            message.To.Add(new MailboxAddress("", toEmail)); 
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };

            var attachmentPart = new MimePart("application", "pdf")
            {
                Content = new MimeContent(new MemoryStream(attachment)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = "invoice.pdf"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(attachmentPart);
            message.Body = multipart;


            using (var client = new SmtpClient())
            {
                client.Connect(host, port);
                client.Authenticate(userName, password);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
