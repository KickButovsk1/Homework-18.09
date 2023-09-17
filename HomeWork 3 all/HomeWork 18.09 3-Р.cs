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
            double x = Convert.ToDouble(Console.ReadLine());
            double otvet = (Math.Sqrt(x + 1) + Math.Sqrt(x - 1) / (2 * Math.Sqrt(x)));
            Console.WriteLine(otvet);
            Console.ReadKey();

        }
    }
}
