using Dapper;
using Final_Project.Core.Common;
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
    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext dbContext;
        public JWTRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public User Auth(User login)
        {
            var p = new DynamicParameters();
            p.Add("User_NAME", login.User_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASS", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<User> result = dbContext.Connection.Query<User>("Users_Package.User_Login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
