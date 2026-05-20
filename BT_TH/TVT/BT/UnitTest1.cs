using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 choHuy = new Class1();
            int A = 3;
            int B = 1;
            int C = 2;
            double Mean = 2;
            int Max = 2;
            double Meantt;
            int Maxtt = choHuy.MaxAndMean(A, B, C, out Meantt);
            Assert.AreEqual(Max, Maxtt);
            Assert.AreEqual(Mean, Mean);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 choHuy = new Class1();
            int A = 3;
            int B = 2;
            int C = 5;
            double Mean = 3.33333333333333;
            int Max = 2;
            double Meant;
            int Maxtt = choHuy.MaxAndMean(A, B, C, out Meant);
            Assert.AreEqual(Max, Maxtt);
            Assert.AreEqual(Mean, Meant);
        }
        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
