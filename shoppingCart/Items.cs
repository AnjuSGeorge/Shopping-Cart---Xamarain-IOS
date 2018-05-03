using System;
using SQLite;
namespace shoppingCart
{
    public class Items
    {
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public double price
        {
            get; set;
        }
       
    }
}
