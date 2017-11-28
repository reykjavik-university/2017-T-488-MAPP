using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;

namespace HelloWorld.iOS
{
    public class NameListDataSource : UITableViewSource
    {
        private readonly List<string> _nameList;

        public readonly NSString NameListCellId = new NSString("NameListCell");

        public NameListDataSource(List<string> nameList)
        {
            this._nameList = nameList;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell((NSString) this.NameListCellId);
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, this.NameListCellId);
            }
            cell.TextLabel.Text = this._nameList[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return this._nameList.Count;
        }
    }
}
