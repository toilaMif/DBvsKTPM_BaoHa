using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTest
{
    public class function
    {
        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;

            if (A > B)
            {
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            }
            else
            {
                if (B > C)
                    Maximum = B;
                else
                    Maximum = C;
            }

            return Maximum;
        }
    }
}
