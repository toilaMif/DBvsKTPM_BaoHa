using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai5
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai5_Data.csv",
            "Bai5_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai5_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            string expected = TestContext.DataRow[3].ToString();

            Console.WriteLine($"Input: {a}, {b}, {c}");
            Console.WriteLine($"Expected: {expected}");

            string actual = o.Triangle(a, b, c);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}