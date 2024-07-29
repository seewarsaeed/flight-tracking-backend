using Final_Project.Core.Models;
using Final_Project.Core.Repository;
using Final_Project.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Infra.Service
{
    public class HeaderService : IHeaderService
    {
        private readonly IHeaderRepository headerRepository;
        public HeaderService(IHeaderRepository headerRepository)
        {
            this.headerRepository = headerRepository;
        }

        public List<Header> GetAllHeader()
        {
            return headerRepository.GetAllHeader();
        }

        public Header GetHeaderById(int id)
        {
            return headerRepository.GetHeaderById(id);
        }

        public void CreateHeader(Header header)
        {
             headerRepository.CreateHeader(header);
        }

        public void UpdateHeader(Header header)
        {
             headerRepository.UpdateHeader(header);
        }

        public void DeleteHeader(int id)
        {
             headerRepository.DeleteHeader(id);
        }
    }
}
