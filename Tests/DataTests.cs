using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        //private DataLayerAbstractAPI dataLayer = DataLayerAbstractAPI.CreateLinq2SQL();
        //private TestDataGenerator generator = new TestDataGenerator();

        //[TestMethod]
        //public void clientRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getClient(0));
        //    Assert.IsNotNull(dataLayer.getClient(1));
        //    Assert.IsNotNull(dataLayer.getClient(2));
        //}

        //[TestMethod]
        //public void supplierRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getSupplier(0));
        //    Assert.IsNotNull(dataLayer.getSupplier(1));
        //    Assert.IsNotNull(dataLayer.getSupplier(2));
        //}

        //[TestMethod]
        //public void workerRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getWorker(0));
        //    Assert.IsNotNull(dataLayer.getWorker(1));
        //    Assert.IsNotNull(dataLayer.getWorker(2));
        //}

        //[TestMethod]
        //public void productRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getProduct(0));
        //    Assert.IsNotNull(dataLayer.getProduct(1));
        //    Assert.IsNotNull(dataLayer.getProduct(2));
        //}

        //[TestMethod]
        //public void invoiceInRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getInvoiceIn(0));
        //}

        //[TestMethod]
        //public void invoiceOutRepositoryState()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.IsNotNull(dataLayer.getInvoiceOut(0));
        //}

        //[TestMethod]
        //public void removingClient()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeClient(0);
        //    Assert.AreEqual(2, dataLayer.Client.Count);
        //}

        //[TestMethod]
        //public void removingSupplier()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeSupplier(0);
        //    Assert.AreEqual(2, dataLayer.Supplier.Count);
        //}

        //[TestMethod]
        //public void removingWorker()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeWorker(0);
        //    Assert.AreEqual(2, dataLayer.Worker.Count);
        //}

        //[TestMethod]
        //public void removingInvoiceIn()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeInvoiceIn(0);
        //    Assert.AreEqual(0, dataLayer.InvoiceIn.Count);
        //}

        //[TestMethod]
        //public void removingInvoiceOut()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeInvoiceOut(0);
        //    Assert.AreEqual(0, dataLayer.InvoiceOut.Count);
        //}

        //[TestMethod]
        //public void checkProductValues()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    dataLayer.removeInvoiceOut(0);
        //    Assert.AreEqual(1, dataLayer.getProduct(0).ItemID);
        //    Assert.AreEqual(21, dataLayer.getProduct(0).Quantity);
        //    Assert.AreEqual(150.0f, dataLayer.getProduct(0).PricePerUnit);
        //}

        //[TestMethod]
        //public void checkInvoiceInValues()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.AreEqual(dataLayer.getSupplier(0), dataLayer.getInvoiceIn(0).DelieveredBy);     
        //    Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceIn(0).ReceivedBy);       
        //    Assert.AreEqual(1000.0f, dataLayer.getInvoiceIn(0).Price);
        //    Assert.AreEqual("IN/00052/2002", dataLayer.getInvoiceIn(0).InvoiceNumber);
        //    Assert.AreEqual(31, dataLayer.getInvoiceIn(0).Day);
        //    Assert.AreEqual(12, dataLayer.getInvoiceIn(0).Month);
        //    Assert.AreEqual(2022, dataLayer.getInvoiceIn(0).Year);
        //}

        //[TestMethod]
        //public void checkInvoiceOutValues()
        //{
        //    dataLayer = generator.GenerateForDataAPI();
        //    Assert.AreEqual(dataLayer.getWorker(0), dataLayer.getInvoiceOut(0).SentBy);       
        //    Assert.AreEqual(dataLayer.getClient(0), dataLayer.getInvoiceOut(0).ReceivedBy);      
        //    Assert.AreEqual(750.0f, dataLayer.getInvoiceOut(0).Price);
        //    Assert.AreEqual("OUT/10052/2002", dataLayer.getInvoiceOut(0).InvoiceNumber);
        //    Assert.AreEqual(30, dataLayer.getInvoiceOut(0).Day);
        //    Assert.AreEqual(12, dataLayer.getInvoiceOut(0).Month);
        //    Assert.AreEqual(2022, dataLayer.getInvoiceOut(0).Year);
        //}
    }
}