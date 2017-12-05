using Android.App;
using Android.OS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HelloWorld.Droid
{
    [Activity(Label = "Name list", Theme = "@style/MyTheme")]
    public class NameListActivity : ListActivity
    {
        private List<Person> _personList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            var jsonStr = this.Intent.GetStringExtra("personList");
            this._personList = JsonConvert.DeserializeObject<List<Person>>(jsonStr);

            this.ListView.ItemClick += (sender, args) =>
            {
                this.ShowAlert(args.Position);
            };

            this.ListAdapter = new NameListAdapter(this, this._personList);
        }

        private void ShowAlert(int position)
        {
            var person = this._personList[position];
            var alertBuilder = new AlertDialog.Builder(this);
            alertBuilder.SetTitle("Person selected");
            alertBuilder.SetMessage(person.Name);
            alertBuilder.SetCancelable(true);
            alertBuilder.SetPositiveButton("OK", (e, args) => { });
            var dialog = alertBuilder.Create();
            dialog.Show();
        }
    }
}