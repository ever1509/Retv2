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
    public class UserTypeRepository:Repository<UserType>,IUserTypeRepository
    {
        public UserTypeRepository(DbContext dbContext)
            :base(dbContext)
        {
                
        }
        public override UserType Get(UserType entity)
        {
            return DbSet.FirstOrDefault(ut => ut.UserTypeID == entity.UserTypeID);
        }
    }
}
