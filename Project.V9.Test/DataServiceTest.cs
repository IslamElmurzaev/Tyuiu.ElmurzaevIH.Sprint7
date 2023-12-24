using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V9.Lib;
namespace Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxDuration()
        {
            DataService ds = new DataService();
            Assert.AreEqual(300, ds.GetMaxVideoDuration(@"C:\Users\adami\OneDrive\Рабочий стол\Sprint7\videos4test.csv"));
        }

        [TestMethod]
        public void ValidGetMinDuration()
        {
            DataService ds = new DataService();
            Assert.AreEqual(180, ds.GetMinVideoDuration(@"C:\Users\adami\OneDrive\Рабочий стол\Sprint7\videos4test.csv"));
        }

        [TestMethod]
        public void ValidGetMaxVideoPrice()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2500, ds.GetMaxVideoPrice(@"C:\Users\adami\OneDrive\Рабочий стол\Sprint7\videos4test.csv"));
        }

        [TestMethod]
        public void ValidGetMinVideoPrice()
        {
            DataService ds = new DataService();
            Assert.AreEqual(500, ds.GetMinVideoPrice(@"C:\Users\adami\OneDrive\Рабочий стол\Sprint7\videos4test.csv"));
        }
    }
}
