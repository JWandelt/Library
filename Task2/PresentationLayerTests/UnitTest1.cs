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
            DataGenerator Data = new DataGenerator();
            ViewModelAbstractAPI.ViewModelAPI ViewModel = new ViewModelAbstractAPI.ViewModelAPI(Data);
            Assert.AreEqual(ViewModel.ReadTitle(), "TestTitle");
            Assert.AreEqual(ViewModel.ReadFirstName(), "TestFirstName");
            Assert.AreEqual(ViewModel.ReadLastName(), "TestLastName");
            Assert.AreEqual(ViewModel.ReadDescription(), "TestDescription");
            
        }
    }
}
