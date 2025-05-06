using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.api
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(ApiConfig.BaseUrl)
            };

            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void AddAuthorizationHeader()
        {
            if (!string.IsNullOrEmpty(ApiConfig.Token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", ApiConfig.Token);
            }
        }

        public async Task<ApiResponse<T>> SendRequestAsync<T>(string endpoint, HttpMethod method, object data = null, bool authorized = false)
        {
            if (authorized)
                AddAuthorizationHeader();

            HttpRequestMessage request = new HttpRequestMessage(method, endpoint);

            if (data != null && method != HttpMethod.Get && method != HttpMethod.Delete)
            {
                string json = JsonConvert.SerializeObject(data);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            HttpResponseMessage response = await _client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResponse<T>>(responseBody);
        }
    }
}
