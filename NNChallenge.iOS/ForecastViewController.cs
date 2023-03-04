﻿using System;
using System.Collections.Generic;
using NNChallenge.Constants;
using NNChallenge.Interfaces;
using NNChallenge.iOS.ViewModel;
using NNChallenge.Presenter;
using UIKit;

namespace NNChallenge.iOS
{
    public partial class ForecastViewController : UIViewController, IUpdateView
    {
        private ForecastPresenter _presenter;
        UITableView _tableView;
        public int CitySelected { get; set; }

        public ForecastViewController() : base("ForecastViewController", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Forecast";
            // Perform any additional setup after loading the view, typically from a nib.

            //create tableview and added to view parent
            _tableView = new UITableView(View.Bounds);
            _tableView.RegisterNibForCellReuse(UINib.FromName("HourViewCell", null), "HourViewCell");
            this.View.AddSubview(_tableView);

            var city = LocationConstants.LOCATIONS[CitySelected];

            //call service
            _presenter = new ForecastPresenter(this);
            await _presenter.GetForecastByCity(city);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //result service request
        public void UpdateView()
        {
            Title = _presenter.City;
            _tableView.Source = new ForecastDataSource(_presenter.HourForecast);

            _tableView.ReloadData();
        }
    }
}

