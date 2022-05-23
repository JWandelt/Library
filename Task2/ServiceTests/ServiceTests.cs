using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTests
{
    [TestClass]
    public class ServiceTests
    {
        ServiceTestDataAPI data;
        ServiceTestAPI service;

        [TestInitialize]
        public void Startup()
        {
            data = new ServiceTestDataAPI();
            service = new ServiceTestAPI(data);
        }

        [TestMethod]
        public void addBook()
        {
            //TestBook book = new TestBook(0, "test", "test", "test", "test", false);
            service.addBook("test", "test", "test", "test", false);
            Assert.AreEqual(data.Book.Count, 1);
        }

        [TestMethod]
        public void removeBook()
        {
            service.addBook("test", "test", "test", "test", false);
            service.removeBook(0);
            Assert.AreEqual(data.Book.Count, 0);
        }

        [TestMethod]
        public void editBook()
        {
            service.addBook("test", "test", "test", "test", false);
            service.editBook(0, "test2", "test2", "test2", "test2", false);
            Assert.AreEqual(data.Book[0].bookID, 0);
            Assert.AreEqual(data.Book[0].title, "test2");
            Assert.AreEqual(data.Book[0].author_first_name, "test2");
            Assert.AreEqual(data.Book[0].author_last_name, "test2");
            Assert.AreEqual(data.Book[0].description, "test2");
        }

        [TestMethod]
        public void addReader()
        {
            service.addReader("test", "test");
            Assert.AreEqual(data.Reader.Count, 1);
        }

        [TestMethod]
        public void removeReader()
        {
            service.addReader("test", "test");
            service.removeReader(0);
        }

        [TestMethod]
        public void editReader()
        {
            service.addReader("test", "test");
            service.editReader(0, "test2", "test2");
            Assert.AreEqual(data.Reader[0].last_name, "test2");
            Assert.AreEqual(data.Reader[0].first_name, "test2");
        }

        [TestMethod]
        public void addLendList()
        {
            service.addLendList(0, 0);
            Assert.AreEqual(data.LendList.Count, 1);
        }

        [TestMethod]
        public void removeLendList()
        {
            service.addLendList(0, 0);
            service.removeLendList(0);
            Assert.AreEqual(data.LendList.Count, 0);
        }

        [TestMethod]
        public void editLendList()
        {
            service.addLendList(0, 0);
            service.editLendList(0, 1, 1);
            Assert.AreEqual(data.LendList.Count, 1);
            Assert.AreEqual(data.LendList[0].lend_listID, 0);
            Assert.AreEqual(data.LendList[0].readerID, 1);
            Assert.AreEqual(data.LendList[0].bookID, 1);
        }
        
        [TestMethod]
        public void lendABook()
        {
            service.addBook("test", "test", "test", "test", false);
            service.lendABook(0, 0);
            Assert.AreEqual(data.Book.Count, 1);
            Assert.IsTrue(data.Book[0].lent);
        }

        [TestMethod]
        public void cancelBookLease()
        {
            service.addBook("test", "test", "test", "test", false);
            service.lendABook(0, 0);
            service.cancelLease(0);
            Assert.AreEqual(data.Book.Count, 1);
            Assert.IsFalse  (data.Book[0].lent);
        }
    }
}