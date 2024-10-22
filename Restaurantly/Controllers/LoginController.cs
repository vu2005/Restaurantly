using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.ViewModels;
using Restaurantly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Restaurantly.Controllers
{
    public class LoginController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public LoginController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Xóa khoảng trắng email và mật khẩu
                var email = model.Email.Trim().ToLower(); // Chuyển email về chữ thường
                var password = model.Password.Trim();

                // Tìm khách hàng theo email (chuyển email về chữ thường)
                var customer = _context.Customers
                    .FirstOrDefault(c => c.Email.ToLower() == email);

                if (customer != null)
                {
                    // Kiểm tra mật khẩu
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, customer.Password);

                    if (isPasswordValid)
                    {
                        // Đăng nhập thành công
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, customer.Email),
                            new Claim("FullName", customer.FullName)
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var authProperties = new AuthenticationProperties
                        {
                            IsPersistent = model.RememberMe // Lưu trạng thái đăng nhập
                        };

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity), authProperties);

                        // Chuyển hướng sau khi đăng nhập thành công
                        return RedirectToAction("Index", "Home");
                    }

                    ModelState.AddModelError(string.Empty, "Mật khẩu không chính xác."); // Mật khẩu không đúng
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Email không tồn tại."); // Email không tìm thấy
                }
            }

            return View(model);
        }
    }
}
