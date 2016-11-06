using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        Int32? CommitChanges();
        ICategoryRepository CategoryRepository { get; }
        IFoodMenuRepository FoodMenuRepository { get; }
        IOrderRepository OrderRepository { get;}
        ISaleControlRepository SaleControlRepository { get; }
        IUserTypeRepository UserTypeRepository { get;}
        IUserRepository UserRepository { get;}

    }
}
