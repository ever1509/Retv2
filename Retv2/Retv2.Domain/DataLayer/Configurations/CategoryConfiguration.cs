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
    public class CategoryConfiguration:EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            HasKey(c => c.CategoryID);
            Property(c => c.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.CategoryID).HasColumnType("int").IsRequired();
            Property(c => c.CategoryName).HasColumnType("varchar").HasMaxLength(25).IsOptional();
            Property(c => c.CategoryStatus).HasColumnType("varchar").HasMaxLength(1).IsOptional();

        }
    }
}
