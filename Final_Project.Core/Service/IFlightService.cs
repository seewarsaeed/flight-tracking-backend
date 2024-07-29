using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Service
{
    public interface IFlightService
    {
        List<Flight> GetAllFlights();
        void CreateFlight(Flight flight);
        void UpdateFlight(Flight flight);
        void DeleteFlight(int id);
        Flight GetFlightById(int id);

        List<Flight> GetFlightsWithMaxReservedSeats();
        List<Flight> GetFlightBetweenInterval(DateTime DateFrom, DateTime DateTo);
        List<Flight> GetFlightByName(string name);
        List<Flight> SearchFlightsByAirportName(string name);
        List<Chart> GetChartData();
    }
}
