using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathLab1_4sem
{
    internal class SimpleIterations_method: method      
    {
        float left;
        float right;
        float e;
        List<float> solves = new List<float>();
        public SimpleIterations_method(float left,float right,float e) {
            this.left = left;
            this.right = right;
            this.e = e;
        }   
        public void Solve()
        {
            float x0 = right;
            float temp = 0;
     
            while (true)
            {
                temp = Phi2(x0);
                if (Math.Abs(temp - x0) <= e)
                {
                   
                    solves.Add(temp);
                    break;
                }
                x0 = temp;
            }
            foreach (float x in solves)
            {
                Console.WriteLine(x);
            }
        }
        float Phi(float x)
        {
            float b = 12 * (float)Math.Pow(x, 2);
            float c = (float)x / 2 - 4;
            float pow = (float)1 / 4;
            float solve = (float)Math.Pow(b + c, pow);
            return solve;
        }
        float Phi2(float x) {
            float a = (float)1 / 12 * (float)Math.Pow(x, 4);
            float b = (float)x / -24;
            float c = (float)1 / 3;
            return (float)Math.Sqrt(a+b+c);
        }
    }
}
