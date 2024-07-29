using Final_Project.Core.Repository;
using Final_Project.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.Models;
namespace Final_Project.Infra.Service
{
    public class BankService : IBankService
    {
        private readonly IBankRepository bankRepository;
        public BankService(IBankRepository bankRepository)
        {
            this.bankRepository = bankRepository;
        }
        public void CreateBank(Bank bank)
        {
            bankRepository.CreateBank(bank);
        }

        public void DeleteBank(int id)
        {
            bankRepository.DeleteBank(id);
        }


        public List<Bank> GetAllBanks()
        {
            return bankRepository.GetAllBanks();
        }

        public Bank GetBankById(int id)
        {
            return bankRepository.GetBankById(id);
        }

        public void UpdateBank(Bank bank)
        {
            bankRepository.UpdateBank(bank);
        }
    }
}
