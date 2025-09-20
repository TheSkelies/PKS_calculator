using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер дня недели (1-пн ... 7-вс): ");
            int starting_day = Convert.ToInt32(Console.ReadLine());

            if (starting_day > 7 || starting_day < 1)
            {
                Console.WriteLine("Неверный день недели");
            }
            else
            {
                Console.WriteLine("Введите день на проверку");
                int day = Convert.ToInt32(Console.ReadLine());

                if (day > 31 || day < 1)
                {
                    Console.WriteLine("Неправильный день на проверку (1 - 31)");
                }
                else
                {
                    if ((day >= 1 && day <= 5) ||
                        (day >= 8 && day <= 10))
                    {
                        Console.WriteLine("Выходной");
                    }
                    else if (((day + starting_day - 1) % 7 == 6) ||
                        ((day + starting_day - 1) % 7 == 0))
                    {
                        Console.WriteLine("Выходной");
                    }
                    else
                    {
                        Console.WriteLine("Будний день");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
