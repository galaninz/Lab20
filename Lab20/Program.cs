using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Lenght;
            double p = Lenght(r);
            Console.WriteLine($"Длина: {p}");
            myDelegate = Area;
            p = Area(r);
            Console.WriteLine($"Площадь: {p}");
            myDelegate = Volume;
            p = Volume(r);
            Console.WriteLine($"Объем: {p}");

            Console.ReadKey();


        }
        static double Lenght(double r) => 2 * Math.PI * r;
        static double Area(double r) => Math.PI * r * r;
        static double Volume(double r) => 4 * Math.PI * r * r * r / 3;
    }
}
