namespace Restaurantly.Models
{
    public class BannerImage
    {
        public int BannerId { get; set; }
        public string? Image { get; set; }
        public string? Link { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
    }

}
