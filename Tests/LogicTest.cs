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
        private static DataGenerator dataGenerator = new DataGenerator();
        LogicLayerAbstractAPI data = dataGenerator.GenerateForLogicAPI();
        
        [TestMethod]
        public void Invoices_AreEqual()
        {
            Assert.AreEqual(data.getData().getClient(0),data.getData().getInvoiceOut(0).ReceivedBy);
            Assert.AreEqual(data.getData().getWorker(0),data.getData().getInvoiceIn(0).ReceivedBy);
            Assert.AreEqual(data.getData().getWorker(0),data.getData().getInvoiceOut(0).SentBy);
            Assert.AreEqual(data.getData().getSupplier(0),data.getData().getInvoiceIn(0).DelieveredBy);
            Assert.AreEqual("IN/00052/2002",data.getData().getInvoiceIn(0).InvoiceNumber);
            Assert.AreEqual("OUT/10052/2002",data.getData().getInvoiceOut(0).InvoiceNumber);
            Assert.AreEqual(1000,data.getData().getInvoiceIn(0).Price);
            Assert.AreEqual(750,data.getData().getInvoiceOut(0).Price);

            Assert.AreEqual("31-12-2022",data.getData().getInvoiceIn(0).getDate());
            Assert.AreEqual("30-12-2022",data.getData().getInvoiceOut(0).getDate());
        }
    }
}
