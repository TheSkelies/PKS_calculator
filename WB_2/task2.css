using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета: ");
            int bilet = Convert.ToInt32(Console.ReadLine());
            int left_part = ((bilet/1000)/100 + (bilet / 1000) % 100 / 10 + (bilet / 1000) % 10);
            int right_part = ((bilet % 1000) / 100 + (bilet % 1000) % 100 / 10 + (bilet % 1000) % 10);
            if (bilet > 999999 || bilet < 100000)
            {
                Console.WriteLine("Это не билет");
            }
            else
            {
                Console.WriteLine(left_part == right_part);
            }

        }
    }
}
