using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Trung_Trung
{
    [TestClass]
    public class UT_Lab_7
    {
        [TestMethod]
        public void TestMethod1()

        {
            MethodLibrary.MethodLibrary o1 = new MethodLibrary.MethodLibrary();
            int[] array1 = { 1, 2, 5, 3, 4, 7, 8, 9 };
            int expected1 = 9;

            int actual1 = o1.Largest(array1);
            Assert.AreEqual(expected1, actual1);
        }

        //[TestMethod]
        //public void TestMethod2()

        //{
        //    MethodLibrary.MethodLibrary o2 = new MethodLibrary.MethodLibrary();
        //    int[] array2 = { 1, 2, 5, 3, 4, 7, 8, Int32.MinValue-5};


        //    Exception expectedException = null;

        //    try
        //    {

        //        System.Console.WriteLine(o2.Largest(array2));

        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        expectedException = ex;
        //    }

        //    Assert.IsNotNull(expectedException);
        //}

        //[TestMethod]
        //public void TestMethod3()

        //{
        //    MethodLibrary.MethodLibrary o3 = new MethodLibrary.MethodLibrary();
        //    int[] array3 = { 1, 2, 5, 3, 4, 7, 8, Int32.MaxValue + 5 };


        //    Exception expectedException = null;

        //    try
        //    {

        //        System.Console.WriteLine(o3.Largest(array3));

        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        expectedException = ex;
        //    }

        //    Assert.IsNotNull(expectedException);
        //}

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o1 = new MethodLibrary.MethodLibrary();
            int[] array1 = { 1, 2, 5, 3, 4, 7, 8, Int32.MinValue };
            int expected1 = 8;
            int actual1 = o1.Largest(array1);
            Assert.AreEqual(expected1, actual1);


        }
        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o1 = new MethodLibrary.MethodLibrary();
            int[] array1 = { 1, 2, 5, 3, 4, 7, 8, Int32.MaxValue };
            int expected1 = Int32.MaxValue;
            int actual1 = o1.Largest(array1);
            Assert.AreEqual(expected1, actual1);
        }
        //[TestMethod]
        //public void TestMethod6()
        //{
        //    MethodLibrary.MethodLibrary o3 = new MethodLibrary.MethodLibrary();
        //    int[] array3 = { 1, 2, 5, 3, 4, 7, 8, Int32.MinValue - 1 };


        //    Exception expectedException = null;

        //    try
        //    {

        //        System.Console.WriteLine(o3.Largest(array3));

        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        expectedException = ex;
        //    }

        //    Assert.IsNotNull(expectedException);
        //}
        //[TestMethod]
        //public void TestMethod7()
        //{
        //    MethodLibrary.MethodLibrary o3 = new MethodLibrary.MethodLibrary();
        //    int[] array3 = { 1, 2, 5, 3, 4, 7, 8, Int32.MaxValue + 1 };


        //    Exception expectedException = null;

        //    try
        //    {

        //        System.Console.WriteLine(o3.Largest(array3));

        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        expectedException = ex;
        //    }

        //    Assert.IsNotNull(expectedException);
        //}
        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary o1 = new MethodLibrary.MethodLibrary();
            int[] array1 = {};
            int expected1 = Int32.MaxValue;
            int actual1 = o1.Largest(array1);
            Assert.AreEqual(expected1, actual1);
        }
    }
    
    }
