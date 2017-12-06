using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;
using Newtonsoft.Json;

namespace HelloWorld.Droid
{
	[Activity (Label = "HelloWorld", Theme="@style/MyTheme")]
	public class MainActivity : Activity
	{
	    public static People People { get; set; }

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

		    var toolbar = this.FindViewById<Toolbar>(Resource.Id.toolbar);
            this.SetActionBar(toolbar);
		    this.ActionBar.Title = "My Toolbar";
		}
	}
}


