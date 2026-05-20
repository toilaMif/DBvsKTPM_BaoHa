using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\TextFile2.csv",
            "TextFile2#csv",
            DataAccessMethod.Sequential),
             DeploymentItem("TextFile2.csv"),
             TestMethod]
        public void TestMethod1()
        {
            Class1 o = new Class1();
            int Sum  = Convert.ToInt32(TestContext.DataRow[0]);
            int Count = Convert.ToInt32(TestContext.DataRow[1]);


            int Expected = Convert.ToInt32(TestContext.DataRow[2]);

            double ketquathucte;
            ketquathucte = o.Average(Sum, Count);
            Assert.AreEqual(Expected, ketquathucte);


        }
    }
}
