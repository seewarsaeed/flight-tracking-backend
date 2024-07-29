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
    public class BackgroundService : IBackgroundService
    {
        private readonly IBackgroundRepository backgroundRepository;
        public BackgroundService(IBackgroundRepository backgroundRepository)
        {
            this.backgroundRepository = backgroundRepository;
        }
        public void CreateBackground(Background background)
        {
            backgroundRepository.CreateBackground(background);
        }

        public void DeleteBackground(int id)
        {
            backgroundRepository.DeleteBackground(id);
        }


        public List<Background> GetAllBackground()
        {
            return backgroundRepository.GetAllBackground();
        }

        public Background GetBackgroundById(int id)
        {
            return backgroundRepository.GetBackgroundById(id);
        }

        public void UpdateBackground(Background background)
        {
            backgroundRepository.UpdateBackground(background);
        }
    }
}
