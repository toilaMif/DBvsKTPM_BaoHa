using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_NguyenThanhTrung_22696701_Tuan07
{
    public class FunctionTuan07
    {
        // bai 3
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

        // bai 4
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
        // bai 6
        public double Average(double sum, double count)
        {
            if (count == 1)
                return sum;
            else if (count > 0)
                return sum / count;
            else
                return 0;
        }

        // bai 7
        public int DaysInMonth(int month, int year)
        {

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    if (year % 400 == 0)
                        return 29;
                    else if (year % 400 != 0 && year % 100 == 0)
                        return 28;
                    else if (year % 100 != 0 && year % 4 == 0)
                        return 29;
                    else
                        return 28;

                default:
                    return 0;
            }
        }
        // bai 8


        public (string x1, string x2) Solve(float a, float b, float c)
        {
            if (a == 0)
                return ("Error", "Error");

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return ("No results", "No results");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return (x.ToString(), x.ToString());
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b - sqrtDelta) / (2 * a);
                double x2 = (-b + sqrtDelta) / (2 * a);

                return (x1.ToString(), x2.ToString());
            }

        }
        // bai 9

        public float bai9(float a, float b, float x)
        {
            if (a > b)
                throw new IndexOutOfRangeException();

            if (x < a)
                return a;

            if (x > b)
                return b;

            return x;
        }

        // bai 10
        public bool IsTriangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;

            if (a + b <= c)
                return false;

            if (a + c <= b)
                return false;

            if (b + c <= a)
                return false;

            return true;
        }
        // bai 11 
        public (float x, float y) CenterImage(float w, float h, float ww, float wh)
        {
            if (w <= 0 || h <= 0 || ww <= 0 || wh <= 0)
                throw new IndexOutOfRangeException();

            float x;
            if (w > ww)
                x = 0;
            else
                x = (ww - w) / 2;

            float y;
            if (h > wh)
                y = 0;
            else
                y = (wh - h) / 2;

            return (x, y);
        }
        // bai 12
        public float Bai12(float total, float p1, float p2, float p3)
        {
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
                throw new IndexOutOfRangeException();

            if (total <= 100)
                return total * p1;

            if (total <= 150)
                return 100 * p1 + (total - 100) * p2;

            return 100 * p1 + 50 * p2 + (total - 150) * p3;
        }
        // bai 13
        public bool Bai13(float x1, float y1, float x2, float y2, float x, float y)
        {
            if (x1 > x2 || y1 > y2)
                throw new IndexOutOfRangeException();

            if (x < x1 || x > x2)
                return false;

            if (y < y1 || y > y2)
                return false;

            return true;
        }
        // bai 14
        public (float x, float y, float s) Bai14(float w, float h)
        {
            if (w < 0 || h < 0)
                throw new IndexOutOfRangeException();

            if (w > h)
                return ((w - h) / 2, 0, h);

            return (0, (h - w) / 2, w);
        }
        //bai 15
        public bool Bai15(int year)
        {
            if (year > 10000 || year < 1000)
                return false;

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
            else if (year % 4 == 0)
                return true;

            return false;
        }
        // bài  16
        public bool Bai16(string pass)
        {
            if (pass.Length < 6)
                return false;

            if (pass.Length > 10)
                return false;

            bool hasDigit = false;
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                    break;
                }
            }

            if (!hasDigit)
                return false;

            return true;
        }
        // bai 17
        public bool Bai17(int year, int month, int day)
        {
            if (month < 1 || month > 12)
                return false;

            if (day < 1)
                return false;

            int days = DateTime.DaysInMonth(year, month);

            if (day > days)
                return false;

            return true;
        }
        // bài 18
        public bool Bai18(string email)
        {
            if (!email.Contains("."))
                return false;

            if (email.Contains(".."))
                return false;

            int countAt = email.Split('@').Length - 1;
            if (countAt != 1)
                return false;

            if (email.Contains("@.") || email.Contains(".@") || email.Contains("@@"))
                return false;

            return true;
        }
        // bai 19
        public int Bai19(float height, float weight)
        {
            if (height <= 0)
                return -1;

            if (weight <= 0)
                return -1;

            float scale = weight * 10000 / (height * height);

            if (scale < 18)
                return 2;

            if (scale > 20)
                return 1;

            return 0;
        }
        // bai 20
        public int Bai20(char tmp)
        {
            string str = "Statement Coverage";
            int pos = 32767;

            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == tmp)
                {
                    pos = i;
                    break;
                }
                i++;
            }

            return pos;
        }
        // bài 21 
        public long HexToDec(string hexaString)
        {
            int i = 0;
            long hexnum = 0;
            int c;

            while (i < hexaString.Length)
            {
                c = hexaString[i++];

                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        hexnum = hexnum * 16 + (c - '0');
                        break;

                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                        hexnum = hexnum * 16 + (c - 'a' + 10);
                        break;

                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        hexnum = hexnum * 16 + (c - 'A' + 10);
                        break;

                    default:
                        break;
                }
            }

            return hexnum;
        }
        // bai 5
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
