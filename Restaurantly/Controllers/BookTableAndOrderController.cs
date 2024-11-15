using Microsoft.AspNetCore.Mvc;
using Restaurantly.Models;
using Restaurantly.ViewModels;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Restaurantly.Controllers
{
    [Route("book-table")]
    public class BookTableAndOrderController : Controller
    {
        private readonly RestaurantlyDbContext _context;

        public BookTableAndOrderController(RestaurantlyDbContext context)
        {
            _context = context;
        }

        // GET: /book-table
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = new BookTableViewModel();
            return View(model);
        }

        // POST: /book-table
        [HttpPost("")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(BookTableViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Get customer ID from claims
                var customerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(customerIdClaim))
                {
                    TempData["ErrorMessage"] = "Vui lòng hãy đăng nhập để thực hiện. Nếu chưa có tài khoản bạn hãy đăng ký!.";
                    return View(model);
                }

                // Set CustomerId from claim
                model.CustomerId = int.Parse(customerIdClaim);

                // Get the selected product
                var product = _context.Products.FirstOrDefault(p => p.Id == model.ProductId);
                if (product == null)
                {
                    ModelState.AddModelError(string.Empty, "Product không tìm thấy.");
                    return View(model);
                }

                // Create reservation object
                var reservation = new Reservation
                {
                    CustomerId = model.CustomerId,
                    FullName = model.FullName,
                    Email = model.Email,
                    Phone = model.Phone,
                    NumberOfGuests = model.NumberOfGuests,
                    ReservationDate = model.ReservationDate,
                    ReservationTime = model.ReservationTime,
                    Message = model.Message,
                    TableId = model.TableId,
                    ProductId = model.ProductId,
                    IsConfirmed = false,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now
                };

                // Add reservation to database
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                // Create the order
                var order = new Order
                {
                    CustomerId = model.CustomerId,
                    Total = product.Price * model.NumberOfGuests,  // Calculate total
                    Status = false,
                    PaymentStatus = false,
                    DateAdded = DateTime.Now,
                    ReservationId = reservation.Id,
                    DateModified = DateTime.Now
                };

                // Add the order to the database
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                // Create the OrderItem
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = model.ProductId,
                    Quantity = model.NumberOfGuests,
                    Price = product.Price,
                    CustomerId = model.CustomerId,
                    ReservationId = reservation.Id
                };

                // Add the OrderItem to the database
                _context.OrderItems.Add(orderItem);
                await _context.SaveChangesAsync();

                // Success message
                TempData["SuccessMessage"] = "Đặt bàn và đơn hàng của bạn đã được tạo thành công!";
                return RedirectToAction("Index");
            }

            // Return the view with validation errors if model is not valid
            return View(model);
        }
    }
}
