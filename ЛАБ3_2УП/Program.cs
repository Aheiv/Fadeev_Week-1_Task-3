using System;

namespace ЛАБ3_2УП
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x < 1) y = (x * x - 1) * (x * x - 1);
            else if (x > 1) y = 1 / ((1 + x) * (1 + x));
            else y = 0;
            return y;
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            Console.Write("Введите начало диапазона x: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Некорректный ввод данных");
            Console.Write("Введите конец диапазона x: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b < a)
                Console.WriteLine("Некорректный ввод данных");
            Console.Write("Введите шаг h: ");
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
                Console.WriteLine("Некорректный ввод данных");
            for (double i = a; i <= b; i+=h)
            {
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }
        }
    }
}
