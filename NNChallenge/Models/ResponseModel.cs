using Newtonsoft.Json;
using NNChallenge.Models.Forecast;

namespace NNChallenge.Models
{
    public class ResponseModel
    {

        [JsonProperty("location")]
        public LocationModel Location { get; set; }

        [JsonProperty("current")]
        public CurrentModel Current { get; set; }

        [JsonProperty("forecast")]
        public ForecastModel Forecast { get; set; }
    }
}
