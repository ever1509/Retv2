using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Retv2.Domain.BusinessLayer.Contracts;
using Retv2.Domain.BusinessLayer;
using Retv2.Domain.DataLayer;

namespace Retv2.API.Services
{
    public class BusinessObjectService : IBusinessObjectService
    {
        public IRestaurantBusinessObject GetBusinessObject()
        {
            return new RestaurantBusinessObject(new UnitOfWork(new RestaurantDbContext()));
        }
    }
}