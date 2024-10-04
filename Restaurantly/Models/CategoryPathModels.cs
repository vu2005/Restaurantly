namespace Restaurantly.Models
{
    public class CategoryPath
    {
        public int CategoryId { get; set; }
        public int PathId { get; set; }
        public int Level { get; set; }

        public Category Category { get; set; }
    }

}
