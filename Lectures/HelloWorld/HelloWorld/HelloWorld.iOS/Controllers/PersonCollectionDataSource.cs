using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using HelloWorld.iOS.Views;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class PersonCollectionDataSource : UICollectionViewSource
    {
        private readonly List<Person> _personList;

        public PersonCollectionDataSource(List<Person> personList)
        {
            this._personList = personList;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return this._personList.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (PersonCollectionCell)collectionView.DequeueReusableCell((NSString)PersonCollectionCell.CellId, indexPath);

            cell.UpdateCell(this._personList[indexPath.Row]);
            return cell;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            Console.WriteLine("Row {0} selected", indexPath.Row);
        }

        public override Boolean ShouldSelectItem(UICollectionView collectionView, NSIndexPath indexPath)
        {
            return true;
        }
    }
}
