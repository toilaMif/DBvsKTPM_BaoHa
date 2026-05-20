using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_2
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\Data_Lab2.csv",
            "Data_Lab2#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("Data_Lab2.csv"),
         TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);

            string expected = TestContext.DataRow[3].ToString();

            float expectedX1 = 0;
            float expectedX2 = 0;

            if (TestContext.DataRow[4].ToString() != "")
                expectedX1 = Convert.ToSingle(TestContext.DataRow[4]);

            if (TestContext.DataRow[5].ToString() != "")
                expectedX2 = Convert.ToSingle(TestContext.DataRow[5]);

            float x1, x2;
            string kq_mongdoi = expected;

            if (expected == "Vo so nghiem")
                kq_mongdoi = "Vô số nghiệm";
            else if (expected == "Vo nghiem")
                kq_mongdoi = "Vô nghiệm";
            else if (expected == "Co 1 nghiem")
                kq_mongdoi = "Có 1 nghiệm";
            else if (expected == "Co nghiem kep")
                kq_mongdoi = "Có nghiệm kép";
            else if (expected == "Co 2 nghiem phan biet")
                kq_mongdoi = "Có 2 nghiệm phân biệt";

            string actual = o.SolveQuadratic(a, b, c, out x1, out x2);

            Assert.AreEqual(kq_mongdoi, actual);

            if (expected == "Có 1 nghiệm" ||
                expected == "Có nghiệm kép" ||
                expected == "Có 2 nghiệm phân biệt")
            {
                Assert.AreEqual(expectedX1, x1, 0.0001f);
                Assert.AreEqual(expectedX2, x2, 0.0001f);
            }

            TestContext.WriteLine($"Input: a={a}, b={b}, c={c}");
            TestContext.WriteLine($"Actual: {actual}, x1={x1}, x2={x2}");
        }
    }
}