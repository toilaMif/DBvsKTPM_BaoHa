using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai13
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai13_Data.csv",
            "Bai13_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai13_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float x1 = Convert.ToSingle(TestContext.DataRow[0]);
            float y1 = Convert.ToSingle(TestContext.DataRow[1]);
            float x2 = Convert.ToSingle(TestContext.DataRow[2]);
            float y2 = Convert.ToSingle(TestContext.DataRow[3]);
            float x = Convert.ToSingle(TestContext.DataRow[4]);
            float y = Convert.ToSingle(TestContext.DataRow[5]);
            bool expected = Convert.ToBoolean(TestContext.DataRow[6]);

            Console.WriteLine($"Input: {x1}, {y1}, {x2}, {y2}, {x}, {y}");
            Console.WriteLine($"Expected: {expected}");

            bool actual = o.Bai13(x1, y1, x2, y2, x, y);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            float x1 = 5;
            float y1 = 1;
            float x2 = 2;
            float y2 = 4;
            float x = 3;
            float y = 2;

            Console.WriteLine($"Input: {x1}, {y1}, {x2}, {y2}, {x}, {y}");
            Exception expectedException = null;
            try
            {
                o.Bai13(x1, y1,x2,y2, x, y);
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}