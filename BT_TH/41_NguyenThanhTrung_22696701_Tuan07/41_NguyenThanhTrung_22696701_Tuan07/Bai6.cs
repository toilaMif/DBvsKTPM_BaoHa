using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai6
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai6_Data.csv",
            "Bai6_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai6_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int sum = Convert.ToInt32(TestContext.DataRow[0]);
            int count = Convert.ToInt32(TestContext.DataRow[1]);
            double expected = Convert.ToInt32(TestContext.DataRow[2]);


            System.Console.WriteLine($"Input: {sum}, {count}");
            double actual = o.Average(sum, count);
            System.Console.WriteLine($"actual: {actual}");
            System.Console.WriteLine($"expected: {expected}");

            Assert.AreEqual(expected, actual);

        }
    }
}
