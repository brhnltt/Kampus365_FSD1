namespace WinFormsApp_EF_Ders2_Part2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinFormsApp_EF_Ders2_Part2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormsApp_EF_Ders2_Part2.Models.MyShopEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = false;

            ContextKey = "WinFormsApp_EF_Ders2_Part2.Models.MyShopEntities";
        }

        protected override void Seed(WinFormsApp_EF_Ders2_Part2.Models.MyShopEntities db)
        {
            if (db.Employees.Any() == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    Employee employee = new Employee
                    {
                        FullName = $"Employee-{i}"
                    };

                    db.Employees.Add(employee);
                }

                db.SaveChanges();
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
