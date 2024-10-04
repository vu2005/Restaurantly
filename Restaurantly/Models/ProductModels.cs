namespace Restaurantly.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}
