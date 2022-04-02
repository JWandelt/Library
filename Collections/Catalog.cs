using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Catalog
    {
        private int itemID;
        private string itemName;
        private string itemShortDescription;
        private string itemLongDescription;
    
    public Catalog(int itemID, string itemName, string itemShortDescription, string itemLongDescription)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemShortDescription = itemShortDescription;
            this.itemLongDescription = itemLongDescription;
        }
    
      public int ItemID { get { return itemID; } set { } }
      public string ItemName { get { return itemName; } set { itemName = value; } }
      public string ItemShortDescription { get { return itemShortDescription; } set { itemShortDescription = value; } }
      public string LongDescription { get { return itemLongDescription; } set { itemLongDescription = value; } }
    }



}
