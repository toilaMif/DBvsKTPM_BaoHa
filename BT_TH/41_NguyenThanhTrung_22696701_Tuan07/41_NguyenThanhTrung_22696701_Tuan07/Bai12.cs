using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai12
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai12_Data.csv",
            "Bai12_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai12_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float total = Convert.ToSingle(TestContext.DataRow[0]);
            float p1 = Convert.ToSingle(TestContext.DataRow[1]);
            float p2 = Convert.ToSingle(TestContext.DataRow[2]);
            float p3 = Convert.ToSingle(TestContext.DataRow[3]);
            float expected = Convert.ToSingle(TestContext.DataRow[4]);


            System.Console.WriteLine($"Input: {total}, {p1}, {p2}, {p3} ");

            System.Console.WriteLine($"Expected: {expected}");
            float acutal = o.Bai12(total, p1, p2, p3);
            System.Console.WriteLine($"acutal: {acutal}");
            Assert.AreEqual(expected, acutal);


        }
        [TestMethod]
        public void TestMethod2()
        {
            float total = -1;
            float p1 = 1;
            float p2 = 1;
            float p3 = 0;

            System.Console.WriteLine($"Input: {total}, {p1}, {p2}, {p3} ");

            Exception expectedException = null;
            try
            {
                o.Bai12(total, p1, p2, p3);
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}
