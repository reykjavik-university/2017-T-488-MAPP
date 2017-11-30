using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using HelloWorld.iOS.Views;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class PersonListDataSource : UITableViewSource
    {
        private readonly List<Person> _personList;

        public readonly NSString NameListCellId = new NSString("NameListCell");
        private readonly Action<int> _onSelectedPerson;

        public PersonListDataSource(List<Person> personList, Action<int> onSelectedPerson)
        {
            this._personList = personList;
            this._onSelectedPerson = onSelectedPerson;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PersonCell)tableView.DequeueReusableCell((NSString) this.NameListCellId);
            if (cell == null)
            {
                cell = new PersonCell(this.NameListCellId);
            }

            cell.UpdateCell(this._personList[indexPath.Row]);            
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return this._personList.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            this._onSelectedPerson(indexPath.Row);
        }
    }
}
