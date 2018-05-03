using System;

using UIKit;
using SQLite;
using System.IO;
using System.Collections;

namespace shoppingCart
{
    public partial class ViewController : UIViewController
    {
        public static string DbName = "Shoppingcart.db3";
        public static string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DbName);
        public void CreateDB()
        {
            try
            {
                var db = new SQLiteConnection(DbPath);
                db.CreateTable<Items>();

            }
            catch (Exception ex)
            {

            }
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            CreateDB();
        }

        partial void BtnJacket_TouchUpInside(UIButton sender)
        {
            try
            {
                string prodName = "Jacket";
                double prodPrice = 450.75;

                var addCart = new Items
                {
                    name = prodName,
                    price = prodPrice,

                };
                var db = new SQLiteConnection(DbPath);
                db.Insert(addCart);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside exception");
                lblResult.Text = "Exception";
            }
            
        }

        partial void BtnPants_TouchUpInside(UIButton sender)
        {
            try
            {
                string prodName = "Pants";
                double prodPrice = 250.75;

                var addCart = new Items
                {
                    name = prodName,
                    price = prodPrice,

                };
                var db = new SQLiteConnection(DbPath);
                db.Insert(addCart);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside exception");
                lblResult.Text = "Exception";
            }
        }

        partial void BtnSkirt_TouchUpInside(UIButton sender)
        {
            try
            {
                string prodName = "Skirt";
                double prodPrice = 245.75;

                var addCart = new Items
                {
                    name = prodName,
                    price = prodPrice,

                };
                var db = new SQLiteConnection(DbPath);
                db.Insert(addCart);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside exception");
                lblResult.Text = "Exception";
            }
        }

        partial void BtnShirt_TouchUpInside(UIButton sender)
        {
            try
            {
                string prodName = "Shirt";
                double prodPrice = 95.45;
                
                var addCart = new Items
                {
                    name = prodName,
                    price = prodPrice,

                };
                var db = new SQLiteConnection(DbPath);
                db.Insert(addCart);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside exception");
                lblResult.Text = "Exception";
            }
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnViewCart_Activated(UIBarButtonItem sender)
        {
            CartTableViewController page3Controller = this.Storyboard.InstantiateViewController("TableShow") as CartTableViewController;
            this.NavigationController.PushViewController(page3Controller, true);
        }

        partial void BtnCheckOut_Activated(UIBarButtonItem sender)
        {
            try
            {
                var conn = new SQLiteConnection(DbPath);
                conn.Execute("DELETE FROM Items");
                UIAlertView success = new UIAlertView()
                {
                    Title = "Success",
                    Message = "Checked out successfully"
                };
                success.AddButton("OK");
                success.Show();

            }
            catch(Exception ex)
            {
                
            }

        }
    }
}
