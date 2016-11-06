using Retv2.Domain.DataLayer.Configurations;
using Retv2.Domain.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retv2.Domain.DataLayer
{
    public class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext()
            :base("RestaurantConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        #region Entity Set
        public DbSet<Category> Category { get; set; }
        public DbSet<FoodMenu> FoodMenu { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<SaleControl> SaleControl { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<RestaurantDbContext>(null);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodMenuConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new SaleControlConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
