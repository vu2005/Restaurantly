using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("favorite-dish")]
    public class FavoriteDishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
