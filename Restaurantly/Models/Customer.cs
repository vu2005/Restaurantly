namespace Restaurantly.Models
{
    // Models/Customer.cs
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetTokenExpiry { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
