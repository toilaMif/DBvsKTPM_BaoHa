using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai15
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai15_Data.csv",
            "Bai15_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai15_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int year = Convert.ToInt32(TestContext.DataRow[0]);
            bool expected = Convert.ToBoolean(TestContext.DataRow[1]);

            Console.WriteLine($"Input: {year}");
            Console.WriteLine($"Expected: {expected}");

            bool actual = o.Bai15(year);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}
