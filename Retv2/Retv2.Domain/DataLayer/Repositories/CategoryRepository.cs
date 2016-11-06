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
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
        public override Category Get(Category entity)
        {
            return DbSet.FirstOrDefault(c => c.CategoryID == entity.CategoryID);
        }
    }
}
