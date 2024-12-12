namespace Meme.Domain.Models
{
    public class ProfileModel : IModelItem
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Headline { get; set; }

        public string? Description { get; set; }

        public string? ContractAddress { get; set; }

        public string? BuyUrl { get; set; }

        public DateTime Created { get; set; }

        public PageStatus Status { get; set; }

        public Dictionary<string, string>? Metadata { get; set; }

        public List<PageImageModel> Images { get; set; } = new List<PageImageModel>();
    }
}