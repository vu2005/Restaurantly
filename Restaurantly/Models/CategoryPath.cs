namespace Restaurantly.Models
{
    // Models/CategoryPath.cs
    public class CategoryPath
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int PathId { get; set; }
        public int Level { get; set; }

        public Category Category { get; set; }
    }
}
