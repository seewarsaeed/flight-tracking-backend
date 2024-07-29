using Dapper;
using Final_Project.Core.Common;
using Final_Project.Core.DTO;
using Final_Project.Core.Models;
using Final_Project.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Infra.Repository
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IDbContext dbContext;
        public FlightRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateFlight(Flight flight)
        {
            var p = new DynamicParameters();
            p.Add("FlightName", flight.Flight_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Flight_Price", flight.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("NumOfEmptySeats", flight.Numberofemptyseats, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NumOfReservedSeats", flight.Numberofreservedseats, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Arrival_status", flight.Arrival_Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Departure_date", flight.Departure_Datetime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Arrival_date", flight.Arrival_Datetime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("AdditionCost", flight.Additionalcost, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("ImageName", flight.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DepartureAirport_ID", flight.Departure_Airport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ArrivalAirport_ID", flight.Arrival_Airport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Flight_Package.CreateFlight", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteFlight(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            dbContext.Connection.Execute("Flight_Package.DeleteFlight", p, commandType: CommandType.StoredProcedure);

        }

        public List<Flight> GetAllFlights()
        {
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.GetAllFlights", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Flight> GetFlightBetweenInterval(DateTime DateFrom, DateTime DateTo)
        {
            var p = new DynamicParameters();
            p.Add("DateFrom", DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("DateTo", DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.GetFlightBetweenInterval", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Flight GetFlightById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.GetFlightById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public List<Flight> GetFlightByName(string name)
        {
            var p = new DynamicParameters();
            p.Add("Search_Name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.GetFlightByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Flight> GetFlightsWithMaxReservedSeats()
        {
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.GetFlightsWithMaxReservedSeats", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Flight> SearchFlightsByAirportName(string name)
        {
            var p = new DynamicParameters();
            p.Add("Search_Name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Flight> result = dbContext.Connection.Query<Flight>("Flight_Package.SearchFlightsByAirportName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateFlight(Flight flight)
        {
            var p = new DynamicParameters();
            p.Add("ID", flight.Flight_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FlightName", flight.Flight_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Flight_Price", flight.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("NumOfEmptySeats", flight.Numberofemptyseats, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NumOfReservedSeats", flight.Numberofreservedseats, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Departure_date", flight.Departure_Datetime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Arrival_date", flight.Arrival_Datetime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Arrival_statuss", flight.Arrival_Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AdditionCost", flight.Additionalcost, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("ImageName", flight.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DepartureAirport_ID", flight.Departure_Airport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ArrivalAirport_ID", flight.Arrival_Airport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.Connection.Execute("Flight_Package.UpdateFlight", p, commandType: CommandType.StoredProcedure);

        }
        public List<Chart> GetChartData()
        {
            IEnumerable<Chart> result = dbContext.Connection.Query<Chart>("Flight_Package.GetChartData", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
