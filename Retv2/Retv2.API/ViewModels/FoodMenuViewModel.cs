using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class FoodMenuViewModel
    {
        public FoodMenuViewModel()
        {

        }
        public FoodMenuViewModel(FoodMenu entity)
        {
            FoodName = entity.FoodName;
            Description = entity.Description;
            UnitPrice = entity.UnitPrice;
            FoodNameStatus = entity.FoodNameStatus;
        }       
        public String FoodName { get; set; }
        public String Description { get; set; }
        public Decimal? UnitPrice { get; set; }
        public String FoodNameStatus { get; set; }
    }
}