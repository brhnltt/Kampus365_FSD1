using Microsoft.EntityFrameworkCore;

namespace EF_RentACarOrnegi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Renting> Rentings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RentACarDB;Trusted_Connection=True;");
            }
        }
    }
}
