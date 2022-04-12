using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Product : IState
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
            Catalog = catalog;
        }

        public int ItemID { get { return itemID; } set { itemID = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public float PricePerUnit { get { return pricePerUnit; } set { pricePerUnit = value; } }
        public Catalog Catalog { get { return catalog; } set { catalog = value; } }

     }
}
