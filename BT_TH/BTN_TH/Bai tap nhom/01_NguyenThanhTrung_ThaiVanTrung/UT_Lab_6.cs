using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_6
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Data_Lab6.csv",
            "Data_Lab6#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Data_Lab6.csv"),
         TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s1 = Convert.ToString(TestContext.DataRow[0]);
            string s2 = Convert.ToString(TestContext.DataRow[1]);
            string s3 = Convert.ToString(TestContext.DataRow[2]);
            string expected = Convert.ToString(TestContext.DataRow[3]);

            string actual = o.ThayThe(s1, s2, s3);


            System.Console.WriteLine("expected:" + expected);
            System.Console.WriteLine("actual:" + actual);

            Assert.AreEqual(expected, actual);

        }
    }
}
