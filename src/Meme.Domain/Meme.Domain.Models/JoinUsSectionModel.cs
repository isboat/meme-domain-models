namespace Meme.Domain.Models
{
    public class JoinUsSectionModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? ImgUrl { get; set; }

        public string? Telegram { get; set; }

        public string? Twitter { get; set; }

        public string? DexScreener { get; set; }

        public string? CoinMarketCap { get; set; }

        public string? Dextools { get; set; }

        public Dictionary<string, string>? Metadata { get; set; }
    }
}
