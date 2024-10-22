using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using Restaurantly.ViewModels;
using System;
using System.Linq;
using BCrypt.Net; // Ensure BCrypt.Net is included

namespace Restaurantly.Controllers
{
    [Route("reset-password")]
    public class ResetPasswordController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public ResetPasswordController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        // Show the Reset Password Form
        [HttpGet]
        public IActionResult Index(string token, string email)
        {
            // Ensure that the token and email are not null or empty
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError(string.Empty, "Invalid token or email.");
                return View(new ResetPasswordViewModel());
            }

            var model = new ResetPasswordViewModel
            {
                Token = token,
                Email = email
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check if the user exists with the provided email
                var user = _context.Customers.FirstOrDefault(c => c.Email.ToLower() == model.Email.ToLower());

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Email không hợp lệ.");
                    return View(model);
                }

                // Validate the token and check for expiration
                if (user.ResetToken != model.Token || user.ResetTokenExpiry < DateTime.UtcNow)
                {
                    ModelState.AddModelError(string.Empty, "Mã token không hợp lệ hoặc đã hết hạn.");
                    return View(model);
                }

                // Check if the new password and confirm password match
                if (model.NewPassword != model.ConfirmPassword)
                {
                    ModelState.AddModelError(string.Empty, "Mật khẩu và xác nhận mật khẩu không khớp.");
                    return View(model);
                }

                // Hash the new password
                user.Password = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);

                // Clear the reset token and expiry
                user.ResetToken = null;
                user.ResetTokenExpiry = null;

                // Save changes to the database
                _context.SaveChanges();

                ViewBag.Message = "Mật khẩu của bạn đã được đặt lại thành công.";
                // Redirect to the login page after successful reset
                return RedirectToAction("Index", "Login");
            }

            // If model is invalid, display errors
            return View(model);
        }
    }
}
