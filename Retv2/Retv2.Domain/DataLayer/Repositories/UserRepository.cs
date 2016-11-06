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
    public class UserRepository:Repository<User>,IUserRepository
    {
        public UserRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
        public override User Get(User entity)
        {
            return DbSet.FirstOrDefault(u => u.UserID == entity.UserID);
        }
    }
}
