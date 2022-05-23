using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PresentationLayerTests
{
    [TestClass]
    public class ViewModelTests
    {
        private TestViewModel viewModel;
        IDataGenerator generator;

        [TestInitialize]
        public void Startup()
        {
            generator = new DataGenerator();
            viewModel = new TestViewModel(generator);
        }

        [TestMethod]
        public void deleteBookCommand()
        {
            viewModel.DeleteBookCommand.Execute(null);
            Assert.AreEqual(viewModel.Books.Count, 0);
        }

        [TestMethod]
        public void cancelLeaseCommand()
        {
            viewModel.CancelBookLeaseCommand.Execute(null);
            Assert.AreEqual(viewModel.LendLists.Count, 0);
        }

        [TestMethod]
        public void deleteReaderCommand()
        {
            viewModel.DeleteReaderCommand.Execute(null);
            Assert.AreEqual(viewModel.Readers.Count, 0);
        }
    }
}
