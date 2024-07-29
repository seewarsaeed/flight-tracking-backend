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
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly IDbContext dbContext;
        public AboutUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Aboutu> GetAllAboutUs()
        {
            IEnumerable<Aboutu> result = dbContext.Connection.Query<Aboutu>("AboutUsPackage.GetAllAboutUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public void CreateAboutUs(Aboutu aboutUs)
        {
            var p = new DynamicParameters();

            p.Add("Image_NamePKG", aboutUs.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("DescriptionPKG", aboutUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("TitlePKG", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("AboutUsPackage.CreateAboutUs", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateAboutUs(Aboutu aboutUs)
        {
            var p = new DynamicParameters();

            p.Add("ID", aboutUs.About_Us_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("Image_NamePKG", aboutUs.Image_Name, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("DescriptionPKG", aboutUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("TitlePKG", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("AboutUsPackage.UpdateAboutUs", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteAboutUs(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("AboutUsPackage.DeleteAboutUs", p, commandType: CommandType.StoredProcedure);

        }


        public Aboutu GetAboutUsById(int id)
        {
            var p = new DynamicParameters();

            p.Add("ID", id, dbType: DbType.Int64, direction: ParameterDirection.Input);

            IEnumerable<Aboutu> result = dbContext.Connection.Query<Aboutu>("AboutUsPackage.GetAboutUsById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
