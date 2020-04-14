using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIN.Models
{
    public class VIN
    {
        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
