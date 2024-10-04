namespace Restaurantly.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<CategoryPath> CategoryPaths { get; set; }
    }

}
