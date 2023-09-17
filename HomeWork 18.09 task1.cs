using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18._09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("A:");
                double A = Convert.ToDouble(Console.ReadLine());
                double AA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("B:");
                double B = Convert.ToDouble(Console.ReadLine());
                double BB = Convert.ToDouble(Console.ReadLine());
                double dlina = Math.Sqrt(Math.Pow(B - A, 2) + Math.Pow(BB - AA, 2));
                Console.WriteLine($"AB = " + dlina);
                Console.ReadKey();
            }
        }
    }
}
