using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFHelloWorld.Model;

namespace XFHelloWorld.Pages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var greetingPage = new MainPage(new People());
            var greetingNavigationPage = new NavigationPage(greetingPage);
            greetingNavigationPage.Title = "People";

            var otherPage = new OtherPage();
            var otherNavigationPage = new NavigationPage(otherPage);
            otherNavigationPage.Title = "Other";

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(greetingNavigationPage);
            tabbedPage.Children.Add(otherNavigationPage);

            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
