using Final_Project.Core.DTO;
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
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository flightRepository;
        public FlightService(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }
        public void CreateFlight(Flight flight)
        {
            flightRepository.CreateFlight(flight);
        }

        public void DeleteFlight(int id)
        {
            flightRepository.DeleteFlight(id);
        }

        public List<Flight> GetAllFlights()
        {
            return flightRepository.GetAllFlights();
        }

        public List<Flight> GetFlightBetweenInterval(DateTime DateFrom, DateTime DateTo)
        {
            return flightRepository.GetFlightBetweenInterval(DateFrom, DateTo);
        }

        public Flight GetFlightById(int id)
        {
            return flightRepository.GetFlightById(id);
        }

        public List<Flight> GetFlightByName(string name)
        {
            return flightRepository.GetFlightByName(name);
        }

        public List<Flight> GetFlightsWithMaxReservedSeats()
        {
            return flightRepository.GetFlightsWithMaxReservedSeats();
        }

        public List<Flight> SearchFlightsByAirportName(string name)
        {
            return flightRepository.SearchFlightsByAirportName(name);
        }

        public void UpdateFlight(Flight flight)
        {
            flightRepository.UpdateFlight(flight);
        }
        public List<Chart> GetChartData()
        {
            return flightRepository.GetChartData();
        }
    }
}
