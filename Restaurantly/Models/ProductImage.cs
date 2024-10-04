namespace Restaurantly.Models
{
    // Models/ProductImage.cs
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }

        public Product Product { get; set; }
    }
}
