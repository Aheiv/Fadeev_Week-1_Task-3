using System;

namespace ЛАБ3УП
{
    class Program
    {
        static double chetnechet(int y)
        {
            if (Math.Abs(y) % 10 == 0 || Math.Abs(y) % 10 == 2 || Math.Abs(y) % 10 == 4 || Math.Abs(y) % 10 == 6 || Math.Abs(y) % 10 == 8)
            {
                Console.WriteLine("Ваше число - чётное");
                y = y / 2;
            }
            else
            {
                Console.WriteLine("Ваше число - нечётное");
                y = 0;
            }
            return y;
        }
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите ваше число: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Некорретный ввод данных!");
            Console.WriteLine("Ваше число теперь равно " + chetnechet(a));
        }    
    }
}
