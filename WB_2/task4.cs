using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_num = 63;
            int min_num = 0;
            int cur_num = 32;
            int otvet = 4;
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"{i}: Ваше число больше {cur_num}? (да-1, нет-0, 2 - это моё число)");
                otvet = Convert.ToInt32(Console.ReadLine());
                if (cur_num == 62 && otvet == 1)
                {
                    Console.Write("Вы загадали число: 63");
                    break;
                }
                else if (cur_num == 1 && otvet == 0)
                {
                    Console.Write("Вы загадали число: 0");
                    break;
                }
                else if (otvet == 1)
                {
                    min_num = cur_num;
                    cur_num += (max_num - cur_num) / 2;
                }
                else if (otvet == 0)
                {
                    max_num = cur_num;
                    cur_num -= (cur_num - min_num) / 2;
                }
                else if (otvet == 2)
                {
                    Console.Write("Вы загадали число: ");
                    Console.WriteLine(cur_num);
                    break;
                }
                else
                {
                    Console.WriteLine("Не правильная операция, завершение программы");
                    break;
                }
            }
        }
    }
}
