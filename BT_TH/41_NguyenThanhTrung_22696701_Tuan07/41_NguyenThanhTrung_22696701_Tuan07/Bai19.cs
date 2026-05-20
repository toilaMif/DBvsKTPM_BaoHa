using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai19
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai19_Data.csv",
            "Bai19_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai19_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float height = Convert.ToSingle(TestContext.DataRow[0]);
            float weight = Convert.ToSingle(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);

            Console.WriteLine($"Input: {height}, {weight}");
            Console.WriteLine($"Expected: {expected}");

            int actual = o.Bai19(height, weight);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}