using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VelizhaninPI.Sprint2.Task5.V10.Lib;

namespace Tyuiu.VelizhaninPI.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 2007;
            m = 05;
            n = 01;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "31.04.2007";
        }
    }
}
