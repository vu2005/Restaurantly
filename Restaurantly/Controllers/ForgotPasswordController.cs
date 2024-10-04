using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("forgot-password")]
    public class ForgotPassword : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
