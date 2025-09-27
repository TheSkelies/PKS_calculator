using System;

namespace corp_sys
{
    class Program
    {
        private static double factorial(double x)
        {
            double f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }
        private static double solution(double n, double x)
        {
            if (n == 1) return 1;
            double s = 1;
            for (int i = 1; i < n; i++)
            {
                s += (Math.Pow(x, i) / factorial(i));
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точность e (e < 0,01) (через запятую): ");
            double e = Convert.ToDouble(Console.ReadLine());

            if (e >= 0.01)
            {
                Console.WriteLine("Точность е больше или равно 0,01");
            }
            else
            {
                string s = Convert.ToString(e);
                int ind = s.IndexOf(',');
                Console.WriteLine(Math.Round(solution(n, x), s.Substring(ind).Length - 1));
            }

            
        }
    }
}
