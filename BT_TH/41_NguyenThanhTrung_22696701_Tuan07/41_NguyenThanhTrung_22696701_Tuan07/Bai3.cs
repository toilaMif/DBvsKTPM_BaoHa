using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai3
    {
        FunctionTuan07 obj = new FunctionTuan07();

        [TestMethod]
        public void TC1()
        {
            int a = 3, b = 1, c = 2;
            int maxExpected = 3;
            double meanExpected = 2;


            int Max = obj.MaxAndMean(a,b,c, out double mean);

            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"maxExpected; {maxExpected}");
            System.Console.WriteLine($"meanExpected; {meanExpected}");
            System.Console.WriteLine($"Max: {Max} ");
            System.Console.WriteLine($"Mean: {mean} ");
            Assert.AreEqual(maxExpected, Max);
            Assert.AreEqual(meanExpected, mean);
        }
        [TestMethod]
        public void TC2()
        {
            int a = 3, b = 2, c = 5;
            int maxExpected = 2;
            double meanExpected = 3.33333333333333;


            int Max = obj.MaxAndMean(a, b, c, out double mean);

            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"maxExpected; {maxExpected}");
            System.Console.WriteLine($"meanExpected; {meanExpected}");
            System.Console.WriteLine($"Max: {Max} ");
            System.Console.WriteLine($"Mean: {mean} ");
            Assert.AreEqual(maxExpected, Max);
            Assert.AreEqual(meanExpected, mean, 0.0001);
        }
        [TestMethod]
        public void TC3()
        {
            int a = 3, b = 4, c = 2;
            int maxExpected = 4;
            double meanExpected = 3;


            int Max = obj.MaxAndMean(a, b, c, out double mean);

            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"maxExpected; {maxExpected}");
            System.Console.WriteLine($"meanExpected; {meanExpected}");
            System.Console.WriteLine($"Max: {Max} ");
            System.Console.WriteLine($"Mean: {mean} ");
            Assert.AreEqual(maxExpected, Max);
            Assert.AreEqual(meanExpected, mean, 0.0001);
        }
        [TestMethod]
        public void TC4()
        {
            int a = 3, b = 4, c = 5;
            int maxExpected = 5;
            double meanExpected = 4;


            int Max = obj.MaxAndMean(a, b, c, out double mean);

            System.Console.WriteLine($"Input: {a}, {b}, {c} ");
            System.Console.WriteLine($"maxExpected; {maxExpected}");
            System.Console.WriteLine($"meanExpected; {meanExpected}");
            System.Console.WriteLine($"Max: {Max} ");
            System.Console.WriteLine($"Mean: {mean} ");
            Assert.AreEqual(maxExpected, Max);
            Assert.AreEqual(meanExpected, mean, 0.0001);
        }



    }
}
