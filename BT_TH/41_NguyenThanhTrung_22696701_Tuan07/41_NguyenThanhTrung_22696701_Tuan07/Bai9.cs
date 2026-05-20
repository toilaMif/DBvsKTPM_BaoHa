using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai9
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai9_Data.csv",
            "Bai9_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai9_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float a = Convert.ToSingle(TestContext.DataRow[0]);
            float b = Convert.ToSingle(TestContext.DataRow[1]);
            float c = Convert.ToSingle(TestContext.DataRow[2]);
            float Expected = Convert.ToSingle(TestContext.DataRow[3]);



            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"Expected: {Expected}");

            float actual = o.bai9(a, b, c);
            System.Console.WriteLine($"actual: {actual}");
            Assert.AreEqual(Expected, actual);


        }
        [TestMethod]
        public void TestMethod2()
        {
            float a = 5;
            float b = 3;
            float x = 4;

            Console.WriteLine($"Input: {a}, {b}, {x}");


            Exception expectedException = null;
            try
            {
                o.bai9(a,b, x);
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}
