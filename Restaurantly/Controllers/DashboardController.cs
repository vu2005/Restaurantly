using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("dash-board")]
    public class DashboardController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
