using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer.Configurations
{
    public class OrderConfiguration:EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Orders");
            HasKey(o => o.OrderID);
            Property(o => o.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.OrderID).HasColumnType("int").IsRequired();
            Property(o => o.UserID).HasColumnType("int").IsOptional();
            Property(o => o.OrderTime).HasColumnType("datetime").IsOptional();
            //-------------------------------------------------------------------------------------  
            HasOptional(o => o.fkUsers).WithMany(o => o.Order).HasForeignKey(o => o.UserID).WillCascadeOnDelete(false);
        }
    }
}
