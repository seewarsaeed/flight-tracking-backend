using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.Models;
namespace Final_Project.Core.Service
{
    public interface IBankService
    {
        List<Bank> GetAllBanks();

        Bank GetBankById(int id);

        void CreateBank(Bank bank);

        void UpdateBank(Bank bank);

        void DeleteBank(int id);
    }
}
