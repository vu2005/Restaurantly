namespace Restaurantly.Models
{
    // Models/Product.cs
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Image { get; set; } // Add this line to keep a single image field
        public bool Featured { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public Category Category { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; } // Assuming you want to load images for the product

    }



}
