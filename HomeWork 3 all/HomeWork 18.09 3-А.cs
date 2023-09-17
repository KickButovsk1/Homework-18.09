using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double otvet = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
            Console.WriteLine(otvet);
            Console.ReadKey();

        }
    }
}
