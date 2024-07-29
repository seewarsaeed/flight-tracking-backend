using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Repository
{
    public interface IBankRepository
    {
        List<Bank> GetAllBanks();

        Bank GetBankById(int id);

        void CreateBank(Bank bank);

        void UpdateBank(Bank bank);

        void DeleteBank(int id);
    }
}
