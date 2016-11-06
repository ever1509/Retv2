using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Retv2.API.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {

        }
        public CategoryViewModel(Category entity)
        {
            CategoryName = entity.CategoryName;
            CategoryStatus = entity.CategoryStatus;
        }        
        public String CategoryName { get; set; }
        public String CategoryStatus { get; set; }
    }
}