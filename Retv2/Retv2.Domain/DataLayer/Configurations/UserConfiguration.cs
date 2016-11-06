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
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasKey(u => u.UserID);
            Property(u => u.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.UserID).HasColumnType("int").IsRequired();
            Property(u => u.UserTypeID).HasColumnType("int").IsOptional();
            Property(u => u.UserName).HasColumnType("varchar").HasMaxLength(25).IsOptional();
            Property(u => u.NickName).HasColumnType("varchar").HasMaxLength(10).IsOptional();
            Property(u => u.Password).HasColumnType("varchar").HasMaxLength(2000).IsOptional();
            Property(u => u.TableStatus).HasColumnType("varchar").HasMaxLength(1).IsOptional();
            Property(u => u.UserStatus).HasColumnType("varchar").HasMaxLength(1).IsOptional();
            Property(u => u.MaximumPerson).HasColumnType("smallint").IsOptional();
            //-------------------------------------------------------------------------------------           
            HasOptional(u => u.fkUserTypes).WithMany(u => u.User).HasForeignKey(u => u.UserTypeID).WillCascadeOnDelete(false);
        }
    }
}
