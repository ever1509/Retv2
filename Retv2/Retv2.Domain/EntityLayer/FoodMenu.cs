using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{
    [Table("FoodMenu")]
    public class FoodMenu
    {
        public FoodMenu()
        {

        }
        public FoodMenu(Int32? foodmenu)
        {
            FoodMenuID = foodmenu;
        }
        public Int32? FoodMenuID { get; set; }
        public Int32? CategoryID { get; set; }
        public String FoodName { get; set; }
        public String Description { get; set; }
        public Decimal? UnitPrice { get; set; }
        public String FoodNameStatus { get; set; }

        public virtual Category fkCategories { get; set; }

        public Collection<SaleControl> SaleControl { get; set; }
    }
}
