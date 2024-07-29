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
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;
        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        public List<Contactu> GetAllContactUs()
        {
            return contactUsRepository.GetAllContactUs();
        }

        public void CreateContactUs(Contactu contactUs)
        {
             contactUsRepository.CreateContactUs(contactUs);
        }

        public void UpdateContactUs(Contactu contactUs)
        {
             contactUsRepository.UpdateContactUs(contactUs);
        }

        public void DeleteContactUs(int id)
        {
             contactUsRepository.DeleteContactUs(id);
        }
        public Contactu GetContactUsById(int id)
        {
            return contactUsRepository.GetContactUsById(id);
        }
    }
}
