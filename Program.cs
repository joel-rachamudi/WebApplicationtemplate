using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationtemplate.Areas.Identity.Data;
using Newtonsoft.Json;
using WebApplicationtemplate.Controllers;
using WebApplicationtemplate.Context;
using WebApplicationtemplate.Services;

namespace WebApplicationtemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'WebApplicationtemplateContextConnection' not found.");
            builder.Services.AddScoped<IUserDataService, UserDataService>();
            builder.Services.AddDbContext<Data.WebApplicationtemplateContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddDbContext<UserProductContext>();
            builder.Services.AddDefaultIdentity<WebApplicationtemplateUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Data.WebApplicationtemplateContext>();

            // Add services to the container.connectionString
            builder.Services.AddControllersWithViews();
            //builder.Services.AddIdentity
            builder.Services.AddRazorPages();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.MapRazorPages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            
            




            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();


        }
    }
}