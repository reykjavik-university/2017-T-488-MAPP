using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;

namespace HelloWorld.Droid
{
	[Activity (Label = "HelloWorld.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
		    var nameEditText = this.FindViewById<EditText>(Resource.Id.nameEditText);
		    var greetingButton = this.FindViewById<Button> (Resource.Id.greetingButton);
		    var greetingTextView = this.FindViewById<TextView>(Resource.Id.greetingTextView);

		    greetingButton.Click += (object sender, EventArgs e) =>
		    {
		        var manager = (InputMethodManager)this.GetSystemService(InputMethodService);
		        manager.HideSoftInputFromWindow(nameEditText.WindowToken, 0);
		        greetingTextView.Text = "Hello " + nameEditText.Text;
		    };
        }
	}
}


