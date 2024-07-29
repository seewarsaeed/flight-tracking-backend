using Dapper;
using Final_Project.Core.Common;
using Final_Project.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Core.Models;
namespace Final_Project.Infra.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDbContext dbContext;
        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Contactu> GetAllContactUs()
        {
            IEnumerable<Contactu> result = dbContext.Connection.Query<Contactu>("ContactUsPackage.GetAllContactUs", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public void CreateContactUs(Contactu contactUs)
        {
            var p = new DynamicParameters();

            p.Add("NamePKG", contactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailPKG", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("SubjectPKG", contactUs.Subject, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("MessagePKG", contactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("ContactUsPackage.CreateContactUs", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateContactUs(Contactu contactUs)
        {
            var p = new DynamicParameters();

            p.Add("ID", contactUs.Contact_Us_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("NamePKG", contactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailPKG", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("SubjectPKG", contactUs.Subject, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("MessagePKG", contactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("ContactUsPackage.UpdateContactUs", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteContactUs(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("ContactUsPackage.DeleteContactUs", p, commandType: CommandType.StoredProcedure);


        }

        public Contactu GetContactUsById(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Contactu> result = dbContext.Connection.Query<Contactu>("ContactUsPackage.GetContactUsById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

    }
}
