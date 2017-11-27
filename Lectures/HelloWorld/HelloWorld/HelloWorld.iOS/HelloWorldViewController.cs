using System;
using CoreGraphics;
using UIKit;

namespace HelloWorld.iOS
{
    public partial class HelloWorldViewController : UIViewController
    {
        private const double StartX = 20;

        public HelloWorldViewController() : base("HelloWorldViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;

            var promptLabel = new UILabel()
            {
                Frame = new CGRect(StartX, 80, this.View.Bounds.Width, 50),
                Text = "Enter your name: "
            };

            this.View.AddSubview(promptLabel);

            var nameField = new UITextField()
            {
                Frame = new CGRect(StartX, 130, this.View.Bounds.Width, 50),
                BorderStyle = UITextBorderStyle.RoundedRect
            };

            this.View.AddSubview(nameField);

            var greetingButton = UIButton.FromType(UIButtonType.RoundedRect);
            greetingButton.Frame = new CGRect(StartX, 180, this.View.Bounds.Width / 2, 50);
            greetingButton.SetTitle("Greet me", UIControlState.Normal);

            this.View.AddSubview(greetingButton);

            var greetingLabel = new UILabel()
            {
                Frame = new CGRect(StartX, 230, this.View.Bounds.Width, 50),
                Text = "Hello"
            };
            this.View.AddSubview(greetingLabel);

            greetingButton.TouchUpInside += (sender, args) =>
            {
                nameField.ResignFirstResponder();
                greetingLabel.Text = "Hello " + nameField.Text;
            };
        }
    }
}