using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {

        }
        public OrderViewModel(Order entity)
        {
            OrderID = entity.OrderID;
            OrderTime = entity.OrderTime;
        }
        public Int32? OrderID { get; set; }
        public DateTime? OrderTime { get; set; }
    }
}