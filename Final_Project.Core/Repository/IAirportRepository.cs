using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Repository
{
    public interface IAirportRepository
    {
        List<Airport> GetAllAirports();
        void CreateAirport(Airport airport);
        void UpdateAirport(Airport airport);
        void DeleteAirport(int id);
        Airport GetAirportById(int id);

        int NumberOfAirports();
    }
}
