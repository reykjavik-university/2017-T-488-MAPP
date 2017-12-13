using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFHelloWorld.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyButton : Button
    {
        public MyButton()
        {
            InitializeComponent();
        }
    }
}