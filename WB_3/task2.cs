using System;

namespace corp_sys
{
    class Program
    {

        static long Akkerman(long m, long n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите целое число m: ");
            string input_m = Console.ReadLine();
            Console.Write("Введите целое число n: ");
            string input_n = Console.ReadLine();

            if (!long.TryParse(input_m, out long m) && !long.TryParse(input_n, out long n))
            {
                Console.WriteLine("Не правильный ввод");
            }
            else
            {
                long m_i = Convert.ToInt32(input_m);
                long n_i = Convert.ToInt32(input_n);
                Console.WriteLine($"A(m, n) = {Akkerman(m_i, n_i)}");
            }

            
            

        }
    }
}
