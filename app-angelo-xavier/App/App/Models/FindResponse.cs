using Newtonsoft.Json;
using Service.Configuration;
using System.Collections.Generic;

namespace App.Models
{
    public class FindResponse
    {
        [JsonProperty("data")]
        public List<ExternalDataResponseResultItem> Data { get; set; }
    }
}
