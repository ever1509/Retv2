using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.EntityLayer
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {

        }
        public Order(Int32? order)
        {
            OrderID = order;
        }
        public Int32? OrderID { get; set; }
        public Int32? UserID { get; set; }
        public DateTime? OrderTime { get; set; }

        public virtual User fkUsers { get; set; }

        public Collection<SaleControl> SaleControl { get; set; }
    }
}
