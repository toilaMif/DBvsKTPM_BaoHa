using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{

    public class Class1
    {
        public double Average(double Sum, double Count)
        {
            if (Count == 1)
            {
                return Sum;
            }
            else if (Count > 0)
            {
                return Sum / Count;
            }
            else
            {
                return 0;
            }
        }


        public String Triangle(int a, int b, int c)
        {
            int match = 0;

            if (a == b)
                match = match + 1;

            if (a == c)
                match = match + 2;

            if (b == c)
                match = match + 3;

            if (match == 0)
            {
                if ((a + b) <= c)
                    return "Not a Triangle";
                else if ((b + c) <= a)
                    return "Not a Triangle";
                else if ((a + c) <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Scalene";
            }
            else if (match == 1)
            {
                if ((a + c) <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 2)
            {
                if ((a + b) <= c)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 3)
            {
                if ((b + c) <= a)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else
            {
                return "Triangle is Equilateral";
            }
        }
    }
}
