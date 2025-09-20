using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму обналичивания (не более 150_000): ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 150_000 || N <= 0)
            {
                Console.WriteLine("Не верная сумма");
            }
            else if (N % 100 != 0)
            {
                Console.WriteLine("Невозможно выдать данную сумму");
            }
            else
            {
                int kyp_5000 = N / 5000;
                N = N % 5000;
                int kyp_2000 = N / 2000;
                N = N % 2000;
                int kyp_1000 = N / 1000;
                N = N % 1000;
                int kyp_500 = N / 500;
                N = N % 500;
                int kyp_200 = N / 200;
                N = N % 200;
                int kyp_100 = N / 100;
                N = N % 100;

                Console.WriteLine($"{kyp_5000} по 5000, {kyp_2000} по 2000, {kyp_1000} по 1000, {kyp_500} по 500, {kyp_200} по 200, {kyp_100} по 100");
            }




            Console.ReadKey();
        }
    }
}
