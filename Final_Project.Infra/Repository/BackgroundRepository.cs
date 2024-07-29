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
    public class BackgroundRepository : IBackgroundRepository
    {
        private readonly IDbContext dbContext;
        public BackgroundRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateBackground(Background background)
        {
            var p = new DynamicParameters();

            p.Add("DescriptionPKG", background.Description, dbType: DbType.String, ParameterDirection.Input);

            p.Add("Image_NamePKG", background.Image_Name, dbType: DbType.String, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("BackgroundPackage.CreateBackground", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteBackground(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("BackgroundPackage.DeleteBackground",p, commandType: CommandType.StoredProcedure);
        }


        public List<Background> GetAllBackground()
        {
            IEnumerable<Background> result = dbContext.Connection.Query<Background>("BackgroundPackage.GetAllBackground", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Background GetBackgroundById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int64, ParameterDirection.Input);

            IEnumerable<Background> result = dbContext.Connection.Query<Background>("BackgroundPackage.GetBackgroundById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void UpdateBackground(Background background)
        {
            var p = new DynamicParameters();
            p.Add("ID", background.Background_Id, dbType: DbType.Int32, ParameterDirection.Input);

            p.Add("DescriptionPKG", background.Description, dbType: DbType.String, ParameterDirection.Input);

            p.Add("Image_NamePKG", background.Image_Name, dbType: DbType.String, ParameterDirection.Input);

            var result = dbContext.Connection.Execute("BackgroundPackage.UpdateBackground", p, commandType: CommandType.StoredProcedure);
        }

    }
}
