using WebApplication1.Business;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Dependency Injection
            // IoC = Inversion of Control
            builder.Services.AddScoped<INotification, FaxNotification>();
            //builder.Services.AddSingleton<INotification, FaxNotification>();
            //builder.Services.AddTransient<INotification, FaxNotification>();
            //builder.Services.AddScoped<MultiNotificator, MultiNotificator>();


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