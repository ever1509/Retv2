using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{

    [Table("SaleControl")]
    public class SaleControl
    {
        public SaleControl()
        {

        }
        public SaleControl(Int32? salecontrol)
        {
            SaleControlID = salecontrol;
        }
        public Int32? SaleControlID { get; set; }
        public Int32? FoodMenuID { get; set; }
        public Int32? OrderID { get; set; }
        public Int16? Quantity { get; set; }
        public String StatusService { get; set; }

        public virtual FoodMenu fkFoodMenus { get; set; }
        public virtual Order fkOrders { get; set; }
    }
}
