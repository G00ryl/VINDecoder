using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIN.Models
{
    public class Message
    {
      
            [JsonProperty("code")]
            public long Code { get; set; }

            [JsonProperty("message")]
            public string MessageMessage { get; set; }

            [JsonProperty("credentials")]
            public string Credentials { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("endpoint")]
            public string Endpoint { get; set; }

            [JsonProperty("counter")]
            public long Counter { get; set; }
     
    }
}
