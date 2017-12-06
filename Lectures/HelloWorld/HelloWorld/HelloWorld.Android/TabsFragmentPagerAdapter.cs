using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace HelloWorld.Droid
{
    public class TabsFragmentPagerAdapter : FragmentPagerAdapter
    {

        private readonly Fragment[] _fragments;
        private readonly ICharSequence[] _titles;

        public TabsFragmentPagerAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles) : base(fm)
        {
            this._fragments = fragments;
            this._titles = titles;
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return this._titles[position];
        }

        public override Fragment GetItem(int position)
        {
            return this._fragments[position];
        }
   
        public override int Count => this._fragments.Length;
       
    }    
}