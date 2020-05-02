using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{
    public class ExternalDataResponseBodyHits
    {
        [JsonProperty("_index")]
        public string Index { get; set; }
        [JsonProperty("_type")]
        public string Type { get; set; }
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("_score")]
        public string Score { get; set; }
        [JsonProperty("_source")]
        public ExternalDataResponseResultItem Source { get; set; }
    }
}

