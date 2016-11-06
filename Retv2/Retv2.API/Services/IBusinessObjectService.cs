using Retv2.Domain.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.API.Services
{
    public interface IBusinessObjectService
    {
        IRestaurantBusinessObject GetBusinessObject();
    }
}
