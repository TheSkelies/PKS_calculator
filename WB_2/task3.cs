using System;

namespace corp_sys
{
    class Program
    {
        static private int NOD(int m, int n)
        {
            int bol;
            if (Math.Abs(n) > Math.Abs(m))
            {
                bol = n;
            }
            else
            {
                bol = m;
            }
            for (int i = Math.Abs(bol)/2; i > 0; i--)
            {
                if (Math.Abs(m) % i == 0 && Math.Abs(n) % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите числитель: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
            else if (M == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int nod = NOD(M, N);
                if ((M < 0 && N > 0) || (M > 0 && N < 0))
                {
                    Console.Write("-");
                    Console.Write(Math.Abs(M) / nod);
                    Console.Write(" / ");
                    Console.Write(Math.Abs(N) / nod);
                }
                else
                {
                    Console.Write(Math.Abs(M) / nod);
                    Console.Write(" / ");
                    Console.Write(Math.Abs(N) / nod);
                }
            }
            
        }
    }
}
