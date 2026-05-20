using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07.Properties
{
    [TestClass]
    public class Bai11
    {
        FunctionTuan07 o = new FunctionTuan07();
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Bai11_Data.csv",
            "Bai11_Data#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Bai11_Data.csv"),
         TestMethod]
        public void TestMethod1()
        {
            float w = Convert.ToSingle(TestContext.DataRow[0]);
            float h = Convert.ToSingle(TestContext.DataRow[1]);
            float ww = Convert.ToSingle(TestContext.DataRow[2]);
            float wh = Convert.ToSingle(TestContext.DataRow[3]);
            float ExpectedX = Convert.ToSingle(TestContext.DataRow[4]);
            float ExpectedY = Convert.ToSingle(TestContext.DataRow[5]);



            System.Console.WriteLine($"Input: {w}, {h}, {ww}, {wh}");
            System.Console.WriteLine($"ExpectedX: {ExpectedX}");
            System.Console.WriteLine($"ExpectedY: {ExpectedY}");
            (float actualX, float actualY) = o.CenterImage(w, h, ww, wh);
            System.Console.WriteLine($"actualX: {actualX}");
            System.Console.WriteLine($"actualY: {actualY}");
            Assert.AreEqual(actualX, ExpectedX);
            Assert.AreEqual(actualY, ExpectedY);


        }
        [TestMethod]
        public void TestMethod2()
        {
            float w = 0;
            float h = 1;
            float ww = 2;
            float wh = 3;

            System.Console.WriteLine($"Input: {w}, {h}, {ww}, {wh}");

            Exception expectedException = null;
            try
            {
                o.CenterImage(w, h, ww, wh);
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}
