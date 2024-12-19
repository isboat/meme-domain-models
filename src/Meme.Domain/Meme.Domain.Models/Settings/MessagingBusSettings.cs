using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme.Domain.Models.Settings
{
    public class MessagingBusSettings
    {
        public string? ConnectionString { get; set; }

        public string? QueueName { get; set; }
    }
}
