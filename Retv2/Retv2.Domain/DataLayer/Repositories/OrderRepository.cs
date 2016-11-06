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
    public class OrderRepository:Repository<Order>,IOrderRepository
    {
        public OrderRepository(DbContext dbcontext)
            :base(dbcontext)
        {


        }
        public override Order Get(Order entity)
        {
            return DbSet.FirstOrDefault(o => o.OrderID == entity.OrderID);
        }
    }
}
