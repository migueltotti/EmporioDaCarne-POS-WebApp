using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmporioDaCarne_POS.Data;
using EmporioDaCarne_POS.Services;
namespace EmporioDaCarne_POS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<EmporioDaCarne_POSContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EmporioDaCarne_POSContext") ?? throw new InvalidOperationException("Connection string 'EmporioDaCarne_POSContext' not found.")));

            builder.Services.AddScoped<UserService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Users}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
