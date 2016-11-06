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
    public class SaleControlRepository:Repository<SaleControl>,ISaleControlRepository
    {
        public SaleControlRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
        public override SaleControl Get(SaleControl entity)
        {
            return DbSet.FirstOrDefault(sc => sc.SaleControlID == entity.SaleControlID);
        }
    }
}
