using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<StudentCourse> StudentCourses { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentCourseDB;Trusted_Connection=true");
        //        optionsBuilder.UseLazyLoadingProxies();
        //    }
        //}
    }
}
