using System;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)

        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите значение сторон треугольника");

            Thread.Sleep(1000);
            Thread.Sleep(500);
            Console.Write($" Введите сторону треугольника a = ");
            double a = Convert.ToDouble(Console.ReadLine());
			double df = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите сторону треуголньика b = ");
            double b= Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите сторону треугольника c = ");
            double c= Convert.ToDouble(Console.ReadLine());

            if (a > 0 & b> 0 & c> 0)
            {
                if ((b + c) > a& (a+ c) > b& (a+ b) > c)
                {
                    double sum = a + b+ c;
                    Console.WriteLine($"Периметр треугольника = {Math.Round(sum, 2)}");
                }
                else
                {
                    Console.WriteLine("Две стороны не могут равняться или быть меньше одной стороны");
                }
            }
            else
            {
                Console.WriteLine("Значения должны быть больше 0");
            }
            Thread.Sleep(850);
            Console.ReadKey();
        }
    }
}