using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai10
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai10_Data.csv",
            "Bai10_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai10_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float a = Convert.ToSingle(TestContext.DataRow[0]);
            float b = Convert.ToSingle(TestContext.DataRow[1]);
            float c = Convert.ToSingle(TestContext.DataRow[2]);
            Boolean Expected = Convert.ToBoolean(TestContext.DataRow[3]);



            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"Expected: {Expected}");

            Boolean actual = o.IsTriangle(a, b, c);
            System.Console.WriteLine($"actual: {actual}");
            Assert.AreEqual(Expected, actual);


        }
    }
}
