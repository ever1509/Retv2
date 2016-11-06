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
    public class UserTypeConfiguration:EntityTypeConfiguration<UserType>
    {
        public UserTypeConfiguration()
        {
            ToTable("UserType");
            HasKey(ut => ut.UserTypeID);
            Property(ut => ut.UserTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ut => ut.UserTypeID).HasColumnType("int").IsRequired();
            Property(ut => ut.UserTypeName).HasColumnType("varchar").HasMaxLength(30).IsOptional();
            Property(ut => ut.Description).HasColumnType("varchar").HasMaxLength(50).IsOptional();
            

        }
    }
}
