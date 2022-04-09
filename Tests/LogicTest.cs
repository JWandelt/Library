using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LogicTest
    {
        //private static List<IUser> clients;
        //private static List<IUser> workers;
        //private static List<IUser> suppliers;
        //private static List<InvoiceIn> invoiceIns;
        //private static List<InvoiceOut> invoiceOuts;
        //private static List<Product> products;
        LogicLayerAbstractAPI ll = LogicLayerAbstractAPI.CreateLayer();

        [TestMethod]
        public void TestMethod1()
        {
            //IUser client = new Client("Jakub", "Wandelt", 20, "15d", "123", "lodz", "poland", "budowlana");
            //IUser worker = new WarehouseWorker("Dzakub", "Kandel", 25, "2d", "jomama");
            //List<Product>? products = new List<Product>();
            ////products.Add(product);
            //////clients.Add(client);
            ////ll.sellProduct(client, worker, products, "123", 0, 0, 0);
            //ll.sellProduct(client, worker, products, "2331", 0, 0, 0);
            
        }
    }
}
