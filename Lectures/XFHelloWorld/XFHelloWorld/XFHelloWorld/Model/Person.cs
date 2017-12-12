using Xamarin.Forms;

namespace XFHelloWorld.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string ImageName { get; set; }
        public ImageSource ImageSource => ImageSource.FromResource("XFHelloWorld.Images." + this.ImageName + ".png");
    }
}
