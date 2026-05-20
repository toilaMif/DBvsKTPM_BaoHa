using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai8
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai8_Data.csv",
            "Bai8_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai8_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float a = Convert.ToSingle(TestContext.DataRow[0]);
            float b = Convert.ToSingle(TestContext.DataRow[1]);
            float c = Convert.ToSingle(TestContext.DataRow[2]);
            string x1Expected = Convert.ToString(TestContext.DataRow[3]);
            string x2Expected = Convert.ToString(TestContext.DataRow[4]);


            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"x1Expected: {x1Expected}");
            System.Console.WriteLine($"x2Expected: {x2Expected}");
             (string x1, string x2) = o.Solve(a, b, c);
            System.Console.WriteLine("x1: "  + x1);
            System.Console.WriteLine("x2: " + x2);
             Assert.AreEqual(x1Expected, x1);
            Assert.AreEqual(x2Expected, x2);


        }
    }
}
