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
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository airportRepository;
        public AirportService(IAirportRepository airportRepository)
        {
            this.airportRepository = airportRepository;
        }
        public void CreateAirport(Airport airport)
        {
            airportRepository.CreateAirport(airport);
        }

        public void DeleteAirport(int id)
        {
            airportRepository.DeleteAirport(id);
        }

        public Airport GetAirportById(int id)
        {
            return airportRepository.GetAirportById(id);
        }

        public List<Airport> GetAllAirports()
        {
            return airportRepository.GetAllAirports();
        }

        public int NumberOfAirports()
        {
            return airportRepository.NumberOfAirports();
        }

        public void UpdateAirport(Airport airport)
        {
            airportRepository.UpdateAirport(airport);
        }
    }
}
