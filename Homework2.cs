using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты правой точки - ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки - ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double k = (y1 - y2);
            double k1 = (x1 - x2);
            if (k1 <= 0)
            {
                Console.WriteLine("Знаменатель в уравнении k не может быть меньше либо равен 0");
            }
            else
            {
                Console.WriteLine("Коэф k = " + k / k1);
            }
            double b = y2 - (k * x2);
            Console.WriteLine("Свободный член b будет равен - " + b);
            Console.WriteLine($"Вывод уравнения прямой y={k}*x+{b}");
            Console.ReadKey();
        }
    }
}
