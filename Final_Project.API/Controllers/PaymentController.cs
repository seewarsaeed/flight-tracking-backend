using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        [HttpGet]
        public List<Payment> GetAllPayments()
        {
            return paymentService.GetAllPayments();
        }
        [HttpPost]
        public void CreatePayment(Payment payment)
        {
            paymentService.CreatePayment(payment);
        }
        [HttpPut]
        public void UpdatePayment(Payment payment)
        {
            paymentService.UpdatePayment(payment);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeletePayment(int id)
        {
            paymentService.DeletePayment(id);
        }
        [HttpGet]
        [Route("GetPaymentById/{id}")]
        public Payment GetPaymentById(int id)
        {
            return paymentService.GetPaymentById(id);
        }
    }
}
