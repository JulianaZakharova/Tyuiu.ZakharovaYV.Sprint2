using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint2.Task4.V23.Lib;
namespace Tyuiu.ZakharovaYV.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res ds.Calculate(x, y);
            double wait = 1.167;
            Assert.AreEqual(wait, res);
        }
    }
}
