using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurantly.Models
{
    // Models/BannerImage.cs
    public class BannerImage
    {
        [Key] // Đánh dấu Id là khóa chính
        public int Id { get; set; }

        public string Image { get; set; }
        public string Link { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
    }
}
