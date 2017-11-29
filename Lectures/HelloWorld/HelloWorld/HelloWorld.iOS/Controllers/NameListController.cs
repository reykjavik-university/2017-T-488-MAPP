using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace HelloWorld.iOS.Controllers
{
    public class NameListController : UITableViewController
    {
        private readonly List<Person> _personList;

        public NameListController(List<Person> personList)
        {
            this._personList = personList;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Name list";

            this.TableView.Source = new NameListDataSource(this._personList);
        }
    }
}
