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
        private UIImageView _imageView;
        private UILabel _headingLabel;
        private UILabel _subheadingLabel;

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
        }

        public void UpdateCell(string name, string year, string imageName)
        {
            this._imageView.Image = UIImage.FromFile(imageName);
            this._headingLabel.Text = name;
            this._subheadingLabel.Text = year;
        }
    }
}
