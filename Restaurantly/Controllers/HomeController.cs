using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using Restaurantly.ViewModels; // Make sure to include the namespace for your ViewModel
using System.Diagnostics;
using System.Linq;

namespace Restaurantly.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly RestaurantlyDbContext _context; // Add this line to access your DB context

		public HomeController(ILogger<HomeController> logger, RestaurantlyDbContext context)
		{
			_logger = logger;
			_context = context; // Initialize the context
		}

		public IActionResult Index()
		{
			// Create a new instance of HomeViewModel
			var model = new HomeViewModel
			{
				Products = _context.Products.ToList(), // Get the list of products from the database
				BookTable = new BookTable(), // Initialize a new BookTable object
				Contact = new Contact() // Initialize a new Contact object
			};

			return View(model); // Pass the ViewModel to the view
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
