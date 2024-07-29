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
    public class FooterRepository : IFooterRepository
    {
        private readonly IDbContext dbContext;
        public FooterRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Footer> GetAllFooter()
        {
            IEnumerable<Footer> result = dbContext.Connection.Query<Footer>("FooterPackage.GetAllFooter", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void CreateFooter(Footer footer)
        {
            var p = new DynamicParameters();

            p.Add("LogoPKG", footer.Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("BriefPKG", footer.Brief, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("LocationPKG", footer.Location, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailPKG", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Phone_NumberPKG", footer.Phone_Number, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("LinksTitlePKG", footer.Linkstitle, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("CopyRightPKG", footer.Copyright, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("FooterPackage.CreateFooter", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateFooter(Footer footer)
        {
            var p = new DynamicParameters();

            p.Add("ID", footer.Footer_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("LogoPKG", footer.Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("BriefPKG", footer.Brief, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("LocationPKG", footer.Location, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("EmailPKG", footer.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("Phone_NumberPKG", footer.Phone_Number, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("LinksTitlePKG", footer.Linkstitle, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("CopyRightPKG", footer.Copyright, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("FooterPackage.UpdateFooter", p, commandType: CommandType.StoredProcedure);


        }

        public void DeleteFooter(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("FooterPackage.DeleteFooter", p, commandType: CommandType.StoredProcedure);
        }

        public Footer GetFooterById(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            IEnumerable<Footer> result = dbContext.Connection.Query<Footer>("FooterPackage.GetFooterById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
