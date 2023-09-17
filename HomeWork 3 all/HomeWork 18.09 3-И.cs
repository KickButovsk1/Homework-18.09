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
            double y = Convert.ToDouble(Console.ReadLine());
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double otvet = y * (m1 * m2 / Math.Pow(r, 2));
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
    }
}
