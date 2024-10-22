using Microsoft.AspNetCore.Mvc;
using Restaurantly.ViewModels;
using Restaurantly.Models;
using System;
using System.Linq;

namespace Restaurantly.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public RegisterController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem email đã tồn tại
                var existingCustomer = _context.Customers
                    .FirstOrDefault(c => c.Email.ToLower() == model.Email.ToLower());

                if (existingCustomer != null)
                {
                    ModelState.AddModelError(string.Empty, "Email đã tồn tại.");
                    return View(model);
                }

                // Tạo một khách hàng mới với mật khẩu đã băm
                var customer = new Customer
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    Phone = model.Phone,
                    Password = BCrypt.Net.BCrypt.HashPassword(model.Password), // Băm mật khẩu
                    Status = true,
                    DateAdded = DateTime.Now,
                    ResetToken = null // ResetToken được đặt là null
                };

                // Lưu khách hàng mới vào cơ sở dữ liệu
                _context.Customers.Add(customer);
                _context.SaveChanges();

                // Chuyển hướng đến trang đăng nhập
                return RedirectToAction("Index", "Login");
            }

            return View(model);
        }
    }
}
