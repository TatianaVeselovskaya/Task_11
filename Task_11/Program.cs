using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для решения линейного уравнения 0=kx+b");
            Console.Write("Введите коэффициент к= ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свободный член b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            Line_yrav line_yrav = new Line_yrav(k, b);
            Console.WriteLine(line_yrav.Root());
            Console.ReadKey();
        }
    }
}