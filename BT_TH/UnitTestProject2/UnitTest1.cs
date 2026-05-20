using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\TextFile1.csv",
            "TextFile1#csv",
            DataAccessMethod.Sequential),
             DeploymentItem("TextFile1.csv"),
             TestMethod]

        public void TestMethod1()
        {
            Class1 o = new Class1();
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            String expected = Convert.ToString(TestContext.DataRow[3]);

            String ketquathucte = o.Triangle(a, b, c);

            Assert.AreEqual(expected, ketquathucte);








        }
    }
}
