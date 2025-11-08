using System;

namespace corp_sys
{
    class Program
    {

        static long reverse_num(long num, long reversed)
        {
            if (num == 0)
            {
                return reversed;
            }
            
            long digit_to_add = num % 10;
            long remaining = num / 10;

            return reverse_num(remaining, reversed * 10 + digit_to_add);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string input = Console.ReadLine();

            if (input.Contains('.') || input.Contains(','))
            {
                Console.WriteLine("Число должно быть целым");
            }
            else if (!long.TryParse(input, out long result))
            {
                Console.WriteLine("Ввод содержит не только цифры");
            }
            else if (input.Contains("0"))
            {
                Console.WriteLine("Число содержит ноль");
            }
            else
            {
                long num = Convert.ToInt32(input);

                long answer = reverse_num(num, 0);

                Console.WriteLine(answer);

            }
            

        }
    }
}
