using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai4
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai4_Data.csv",
            "Bai4_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai4_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            int expected = Convert.ToInt32(TestContext.DataRow[3]);


            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            int actual = o.Max(a, b, c);
            System.Console.WriteLine($"actual: {actual}");
            System.Console.WriteLine($"expected: {expected}");

            Assert.AreEqual( expected, actual );

        }
    }
}
