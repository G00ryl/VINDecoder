using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VIN.Models
{
    public class Data
    {
        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("trim")]
        public string Trim { get; set; }

        [JsonProperty("transmission")]
        public string Transmission { get; set; }
    
}
}
