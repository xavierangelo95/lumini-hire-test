using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Service.Configuration;
using Service.Configuration.ExternalData.Config;
using Service.Helpers;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public static class HttpRequestExternalDataHelper
    {
        public static async Task<T> GetRequestExternalData<T>(ExternalDataRequestHeader request)
        {
            try
            {
                ConfigHelper.TryGet<ExternalDataConfig>("ExternalDataConfig", out var config);

                if (config == null)
                    throw new ArgumentException($"{nameof(HttpRequestExternalDataHelper)} - Erro ao obter configurações {nameof(ExternalDataConfig)}");

                var requestBody = JsonConvert.SerializeObject(request);

                using (var client = new HttpClient())
                {
                    var requestHttp = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(config.Url),
                        Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
                    };

                    client
                        .DefaultRequestHeaders
                            .Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.Default.GetBytes(config.Autentication))}");

                    var response = await client.SendAsync(requestHttp).ConfigureAwait(false);

                    if (!response.IsSuccessStatusCode)
                        throw new ArgumentException($"{nameof(HttpRequestExternalDataHelper)} - Erro ao obter a resposta - StatusCode: {response.StatusCode}");

                    response.EnsureSuccessStatusCode();

                    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    return JsonConvert.DeserializeObject<T>(responseBody);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(HttpRequestExternalDataHelper)} - {ex.Message}");
            }
        }
    }
}
