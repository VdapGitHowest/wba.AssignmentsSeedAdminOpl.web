using Microsoft.EntityFrameworkCore;
using wba.Assignments.web.Controllers;
using wba.Assignments.web.Data;

namespace wba.Assignments.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AssignmentDBContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("AssignmentSeedDB")));


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

            //Custom Routes

            app.MapControllerRoute(
               name: "Details",
               pattern: "Employees/{id:int}",
               defaults: new { controller = "Employees", Action = "Details" });


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}