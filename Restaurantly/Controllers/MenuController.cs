using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Restaurantly.Controllers
{
    public class MenuController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public MenuController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Details(int id, string name)
        {
            // Use Include to fetch related ProductImages
            var product = await _context.Products
    .Include(p => p.ProductImages)
    .FirstOrDefaultAsync(p => p.Id == id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product); // Pass the product to the view
        }
    }
}
