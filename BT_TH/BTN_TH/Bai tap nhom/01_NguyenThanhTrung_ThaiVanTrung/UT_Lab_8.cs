using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_8
    {
        [TestMethod]
        public void TestMethod1()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 0;
            int right = 6;
            int[] expected = {1,3,4,5,6,7,8};

            o.QuickSort(array,left,right);
            CollectionAssert.AreEqual(expected, array);
            System.Console.WriteLine(string.Join(", ", array));
            System.Console.WriteLine(string.Join(", ", expected));
        }
        //[TestMethod]
        //public void TestMethod2()

        //{
        //    MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        //    int[] array = { 1, 5, 4, 3, 6, 7, Int64.MinValue};
        //    int left = 0;
        //    int right = 6;
        //    int[] expected = { 1, 3, 4, 5, 6, 7, 8 };

        //    o.QuickSort(array, left, right);
        //    CollectionAssert.AreEqual(expected, array);
        //    System.Console.WriteLine(string.Join(", ", array));
        //    System.Console.WriteLine(string.Join(", ", expected));


        //}
        //[TestMethod]
        //public void TestMethod3()

        //{
        //    MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        //    int[] array = { 1, 5, 4, 3, 6, 7, Int32.MaxValue+5};
        //    int left = 0;
        //    int right = 6;
        //    int[] expected = { 1, 3, 4, 5, 6, 7, 8 };

        //    o.QuickSort(array, left, right);
        //    CollectionAssert.AreEqual(expected, array);
        //    System.Console.WriteLine(string.Join(", ", array));
        //    System.Console.WriteLine(string.Join(", ", expected));


        //}
        [TestMethod]
        public void TestMethod4()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = -10;
            int right = 6;



             Exception expectedException = null;

            try
            {
            o.QuickSort(array, left, right);

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod5()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 10;
            int right = 6;



            Exception expectedException = null;

            try
            {
                o.QuickSort(array, left, right);

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
                System.Console.WriteLine(string.Join(", ", array));
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod6()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 0;
            int right = 20;



            Exception expectedException = null;

            try
            {
                o.QuickSort(array, left, right);

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
                System.Console.WriteLine(string.Join(", ", array));
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod7()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7,Int32.MinValue };
            int left = 0;
            int right = 6;
            int[] expected = { Int32.MinValue,1, 3, 4, 5, 6, 7 };

            o.QuickSort(array, left, right);
            CollectionAssert.AreEqual(expected, array);
            System.Console.WriteLine(string.Join(", ", array));
            System.Console.WriteLine(string.Join(", ", expected));
        }
        [TestMethod]
        public void TestMethod8()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, Int32.MaxValue };
            int left = 0;
            int right = 6;
            int[] expected = {1, 3, 4, 5, 6, 7 ,Int32.MaxValue};

            o.QuickSort(array, left, right);
            CollectionAssert.AreEqual(expected, array);
            System.Console.WriteLine(string.Join(", ", array));
            System.Console.WriteLine(string.Join(", ", expected));
        }
        [TestMethod]
        public void TestMethod9()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8};
            int left = 3;
            int right = 4;
            int[] expected = { 1, 5, 4, 3, 6, 7, 8 };

            o.QuickSort(array, left, right);
            CollectionAssert.AreEqual(expected, array);
            System.Console.WriteLine(string.Join(", ", array));
            System.Console.WriteLine(string.Join(", ", expected));
        }
        [TestMethod]
        public void TestMethod10()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 0;
            int right = 6;
            int[] expected = { 1, 3, 4, 5, 6, 7, 8 };

            o.QuickSort(array, left, right);
            CollectionAssert.AreEqual(expected, array);
            System.Console.WriteLine(string.Join(", ", array));
            System.Console.WriteLine(string.Join(", ", expected));
        }
        //[TestMethod]
        //public void TestMethod11()

        //{
        //    MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        //    int[] array = { 1, 5, 4, 3, 6, 7, Int32.MinValue-1};
        //    int left = 0;
        //    int right = 6;
        //    o.QuickSort(array, left, right);
        //    CollectionAssert.AreEqual(expected, array);
        //    System.Console.WriteLine(string.Join(", ", array));
        //    System.Console.WriteLine(string.Join(", ", expected));


        //}
        //[TestMethod]
        //public void TestMethod12()

        //{
        //    MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        //    int[] array = { 1, 5, 4, 3, 6, 7, Int32.MaxValue+1};
        //    int left = 0;
        //    int right = 6;

        //    o.QuickSort(array, left, right);
        //    CollectionAssert.AreEqual(expected, array);
        //    System.Console.WriteLine(string.Join(", ", array));
        //    System.Console.WriteLine(string.Join(", ", expected));


        //}
        [TestMethod]
        public void TestMethod13()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = -1;
            int right = 6;



            Exception expectedException = null;

            try
            {
                o.QuickSort(array, left, right);

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
                System.Console.WriteLine(string.Join(", ", array));
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod14()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 6;
            int right = 6;



            Exception expectedException = null;

            try
            {
                o.QuickSort(array, left, right);
                System.Console.WriteLine(string.Join(", ", array));

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
               
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void TestMethod15()

        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            int[] array = { 1, 5, 4, 3, 6, 7, 8 };
            int left = 0;
            int right = 7;



            Exception expectedException = null;

            try
            {
                o.QuickSort(array, left, right);

            }
            catch (IndexOutOfRangeException ex)
            {
                expectedException = ex;
                System.Console.WriteLine(string.Join(", ", array));
            }

            Assert.IsNotNull(expectedException);
        }

    }
}
