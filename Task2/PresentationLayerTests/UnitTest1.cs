using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PresentationLayerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWithDataGenerator()
        {
            DataGenerator data = new DataGenerator();
            DataLayerAPI dataLayer = new DataLayerAPI();
            ViewModelAbstractAPI.ViewModelAPI ViewModel = new ViewModelAbstractAPI.ViewModelAPI(dataLayer,data);
            Assert.AreEqual(ViewModel.ReadTitle(), "TestTitle");
            Assert.AreEqual(ViewModel.ReadFirstName(), "TestFirstName");
            Assert.AreEqual(ViewModel.ReadLastName(), "TestLastName");
            Assert.AreEqual(ViewModel.ReadDescription(), "TestDescription");
            
        }
    }
}
