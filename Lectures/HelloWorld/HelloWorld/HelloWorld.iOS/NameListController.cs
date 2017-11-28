using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace HelloWorld.iOS
{
    public class NameListController : UITableViewController
    {
        private List<string> _nameList;

        public NameListController(List<string> nameList)
        {
            this._nameList = nameList;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Name list";
        }
    }
}
