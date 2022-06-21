using WebApplication1.Helpers;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            builder.Services.AddScoped<IDapperHelper, DapperHelper>();
            builder.Services.AddSession(opts =>
            {
                opts.Cookie.Name = "sample.identity.app.session";
                opts.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            //builder.Services.AddScoped<IDapperHelper>(opts =>
            //{
            //    string connStr = builder.Configuration["ConnectionStrings:DefaultConnection"];
            //    return new DapperHelper(connStr);
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}