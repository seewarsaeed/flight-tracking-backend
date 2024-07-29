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
    public class AirportRepository : IAirportRepository
    {
        private readonly IDbContext dbContext;
        public AirportRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateAirport(Airport airport)
        {
            var p = new DynamicParameters();
            p.Add("AirportName", airport.Airport_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Airport_Location", airport.Location, dbType: DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Airport_Package.CreateAirport", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteAirport(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Airport_Package.DeleteAirport", p, commandType: CommandType.StoredProcedure);

        }

        public Airport GetAirportById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Airport> result = dbContext.Connection.Query<Airport>("Airport_Package.GetAirportById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<Airport> GetAllAirports()
        {
            IEnumerable<Airport> result = dbContext.Connection.Query<Airport>("Airport_Package.GetAllAirports", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int NumberOfAirports()
        {
            var parameters = new DynamicParameters();
            parameters.Add("OUT_Result", dbType: DbType.Int32, direction: ParameterDirection.Output);
            dbContext.Connection.Execute("Airport_Package.NumberOfAirports", parameters, commandType: CommandType.StoredProcedure);
            int numberOfAirports = parameters.Get<int>("OUT_Result");
            return numberOfAirports;
        }

        public void UpdateAirport(Airport airport)
        {
            var p = new DynamicParameters();
            p.Add("ID", airport.Airport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("AirportName", airport.Airport_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Airport_Location", airport.Location, dbType: DbType.String, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Airport_Package.UpdateAirport", p, commandType: CommandType.StoredProcedure);

        }
    }
}
