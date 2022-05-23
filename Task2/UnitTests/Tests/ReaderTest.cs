using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.Tests
{
    [TestClass]
    public class ReaderTest
    {
        private DataLayerAPI datalayer;
        [TestInitialize]
        public void Startup()
        {
            datalayer = new DataLayerAPI();
        }

        [TestMethod]
        public void addReader()
        {
            datalayer.addReader(0, "test", "test");
            Assert.AreEqual(datalayer.GetRegisteredReader().Count, 1);
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].readerID, 0);
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].first_name, "test");
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].last_name, "test");
        }

        [TestMethod]
        public void editReader()
        {
            datalayer.addReader(0, "test", "test");
            datalayer.editReader(0, "test1", "test1");
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].readerID, 0);
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].first_name, "test1");
            Assert.AreEqual(datalayer.GetRegisteredReader()[0].last_name, "test1");

        }

        [TestMethod]
        public void removeReader()
        {
            datalayer.addReader(0, "test", "test");
            datalayer.removeReader(0);
            Assert.AreEqual(datalayer.GetRegisteredReader().Count, 0);
        }
    }
}
