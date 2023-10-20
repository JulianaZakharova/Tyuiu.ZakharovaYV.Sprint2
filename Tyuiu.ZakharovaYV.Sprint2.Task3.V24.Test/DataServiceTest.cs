using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint2.Task3.V24.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 10.98777;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.905287;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

    }
}
