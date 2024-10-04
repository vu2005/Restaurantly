using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("order-now")]
    public class OrderNowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
