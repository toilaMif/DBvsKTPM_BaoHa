using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    [TestClass]
    public class Bai21
    {
        FunctionTuan07 o = new FunctionTuan07();

        [TestMethod]
        public void Test_5aA()
        {
            string input = "5aA@";
            long expected = 1450;

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected: {expected}");

            long actual = o.HexToDec(input);

            Console.WriteLine($"Actual: {actual}");

            Assert.AreEqual(expected, actual);
        }
    }
}