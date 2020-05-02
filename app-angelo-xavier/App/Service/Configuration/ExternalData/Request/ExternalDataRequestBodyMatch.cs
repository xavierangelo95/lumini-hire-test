using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{
    /// <summary>
    /// Objeto de consulta para consulta em Elastic Search 
    /// </summary>
    public class ExternalDataRequestBodyMatch
    {
        [JsonProperty("query")]
        public string Query { get; set; }
        [JsonProperty("fields")]
        public string[] Fields { get; set; }
        [JsonProperty("lenient")]
        public bool Lenient { get; set; }
    }
}
