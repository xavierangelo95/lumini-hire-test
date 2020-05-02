using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{
    /// <summary>
    /// Objeto de consulta para consulta em Elastic Search 
    /// </summary>
    public class ExternalDataRequestHeader
    {
        [JsonProperty("_source")]
        public string[] Source { get; set; }

        [JsonProperty("query")]
        public ExternalDataRequestBody Query { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }

    }
}
