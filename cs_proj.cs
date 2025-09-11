using System;
using System.Text;
using System.Threading.Tasks;
namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double mem = 0;
            string value;
            do
            {
                double res = 0;
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                if (!(num1 >= -1_000_000 && num1 <= 1_000_000))
                {
                    Console.WriteLine("Число должно быть в пределах от -1000000 до 1000000");
                    break;
                }
                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (!(num2 >= -1_000_000 && num2 <= 1_000_000))
                {
                    Console.WriteLine("Число должно быть в пределах от -1000000 до 1000000");
                    break;
                }
                Console.Write("Введите операцию (+, -, *, /, %, rev (1/x), **2, sqrt): ");
                string symbol = Console.ReadLine();
                Console.WriteLine("Введите операцию с памятью (M+, M-, MR, nothing): ");
                string mem_sym = Console.ReadLine();
                switch (symbol)
                {

                    case "%":
                        res = num1 % num2;
                        Console.WriteLine("Остаток от деления:" + res);

                        
                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "**2":
                        res = Math.Pow(num1, 2);
                        Console.WriteLine("Квадрат первого числа: " + res);
                        res = Math.Pow(num2, 2);
                        Console.WriteLine("Квадрат первого числа: " + res);

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "sqrt":
                        if (num1 >= 0)
                        {
                            res = Math.Round(Math.Sqrt(num1), 4);
                            Console.WriteLine("Корень первого числа: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вычислить корень из отрицательного числа");
                        }
                        if (num2 >= 0)
                        {
                            res = Math.Round(Math.Sqrt(num2), 4);
                            Console.WriteLine("Корень первого числа: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вычислить корень из отрицательного числа");
                        }

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "rev":
                        if (num1 != 0)
                        {
                            res = 1 / num1;
                            Console.WriteLine("Обратное: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }
                        if (num2 != 0)
                        {
                            res = 1 / num2;
                            Console.WriteLine("Обратное: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Сумма: " + res);

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Разность: " + res);

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Произведение: " + res);

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;

                    case "/":   
                        if (num2 != 0)
                        {
                            res = Math.Round(num1 / num2, 4);
                            Console.WriteLine("Частное: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }

                        switch (mem_sym)
                        {
                            case "M+":
                                mem = mem + res;
                                break;

                            case "M-":
                                mem = mem - res;
                                break;

                            case "MR":
                                Console.WriteLine("Значение в памяти: " + mem);
                                break;
                        }

                        break;
                        
                    default:
                        Console.WriteLine("Не правильный ввод");
                        break;
                }

                Console.Write("Хотите продолжить (y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
