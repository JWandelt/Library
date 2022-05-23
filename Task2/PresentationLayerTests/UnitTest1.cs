using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PresentationLayerTests
{
    [TestClass]
    public class UnitTest1
    {
        DataGenerator data;
        DataLayerAPI dataLayer;
        ViewModelAbstractAPI.ViewModelAPI ViewModel;
      [TestInitialize]
        public void setup()
        {
            data = new DataGenerator();
            dataLayer = new DataLayerAPI();
            ViewModel = new ViewModelAbstractAPI.ViewModelAPI(dataLayer, data);
        }
        [TestMethod]
        public void TestBook()
        {
            Assert.AreEqual(ViewModel.ReadTitle(), "TestTitle");
            Assert.AreEqual(ViewModel.ReadFirstName(), "TestFirstName");
            Assert.AreEqual(ViewModel.ReadLastName(), "TestLastName");
            Assert.AreEqual(ViewModel.ReadDescription(), "TestDescription");
            
        }
        public void TestReader()
        {
            Assert.AreEqual(ViewModel.)

        }
    }
}
