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
    public class FooterService : IFooterService
    {
        private readonly IFooterRepository footerRepository;
        public FooterService(IFooterRepository footerRepository)
        {
            this.footerRepository = footerRepository;
        }

        public List<Footer> GetAllFooter()
        {
            return footerRepository.GetAllFooter();
        }

        public void CreateFooter(Footer footer)
        {
             footerRepository.CreateFooter(footer);
        }

        public void UpdateFooter(Footer footer)
        {
             footerRepository.UpdateFooter(footer);
        }

        public void DeleteFooter(int id)
        {
             footerRepository.DeleteFooter(id);
        }

        public Footer GetFooterById(int id)
        {
            return footerRepository.GetFooterById(id);
        }
    }
}
