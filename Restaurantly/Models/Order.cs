namespace Restaurantly.Models
{
    // Models/Order.cs
    public class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ReservationId { get; set; }
        public decimal Total { get; set; }
        public bool Status { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public Customer Customer { get; set; }
        public Reservation Reservation { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
