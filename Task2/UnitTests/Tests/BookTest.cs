using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.Tests
{
    [TestClass]
    public class BookTest
    {
        private DataLayerAPI datalayer;
        [TestInitialize]
        public void Startup()
        {
            datalayer = new DataLayerAPI();
        }

        [TestMethod]
        public void addBook()
        {
            datalayer.addBook(0, "test", "test", "test", "test", false);
            Assert.AreEqual(datalayer.GetBooks().Count, 1);
            Assert.AreEqual(datalayer.GetBooks()[0].bookID, 0);
            Assert.AreEqual(datalayer.GetBooks()[0].title, "test");
            Assert.AreEqual(datalayer.GetBooks()[0].author_last_name, "test");
            Assert.AreEqual(datalayer.GetBooks()[0].author_first_name, "test");
            Assert.AreEqual(datalayer.GetBooks()[0].description, "test");
            Assert.AreEqual(datalayer.GetBooks()[0].lent, false);
        }

        [TestMethod]
        public void editBook()
        {
            datalayer.addBook(0, "test", "test", "test", "test", false);
            datalayer.editBook(0, "test1", "test1", "test1", "test1", true);     
            Assert.AreEqual(datalayer.GetBooks()[0].bookID, 0);
            Assert.AreEqual(datalayer.GetBooks()[0].title, "test1");
            Assert.AreEqual(datalayer.GetBooks()[0].author_last_name, "test1");
            Assert.AreEqual(datalayer.GetBooks()[0].author_first_name, "test1");
            Assert.AreEqual(datalayer.GetBooks()[0].description, "test1");
            Assert.AreEqual(datalayer.GetBooks()[0].lent, true);
        }

        [TestMethod]
        public void removeBook()
        {
            datalayer.addBook(0, "test", "test", "test", "test", false);
            datalayer.removeBook(0);
            Assert.AreEqual(datalayer.GetBooks().Count, 0);
        }
    }
}
