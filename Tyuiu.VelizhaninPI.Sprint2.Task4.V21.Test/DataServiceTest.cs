using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint2.Task4.V21.Lib;

namespace Tyuiu.VelizhaninPI.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCandition1()
        {
            DataService ds = new DataService();

            double x = -1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 4;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCandition2()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.719;
            Assert.AreEqual(res, wait);
        }
    }
}
