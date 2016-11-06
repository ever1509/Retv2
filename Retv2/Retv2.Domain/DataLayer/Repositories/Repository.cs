using Retv2.Domain.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext DbContext;
        protected DbSet<TEntity> DbSet;
        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }
        public virtual void Add(TEntity entity)
        {
            var dbEntityEntry = DbContext.Entry(entity);
            if(dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public virtual TEntity Get(TEntity entity)
        {
            throw new NotImplementedException("There isn't implementation here");
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Remove(TEntity entity)
        {
            var dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Deleted)
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
            else
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
        }

        public virtual void Update(TEntity entity)
        {
            var dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
                
            }
            
                dbEntityEntry.State = EntityState.Deleted;
            
        }
    }
}
