using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.Tests
{
    [TestClass]
    public class LendListTests
    {
        private DataLayerAPI datalayer;
        [TestInitialize]
        public void Startup()
        {
            datalayer = new DataLayerAPI();
        }

        [TestMethod]
        public void addLendList()
        {
            datalayer.addLendList(0, 0, 0);
            Assert.AreEqual(datalayer.GetLendList().Count, 1);
            Assert.AreEqual(datalayer.GetLendList()[0].lend_listID, 0);
            Assert.AreEqual(datalayer.GetLendList()[0].bookID, 0);
            Assert.AreEqual(datalayer.GetLendList()[0].readerID, 0);
        }

        [TestMethod]
        public void editLendList()
        {
            datalayer.addLendList(0, 0, 0);
            datalayer.editLendList(0, 1, 1);
            Assert.AreEqual(datalayer.GetLendList()[0].lend_listID, 0);
            Assert.AreEqual(datalayer.GetLendList()[0].bookID, 1);
            Assert.AreEqual(datalayer.GetLendList()[0].readerID, 1);

        }

        [TestMethod]
        public void removeLendList()
        {
            datalayer.addLendList(0, 0, 0);
            datalayer.removeLendList(0);
            Assert.AreEqual(datalayer.GetRegisteredReader().Count, 0);
        }
    }
}
