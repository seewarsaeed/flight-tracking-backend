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
    public class BankRepository : IBankRepository
    {
        private readonly IDbContext dbContext;
        public BankRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateBank(Bank bank)
        {
            var p = new DynamicParameters();

            p.Add("card_CVV", bank.Cvv, dbType: DbType.String, ParameterDirection.Input);

            p.Add("Expire_Date", bank.Expire_Date, dbType: DbType.Date, ParameterDirection.Input);

            p.Add("Card_Balance ", bank.Balance, dbType: DbType.Double, ParameterDirection.Input);

            p.Add("status ", bank.Status, dbType: DbType.String, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Bank_Package.CreateBank", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteBank(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Bank_Package.DeleteBank", commandType: CommandType.StoredProcedure);
        }


        public List<Bank> GetAllBanks()
        {
            IEnumerable<Bank> result = dbContext.Connection.Query<Bank>("Bank_Package.GetAllBanks", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Bank GetBankById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, ParameterDirection.Input);

            IEnumerable<Bank> result = dbContext.Connection.Query<Bank>("Bank_Package.GetBankById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateBank(Bank bank)
        {
            var p = new DynamicParameters();
            p.Add("ID", bank.Card_Id, dbType: DbType.Int32, ParameterDirection.Input);

            p.Add("card_CVV", bank.Cvv, dbType: DbType.String, ParameterDirection.Input);

            p.Add("Expire_Date", bank.Expire_Date, dbType: DbType.Date, ParameterDirection.Input);

            p.Add("Card_Balance ", bank.Balance, dbType: DbType.Double, ParameterDirection.Input);

            p.Add("status ", bank.Status, dbType: DbType.String, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Bank_Package.UpdateBank", p, commandType: CommandType.StoredProcedure);
        }
    }
}
