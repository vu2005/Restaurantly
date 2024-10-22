using Microsoft.AspNetCore.Authentication.Cookies; // Thêm không gian tên cho xác thực
using Microsoft.EntityFrameworkCore;
using Restaurantly.Models;
using System;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Cấu hình chuỗi kết nối với MySQL
        builder.Services.AddDbContext<RestaurantlyDbContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 26)))); // Điều chỉnh phiên bản nếu cần

        // Cấu hình dịch vụ xác thực
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/login"; // Đường dẫn đến trang đăng nhập
                options.LogoutPath = "/sign-out"; // Đường dẫn đến trang đăng xuất
                options.AccessDeniedPath = "/access-denied"; // Đường dẫn cho trang từ chối truy cập
            });

        // Đăng ký dịch vụ Identity
        // builder.Services.AddIdentity<Customer, IdentityRole>() // Đảm bảo Customer là lớp người dùng của bạn
        //     .AddEntityFrameworkStores<RestaurantlyDbContext>()
        //     .AddDefaultTokenProviders();

        // Đăng ký dịch vụ cho MVC
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Cấu hình pipeline xử lý yêu cầu HTTP
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Hiển thị lỗi trong môi trường phát triển
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Chuyển hướng đến trang lỗi nếu có lỗi
            app.UseHsts(); // Sử dụng HSTS
        }

        app.UseHttpsRedirection(); // Chuyển hướng HTTP thành HTTPS
        app.UseStaticFiles(); // Cho phép sử dụng các file tĩnh như CSS, JavaScript, hình ảnh
        app.UseRouting(); // Cho phép định tuyến

        // Sử dụng xác thực và ủy quyền
        app.UseAuthentication();
        app.UseAuthorization();

        // Định nghĩa đường dẫn mặc định cho các controller
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run(); // Chạy ứng dụng
    }
}
