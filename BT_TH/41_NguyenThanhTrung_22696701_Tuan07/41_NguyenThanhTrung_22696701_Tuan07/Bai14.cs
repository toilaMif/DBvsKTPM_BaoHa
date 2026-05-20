using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai14
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai14_Data.csv",
            "Bai14_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai14_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float w = Convert.ToSingle(TestContext.DataRow[0]);
            float h = Convert.ToSingle(TestContext.DataRow[1]);

            float expectedX = Convert.ToSingle(TestContext.DataRow[2]);
            float expectedY = Convert.ToSingle(TestContext.DataRow[3]);
            float expectedS = Convert.ToSingle(TestContext.DataRow[4]);

            Console.WriteLine($"Input: {w}, {h}");
            Console.WriteLine($"Expected: {expectedX}, {expectedY}, {expectedS}");

            
                var actual = o.Bai14(w, h);

                Console.WriteLine($"Actual: {actual.x}, {actual.y}, {actual.s}");

                Assert.AreEqual(expectedX, actual.x);
                Assert.AreEqual(expectedY, actual.y);
                Assert.AreEqual(expectedS, actual.s);
            
        }

        [TestMethod]
        public void TestMethod2_Error()
        {
            float w = -1;
            float h = 5;

            Console.WriteLine($"Input: {w}, {h}");

            Exception expectedException = null;
            try
            {
                o.Bai14(w, h);
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}