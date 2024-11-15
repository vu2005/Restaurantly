namespace Restaurantly.Models
{
    // Models/Reservation.cs
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        public string Message { get; set; }
        public int TableId { get; set; }
        public int ProductId { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;

        // Thuộc tính điều hướng
        public virtual Customer Customer { get; set; }
        public virtual Table Table { get; set; }
        public virtual Product Product { get; set; }
    }


}
