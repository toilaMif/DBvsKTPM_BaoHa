using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai7
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai7_Data.csv",
            "Bai7_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai7_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int year = Convert.ToInt32(TestContext.DataRow[0]);
            int month = Convert.ToInt32(TestContext.DataRow[1]);
            double expected = Convert.ToInt32(TestContext.DataRow[2]);


            System.Console.WriteLine($"Input: {year}, {month}");
            double actual = o.DaysInMonth(month, year);
            System.Console.WriteLine($"actual: {actual}");
            System.Console.WriteLine($"expected: {expected}");

            Assert.AreEqual(expected, actual);

        }
    }
}
