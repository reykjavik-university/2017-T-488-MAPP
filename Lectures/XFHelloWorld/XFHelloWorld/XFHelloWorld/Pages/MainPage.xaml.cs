using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFHelloWorld.Model;

namespace XFHelloWorld.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly People _people;

        public MainPage(People people)
        {
            this._people = people;
            InitializeComponent();
        }

        private void GreetingButton_OnClicked(object sender, EventArgs e)
        {
            this.GreetingLabel.Text = "Hello " + this.NameEntry.Text;
        }

        private async void PersonListButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new PersonListPage(this._people));
        }
    }
}
