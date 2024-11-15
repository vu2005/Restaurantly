using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using System;
using System.Threading.Tasks;

namespace Restaurantly.Controllers
{
    public class BookTableController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public BookTableController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(BookTable bookTable)
        {
            if (ModelState.IsValid)
            {
                // Set additional properties
                bookTable.IsConfirmed = false; // You can set this based on your logic
                bookTable.DateAdded = DateTime.Now;

                // Save the booking information to the database
                _context.BookTables.Add(bookTable);
                await _context.SaveChangesAsync();

                // Redirect to the Home page after successful booking
                return RedirectToAction("Index", "Home");
            }

            // If model state is invalid, return the same view with the current model data
            return View(bookTable);
        }
    }
}
