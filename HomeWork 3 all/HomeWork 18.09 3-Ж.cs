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
            double R = Convert.ToDouble(Console.ReadLine());
            double otvet = 2 * Math.PI * R;
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
    }
}
