using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFHelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GreetingButton_OnClicked(object sender, EventArgs e)
        {
            this.GreetingLabel.Text = "Hello " + this.NameEntry.Text;
        }
    }
}
