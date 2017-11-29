using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
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
            var cell = tableView.DequeueReusableCell((NSString) this.NameListCellId);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, this.NameListCellId);
            }
            cell.TextLabel.Text = this._personList[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return this._personList.Count;
        }
    }
}
