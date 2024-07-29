using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService airportService;
        public AirportController(IAirportService airportService)
        {
            this.airportService = airportService;
        }
        [HttpGet]
        public List<Airport> GetAllAirports()
        {
            return airportService.GetAllAirports();
        }
        [HttpPost]
        public void CreateAirport(Airport airport)
        {
            airportService.CreateAirport(airport);
        }
        [HttpPut]
        public void UpdateAirport(Airport airport)
        {
            airportService.UpdateAirport(airport);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteAirport(int id)
        {
            airportService.DeleteAirport(id);
        }

        [HttpGet]
        [Route("GetAirportById/{id}")]
        public Airport GetAirportById(int id)
        {
            return airportService.GetAirportById(id);
        }
        [HttpGet]
        [Route("NumberOfAirports")]
        public int NumberOfAirports()
        {
            return airportService.NumberOfAirports();
        }
    }
}
