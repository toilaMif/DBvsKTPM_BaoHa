using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai16
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai16_Data.csv",
            "Bai16_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai16_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            string pass = TestContext.DataRow[0].ToString();
            bool expected = Convert.ToBoolean(TestContext.DataRow[1]);

            Console.WriteLine($"Input: {pass}");
            Console.WriteLine($"Expected: {expected}");

            bool actual = o.Bai16(pass);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}