using Dapper;
using Final_Project.Core.Common;
using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using Final_Project.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Infra.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbContext dbContext;
        public UsersRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Report> Report()
        {
            var result = dbContext.Connection.Query<Report>("Users_Package.Report", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void CreateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("User_Name", user.User_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FName", user.First_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", user.Last_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ImageName", user.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("User_Email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RoleID", user.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Users_Package.CreateUser", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Users_Package.DeleteUser", p, commandType: CommandType.StoredProcedure);

        }

        public List<User> GetAllUsers()
        {
            IEnumerable<User> result = dbContext.Connection.Query<User>("Users_Package.GetAllUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public User GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<User> result = dbContext.Connection.Query<User>("Users_Package.GetUserById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }


        public User GetUserByName(string name)
        {
            var p = new DynamicParameters();
        p.Add("name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<User> result = dbContext.Connection.Query<User>("Users_Package.GetUserByName", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    public void UpdateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("ID", user.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UserName", user.User_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FName", user.First_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LName", user.Last_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ImageName", user.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("User_Email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RoleID", user.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Users_Package.UpdateUser", p, commandType: CommandType.StoredProcedure);

        }
        public int NumberOfRegisteredUsers()
        {
            var parameters = new DynamicParameters();
            parameters.Add("OUT_Result",dbType: DbType.Int32,direction:ParameterDirection.Output);
            dbContext.Connection.Execute("Users_Package.NumberOfRegisteredUsers", parameters,commandType: CommandType.StoredProcedure);
            int NumberOfRegisteredUsers = parameters.Get<int>("OUT_Result");
            return NumberOfRegisteredUsers;
        }
    }
}
