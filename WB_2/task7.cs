using System;
using System.Drawing;

namespace corp_sys
{
    class Program
    {
        static bool CanFit(int n, int a, int b, int w, int h, int d)
        {
            var cols1 = w / (a + 2 * d);
            var rows1 = h / (b + 2 * d);
            var cols2 = w / (b + 2 * d);
            var rows2 = h / (a + 2 * d);

            var fit1 = cols1 * rows1;
            var fit2 = cols2 * rows2;

            if (fit1 >= n || fit2 >= n)
            {
                return true;
            }

            for (var i = 0; i <= cols1; i++)
            {
                for (var j = 0; j <= rows2; j++)
                {
                    var placed = i * rows1 + j * cols2;
                    if (placed >= n)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static int find_d(int n, int a, int b, int w, int h)
        {
            int answer = 0;

            int moduleWidthH = a + 2 * answer;
            int moduleHeightH = b + 2 * answer;
            int moduleWidthV = b + 2 * answer;
            int moduleHeightV = a + 2 * answer;

            var cols1 = w / moduleWidthH;
            var rows1 = h / moduleHeightH;
            var cols2 = h / moduleWidthV;
            var rows2 = h / moduleHeightV;

            var fit1 = cols1 * rows1;
            var fit2 = cols2 * rows2;

            while (CanFit(n, a, b, w, h, answer))
            {
                answer++;

                moduleWidthH = a + 2 * answer;
                moduleHeightH = b + 2 * answer;
                moduleWidthV = b + 2 * answer;
                moduleHeightV = a + 2 * answer;


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
