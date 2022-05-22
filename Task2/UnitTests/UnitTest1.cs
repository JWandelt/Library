using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataLayer;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private DataLayerAPI datalayer;
        [TestInitialize]
        public void Startup()
        {
            datalayer = new DataLayerAPI();
        }
        [TestMethod]
        public void AddBook()
        {
            var book = new Book(1, "G.I. Jane 2", "bbb","ccc","ddd", false);
            datalayer.Book.Add(book);
            Assert.AreEqual(datalayer.Book[0].title, "G.I. Jane 2");
            Assert.AreEqual(datalayer.Book[0].description, "bbb");
            Assert.AreEqual(datalayer.Book[0].author_last_name, "ccc");
            Assert.AreEqual(datalayer.Book[0].author_first_name, "ddd");
            Assert.AreEqual(datalayer.Book[0].lent, false);

        }
        [TestMethod]
        public void AddReader()
        {
            var reader = new Reader(1, "Will", "Smith");
            datalayer.Reader.Add(reader);
            Assert.AreEqual(datalayer.Reader[0].readerID, 1);
            Assert.AreEqual(datalayer.Reader[0].first_name, "Will");
            Assert.AreEqual(datalayer.Reader[0].last_name, "Smith");
        }
    }
}
