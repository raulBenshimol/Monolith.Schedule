using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Monolith.Schedule.Data;
using Monolith.Schedule.Models;
namespace Monolith.Schedule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MyDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
            
            builder.Services.AddDbContext<MyIdentityDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("MonolithScheduleContext")));

            builder.Services.AddDefaultIdentity<MyUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<MyIdentityDbContext>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication(); // puse esto para el MyUser
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
