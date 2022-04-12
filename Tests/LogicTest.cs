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
    //[TestClass]
    //public class LogicTest
    //{
    //    private static TestDataGenerator dataGenerator = new TestDataGenerator();
    //    LogicLayerAbstractAPI data = dataGenerator.GenerateForLogicAPI();
        
    //    [TestMethod]
    //    public void sellProduct()
    //    {
    //        Catalog ca1 = new Catalog(1, "Lemon balm", "Calming herb");
    //        int initialQuantity = data.getData().getProduct(0).Quantity;
    //        Product p = new Product(1, 1, 10.0f, ca1);
    //        List<Product> productList = new List<Product>();
    //        productList.Add(p);
    //        data.sellProduct(data.getData().getClient(0), data.getData().getWorker(0), productList, "OUT/00041/2022", 30, 02, 2022);
    //        Assert.AreEqual(data.getData().InvoiceOut.Count, 2);
    //        Assert.AreEqual(data.getData().getProduct(0).Quantity, initialQuantity - 1);
    //        Assert.AreEqual(data.getData().getClient(0),data.getData().getInvoiceOut(1).ReceivedBy);
    //        Assert.AreEqual(data.getData().getWorker(0),data.getData().getInvoiceOut(1).SentBy);
    //        Assert.AreEqual("OUT/00041/2022", data.getData().getInvoiceOut(1).InvoiceNumber);
    //        Assert.AreEqual(10.0f,data.getData().getInvoiceOut(1).Price);
    //        Assert.AreEqual("30-2-2022",data.getData().getInvoiceOut(1).getDate());
    //    }

    //    [TestMethod]
    //    public void buyProduct()
    //    {
    //        Catalog ca1 = new Catalog(1, "Lemon balm", "Calming herb");
    //        int initialQuantity = data.getData().getProduct(0).Quantity;
    //        Product p = new Product(1, 1, 10.0f, ca1);
    //        List<Product> productList = new List<Product>();
    //        productList.Add(p);
    //        data.buyProduct(data.getData().getSupplier(0), data.getData().getWorker(0), productList, "IN/00021/2022", 29, 02, 2022);
    //        Assert.AreEqual(data.getData().getWorker(0), data.getData().getInvoiceIn(1).ReceivedBy);
    //        Assert.AreEqual(data.getData().getSupplier(0), data.getData().getInvoiceIn(1).DelieveredBy);
    //        Assert.AreEqual("IN/00021/2022", data.getData().getInvoiceIn(1).InvoiceNumber);
    //        Assert.AreEqual(10.0f, data.getData().getInvoiceIn(1).Price);
    //        Assert.AreEqual("29-2-2022", data.getData().getInvoiceIn(1).getDate());
    //    }
    //}
}
