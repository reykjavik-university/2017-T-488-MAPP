using System;
using CoreGraphics;
using UIKit;

namespace HelloWorld.iOS
{
    public class HelloWorldViewController : UIViewController
    {
        private const double StartX = 20;
        private const double StartY = 80;
        private const double Height = 50;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;

            var promptLabel = new UILabel()
            {
                Frame = new CGRect(StartX, StartY, this.View.Bounds.Width-2*StartX, Height),
                Text = "Enter your name: "
            };

            this.View.AddSubview(promptLabel);

            var nameField = new UITextField()
            {
                Frame = new CGRect(StartX, StartY+Height, this.View.Bounds.Width-2*StartX, Height),
                BorderStyle = UITextBorderStyle.RoundedRect
            };

            this.View.AddSubview(nameField);

            var greetingButton = UIButton.FromType(UIButtonType.RoundedRect);
            greetingButton.Frame = new CGRect(StartX, StartY+2*Height, this.View.Bounds.Width-2*StartX, Height);
            greetingButton.SetTitle("Greet me", UIControlState.Normal);

            this.View.AddSubview(greetingButton);

            var greetingLabel = new UILabel()
            {
                Frame = new CGRect(StartX, StartY+3*Height, this.View.Bounds.Width-2*StartX, Height),
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