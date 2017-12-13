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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFHelloWorld.Droid.Renderers;
using XFHelloWorld.Pages;

[assembly: ExportRenderer(typeof(EntryWithBorder), typeof(EntryWithBorderRenderer))]

namespace XFHelloWorld.Droid.Renderers
{
    public class EntryWithBorderRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                var nativeEditText = (global::Android.Widget.EditText) this.Control;
                nativeEditText.SetBackgroundResource(Resource.Drawable.Box);
            }
        }
    }
}