using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    public class Class1
    {
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
    }
}
