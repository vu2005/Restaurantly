using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using System;
using System.Threading.Tasks;

namespace Restaurantly.Controllers
{
    public class ContactController : Controller
    {
        private readonly RestaurantlyDbContext _context;


        public ContactController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Set the DateAdded to the current timestamp and DateModified to null
                contact.DateAdded = DateTime.Now;
                contact.DateModified = null; // No modification on initial create

                // Add the contact to the database
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                // Display success message and redirect to home
                ViewBag.Message = "Your message has been sent. Thank you!";
                return RedirectToAction("Index", "Home");
            }

            return View(contact);
        }
    }
}

