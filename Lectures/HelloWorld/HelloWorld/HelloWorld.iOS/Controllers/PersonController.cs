using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class PersonController : UIViewController
    {
        private const double StartX = 20;
        private const double StartY = 80;
        private const double Height = 50;

        private List<Person> _personList;

        public PersonController(List<Person> personList)
        {
            this._personList = personList;
            this.TabBarItem = new UITabBarItem(UITabBarSystemItem.Search, 0);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;
            this.Title = "Greeting";

            var promptLabel = PromptLabel();
            var nameField = UiTextField();
            var greetingLabel = GreetingLabel();
            var greetingButton = GreetingButton(greetingLabel, nameField);
            var navigateButton = NavigationButton(nameField);
            this.View.AddSubviews(new UIView[] {promptLabel, nameField, greetingLabel, greetingButton, navigateButton});
        }

        private UIButton NavigationButton(UITextField nameField)
        {
            var navigateButton = UIButton.FromType(UIButtonType.RoundedRect);
            navigateButton.Frame = new CGRect(StartX, StartY + 4 * Height, this.View.Bounds.Width - 2 * StartX, Height);
            navigateButton.SetTitle("See name list", UIControlState.Normal);

            navigateButton.TouchUpInside += (sender, args) =>
            {
                nameField.ResignFirstResponder();
                this.NavigationController.PushViewController(new PersonListController(this._personList), true);
            };
            return navigateButton;
        }

        private UILabel GreetingLabel()
        {
            var greetingLabel = new UILabel()
            {
                Frame = new CGRect(StartX, StartY + 3 * Height, this.View.Bounds.Width - 2 * StartX, Height),
                Text = "Hello"
            };
            return greetingLabel;
        }

        private UIButton GreetingButton(UILabel greetingLabel, UITextField nameField)
        {
            var greetingButton = UIButton.FromType(UIButtonType.RoundedRect);
            greetingButton.Frame = new CGRect(StartX, StartY + 2 * Height, this.View.Bounds.Width - 2 * StartX, Height);
            greetingButton.SetTitle("Greet me", UIControlState.Normal);
            greetingButton.TouchUpInside += (sender, args) =>
            {
                nameField.ResignFirstResponder();
                greetingLabel.Text = "Hello " + nameField.Text;
            };
            return greetingButton;
        }

        private UITextField UiTextField()
        {
            var nameField = new UITextField()
            {
                Frame = new CGRect(StartX, StartY + Height, this.View.Bounds.Width - 2 * StartX, Height),
                BorderStyle = UITextBorderStyle.RoundedRect
            };
            return nameField;
        }

        private UILabel PromptLabel()
        {
            var promptLabel = new UILabel()
            {
                Frame = new CGRect(StartX, StartY, this.View.Bounds.Width - 2 * StartX, Height),
                Text = "Enter your name: "
            };
            return promptLabel;
        }
    }
}