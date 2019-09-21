using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalWhatsProc.Models
{
    public class Message
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("messageText")]
        public string MessageText { get; set; }

        [JsonProperty("when")]
        public DateTime When { get; set; }

        [JsonProperty("direction")]
        public Direction Direction { get; set; }

    }
}
