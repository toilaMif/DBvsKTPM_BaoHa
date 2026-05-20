using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Data_Lab1_Valid.csv",
            "Data_Lab1_Valid#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Data_Lab1_Valid.csv"),
         TestMethod]
        public void TestMethod1_valid()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            int A = Convert.ToInt32(TestContext.DataRow[0]);
            int B = Convert.ToInt32(TestContext.DataRow[1]);
            int C = Convert.ToInt32(TestContext.DataRow[2]);
            int expected = Convert.ToInt32(TestContext.DataRow[3]);

            int actual = o.Max(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @"|DataDirectory|\Data_Lab1_Invalid.csv",
    "Data_Lab1_Invalid#csv",
    DataAccessMethod.Sequential),
 DeploymentItem("Data_Lab1_Invalid.csv")]
        public void TestMethod2_Invalid()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            int A = Convert.ToInt32(TestContext.DataRow[0]);
            int B = Convert.ToInt32(TestContext.DataRow[1]);
            int C = Convert.ToInt32(TestContext.DataRow[2]);

            Exception expectedException = null;

            try
            {
                o.Max(A, B, C); 
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
    }
}