using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18._09_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v0 = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double otvet = v0 * t + (a * Math.Pow(t, 2))/2);
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
    }
}
