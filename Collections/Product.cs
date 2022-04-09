using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Product
    {
        private int itemID;
        int quantity;
        float pricePerUnit;
        Catalog catalog;

        public Product(int itemID, int quantity, float pricePerUnit, Catalog catalog)
        {
            ItemID = itemID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
            this.catalog = catalog;
        }

        public int ItemID { get { return itemID; } set { itemID = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public float PricePerUnit { get { return pricePerUnit; } set { pricePerUnit = value; } }

     }
}
