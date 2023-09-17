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
            double b = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double otvet = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
    }
}
