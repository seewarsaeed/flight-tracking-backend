using Final_Project.Core.Common;
using Final_Project.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Final_Project.Core.Models;

namespace Final_Project.Infra.Repository
{
    public class ReservedFlightsRepository : IReservedFlightsRepository
    {
        private readonly IDbContext dbContext;
        public ReservedFlightsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateReservedFlights(Reservedflight reservedFlights)
        {  
            
            var p = new DynamicParameters();

            p.Add("Dates", reservedFlights.Reservation_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            p.Add("PaidStatus", reservedFlights.Paid_Status, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailStatus", reservedFlights.Email_Status, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("NumOfSeats", reservedFlights.Numberofseats, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("FlightID", reservedFlights.Flight_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("UserID", reservedFlights.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("ReservedFlightsPackage.CreateReservedFlights", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteReservedFlights(int id)
        {
      
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("ReservedFlightsPackage.DeleteReservedFlights", p ,commandType: CommandType.StoredProcedure);
        }


        public List<Reservedflight> GetAllReservedFlights()
        {
            IEnumerable<Reservedflight> result = dbContext.Connection.Query<Reservedflight>("ReservedFlightsPackage.GetAllReservedFlights", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Reservedflight> GetReservedFlightsById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            IEnumerable<Reservedflight> result = dbContext.Connection.Query<Reservedflight>("ReservedFlightsPackage.GetReservedFlightsById", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public void UpdateReservedFlights(Reservedflight reservedFlights)
        {
            var p = new DynamicParameters();

            p.Add("ID", reservedFlights.Reserved_Flights_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("Dates", reservedFlights.Reservation_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            p.Add("PaidStatus", reservedFlights.Paid_Status, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailStatus", reservedFlights.Email_Status, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("NumOfSeats", reservedFlights.Numberofseats, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("FlightID", reservedFlights.Flight_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("UserID", reservedFlights.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("ReservedFlightsPackage.UpdateReservedFlights", p, commandType: CommandType.StoredProcedure);
        }
    }
}
