using Newtonsoft.Json;

namespace Service.Configuration
{
    public class ExternalDataResponseTotalBody
    {
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("relation")]
        public string Relation { get; set; }
    }
}

