namespace Final_Project.API.Models
{
    public class EmailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public byte[] PdfAttachment { get; set; }
    }
}
