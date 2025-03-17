namespace JamaisASec_Site.Network
{
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Configuration;
    using System.Net;

    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["ApiBaseUrl"])
            };
        }

        public async Task<HttpStatusCode> Ping()
        {
            var response = await _httpClient.GetAsync("/");
            return response.StatusCode;

        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(jsonResponse);
        }

        public async Task<T> PostAsync<T>(string endpoint, object payload)
        {
            var jsonPayload = JsonSerializer.Serialize(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }

        public async Task<bool> PingAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/test");
                response.EnsureSuccessStatusCode(); // Throw if HTTP response is an error
                Console.WriteLine("Code 200");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<T> PutAsync<T>(string endpoint, object payload)
        {
        
            var jsonPayload = JsonSerializer.Serialize(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }
    }

}
