using Retv2.Domain.DataLayer.Contracts;
using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer.Repositories
{
    public class FoodMenuRepository:Repository<FoodMenu>,IFoodMenuRepository
    {
        public FoodMenuRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
        public override FoodMenu Get(FoodMenu entity)
        {
            return DbSet.FirstOrDefault(fm => fm.FoodMenuID == entity.FoodMenuID);
        }
    }
}
