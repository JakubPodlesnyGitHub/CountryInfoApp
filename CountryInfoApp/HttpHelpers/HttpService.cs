using System.Text.Json;

namespace CountryInfoApp.HttpHelpers
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions _serializerOptions => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        private string _mediaType = "application/json";

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpWrapper<T>> GetAsync<T>(string URL)
        {
            var responseHttp = await _httpClient.GetAsync(URL);
            var response = await Deserialize<T>(
                httpResponse: responseHttp,
                options: _serializerOptions);
            return new HttpWrapper<T>(responseHttp.IsSuccessStatusCode, response, responseHttp);
        }
        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(responseString))
            {
                return default;
            }
            return JsonSerializer.Deserialize<T>(responseString, options);
        }
    }
}
