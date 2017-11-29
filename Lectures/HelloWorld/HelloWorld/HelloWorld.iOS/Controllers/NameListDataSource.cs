using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using HelloWorld.iOS.Views;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class NameListDataSource : UITableViewSource
    {
        private readonly List<Person> _personList;

        public readonly NSString NameListCellId = new NSString("NameListCell");

        public NameListDataSource(List<Person> personList)
        {
            this._personList = personList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PersonCell)tableView.DequeueReusableCell((NSString) this.NameListCellId);
            if (cell == null)
            {
                cell = new PersonCell(this.NameListCellId);
            }

            var person = this._personList[indexPath.Row];
            cell.UpdateCell(person.Name, person.BirthYear.ToString(), person.ImageName);
            
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return this._personList.Count;
        }
    }
}
