﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint2.Task2.V22.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
            
        }
    }
}
