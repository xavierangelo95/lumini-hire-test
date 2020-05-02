using Newtonsoft.Json;

namespace Service.Configuration
{
    public class ExternalDataResponseShards
    {
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonProperty("successful")]
        public string Successful { get; set; }
        [JsonProperty("skipped")]
        public string Skipped { get; set; }
        [JsonProperty("failed")]
        public string Failed { get; set; }
    }
}


