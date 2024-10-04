using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
