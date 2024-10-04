namespace Restaurantly.Models
{
    public class ProductImage
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }

        public Product Product { get; set; }
    }

}
