using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        [TestInitialize]
        public void Startup()
        {
            TestDataGenerator data = new TestDataGenerator();
            dataLayer = DataTestDataAPI.bindData(data);
        }
        DataTestDataAPI dataLayer;
        
        [TestMethod]
        public void clientRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getClient(0));
            Assert.IsNotNull(dataLayer.getClient(1));
            Assert.IsNotNull(dataLayer.getClient(2));
        }

        [TestMethod]
        public void supplierRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getSupplier(0));
            Assert.IsNotNull(dataLayer.getSupplier(1));
            Assert.IsNotNull(dataLayer.getSupplier(2));
        }

        [TestMethod]
        public void workerRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getWorker(0));
            Assert.IsNotNull(dataLayer.getWorker(1));
            Assert.IsNotNull(dataLayer.getWorker(2));
        }

        [TestMethod]
        public void productRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getProduct(0));
            Assert.IsNotNull(dataLayer.getProduct(1));
            Assert.IsNotNull(dataLayer.getProduct(2));
        }

        [TestMethod]
        public void invoiceInRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getInvoiceIn(0));
        }

        [TestMethod]
        public void invoiceOutRepositoryState()
        {
            Assert.IsNotNull(dataLayer.getInvoiceOut(0));
        }

        [TestMethod]
        public void removingClient()
        {
            dataLayer.removeClient(0);
            Assert.AreEqual(2, dataLayer.Client.Count);
        }

        [TestMethod]
        public void removingSupplier()
        {
            dataLayer.removeSupplier(0);
            Assert.AreEqual(2, dataLayer.Supplier.Count);
        }

        [TestMethod]
        public void removingWorker()
        {
            dataLayer.removeWorker(0);
            Assert.AreEqual(2, dataLayer.Worker.Count);
        }

        [TestMethod]
        public void removingInvoiceIn()
        {
            dataLayer.removeInvoiceIn(0);
            Assert.AreEqual(0, dataLayer.InvoiceIn.Count);
        }

        [TestMethod]
        public void removingInvoiceOut()
        {
            dataLayer.removeInvoiceOut(0);
            Assert.AreEqual(0, dataLayer.InvoiceOut.Count);
        }

        [TestMethod]
        public void checkProductValues()
        {
            dataLayer.removeInvoiceOut(0);
            Assert.AreEqual(1, dataLayer.getProduct(0).ItemID);
            Assert.AreEqual(21, dataLayer.getProduct(0).Quantity);
            Assert.AreEqual(150.0f, dataLayer.getProduct(0).PricePerUnit);
        }

        [TestMethod]
        public void checkInvoiceInValues()
        {
            Assert.AreEqual(dataLayer.getSupplier(0), dataLayer.getInvoiceIn(0).Sender);
            Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceIn(0).Receiver);
            Assert.AreEqual(1000.0f, dataLayer.getInvoiceIn(0).Price);
            Assert.AreEqual("IN/00052/2002", dataLayer.getInvoiceIn(0).InvoiceNumber);
            Assert.AreEqual(31, dataLayer.getInvoiceIn(0).Day);
            Assert.AreEqual(12, dataLayer.getInvoiceIn(0).Month);
            Assert.AreEqual(2022, dataLayer.getInvoiceIn(0).Year);
        }

        [TestMethod]
        public void checkInvoiceOutValues()
        {
            Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceOut(0).Sender);
            Assert.AreEqual(dataLayer.getClient(0), dataLayer.getInvoiceOut(0).Receiver);
            Assert.AreEqual(750.0f, dataLayer.getInvoiceOut(0).Price);
            Assert.AreEqual("OUT/10052/2002", dataLayer.getInvoiceOut(0).InvoiceNumber);
            Assert.AreEqual(30, dataLayer.getInvoiceOut(0).Day);
            Assert.AreEqual(12, dataLayer.getInvoiceOut(0).Month);
            Assert.AreEqual(2022, dataLayer.getInvoiceOut(0).Year);
        }
    }
}