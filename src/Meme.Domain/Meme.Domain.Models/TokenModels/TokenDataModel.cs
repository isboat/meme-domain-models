using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme.Domain.Models.TokenModels
{
    public class TokenDataModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool ShowName { get; set; }
        public string? CreatedOn { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string? Website { get; set; }
        public RawTokenDataModel? RawData { get; set; }
    }
}
