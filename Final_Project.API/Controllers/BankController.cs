using Final_Project.Core.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Final_Project.Core.Models;
namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;
        public BankController(IBankService bankService)
        {
            this.bankService = bankService;
        }
        [HttpGet]
        public List<Bank> GetAllBanks()
        {
            return bankService.GetAllBanks();
        }
        [HttpPost]
        public void CreateBank(Bank bank)
        {
            bankService.CreateBank(bank);
        }
        [HttpPut]
        public void UpdateBank(Bank bank)
        {
            bankService.UpdateBank(bank);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteBank(int id)
        {
            bankService.DeleteBank(id);
        }
        [HttpGet]
        [Route("GetBankById/{id}")]
        public Bank GetBankById(int id)
        {
            return bankService.GetBankById(id);
        }
    }
}
