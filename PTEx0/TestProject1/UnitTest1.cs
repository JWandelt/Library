using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student1 = new Student(1, "Jakub", 20);
            Assert.AreEqual(student1.Age, 20, 0.001, "Age doesn't match");
            Assert.AreEqual(student1.Id, 1, 0.001, "Id doesn't match");
            Assert.AreEqual(student1.Name, "Jakub", "Name doesn't match");
        }
        [TestMethod]
        public void TestAddAge()
        {
            Student student1 = new Student(1, "Jakub", 20);
            student1.addToAge(1);
            Assert.AreEqual(student1.Age, 21, "Age doesn't match");
        }
    }
}