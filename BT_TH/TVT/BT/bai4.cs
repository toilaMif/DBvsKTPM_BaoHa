using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BT
{
    [TestClass]
    public class bai4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 chotrung = new Class1();
            int a = 1;
            int b = 2;
            int c = 3;
            int max = 3;
            int maxtt = chotrung.Max(a, b, c);
            Assert.AreEqual(max, maxtt);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Class1 chotrung = new Class1();
            int a = 5;
            int b = 4;
            int c = 3;
            int max = 5;
            int maxtt = chotrung.Max(a, b, c);
            Assert.AreEqual(max, maxtt);

        }


    }
}
