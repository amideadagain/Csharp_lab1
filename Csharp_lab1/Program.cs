using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = SquareSum(4, 3);
            Console.WriteLine("Ответ: {0}", res);
            Console.ReadKey();
        }

        static double SquareSum(double a, double b)
        {
            double sum = a + b;
            double result = Math.Pow(sum, 2);
            return result;
        }
    }
}