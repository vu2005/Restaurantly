using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    public class SignOutController : Controller
    {
        [Route("sign-out")]
        [HttpGet] // Thay đổi thành HttpGet
        public async Task<IActionResult> Logout()
        {
            // Đăng xuất người dùng
            await HttpContext.SignOutAsync();

            // Chuyển hướng về Index của HomeController
            return RedirectToAction("Index", "Home");
        }
    }
}
