using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface IAboutUsService
    {

        List<Aboutu> GetAllAboutUs();

        void CreateAboutUs(Aboutu aboutUs);

        void UpdateAboutUs(Aboutu aboutUs);

        void DeleteAboutUs(int id);

        Aboutu GetAboutUsById(int id);
    }
}
