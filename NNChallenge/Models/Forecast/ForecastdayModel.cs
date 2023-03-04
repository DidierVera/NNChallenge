using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NNChallenge.Models.Forecast
{
    public class ForecastdayModel
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        public int date_epoch { get; set; }
        public DayModel day { get; set; }
        public AstroModel astro { get; set; }
        [JsonProperty("hour")]
        public List<HourModel> Hours { get; set; }
    }
}
