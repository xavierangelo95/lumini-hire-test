using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{
    /// <summary>
    /// Objeto de resposta para consulta em Elastic Search 
    /// </summary>
    public class ExternalDataResponseHeader
    {
        [JsonProperty("took")]
        public string Took { get; set; }
        [JsonProperty("timed_out")]
        public string TimeOut { get; set; }
        [JsonProperty("_shards")]
        public ExternalDataResponseShards Shards { get; set; }
        [JsonProperty("hits")]
        public ExternalDataServiceHit Hit { get; set; }
    }
}
