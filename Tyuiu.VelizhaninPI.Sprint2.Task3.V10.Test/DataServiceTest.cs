using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint2.Task3.V10.Lib;

namespace Tyuiu.VelizhaninPI.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCandition1()
        {
            DataService ds = new DataService();

            double x = 3;
            double res = ds.Calculate(x);
            double wait = 5835;

            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCandition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            double wait = -1;

            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCandition3()
        {
            DataService ds = new DataService();

            double x = -3;
            double res = ds.Calculate(x);
            double wait = 0.007;

            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCandition4()
        {
            DataService ds = new DataService();

            double x = -15;
            double res = ds.Calculate(x);
            double wait = -164.933;

            Assert.AreEqual(res, wait);
        }
    }
}
