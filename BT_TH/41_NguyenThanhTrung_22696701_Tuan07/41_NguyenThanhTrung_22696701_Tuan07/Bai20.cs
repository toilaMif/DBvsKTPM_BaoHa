using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai20
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai20_Data.csv",
            "Bai20_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai20_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            char tmp = Convert.ToChar(TestContext.DataRow[0]);
            int expected = Convert.ToInt32(TestContext.DataRow[1]);

            Console.WriteLine($"Input: {tmp}");
            Console.WriteLine($"Expected: {expected}");

            int actual = o.Bai20(tmp);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}
