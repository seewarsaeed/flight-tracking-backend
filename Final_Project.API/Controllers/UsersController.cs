using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using Final_Project.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        [Route("uploadImage")]
        [HttpPost]
        public User UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Dell\\Desktop\\Trainig Tahaluf\\Final_Project_Angular\\FlightTracker\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Image_Name = fileName;
            return item;
        }
        [HttpGet]
        [Route("Report")]
        public List<Report> Report()
        {
            return usersService.Report();
        }
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return usersService.GetAllUsers();
        }

        [HttpPost]
        public void CreateUser(User user)
        {
            usersService.CreateUser(user);
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            usersService.UpdateUser(user);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteUser(int id)
        {
            usersService.DeleteUser(id);
        }
        [HttpGet]
        [Route("GetUserById/{id}")]
        public User GetUserById(int id)
        {
            return usersService.GetUserById(id);
        }


        [HttpGet]
        [Route("GetUserByName/{name}")]
        public User GetUserByName(string name)
        {
            return usersService.GetUserByName(name);
        }


        [HttpGet]
        [Route("NumberOfRegisteredUsers")]
        public int NumberOfRegisteredUsers()
        {
            return usersService.NumberOfRegisteredUsers();
        }
    }
}
