using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface IFooterService
    {
        List<Footer> GetAllFooter();

        void CreateFooter(Footer footer);

        void UpdateFooter(Footer footer);

        void DeleteFooter(int id);

        Footer GetFooterById(int id);
    }
}
