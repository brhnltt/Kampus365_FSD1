using Microsoft.EntityFrameworkCore;

namespace WinFormsApp_EF_Ders3_Part2.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UserAddressDB;Trusted_Connection=True;");
            }
        }
    }
}
