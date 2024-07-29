using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService flightService;
        public FlightController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        [HttpGet]
        public List<Flight> GetAllFlights()
        {
            return flightService.GetAllFlights();
        }
        [HttpPost]
        public void CreateFlight(Flight flight)
        {
            flightService.CreateFlight(flight);
        }
        [HttpPut]
        public void UpdateFlight(Flight flight)
        {
            flightService.UpdateFlight(flight);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteFlight(int id)
        {
            flightService.DeleteFlight(id);
        }
        [HttpGet]
        [Route("GetFlightById/{id}")]
        public Flight GetFlightById(int id)
        {
            return flightService.GetFlightById(id);
        }
        [HttpGet]
        [Route("GetFlightsWithMaxReservedSeats")]
        public List<Flight> GetFlightsWithMaxReservedSeats()
        {
            return flightService.GetFlightsWithMaxReservedSeats();
        }
        [HttpPost]
        [Route("GetFlightBetweenInterval")]
        public List<Flight> GetFlightBetweenInterval(DateTime DateFrom, DateTime DateTo)
        {
            return flightService.GetFlightBetweenInterval(DateFrom, DateTo);
        }
        [HttpPost]
        [Route("GetFlightByName")]
        public List<Flight> GetFlightByName(string name)
        {
            return flightService.GetFlightByName(name);
        }
        [HttpPost]
        [Route("SearchFlightsByAirportName")]
        public List<Flight> SearchFlightsByAirportName(string name)
        {
            return flightService.SearchFlightsByAirportName(name);
        }

        [Route("uploadImage")]
        [HttpPost]
        public Flight UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Flight item = new Flight();
            item.Image_Name = fileName;
            return item;
        }
        [HttpGet]
        [Route("GetChartData")]
        public List<Chart> GetChartData()
        {
            return flightService.GetChartData();
        }
    }
}
