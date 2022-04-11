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
        private static List<IUser> clients = new List<IUser> ();
        private static List<IUser> workers;
        private static List<IUser> suppliers;
        private static List<InvoiceIn> invoiceIns;
        private static List<InvoiceOut> invoiceOuts;
        private static List<Product> products = new List<Product>();
        LogicLayerAbstractAPI ll = LogicLayerAbstractAPI.CreateLayer();
        IUser client = new Client("Jakub", "Wandelt", 20, "15d", "123", "lodz", "poland", "budowlana");
        IUser worker = new WarehouseWorker("Dzakub", "Kandel", 25, "2d", "jomama");
        
        
        [TestMethod]
        public void addingClient_AreEqual()
        {
          
            List<Product>products = new List<Product>();
            ll.sellProduct(client, worker, products, "123", 0, 0, 0);
            ll.sellProduct(client, worker, products, "2331", 0, 0, 0);

            //Assert.AreEqual(ll.getData().getInvoiceOut(0).ReceivedBy, client);
           //Assert.AreEqual(ll.getData().getInvoiceOut(0).InvoiceNumber, "123");
            //Assert.AreEqual(ll.getData().getInvoiceOut(1).InvoiceNumber, "2331");
            //Assert.AreEqual(1, clients.Count);

        }
    }
}
