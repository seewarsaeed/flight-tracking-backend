using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservedFlightsController : ControllerBase
    {
        private readonly IReservedFlightsService reservedFlightsService;
        public ReservedFlightsController(IReservedFlightsService reservedFlightsService)
        {
            this.reservedFlightsService = reservedFlightsService;
        }
        [HttpGet]
        public List<Reservedflight> GetAllReservedFlights()
        {
            return reservedFlightsService.GetAllReservedFlights();
        }
        [HttpPost]
        public void CreateReservedFlights(Reservedflight reservedFlights)
        {
            reservedFlightsService.CreateReservedFlights(reservedFlights);
        }
        [HttpPut]
        public void UpdateReservedFlights(Reservedflight reservedFlights)
        {
            reservedFlightsService.UpdateReservedFlights(reservedFlights);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteReservedFlights(int id)
        {
            reservedFlightsService.DeleteReservedFlights(id);
        }
        [HttpGet]
        [Route("GetReservedFlightsById/{id}")]
        public List<Reservedflight> GetReservedFlightsById(int id)
        {
            return reservedFlightsService.GetReservedFlightsById(id);
        }
    }
}
