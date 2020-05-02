using Newtonsoft.Json;
using System.Collections.Generic;

namespace Service.Configuration
{  /// <summary>
   /// Objeto de consulta para consulta em Elastic Search 
   /// </summary>
    public class ExternalDataRequestBody
    {
        [JsonProperty("multi_match")]
        public ExternalDataRequestBodyMatch MultiMatch { get; set; }
    
    }
}
