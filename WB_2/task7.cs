using System;

namespace corp_sys
{
    class Program
    {
        static bool fit_modules(int n, int modW, int modH, int fW, int fH)
        {
            if (modW > fW || modH > fH)
                return false;

            int totalMods = (fW / modW) * (fH / modH);

            return totalMods >= n;
        }

        static int find_d(int n, int a, int b, int w, int h)
        {
            int answer = 0;

            int modW = a + 2 * answer;
            int modH = b + 2 * answer;

            bool fits1 = fit_modules(n, modW, modH, w, h);
            bool fits2 = fit_modules(n, modH, modW, w, h);

            while (fits1 || fits2)
            {
                answer++;

                modW = a + 2 * answer;
                modH = b + 2 * answer;

                fits1 = fit_modules(n, modW, modH, w, h);
                fits2 = fit_modules(n, modH, modW, w, h);
            }


            return answer - 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите w: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            

            if (n <= 0)
            {
                Console.WriteLine("Число модулей введено неверно");
            }
            else if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Размер модулей введён неверно");
            }
            else if (w <= 0 || h <= 0)
            {
                Console.WriteLine("Размер поля введён неверно");
            }
            else
            {
                int d = find_d(n, a, b, w, h);
                Console.WriteLine($"Ответ d = {d} ");
            }
            
        }
    }

}
