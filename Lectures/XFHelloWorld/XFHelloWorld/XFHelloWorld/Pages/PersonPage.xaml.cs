using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFHelloWorld.Model;

namespace XFHelloWorld.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {
        public PersonPage(Person person)
        {
            this.BindingContext = person;
            InitializeComponent();
        }
    }
}