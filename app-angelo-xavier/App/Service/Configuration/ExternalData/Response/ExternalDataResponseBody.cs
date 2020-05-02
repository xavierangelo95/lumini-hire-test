using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{
    public class ExternalDataServiceHit
    {
        [JsonProperty("total")]
        public ExternalDataResponseTotalBody Total { get; set; }

        [JsonProperty("max_score")]
        public string MaxScore { get; set; }

        [JsonProperty("hits")]
        public List<ExternalDataResponseBodyHits> Hits { get; set; }
    }
}