using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_4
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long so = 10;
            long s;

           
            Double actual = o.Sum(so, out s);

            System.Console.WriteLine("k: "+ actual);
            System.Console.WriteLine("s: " + s);


        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long so = long.MinValue;
            long s;




            Double actual = o.Sum(so, out s);


            System.Console.WriteLine("k: " + actual);
            System.Console.WriteLine("s: " + s);


        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            long so = long.MaxValue;
            long s;

            Double actual = o.Sum(so, out s);

            System.Console.WriteLine("k: " + actual);
            System.Console.WriteLine("s: " + s);


        }
        
    }
}
