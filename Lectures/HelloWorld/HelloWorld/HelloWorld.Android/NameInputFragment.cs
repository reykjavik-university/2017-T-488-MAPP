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
using Fragment = Android.Support.V4.App.Fragment;

namespace HelloWorld.Droid
{
	[Activity (Label = "HelloWorld", Theme="@style/MyTheme")]
	public class NameInputFragment : Fragment
	{
	    private readonly People _people;

	    public NameInputFragment(People people)
	    {
	        this._people = people;
	    }

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle bundle)
		{
		    var rootView = inflater.Inflate(Resource.Layout.NameInput, container, false);

			// Get our button from the layout resource,
			// and attach an event to it
		    var nameEditText = rootView.FindViewById<EditText>(Resource.Id.nameEditText);
		    var greetingButton = rootView.FindViewById<Button> (Resource.Id.greetingButton);
		    var greetingTextView = rootView.FindViewById<TextView>(Resource.Id.greetingTextView);
		    var nameListButton = rootView.FindViewById<Button>(Resource.Id.nameListButton);

		    greetingButton.Click += (object sender, EventArgs e) =>
		    {
		        var manager = (InputMethodManager)this.Context.GetSystemService(Context.InputMethodService);
		        manager.HideSoftInputFromWindow(nameEditText.WindowToken, 0);
		        greetingTextView.Text = "Hello " + nameEditText.Text;
                this._people.Persons.Add(new Person()
                {
                    Name = nameEditText.Text
                });
		    };

		    nameListButton.Click += (sender, args) =>
		    {
		        var intent = new Intent(this.Context, typeof(NameListActivity));
		        intent.PutExtra("personList", JsonConvert.SerializeObject(this._people.Persons));
                this.StartActivity(intent);
		    };

		    return rootView;
		}
	}
}


