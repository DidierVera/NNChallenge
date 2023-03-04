using System;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using NNChallenge.Droid.ViewHolders;
using NNChallenge.Interfaces;

namespace NNChallenge.Droid.Adapters
{
    public class WeatherAdapter : RecyclerView.Adapter
    {
        private IHourWeatherForecastVO[] _hourForecast;
        public WeatherAdapter(IHourWeatherForecastVO[] hourForecast)
        {
            _hourForecast = hourForecast;
        }

        public override int ItemCount => _hourForecast.Length;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var item = _hourForecast[position];
            var weather = string.Format("{0}ºC / {1}ºF", item.TeperatureCelcius, item.TeperatureFahrenheit);

            HourViewHolder viewHolder = holder as HourViewHolder;
            viewHolder.Bind(weather, item.ForecastPitureURL, item.Date);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View hoursVw = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.hours_item_view, parent, false);
            return new HourViewHolder(hoursVw);
        }
    }
}
