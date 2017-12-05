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

			// Get our button from the layout resource,
			// and attach an event to it
		    var nameEditText = this.FindViewById<EditText>(Resource.Id.nameEditText);
		    var greetingButton = this.FindViewById<Button> (Resource.Id.greetingButton);
		    var greetingTextView = this.FindViewById<TextView>(Resource.Id.greetingTextView);
		    var nameListButton = this.FindViewById<Button>(Resource.Id.nameListButton);

		    greetingButton.Click += (object sender, EventArgs e) =>
		    {
		        var manager = (InputMethodManager)this.GetSystemService(InputMethodService);
		        manager.HideSoftInputFromWindow(nameEditText.WindowToken, 0);
		        greetingTextView.Text = "Hello " + nameEditText.Text;
                People.Persons.Add(new Person()
                {
                    Name = nameEditText.Text
                });
		    };

		    nameListButton.Click += (sender, args) =>
		    {
		        var intent = new Intent(this, typeof(NameListActivity));
		        intent.PutExtra("personList", JsonConvert.SerializeObject(People.Persons));
                this.StartActivity(intent);
		    };

		}
	}
}


