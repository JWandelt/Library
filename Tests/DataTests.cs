using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        private DataLayerAbstractAPI dataLayer = DataLayerAbstractAPI.CreateLinq2SQL();
        private DataGenerator generator = new DataGenerator();

        [TestMethod]
        public void clientRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getClient(0));
            Assert.IsNotNull(dataLayer.getClient(1));
            Assert.IsNotNull(dataLayer.getClient(2));
        }

        [TestMethod]
        public void supplierRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getSupplier(0));
            Assert.IsNotNull(dataLayer.getSupplier(1));
            Assert.IsNotNull(dataLayer.getSupplier(2));
        }

        [TestMethod]
        public void workerRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getWorker(0));
            Assert.IsNotNull(dataLayer.getWorker(1));
            Assert.IsNotNull(dataLayer.getWorker(2));
        }

        [TestMethod]
        public void productRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getProduct(0));
            Assert.IsNotNull(dataLayer.getProduct(1));
            Assert.IsNotNull(dataLayer.getProduct(2));
        }

        [TestMethod]
        public void invoiceInRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getInvoiceIn(0));
        }

        [TestMethod]
        public void invoiceOutRepositoryState()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.IsNotNull(dataLayer.getInvoiceOut(0));
        }

        [TestMethod]
        public void removingClient()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeClient(0);
            Assert.AreEqual(2, dataLayer.Client.Count);
        }

        [TestMethod]
        public void removingSupplier()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeSupplier(0);
            Assert.AreEqual(2, dataLayer.Supplier.Count);
        }

        [TestMethod]
        public void removingWorker()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeWorker(0);
            Assert.AreEqual(2, dataLayer.Worker.Count);
        }

        [TestMethod]
        public void removingInvoiceIn()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeInvoiceIn(0);
            Assert.AreEqual(0, dataLayer.InvoiceIn.Count);
        }

        [TestMethod]
        public void removingInvoiceOut()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeInvoiceOut(0);
            Assert.AreEqual(0, dataLayer.InvoiceOut.Count);
        }

        [TestMethod]
        public void checkProductValues()
        {
            dataLayer = generator.GenerateForDataAPI();
            dataLayer.removeInvoiceOut(0);
            Assert.AreEqual(1, dataLayer.getProduct(0).ItemID);
            Assert.AreEqual(21, dataLayer.getProduct(0).Quantity);
            Assert.AreEqual(150.0f, dataLayer.getProduct(0).PricePerUnit);
        }

        [TestMethod]
        public void checkInvoiceInValues()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.AreEqual(dataLayer.getSupplier(0), dataLayer.getInvoiceIn(0).DelieveredBy);       //InvoiceIn invoiceIn = new InvoiceIn(s1, w1, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
            Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceIn(0).ReceivedBy);       //InvoiceOut invoiceOut = new InvoiceOut(w1, c1, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);
            Assert.AreEqual(1000.0f, dataLayer.getInvoiceIn(0).Price);
            Assert.AreEqual("IN/00052/2002", dataLayer.getInvoiceIn(0).InvoiceNumber);
            Assert.AreEqual(31, dataLayer.getInvoiceIn(0).Day);
            Assert.AreEqual(12, dataLayer.getInvoiceIn(0).Month);
            Assert.AreEqual(2022, dataLayer.getInvoiceIn(0).Year);
        }

        [TestMethod]
        public void checkInvoiceOutValues()
        {
            dataLayer = generator.GenerateForDataAPI();
            Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceOut(0).SentBy);       //InvoiceIn invoiceIn = new InvoiceIn(s1, w1, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
            Assert.AreEqual(dataLayer.getClient(0), dataLayer.getInvoiceOut(0).ReceivedBy);       //InvoiceOut invoiceOut = new InvoiceOut(w1, c1, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);
            Assert.AreEqual(750.0f, dataLayer.getInvoiceOut(0).Price);
            Assert.AreEqual("OUT/10052/2002", dataLayer.getInvoiceOut(0).InvoiceNumber);
            Assert.AreEqual(30, dataLayer.getInvoiceOut(0).Day);
            Assert.AreEqual(12, dataLayer.getInvoiceOut(0).Month);
            Assert.AreEqual(2022, dataLayer.getInvoiceOut(0).Year);
        }

        //[TestMethod]
        //public void getterWorker_Equal()
        //{
        //    Assert.AreEqual(worker.FirstName, "Alexander");
        //    Assert.AreEqual(worker.LastName, "Shulgin");
        //    Assert.AreEqual(worker.Age, 42);
        //    Assert.AreEqual(worker.ID, "w042");
        //}

        //[TestMethod]
        //public void removingTest()
        //{
        //    Product product = new Product(1, 21, 150.0f, catalog);
        //    Product product2 = new Product(2, 21, 250.0f, catalog2);
        //    orderedProducts.Add(product);
        //    orderedProducts.Add(product2);
        //    InvoiceIn invoiceIn = new InvoiceIn(supplier, worker, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
        //    InvoiceOut invoiceOut = new InvoiceOut(worker, client, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);
        //    dl.addClient(client);
        //    dl.addSupplier(supplier);
        //    dl.addWorker(worker);
        //    dl.addInvoiceIn(invoiceIn); 
        //    dl.addInvoiceOut(invoiceOut);
        //    Assert.IsNotNull(dl.getInvoiceOut(0));
        //    Assert.IsNotNull(dl.getInvoiceIn(0));
        //    dl.removeWorker(0);
        //    dl.removeSupplier(0);
        //    dl.removeClient(0);
        //    dl.removeInvoiceIn(0);
        //    dl.removeInvoiceOut(0);
        //    Assert.AreEqual(0, dl.Worker.Count);
        //    Assert.AreEqual(0, dl.Client.Count);
        //    Assert.AreEqual(0, dl.Supplier.Count);
        //    Assert.AreEqual(0, dl.InvoiceOut.Count);
        //    Assert.AreEqual(0, dl.InvoiceIn.Count);
        //}
    }
}