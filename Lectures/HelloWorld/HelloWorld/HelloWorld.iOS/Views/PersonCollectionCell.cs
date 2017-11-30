using System;
using System.Collections.Generic;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace HelloWorld.iOS.Views
{
    public class PersonCollectionCell : UICollectionViewCell
    {
        private readonly UIImageView _imageView;
        private readonly UILabel _label;

        public static readonly string CellId = "PersonCollectionCell";

        [Export("initWithFrame:")]
        public PersonCollectionCell(CGRect frame) : base(frame)
        {
            this._imageView = new UIImageView()
            {
                Frame = new CGRect(0,0,this.ContentView.Bounds.Width - 20, this.ContentView.Bounds.Height - 20),
            };

            this._label = new UILabel()
            {
                Frame = new CGRect(0, this.ContentView.Bounds.Height - 20, this.ContentView.Bounds.Width, 20),
                Font = UIFont.FromName("AmericanTypewriter", 10f),
                TextColor = UIColor.Red,
                TextAlignment = UITextAlignment.Left,
                BackgroundColor = UIColor.White
            };

            this.ContentView.AddSubviews(new UIView[] { this._imageView, this._label});
        }

        public void UpdateCell(Person person)
        {
            this._imageView.Image = UIImage.FromFile(person.ImageName);
            this._label.Text = person.Name;
        }
    }
}
