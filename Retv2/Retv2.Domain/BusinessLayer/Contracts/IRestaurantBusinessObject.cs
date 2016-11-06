using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.BusinessLayer.Contracts
{
    public interface IRestaurantBusinessObject:IBusinessObject
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(Category entity);
        Category CreateCategory(Category entity);
        Category UpdateCategory(Category entity);
        Category DeleteCategory(Category entity);

        IEnumerable<FoodMenu> GetFoodMenus();
        FoodMenu GetFoodMenu(FoodMenu entity);
        FoodMenu CreateFoodMenu(FoodMenu entity);
        FoodMenu UpdateFoodMenu(FoodMenu entity);
        FoodMenu DeleteFoodMenu(FoodMenu entity);

        IEnumerable<Order> GetOrders();
        Order GetOrder(Order entity);
        Order CreateOrder(Order entity);
        Order UpdateOrder(Order entity);
        Order DeleteOrder(Order entity);

        IEnumerable<SaleControl> GetSaleControls();
        SaleControl GetSaleControl(SaleControl entity);
        SaleControl CreateSaleControl(SaleControl entity);
        SaleControl UpdateSaleControl(SaleControl entity);
        SaleControl DeleteSaleControl(SaleControl entity);

        IEnumerable<User> GetUsers();
        User GetUser(User entity);
        User CreateUser(User entity);
        User UpdateUser(User entity);
        User DeleteUser(User entity);

        IEnumerable<UserType> GetUserTypes();
        UserType GetUserType(UserType entity);
        UserType CreateUserType(UserType entity);
        UserType UpdateUserType(UserType entity);
        UserType DeleteUserType(UserType entity);

    }
}
