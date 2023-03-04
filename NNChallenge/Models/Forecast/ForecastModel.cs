using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NNChallenge.Models.Forecast
{
    public class ForecastModel
    {
        [JsonProperty("forecastday")]
        public List<ForecastdayModel> Forecastday { get; set; }

    }
}
