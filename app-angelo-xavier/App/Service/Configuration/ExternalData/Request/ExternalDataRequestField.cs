using Newtonsoft.Json;

namespace Service.Configuration
{
    /// <summary>
    /// Objeto de consulta para consulta em Elastic Search 
    /// </summary>
    public static class ExternalDataRequestField
    {
        [JsonProperty("UNITID")]
        public const string UNITID = "UNITID";
        [JsonProperty("OPEID")]
        public const string OPEID = "OPEID";
        [JsonProperty("OPEID6")]
        public const string OPEID6 = "OPEID6";
        [JsonProperty("INSTNM")]
        public const string INSTNM = "INSTNM";
        [JsonProperty("CITY")]
        public const string CITY = "CITY";
        [JsonProperty("STABBR")]
        public const string STABBR = "STABBR";
        [JsonProperty("ZIP")]
        public const string ZIP = "ZIP";
        [JsonProperty("REGION")]
        public const string REGION = "REGION";
        [JsonProperty("INEXPFTE")]
        public const string INEXPFTE = "INEXPFTE";
        [JsonProperty("TUITFTE")]
        public const string TUITFTE = "TUITFTE";
        [JsonProperty("PFTFAC")]
        public const string PFTFAC = "PFTFAC";
    }
}
