using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    public class Class1
    {
        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;

            if (A > B)
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            else
                if (B > C)
                    Maximum = B;
                else
                    Maximum = C;

            return Maximum;
        }
        public int Max(int a, int b, int c)
        {
            int max = 0;

            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;

            if (max < b)
                max = b;

            if (max < c)
                max = c;

            return max;
        }
        public string Triangle(int a, int b, int c)
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
                if (a + c <= b)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 2)
            {
                if (a + b <= c)
                    return "Not a Triangle";
                else
                    return "Triangle is Isosceles";
            }
            else if (match == 3)
            {
                if (b + c <= a)
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
