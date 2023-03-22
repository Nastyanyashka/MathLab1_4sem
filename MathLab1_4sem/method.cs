using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLab1_4sem
{
    internal class method
    {
        protected method() { }
        protected float func(float x)
        {
            float smth = 2 * (float)Math.Pow(x, 4.0) - 24 * (float)Math.Pow(x, 2.0) - x + 8;
            return smth;
        }
        protected float derivative(float x)
        {
            return 8 * (float)Math.Pow(x, 3.0) - 48 * x - 1;
        }
    }
}
