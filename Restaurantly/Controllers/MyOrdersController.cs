using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    public class MyOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
