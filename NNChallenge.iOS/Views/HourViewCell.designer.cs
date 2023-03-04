// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NNChallenge.iOS
{
	[Register ("HourViewCell")]
	partial class HourViewCell
	{
		[Outlet]
		UIKit.UIImageView _imgIcon { get; set; }

		[Outlet]
		UIKit.UILabel _lblDate { get; set; }

		[Outlet]
		UIKit.UILabel _lblTime { get; set; }

		[Outlet]
		UIKit.UILabel _lblWeather { get; set; }

		[Outlet]
		UIKit.UILabel _lblYear { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgIcon != null) {
				_imgIcon.Dispose ();
				_imgIcon = null;
			}

			if (_lblTime != null) {
				_lblTime.Dispose ();
				_lblTime = null;
			}

			if (_lblWeather != null) {
				_lblWeather.Dispose ();
				_lblWeather = null;
			}

			if (_lblDate != null) {
				_lblDate.Dispose ();
				_lblDate = null;
			}

			if (_lblYear != null) {
				_lblYear.Dispose ();
				_lblYear = null;
			}
		}
	}
}
