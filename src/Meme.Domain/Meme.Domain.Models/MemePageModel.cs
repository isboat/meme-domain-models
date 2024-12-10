namespace Meme.Domain.Models
{
    public class MemePageModel : IModelItem
    {
        public string? Id { get; set; }

        public List<string>? OwnerIds { get; set; }

        public string? Name { get; set; }

        public string? ContractAddress { get; set; }

        public string? BuyUrl { get; set; }

        public string? PathUrl { get; set; }

        public AboutSectionModel? About { get; set; }

        public HomeSectionModel? HomeSection { get; set; }

        public DateTime Created { get; set; }

        public PageStatus Status { get; set; }

        public Dictionary<string, string>? Metadata { get; set; }

        public List<PageImageModel> Images { get; set; } = new List<PageImageModel>();
    }


    public class ProfileModel : IModelItem
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? ContractAddress { get; set; }

        public string? BuyUrl { get; set; }

        public string? PathUrl { get; set; }

        public HomeSectionModel? HomeSection { get; set; }

        public DateTime Created { get; set; }

        public PageStatus Status { get; set; }

        public Dictionary<string, string>? Metadata { get; set; }

        public List<PageImageModel> Images { get; set; } = new List<PageImageModel>();
    }
}