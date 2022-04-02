using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Product
    {
        private int itemID;
        private string itemName;
        int quantity;
        float pricePerUnit;

        public Product(int itemID, string itemName, int quantity, float pricePerUnit)
        {
            ItemID = itemID;
            ItemName = itemName;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        public int ItemID { get { return itemID; } set { itemID = value; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public float PricePerUnit { get { return pricePerUnit; } set { pricePerUnit = value; } }

     }
}
