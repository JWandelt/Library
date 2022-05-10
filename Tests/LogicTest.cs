using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.TestData;

namespace Tests
{
    [TestClass]
    public class LogicTest
    {
        [TestInitialize]
        public void Startup()
        {
            TestDataGenerator data = new TestDataGenerator();
            logicLayer = LogicLayerAbstractAPI.CreateLayer(data);
        }
        LogicLayerAbstractAPI logicLayer;

        [TestMethod]
        public void sellProduct()
        {
            ICatalog ca1 = new TCatalog(1, "Lemon balm", "Calming herb");
            int initialQuantity = logicLayer.getData().getProduct(0).Quantity;
            IState p = new TProduct(1, 1, 10.0f, ca1);
            List<IState> productList = new List<IState>();
            productList.Add(p);
            logicLayer.sellProduct(logicLayer.getData().getClient(0), logicLayer.getData().getWorker(0), productList, "OUT/00041/2022", 30, 02, 2022);
            Assert.AreEqual(logicLayer.getData().InvoiceOut.Count, 2);
            Assert.AreEqual(logicLayer.getData().getProduct(0).Quantity, initialQuantity - 1);
            Assert.AreEqual(logicLayer.getData().getClient(0), logicLayer.getData().getInvoiceOut(1).Receiver);
            Assert.AreEqual(logicLayer.getData().getWorker(0), logicLayer.getData().getInvoiceOut(1).Sender);
            Assert.AreEqual("OUT/00041/2022", logicLayer.getData().getInvoiceOut(1).InvoiceNumber);
            Assert.AreEqual(10.0f, logicLayer.getData().getInvoiceOut(1).Price);
        }

        [TestMethod]
        public void buyProduct()
        {
            ICatalog ca1 = new TCatalog(1, "Lemon balm", "Calming herb");
            int initialQuantity = logicLayer.getData().getProduct(0).Quantity;
            IState p = new TProduct(1, 1, 10.0f, ca1);
            List<IState> productList = new List<IState>();
            productList.Add(p);
            logicLayer.buyProduct(logicLayer.getData().getSupplier(0), logicLayer.getData().getWorker(0), productList, "IN/00021/2022", 29, 02, 2022);
            Assert.AreEqual(logicLayer.getData().getWorker(0), logicLayer.getData().getInvoiceIn(1).Receiver);
            Assert.AreEqual(logicLayer.getData().getSupplier(0), logicLayer.getData().getInvoiceIn(1).Sender);
            Assert.AreEqual("IN/00021/2022", logicLayer.getData().getInvoiceIn(1).InvoiceNumber);
            Assert.AreEqual(10.0f, logicLayer.getData().getInvoiceIn(1).Price);
        }
    }
}
