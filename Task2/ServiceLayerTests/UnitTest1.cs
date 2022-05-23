using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ServiceLayerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBook()
        {

            Book book = new Book(1, "t", "d", "al", "af", false);
            Assert.IsNotNull(book);
            Assert.AreEqual(book.bookID, 1);
            Assert.AreEqual(book.title, "t");
            Assert.AreEqual(book.description, "d");
            Assert.AreEqual(book.author_last_name, "al");
            Assert.AreEqual(book.author_first_name, "af");
            Assert.AreEqual(book.lent, false);
        }
        public void TestReader()
        {
            Reader reader = new Reader(2, "aaa", "bbb");

            Assert.AreEqual(reader.readerID, 2);
            Assert.AreEqual(reader.first_name, "aaa");
            Assert.AreEqual(reader.last_name, "bbb");
        }
        public void TestLendList()
        {
            LendList lendList = new LendList(1, 2, 3);
            Assert.AreEqual(lendList.lend_listID, 1);
            Assert.AreEqual(lendList.bookID, 2);
            Assert.AreEqual(lendList.readerID, 3);

        }
    }
}