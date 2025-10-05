using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.Write("Введите число бактерий: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число капель антибиотика: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int hour = 10;

            while (N > 0 && hour != 0)
            {
                N *= 2;
                N -= X*hour;
                hour--;
                if (N < 0)
                {
                    Console.WriteLine($"После {10 - hour} часа бактерий осталось 0");
                }
                else
                {
                    Console.WriteLine($"После {10 - hour} часа бактерий осталось {N}");
                }
            }
            Console.WriteLine("*********************************************************");
        }
    }
}
