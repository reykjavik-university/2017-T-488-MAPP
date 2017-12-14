using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFHelloWorld.ViewModels;

namespace XFHelloWorld.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OtherPage : ContentPage
    {
        public OtherPage()
        {
            this.BindingContext = new OtherViewModel();
            InitializeComponent();
        }
    }
}