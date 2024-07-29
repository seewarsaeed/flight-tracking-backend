using Dapper;
using Final_Project.Core.Common;
using Final_Project.Core.Models;
using Final_Project.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Infra.Repository
{
    public class HeaderRepository : IHeaderRepository
    {
        private readonly IDbContext dbContext;
        public HeaderRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Header> GetAllHeader()
        {
            IEnumerable<Header> result = dbContext.Connection.Query<Header>("HeaderPackage.GetAllHeader", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public Header GetHeaderById(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            IEnumerable<Header> result = dbContext.Connection.Query<Header>("HeaderPackage.GetHeaderById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void CreateHeader(Header header)
        {
            var p = new DynamicParameters();

            p.Add("Logo", header.Header_Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Title", header.Header_Title, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("WebsiteName", header.Website_Name, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("HeaderPackage.CreateHeader", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateHeader(Header header)
        {
            var p = new DynamicParameters();

            p.Add("ID", header.Header_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("Logo", header.Header_Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Title", header.Header_Title, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("WebsiteName", header.Website_Name, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("HeaderPackage.UpdateHeader", p, commandType: CommandType.StoredProcedure);


        }

        public void DeleteHeader(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("HeaderPackage.DeleteHeader", p, commandType: CommandType.StoredProcedure);

        }
    }
}
