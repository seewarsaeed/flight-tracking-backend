using Final_Project.Core.Models;
using Final_Project.Core.Repository;
using Final_Project.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Infra.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        public void CreatePayment(Payment payment)
        {
            paymentRepository.CreatePayment(payment);
        }

        public void DeletePayment(int id)
        {
            paymentRepository.DeletePayment(id);
        }


        public List<Payment> GetAllPayments()
        {
            return paymentRepository.GetAllPayments();
        }

        public Payment GetPaymentById(int id)
        {
            return paymentRepository.GetPaymentById(id);
        }

        public void UpdatePayment(Payment payment)
        {
            paymentRepository.UpdatePayment(payment);
        }
    }
}
