namespace Restaurantly.Models
{
    // Models/ProductImage.cs
    public class ProductImages
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Images { get; set; } // Comma-separated string of image filenames
        public int SortOrder { get; set; }

        public Product Product { get; set; }
    }
}
