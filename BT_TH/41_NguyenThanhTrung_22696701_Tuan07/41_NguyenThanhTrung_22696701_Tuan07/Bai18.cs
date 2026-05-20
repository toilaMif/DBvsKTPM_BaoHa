using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai18
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai18_Data.csv",
            "Bai18_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai18_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            string email = TestContext.DataRow[0].ToString();
            bool expected = Convert.ToBoolean(TestContext.DataRow[1]);

            Console.WriteLine($"Input: {email}");
            Console.WriteLine($"Expected: {expected}");

            bool actual = o.Bai18(email);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}