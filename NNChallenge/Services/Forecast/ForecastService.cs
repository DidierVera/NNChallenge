using System;
using System.Threading.Tasks;
using NNChallenge.Contracts;
using NNChallenge.Models;

namespace NNChallenge.Services.Forecast
{
    public class ForecastService : IForecastService
    {
        private readonly MainApiClient _client;
        public ForecastService()
        {
            _client = new MainApiClient();
        }

        public async Task<ResponseModel> GetForecastData(string queryString)
        {
            return await _client.GetAsync<ResponseModel>(queryString);
        }
    }
}
