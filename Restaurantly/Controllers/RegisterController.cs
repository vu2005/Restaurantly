using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("register")]
    public class RegisterController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
