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
    public class FoodMenuConfiguration:EntityTypeConfiguration<FoodMenu>
    {
        public FoodMenuConfiguration()
        {
            ToTable("FoodMenu");
            HasKey(fm => fm.FoodMenuID);
            Property(fm => fm.FoodMenuID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(fm => fm.FoodMenuID).HasColumnType("int").IsRequired();
            Property(fm => fm.CategoryID).HasColumnType("int").IsOptional();
            Property(fm => fm.FoodName).HasColumnType("varchar").HasMaxLength(30).IsOptional();
            Property(fm => fm.Description).HasColumnType("varchar").HasMaxLength(75).IsOptional();
            Property(fm => fm.UnitPrice).HasColumnType("money").IsOptional();
            Property(fm => fm.FoodNameStatus).HasColumnType("varchar").HasMaxLength(1).IsOptional();
            //-------------------------------------------------------------------------------------  
            HasOptional(fm => fm.fkCategories).WithMany(fm => fm.FoodMenu).HasForeignKey(fm => fm.CategoryID).WillCascadeOnDelete(false);
        }
    }
}
