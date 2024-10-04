namespace Restaurantly.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int? CustomerId { get; set; }
        public int TableNumber { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime ReservationTime { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
