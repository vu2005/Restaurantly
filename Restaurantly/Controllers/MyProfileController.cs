using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("my-profile")]
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
