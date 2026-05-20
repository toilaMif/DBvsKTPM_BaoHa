using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_5
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\Data_Lab5.csv",
            "Data_Lab5#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Data_Lab5.csv"),
         TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            string s = Convert.ToString(TestContext.DataRow[0]);
            int n = Convert.ToInt32(TestContext.DataRow[1]);
            int p = Convert.ToInt32(TestContext.DataRow[2]);
            string expected = Convert.ToString(TestContext.DataRow[3]);

            System.Console.WriteLine($"Input: s={s}, n={n}, p={p}");
            string actual = o.HuyChuoi(s, n, p);
            System.Console.WriteLine($"Input: s={s}, n={n}, p={p}");
            System.Console.WriteLine($"actual: {actual}");
            System.Console.WriteLine($"expected: {expected}");
        }
    }
}
