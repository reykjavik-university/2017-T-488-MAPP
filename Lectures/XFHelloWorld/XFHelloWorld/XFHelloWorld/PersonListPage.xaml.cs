using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFHelloWorld.Model;

namespace XFHelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage(People people)
        {
            this.BindingContext = new PersonListViewModel(this.Navigation, people.Persons);
            InitializeComponent();
        }
    }
}