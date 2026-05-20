using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai17
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai17_Data.csv",
            "Bai17_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai17_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int year = Convert.ToInt32(TestContext.DataRow[0]);
            int month = Convert.ToInt32(TestContext.DataRow[1]);
            int day = Convert.ToInt32(TestContext.DataRow[2]);
            bool expected = Convert.ToBoolean(TestContext.DataRow[3]);

            Console.WriteLine($"Input: {year}, {month}, {day}");
            Console.WriteLine($"Expected: {expected}");

            bool actual = o.Bai17(year, month, day);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}