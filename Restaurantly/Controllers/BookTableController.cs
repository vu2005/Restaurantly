using Microsoft.AspNetCore.Mvc;

namespace Restaurantly.Controllers
{
    [Route("book-table")]
    public class BookTableController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
