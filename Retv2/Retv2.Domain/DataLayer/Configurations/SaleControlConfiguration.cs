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
    public class SaleControlConfiguration:EntityTypeConfiguration<SaleControl>
    {
        public SaleControlConfiguration()
        {
            ToTable("SaleControl");
            HasKey(sc => sc.SaleControlID);
            Property(sc => sc.SaleControlID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(sc => sc.SaleControlID).HasColumnType("int").IsRequired();
            Property(sc => sc.FoodMenuID).HasColumnType("int").IsOptional();
            Property(sc => sc.OrderID).HasColumnType("int").IsOptional();
            Property(sc => sc.Quantity).HasColumnType("smallint").IsOptional();
            Property(sc => sc.StatusService).HasColumnType("varchar").HasMaxLength(1);
            //-------------------------------------------------------------------------------------   
            HasOptional(sc => sc.fkFoodMenus).WithMany(sc => sc.SaleControl).HasForeignKey(sc => sc.FoodMenuID).WillCascadeOnDelete(false);
        }
    }
}
