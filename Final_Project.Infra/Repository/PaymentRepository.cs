using Final_Project.Core.Common;
using Final_Project.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Final_Project.Core.Models;

namespace Final_Project.Infra.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IDbContext dbContext;
        public PaymentRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreatePayment(Payment payment)
        {
            var p = new DynamicParameters();

            p.Add("UserID", payment.User_Id, dbType: DbType.Int32, ParameterDirection.Input);

            p.Add("CardID", payment.Card_Id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Payment_Package.CreatePayment", p, commandType: CommandType.StoredProcedure);
        }

        public void DeletePayment(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Payment_Package.DeletePayment",p, commandType: CommandType.StoredProcedure);
        }


        public List<Payment> GetAllPayments()
        {
            IEnumerable<Payment> result = dbContext.Connection.Query<Payment>("Payment_Package.GetAllPayments", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Payment GetPaymentById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            IEnumerable<Payment> result = dbContext.Connection.Query<Payment>("Payment_Package.GetPaymentById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdatePayment(Payment payment)
        {
            var p = new DynamicParameters();
            p.Add("ID", payment.Payment_Id, dbType: DbType.Int64, ParameterDirection.Input);

            p.Add("UserID", payment.User_Id, dbType: DbType.Int32, ParameterDirection.Input);

            p.Add("CardID", payment.Card_Id, dbType: DbType.Int32, ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Payment_Package.UpdatePayment", p, commandType: CommandType.StoredProcedure);
        }
    }
}
