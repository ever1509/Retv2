using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {

        }
        public Category(Int32? category)
        {
            CategoryID = category;
        }
        public Int32? CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryStatus { get; set; }

        public Collection<FoodMenu> FoodMenu { get; set; }
    }
}
