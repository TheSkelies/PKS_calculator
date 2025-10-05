using System;

namespace corp_sys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество воды в мл: ");
            int water = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество молока в мл: ");
            int milk = Convert.ToInt32(Console.ReadLine());

            int amer = 0;
            int latte = 0;
            int rub = 0;

            while ((water >= 300) || (water >= 30 && milk >= 270))
            {
                Console.Write("Выберите напиток (1 - американо, 2 - латте): ");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        if (water < 300)
                        {
                            Console.WriteLine("Не хватает воды");
                        }
                        else
                        {
                            Console.WriteLine("Ваш напиток готов.");
                            amer++;
                            rub += 150;
                            water -= 300;

                        }
                        break;
                    case "2":
                        if (water < 30)
                        {
                            Console.WriteLine("Не хватает воды");
                        }
                        else if (milk < 270)
                        {
                            Console.WriteLine("Не хватает молока");
                        }
                        else
                        {
                            Console.WriteLine("Ваш напиток готов.");
                            latte++;
                            rub += 170;
                            water -= 30;
                            milk -= 270;

                        }
                        break;

                }
            }
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Отчёт");
            Console.WriteLine("Ингридиентов осталось:");
            Console.WriteLine($"       Вода: {water} мл");
            Console.WriteLine($"       Молоко: {milk} мл");
            Console.WriteLine($"Кружек американо приготовлено: {amer}");
            Console.WriteLine($"Кружек латте приготовлено: {latte}");
            Console.WriteLine($"Итого: {rub} рублей.");
            Console.WriteLine("*********************************************************");
        }
    }
}
