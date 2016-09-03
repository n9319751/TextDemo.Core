using System;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace ScreenshotDemo.Droid.Views
{
    [Activity(Label = "View for ScanmenuViewModel")]
    public class FirstView : MvxActivity
    {
        
	

		protected override void OnCreate(Bundle bundle)
		  {
		    base.OnCreate(bundle);
	       SetContentView(Resource.Layout.ScanmenuView);
		   }
	}
}
