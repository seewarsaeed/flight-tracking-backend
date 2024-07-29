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
    public class ReservedFlightsService : IReservedFlightsService
    {
        private readonly IReservedFlightsRepository reservedFlightsRepository;
        public ReservedFlightsService(IReservedFlightsRepository reservedFlightsRepository)
        {
            this.reservedFlightsRepository = reservedFlightsRepository;
        }
        public void CreateReservedFlights(Reservedflight reservedFlights)
        {
            reservedFlightsRepository.CreateReservedFlights(reservedFlights);

        }

        public void DeleteReservedFlights(int id)
        {
            reservedFlightsRepository.DeleteReservedFlights(id);
        }


        public List<Reservedflight> GetAllReservedFlights()
        {
            return reservedFlightsRepository.GetAllReservedFlights();
        }

        public List<Reservedflight> GetReservedFlightsById(int id)
        {
            return reservedFlightsRepository.GetReservedFlightsById(id);
        }

        public void UpdateReservedFlights(Reservedflight reservedFlights)
        {
            reservedFlightsRepository.UpdateReservedFlights(reservedFlights);
        }

    }
}
