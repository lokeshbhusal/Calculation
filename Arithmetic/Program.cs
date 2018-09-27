using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 6;
            double b = 8;
            double sum = Add(a, b);
            Console.WriteLine("sum={0}",sum);
      
        }
        static double Add(double a,double b)
        {
            return a + b;
        }


    }
}
