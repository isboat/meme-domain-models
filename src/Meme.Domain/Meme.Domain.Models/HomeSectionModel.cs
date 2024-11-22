namespace Meme.Domain.Models
{
    public class HomeSectionModel
    {
        public string? Title { get; set; }

        public string? Tagline { get; set; }

        public string? Description { get; set; }

        public string? ImgUrl { get; set; }

        public Dictionary<string, string>? Metadata { get; set; }
    }
}
