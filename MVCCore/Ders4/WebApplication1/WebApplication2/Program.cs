using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            builder.Services.AddDbContext<DatabaseContext>(opts => {
                if (!opts.IsConfigured)
                {
                    opts.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentCourseDB;Trusted_Connection=true");
                    opts.UseLazyLoadingProxies();
                }
            });


            var app = builder.Build();







            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}