using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface IHeaderService
    {
        List<Header> GetAllHeader();

        Header GetHeaderById(int id);

        void CreateHeader(Header header);

        void UpdateHeader(Header header);

        void DeleteHeader(int id);
    }
}
