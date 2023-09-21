using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {   double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Первая координата центра -"+a);
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Первая координата центра -"+ b);
            double R = Convert.ToDouble(Console.ReadLine());
            double G = Math.Pow(R, 2);
            Console.WriteLine("Радиус окружности - " + R);
            Console.WriteLine($"Уравнение окружности - (x-{a})^2+(y-{b})^2={G}");
            Console.ReadKey();
        }
    }
}

