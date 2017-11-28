using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace HelloWorld.iOS
{
    public class NameListController : UITableViewController
    {
        private readonly List<string> _nameList;

        public NameListController(List<string> nameList)
        {
            this._nameList = nameList;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Name list";

            this.TableView.Source = new NameListDataSource(this._nameList);
        }
    }
}
