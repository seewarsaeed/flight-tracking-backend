using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.Models;

namespace Final_Project.Core.Repository
{
    public interface IContactUsRepository
    {
        List<Contactu> GetAllContactUs();

        void CreateContactUs(Contactu contactUs);

        void UpdateContactUs(Contactu contactUs);

        void DeleteContactUs(int id);

        Contactu GetContactUsById(int id);
    }
}
