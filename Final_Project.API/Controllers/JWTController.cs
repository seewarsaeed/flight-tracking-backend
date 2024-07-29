using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private readonly IJWTService jwtservice;
        public JWTController(IJWTService jwtservice)
        {
            this.jwtservice = jwtservice;
        }
        [HttpPost]
        public IActionResult Auth([FromBody] User login)
        {
            var token = jwtservice.Auth(login);
            if (token == null)
            {
                return Unauthorized("Invalid username or password");
            }
            else
            {
                return Ok(token);
            }
        }

    }
}
