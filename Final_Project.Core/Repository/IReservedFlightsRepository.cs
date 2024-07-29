using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Repository
{
    public interface IReservedFlightsRepository
    {
        List<Reservedflight> GetAllReservedFlights();

        List<Reservedflight> GetReservedFlightsById(int id);

        void CreateReservedFlights(Reservedflight reservedFlights);

        void UpdateReservedFlights(Reservedflight reservedFlights);

        void DeleteReservedFlights(int id);
    }
}
