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
                Console.WriteLine($"{i}: Ваше число больше {cur_num}? (да-1, нет-0)");
                otvet = Convert.ToInt32(Console.ReadLine());
                if (otvet == 1)
                {
                    min_num = cur_num;
                    cur_num += (max_num - cur_num) / 2;
                }
                else if (otvet == 0)
                {
                    max_num = cur_num;
                    cur_num -= (cur_num - min_num)/2;
                }
            }
            if (otvet == 0 && cur_num == 1)
            {
                Console.Write("Вы загадали число: ");
                Console.WriteLine(0);
            }
            else
            {
                Console.Write("Вы загадали число: ");
                Console.WriteLine(max_num);
            }
            
            
            
        }
    }
}
