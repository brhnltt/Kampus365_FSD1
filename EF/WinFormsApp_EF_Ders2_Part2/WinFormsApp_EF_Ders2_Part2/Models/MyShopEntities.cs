using My.Data.Annotations;
using System.Data.Entity;
using WinFormsApp_EF_Ders2_Part2.Migrations;

namespace WinFormsApp_EF_Ders2_Part2.Models
{
    public class MyShopEntities : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public MyShopEntities()
        {
            MigrateDatabaseToLatestVersion<MyShopEntities, Configuration> migrate =
                new MigrateDatabaseToLatestVersion<MyShopEntities, Configuration>();

            Database.SetInitializer(migrate);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Precision.ConfigureModelBuilder(modelBuilder);
        }
    }
}
