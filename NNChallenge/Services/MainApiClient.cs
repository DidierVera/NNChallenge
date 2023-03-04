using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NNChallenge.Services
{
    public class MainApiClient
    {
        //Example: http://api.weatherapi.com/v1/forecast.json?key=898147f83a734b7dbaa95705211612&q=Berlin&days=3&aqi=no&alerts=no
        private string BaseUrl = "http://api.weatherapi.com/v1/forecast.json?key=898147f83a734b7dbaa95705211612&q={0}&days=3&aqi=no&alerts=no";
        private readonly HttpClient _client;

        public MainApiClient()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }

        public async Task<T> GetAsync<T>(string queryString)
        {
            string relativeUrl = string.Format(BaseUrl, queryString);

            HttpResponseMessage response = await _client.GetAsync(relativeUrl);
            var result = CastResponseAsync(response);
            return JsonConvert.DeserializeObject<T>(result);
        }

        private string CastResponseAsync(HttpResponseMessage response)
        {
            string responseString = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return responseString;
            }
            else
            {
                return null;
            }
        }
    }
}
