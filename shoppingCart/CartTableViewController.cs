using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using System.IO;

namespace shoppingCart
{
    public partial class CartTableViewController : UITableViewController    {
        List<Items> cItems;
        
        public CartTableViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            cItems = new List<Items>();
            View.BackgroundColor = UIColor.Green;
        }
        public List<Items> Read(string db_Path)
        {
            List<Items> cItems = new List<Items>();
            using (var conn = new SQLiteConnection(db_Path))
            {
                cItems = conn.Table<Items>().ToList();
            }
            return cItems;
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            cItems = Read(ViewController.DbPath);
            TableView.ReloadData();
            View.BackgroundColor = UIColor.Red;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = TableView.DequeueReusableCell("cell_Id", indexPath);
            var data = cItems[indexPath.Row];
             cell.TextLabel.Text = data.name;
             cell.DetailTextLabel.Text = data.price.ToString();
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return cItems.Count;
        }

       

    }
    }
