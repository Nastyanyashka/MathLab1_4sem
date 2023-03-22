using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLab1_4sem
{
   
    internal class Newthon_method: method
    {
        float left;
        float right;
        float e;
        List<float> solves = new List<float>();
        public Newthon_method(float left, float right,float e) {
            this.left = left;
            this.right = right;
            this.e = e;
        }
        public void Solve()
        {
            float x0 = right;
            float temp = 0;
            int counter = 0;
            while (true)
            {
                temp = x0 - (func(x0) / derivative(x0));
                if (Math.Abs(temp - x0) <= e)
                {
                    counter++;
                    solves.Add(temp);
                    if(counter ==4) {
                        break;
                    }
                }
                x0 = temp;
            }
           foreach(float x in solves)
           {
                Console.WriteLine(x);
           }
        }
    }
}
