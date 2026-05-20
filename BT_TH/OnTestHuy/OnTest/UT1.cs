using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnTest
{
    [TestClass]
    public class UT1
    {
        [TestMethod]
        public void TestMethod1()
        {
            function o = new function();
            int a =  3;
            int b =  1;
            int c =  2;
            int max = 4;
            double mean = 2;
            double mean_ketquathucte;
            int max_ketquathucte = o.MaxAndMean(a, b, c, out mean_ketquathucte);

            Assert.AreEqual(max, max_ketquathucte);
            Assert.AreEqual(mean, mean_ketquathucte);
        }
    }
}
