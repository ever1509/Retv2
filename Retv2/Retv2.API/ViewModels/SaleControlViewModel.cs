using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class SaleControlViewModel
    {
        public SaleControlViewModel()
        {

        }
        public SaleControlViewModel(SaleControl entity)
        {
            SaleControlID = entity.SaleControlID;
            FoodMenuID = entity.FoodMenuID;
            OrderID = entity.OrderID;
            Quantity = entity.Quantity;
            StatusService = entity.StatusService;
        }
        public Int32? SaleControlID { get; set; }
        public Int32? FoodMenuID { get; set; }
        public Int32? OrderID { get; set; }
        public Int16? Quantity { get; set; }
        public String StatusService { get; set; }
    }
}