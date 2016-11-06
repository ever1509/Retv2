using Retv2.Domain.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retv2.Domain.EntityLayer;
using Retv2.Domain.DataLayer.Contracts;

namespace Retv2.Domain.BusinessLayer
{
    public class RestaurantBusinessObject : IRestaurantBusinessObject
    {
        protected IUnitOfWork UnitOfWork;
        public RestaurantBusinessObject(IUnitOfWork unitofwork)
        {
            UnitOfWork = unitofwork;
        }
        public Category CreateCategory(Category entity)
        {
            UnitOfWork.CategoryRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public FoodMenu CreateFoodMenu(FoodMenu entity)
        {
            UnitOfWork.FoodMenuRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public Order CreateOrder(Order entity)
        {
            UnitOfWork.OrderRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public SaleControl CreateSaleControl(SaleControl entity)
        {
            UnitOfWork.SaleControlRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public User CreateUser(User entity)
        {
            UnitOfWork.UserRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public UserType CreateUserType(UserType entity)
        {
            UnitOfWork.UserTypeRepository.Add(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public Category DeleteCategory(Category entity)
        {
            UnitOfWork.CategoryRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public FoodMenu DeleteFoodMenu(FoodMenu entity)
        {
            UnitOfWork.FoodMenuRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public Order DeleteOrder(Order entity)
        {
            UnitOfWork.OrderRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public SaleControl DeleteSaleControl(SaleControl entity)
        {
            UnitOfWork.SaleControlRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public User DeleteUser(User entity)
        {
            UnitOfWork.UserRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public UserType DeleteUserType(UserType entity)
        {
            UnitOfWork.UserTypeRepository.Remove(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public IEnumerable<Category> GetCategories()
        {
            return UnitOfWork.CategoryRepository.GetAll();
        }

        public Category GetCategory(Category entity)
        {
            return UnitOfWork.CategoryRepository.Get(entity);
        }

        public FoodMenu GetFoodMenu(FoodMenu entity)
        {
            return UnitOfWork.FoodMenuRepository.Get(entity);
        }

        public IEnumerable<FoodMenu> GetFoodMenus()
        {
            return UnitOfWork.FoodMenuRepository.GetAll();
        }

        public Order GetOrder(Order entity)
        {
            return UnitOfWork.OrderRepository.Get(entity);
        }

        public IEnumerable<Order> GetOrders()
        {
            return UnitOfWork.OrderRepository.GetAll();
        }

        public SaleControl GetSaleControl(SaleControl entity)
        {
            return UnitOfWork.SaleControlRepository.Get(entity);
        }

        public IEnumerable<SaleControl> GetSaleControls()
        {
            return UnitOfWork.SaleControlRepository.GetAll();
        }

        public User GetUser(User entity)
        {
            return UnitOfWork.UserRepository.Get(entity);
        }

        public IEnumerable<User> GetUsers()
        {
            return UnitOfWork.UserRepository.GetAll();
        }

        public UserType GetUserType(UserType entity)
        {
            return UnitOfWork.UserTypeRepository.Get(entity);
        }

        public IEnumerable<UserType> GetUserTypes()
        {
            return UnitOfWork.UserTypeRepository.GetAll();
        }

        public void Release()
        {
            if (UnitOfWork != null)
            {
                UnitOfWork.Dispose();
            }
        }

        public Category UpdateCategory(Category entity)
        {
            UnitOfWork.CategoryRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public FoodMenu UpdateFoodMenu(FoodMenu entity)
        {
            UnitOfWork.FoodMenuRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public Order UpdateOrder(Order entity)
        {
            UnitOfWork.OrderRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public SaleControl UpdateSaleControl(SaleControl entity)
        {
            UnitOfWork.SaleControlRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public User UpdateUser(User entity)
        {
            UnitOfWork.UserRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }

        public UserType UpdateUserType(UserType entity)
        {
            UnitOfWork.UserTypeRepository.Update(entity);
            UnitOfWork.CommitChanges();
            return entity;
        }
    }
}
