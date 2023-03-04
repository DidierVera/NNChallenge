using System;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using NNChallenge.Droid.Helpers;

namespace NNChallenge.Droid.ViewHolders
{
    public class HourViewHolder : RecyclerView.ViewHolder
    {
        private readonly TextView _lblWeather;
        private readonly TextView _lblTime;
        private readonly TextView _lblDate;
        private readonly TextView _lblYear;
        private readonly ImageView _imgWeather;

        public HourViewHolder(View itemView) : base(itemView)
        {
            _lblWeather = itemView.FindViewById<TextView>(Resource.Id.lb_weather);
            _lblTime = itemView.FindViewById<TextView>(Resource.Id.lbl_time);
            _lblDate = itemView.FindViewById<TextView>(Resource.Id.lbl_date);
            _lblYear = itemView.FindViewById<TextView>(Resource.Id.lbl_year);
            _imgWeather = itemView.FindViewById<ImageView>(Resource.Id.img_weather);
        }

        public void Bind(string weather, string imageUrl, DateTime time)
        {
            _lblWeather.Text = weather;
            _lblDate.Text = time.ToString("MMM dd");
            _lblYear.Text = time.Year.ToString();
            _lblTime.Text = time.ToString("hh:mm tt");

            //Set image from url
            var imageBitmap = LoadImageHelper.GetImageBitmapFromUrl(imageUrl);
            _imgWeather.SetImageBitmap(imageBitmap);
        }

    }
}
