using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.iOS.Views;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class PersonCollectionController : UICollectionViewController
    {
        private readonly List<Person> _personList;

        public PersonCollectionController(UICollectionViewFlowLayout layout, List<Person> personList) : base(layout)
        {
            this._personList = personList;
            this.TabBarItem = new UITabBarItem(UITabBarSystemItem.Favorites, 1);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Collection";
            this.CollectionView.BackgroundColor = UIColor.White;
            this.CollectionView.ContentInset = new UIEdgeInsets(10,10,10,10);

            this.CollectionView.RegisterClassForCell(typeof(PersonCollectionCell), PersonCollectionCell.CellId);
            this.CollectionView.Source = new PersonCollectionDataSource(this._personList);
        }
    }
}
