using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace HelloWorld.iOS.Views
{
    public class PersonCell : UITableViewCell
    {
        private const double ImageHeight = 33;
        private readonly UIImageView _imageView;
        private readonly UILabel _headingLabel;
        private readonly UILabel _subheadingLabel;

        public PersonCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            this.SelectionStyle = UITableViewCellSelectionStyle.Gray;

            this._imageView = new UIImageView()
            {
                Frame = new CGRect(this.ContentView.Bounds.Width - 60, 5, ImageHeight, ImageHeight),
            };

            this._headingLabel = new UILabel()
            {
                Frame = new CGRect(5, 5, this.ContentView.Bounds.Width - 60, 25),
                Font = UIFont.FromName("Cochin-BoldItalic", 22f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };

            this._subheadingLabel = new UILabel()
            {
                Frame = new CGRect(100, 25, 100, 20),
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromRGB(38, 127, 0),
                TextAlignment = UITextAlignment.Center,
                BackgroundColor = UIColor.Clear
            };

            this.ContentView.AddSubviews(new UIView[] { this._imageView, this._headingLabel, this._subheadingLabel});

            this.Accessory = UITableViewCellAccessory.DisclosureIndicator;
        }

        public void UpdateCell(Person person)
        {
            this._imageView.Image = UIImage.FromFile(person.ImageName);
            this._headingLabel.Text = person.Name;
            this._subheadingLabel.Text = person.BirthYear.ToString();
        }
    }
}
