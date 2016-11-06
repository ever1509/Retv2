using Retv2.Domain.DataLayer.Contracts;
using Retv2.Domain.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DbContext DbContext;
        protected Boolean Disposed = false;
        protected ICategoryRepository _categoryRepository;
        protected IFoodMenuRepository _foodmenuRepository;
        protected IOrderRepository _orderRepository;
        protected ISaleControlRepository _salecontrolRepository;
        protected IUserTypeRepository _usertypeRepository;
        protected IUserRepository _userRepository;
        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository ?? (_categoryRepository = new CategoryRepository(DbContext));
            }
        }

        public IFoodMenuRepository FoodMenuRepository
        {
            get
            {
                return _foodmenuRepository ?? (_foodmenuRepository = new FoodMenuRepository(DbContext));
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository ?? (_orderRepository = new OrderRepository(DbContext));
            }
        }

        public ISaleControlRepository SaleControlRepository
        {
            get
            {
                return _salecontrolRepository ?? (_salecontrolRepository = new SaleControlRepository(DbContext));
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository ?? (_userRepository = new UserRepository(DbContext));
            }
        }

        public IUserTypeRepository UserTypeRepository
        {
            get
            {
                return _usertypeRepository ?? (_usertypeRepository = new UserTypeRepository(DbContext));
            }
        }

        public int? CommitChanges()
        {
            if (DbContext.ChangeTracker.HasChanges())
            {
                return DbContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        protected void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);            
        }
    }
}
