using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Restaurantly.Controllers
{
    [Authorize] // Ensure that only authenticated users can access this
    public class CustomerController : Controller
    {
        public IActionResult Profile()
        {
            // Retrieve the logged-in user's FullName from claims
            var fullName = User.FindFirst("FullName")?.Value;

            // Pass the FullName to the view
            ViewData["FullName"] = fullName;

            return View();
        }
    }
}
