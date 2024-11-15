using System;

namespace Restaurantly.Models
{
    public class BookTable
    {
        public int Id { get; set; }

        // Customer Information
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Reservation Details
        public int NumberOfGuests { get; set; }
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        public string Message { get; set; }

        // Status of the reservation
        public bool IsConfirmed { get; set; }
        public DateTime DateAdded { get; set; }
        public int TableId { get; internal set; }
    }
}
