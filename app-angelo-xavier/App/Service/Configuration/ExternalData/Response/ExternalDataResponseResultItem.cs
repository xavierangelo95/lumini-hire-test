using Newtonsoft.Json;

namespace Service.Configuration
{
    /// <summary>
    /// Objeto de resposta para consulta em Elastic Search 
    /// </summary>
    public class ExternalDataResponseResultItem
    {
        [JsonProperty("UNITID")]
        public string UNITID { get; set; }
        [JsonProperty("OPEID")]
        public string OPEID { get; set; }
        [JsonProperty("OPEID6")]
        public string OPEID6 { get; set; }
        [JsonProperty("INSTNM")]
        public string INSTNM { get; set; }
        [JsonProperty("CITY")]
        public string CITY { get; set; }
        [JsonProperty("STABBR")]
        public string STABBR { get; set; }
        [JsonProperty("ZIP")]
        public string ZIP { get; set; }
        [JsonProperty("REGION")]
        public string REGION { get; set; }
        [JsonProperty("INEXPFTE")]
        public string INEXPFTE { get; set; }
        [JsonProperty("TUITFTE")]
        public string TUITFTE { get; set; }
        [JsonProperty("PFTFAC")]
        public string PFTFAC { get; set; }
    }
}
