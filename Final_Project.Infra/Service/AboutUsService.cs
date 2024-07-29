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
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            this.aboutUsRepository = aboutUsRepository;
        }

        public List<Aboutu> GetAllAboutUs()
        {
            return aboutUsRepository.GetAllAboutUs();
        }

        public void CreateAboutUs(Aboutu aboutUs)
        {
             aboutUsRepository.CreateAboutUs(aboutUs);
        }

        public void UpdateAboutUs(Aboutu aboutUs)
        {
           aboutUsRepository.UpdateAboutUs(aboutUs);
        }

        public void DeleteAboutUs(int id)
        {
            aboutUsRepository.DeleteAboutUs(id);
        }

        public Aboutu GetAboutUsById(int id)
        {
            return aboutUsRepository.GetAboutUsById(id);
        }
    }
}
