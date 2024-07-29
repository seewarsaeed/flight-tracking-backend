using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface IPaymentService
    {
        List<Payment> GetAllPayments();

        Payment GetPaymentById(int id);

        void CreatePayment(Payment payment);

        void UpdatePayment(Payment payment);

        void DeletePayment(int id);
    }
}
