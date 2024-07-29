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
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext dbContext;
        public TestimonialRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Testimonial> GetAllTestimonials()
        {
            IEnumerable<Testimonial> result = dbContext.Connection.Query<Testimonial>("Testimonial_Package.GetAllTestimonials", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public Testimonial GetTestimonialById(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            IEnumerable<Testimonial> result = dbContext.Connection.Query<Testimonial>("Testimonial_Package.GetTestimonialById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void CreateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();

            p.Add("Testi_Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Testi_Feedback", testimonial.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("UserId", testimonial.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("Testi_status", testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Testimonial_Package.CreateTestimonial", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();

            p.Add("ID", testimonial.Testimonial_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("Testi_Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Testi_Feedback", testimonial.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Testi_status", testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("UserId", testimonial.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("Testimonial_Package.UpdateTestimonial", p, commandType: CommandType.StoredProcedure);


        }

        public void DeleteTestimonial(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Testimonial_Package.DeleteTestimonial", p, commandType: CommandType.StoredProcedure);

        }

    }
}
