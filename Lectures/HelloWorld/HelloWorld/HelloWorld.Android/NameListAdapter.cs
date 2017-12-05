using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloWorld.Droid
{
    public class NameListAdapter : BaseAdapter<Person>
    {

        private readonly Activity _context;
        private readonly List<Person> _personList;

        public NameListAdapter(Activity context, List<Person> personList)
        {
            this._context = context;
            this._personList = personList;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView; // re--use an existing view, if one is available

            if (view == null)
                view = this._context.LayoutInflater.Inflate(Resource.Layout.NameListItem, null);

            var person = this._personList[position];
            view.FindViewById<TextView>(Resource.Id.name).Text = person.Name;
            view.FindViewById<TextView>(Resource.Id.year).Text = person.BirthYear.ToString();
            var resourceId =
                this._context.Resources.GetIdentifier(person.ImageName, "drawable", this._context.PackageName);
            view.FindViewById<ImageView>(Resource.Id.picture).SetBackgroundResource(resourceId);
            return view;
        }

        //Fill in cound here, currently 0
        public override int Count => this._personList.Count;

        public override Person this[int position] => this._personList[position];
    }
}