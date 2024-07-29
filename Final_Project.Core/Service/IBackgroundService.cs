using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.Models;
namespace Final_Project.Core.Service
{
    public interface IBackgroundService
    {
        List<Background> GetAllBackground();

        Background GetBackgroundById(int id);

        void CreateBackground(Background background);

        void UpdateBackground(Background background);

        void DeleteBackground(int id);
    }
}
