namespace Meme.Domain.Models
{
    public class AboutSectionModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? SubTitle { get; set; }

        public string? ImgUrl { get; set; }
        public Dictionary<string, string>? Metadata { get; set; }
    }
}
