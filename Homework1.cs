using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alpha;
            string str = Console.ReadLine();
            bool alphaa = Double.TryParse(str, out alpha);//преобразуем в double
            if (alphaa == true)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double y = Math.Cos(a) + Math.Sin(a);
                double y1 = Math.Cos(a) - Math.Sin(a);
                double z = Math.Tan(a * 2) + (1 / Math.Cos(a) * 2);
                if (y1 <= 0)
                {
                    Console.WriteLine("Знаменатель y меньше или равен 0");
                }
                else
                {
                    Console.WriteLine("y = {0:0.##} ", y / y1);
                }
                if (z <= 0)
                {
                    Console.WriteLine("У выражения z ответ не может быть меньше либо равен 0");
                }
                else
                {
                    Console.WriteLine("z = {0:0.##} ", z);

                }
            }
            Console.ReadKey();
        }
    }
}
    
