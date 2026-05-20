using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_3
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Data_Lab3.csv",
            "Data_Lab3#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Data_Lab3.csv"),
         TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            int chiSoCu = Convert.ToInt32(TestContext.DataRow[0]);
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow[1]);

            double actual;
           
            actual = o.TinhTienDien(chiSoCu, chiSoMoi);



            double expected = Convert.ToDouble(TestContext.DataRow[2], CultureInfo.InvariantCulture)/10;


            TestContext.WriteLine($"Input: chiSoCU={chiSoCu}, chiSoMoi={chiSoMoi}");
            TestContext.WriteLine($"Actual: {actual}");
            TestContext.WriteLine($"Expected: {expected}");

            Assert.AreEqual(expected, actual);
            
        }
    }
}