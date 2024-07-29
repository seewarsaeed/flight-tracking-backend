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
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public List<Report> Report()
        {
            return usersRepository.Report();
        }
        public void CreateUser(User user)
        {
            usersRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            usersRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return usersRepository.GetAllUsers();
        }


        public User GetUserById(int id)
        {
            return usersRepository.GetUserById(id);
        }

        public User GetUserByName(string name)
        {
            return usersRepository.GetUserByName(name);
        }
        public int NumberOfRegisteredUsers()
        {
            return usersRepository.NumberOfRegisteredUsers();
        }

        public void UpdateUser(User user)
        {
            usersRepository.UpdateUser(user);
        }
    }
}
