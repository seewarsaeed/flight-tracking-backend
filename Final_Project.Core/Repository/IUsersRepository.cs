using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Core.Repository
{
    public interface IUsersRepository
    {
        List<Report> Report();
        List<User> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User GetUserById(int id);

        User GetUserByName(string name);
        int NumberOfRegisteredUsers();
    }
}
