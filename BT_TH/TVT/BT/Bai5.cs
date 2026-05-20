using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace BT
{
    [TestClass]
    public class Bai5
    {
        [TestMethod]
        public void Testcase1()
        {
            Class1 choviet = new Class1();
            int a = 1;
            int b = 2;
            int c = 3;
            //string ex = "Not a Triangle";
            //string extt = choviet.Triangle(a, b, c);
            //Assert.AreEqual(ex, extt);

            Exception expectedException = null;

            try
            {
                choviet.Triangle(a, b, c);
                System.Console.WriteLine(choviet.Triangle(a, b, c));
            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }

        public TestContext TestContext { get; set; }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\bai5.csv",
            "bai5#csv",
            DataAccessMethod.Sequential),
         DeploymentItem("bai5.csv"),
         TestMethod]
        public void Testcase2()
        {
            Class1 tvt = new Class1();
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int c = Convert.ToInt32(TestContext.DataRow[2]);
            String ex = Convert.ToString(TestContext.DataRow[3]);

            //System.Console.WriteLine(a);
            //System.Console.WriteLine(b);
            //System.Console.WriteLine(c);
            //System.Console.WriteLine(ex);

            String extt = tvt.Triangle(a, b, c);
            Assert.AreEqual(ex, extt);


        }
        }
}
