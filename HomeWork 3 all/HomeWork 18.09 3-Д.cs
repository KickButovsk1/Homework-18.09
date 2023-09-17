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
            double R1 = Convert.ToDouble(Console.ReadLine());
            double R2 = Convert.ToDouble(Console.ReadLine());
            double otvet = 1 / R1 + 1 / R2;
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
    }
}
