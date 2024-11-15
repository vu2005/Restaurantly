using Microsoft.AspNetCore.Authentication.Cookies; // Namespace for authentication
using Microsoft.EntityFrameworkCore;
using Restaurantly.Models;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure the connection string for MySQL
        builder.Services.AddDbContext<RestaurantlyDbContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 26)))); // Adjust version if needed

        // Configure authentication services
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/login"; // Path to the login page
                options.LogoutPath = "/sign-out"; // Path to the logout page
                options.AccessDeniedPath = "/access-denied"; // Path for access denied
            });

        // Register services for MVC
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Show errors in development mode
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Redirect to error page if an error occurs
            app.UseHsts(); // Use HSTS
        }

        app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
        app.UseStaticFiles(); // Enable serving static files like CSS, JavaScript, images
        app.UseRouting(); // Enable routing

        // Use authentication and authorization
        app.UseAuthentication();
        app.UseAuthorization();

        // Define default route for controllers
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run(); // Run the application
    }
}
