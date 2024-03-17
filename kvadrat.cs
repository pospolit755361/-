using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b * (-Math.Sqrt(d))) / (2 * a);
                double x2 = (-b * Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if(d == 0){
                double x = -b / (2 * a);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            Console.ReadLine();
        }
    }
}
