using System;

namespace corp_sys
{
    class Program
    {
        static bool can_fit_split(int hCount, int vCount, int wH, int hH, int wV, int hV, int fieldW, int fieldH)
        {
            int colsV;
            int rowsV;
            if (hCount == 0)
            {
                colsV = fieldW / wV;
                rowsV = fieldH / hV;
                return colsV * rowsV >= vCount;
            }

            if (vCount == 0)
            {
                int colsH = fieldW / wH;
                int rowsH = fieldH / hH;
                return colsH * rowsH >= hCount;
            }

            int maxColsH = fieldW / wH;
            if (maxColsH == 0) 
            {
                return false; 
            }

            int neededRowsH = (hCount + maxColsH - 1) / maxColsH;
            int heightForH = neededRowsH * hH;
            int remainingHeight = fieldH - heightForH;

            if (remainingHeight < 0) 
            {
                return false;
            }

            colsV = fieldW / wV;
            rowsV = remainingHeight / hV;

            return colsV * rowsV >= vCount;
        }


        static bool can_fit(int n, int widthH, int heightH, int widthV, int heightV, int fieldWidth, int fieldHeight)
        {
            for (int horiz_count = 0; horiz_count <= n; horiz_count++)
            {
                int vert_count = n - horiz_count;

                if (can_fit_split(horiz_count, vert_count, widthH, heightH, widthV, heightV, fieldWidth, fieldHeight))
                {
                    return true;
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

            bool fits = can_fit(n, moduleWidthH, moduleHeightH, moduleWidthV, moduleHeightV, w, h);

            while (fits)
            {
                answer++;

                moduleWidthH = a + 2 * answer;
                moduleHeightH = b + 2 * answer;
                moduleWidthV = b + 2 * answer;
                moduleHeightV = a + 2 * answer;

                fits = can_fit(n, moduleWidthH, moduleHeightH, moduleWidthV, moduleHeightV, w, h);
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
