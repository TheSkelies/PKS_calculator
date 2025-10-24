using System;

namespace corp_sys
{
    class Program
    {
        

        static void create_double_matrix(double[][] matrix, int m)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new double[m];
            }
        }


        static double determinant(double[][] matrix)
        {
            int n = matrix.Length;

            if (n == 1)
                return matrix[0][0];

            if (n == 2)
                return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];

            double det = 0;
            for (int p = 0; p < n; p++)
            {
                double[][] subMatrix = new double[n - 1][];
                create_double_matrix(subMatrix, n-1);

                for (int i = 1; i < n; i++)
                {
                    int colIndex = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == p) continue;
                        subMatrix[i - 1][colIndex] = matrix[i][j];
                        colIndex++;
                    }
                }

                int sign = (p % 2 == 0) ? 1 : -1;
                det += sign * matrix[0][p] * determinant(subMatrix);
            }

            return det;
        }


        static double[][] inverse_matrix(double[][] matrix)
        {
            int n = matrix.Length;
            double det = determinant(matrix);
            double[][] inv = new double[n][];
            create_double_matrix(inv, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double[][] minor = new double[n - 1][];
                    create_double_matrix(minor, n - 1);
                    int mi = 0;

                    for (int r = 0; r < n; r++)
                    {
                        if (r == i) continue;
                        int mj = 0;
                        for (int c = 0; c < n; c++)
                        {
                            if (c == j) continue;
                            minor[mi][mj] = matrix[r][c];
                            mj++;
                        }
                        mi++;
                    }

                    int sign = ((i + j) % 2 == 0) ? 1 : -1;
                    inv[j][i] = sign * determinant(minor) / det;
                }
            }

            return inv;
        }

        static double[][] transpon_matrix(double[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            double[][] trans = new double[m][];
            create_double_matrix(trans, n);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    trans[j][i] = matrix[i][j];

            return trans;
        }

        static double[][] matrix_multiplication(double[][] matrix1, double[][] matrix2)
        {
            int n1 = matrix1.Length;
            int n2 = matrix2.Length;
            int m2 = matrix2[0].Length;
            double[][] mult_of_matrix = new double[n1][];
            create_double_matrix(mult_of_matrix, m2);
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mult_of_matrix[i][j] = 0;
                    for (int k = 0; k < n2; k++)
                    {
                        double el = matrix1[i][k] * matrix2[k][j];
                        mult_of_matrix[i][j] += el;
                    }
                }
            }
            return mult_of_matrix;

        }

        

        static void print_double_matrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($" {Math.Round(matrix[i][j], 4)}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк n для первой матрицы: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов m для первой матрицы: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= 0 || m1 <= 0)
            {
                Console.WriteLine("Не верно введены размеры первой матрицы");
                return;
            }

            Console.Write("Введите количество строк n для второй матрицы: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов m для второй матрицы: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            if (n2 <= 0 || m2 <= 0)
            {
                Console.WriteLine("Не верно введены размеры второй матрицы");
                return;
            }

            double[][] matrix1 = new double[n1][];
            create_double_matrix(matrix1, m1);

            double[][] matrix2 = new double[n2][];
            create_double_matrix(matrix2, m2);

            Console.Write("Введите нужную вам опцию (1 - ввести вручную; 2 - случайные числа): ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Введите данные первой матрицы");
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < m1; j++)
                        {
                            Console.Write($"Введите элемент для {i+1} строки {j+1} столбца: ");
                            int el = Convert.ToInt32(Console.ReadLine());
                            matrix1[i][j] = el;
                        }
                    }

                    Console.WriteLine("Введите данные второй матрицы");
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m2; j++)
                        {
                            Console.Write($"Введите элемент для {i+1} строки {j + 1} столбца: ");
                            int el = Convert.ToInt32(Console.ReadLine());
                            matrix2[i][j] = el;
                        }
                    }

                    print_double_matrix(matrix1);
                    print_double_matrix(matrix2);

                    break;
                case "2":
                    Random random = new Random();
                    Console.Write("Введите минимальное число a для диапазона: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите максимальное число b для диапазона: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < m1; j++)
                        {
                            int el = random.Next(a, b + 1);
                            matrix1[i][j] = el;
                        }
                    }
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m2; j++)
                        {
                            int el = random.Next(a, b + 1);
                            matrix2[i][j] = el;
                        }
                    }

                    Console.WriteLine("Первая матрица");
                    print_double_matrix(matrix1);
                    Console.WriteLine("Вторая матрица");
                    print_double_matrix(matrix2);



                    break;
                default:
                    Console.WriteLine("Неверный выбор опции, нужно вводить вручную");
                    Console.WriteLine("Введите данные первой матрицы");
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < m1; j++)
                        {
                            Console.Write($"Введите элемент для {i} строки {j} столбца: ");
                            int el = Convert.ToInt32(Console.ReadLine());
                            matrix1[i][j] = el;
                        }
                    }

                    Console.WriteLine("Введите данные второй матрицы");
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m2; j++)
                        {
                            Console.Write($"Введите элемент для {i} строки {j} столбца: ");
                            int el = Convert.ToInt32(Console.ReadLine());
                            matrix2[i][j] = el;
                        }
                    }

                    print_double_matrix(matrix1);
                    print_double_matrix(matrix2);

                    break;
            }



            int oper = 0;
            do
            {
                Console.Write("Введите операцию (0 - завершить, 1 - сложение матриц, 2 - умножение матриц, 3 - найти определитель, 4 - найти обратную матрицу, 5 - найти транспонированные матрицы, 6 - найти корни системы уравнений): ");
                oper = Convert.ToInt32(Console.ReadLine());
                switch (oper)
                {
                    case 0:
                        Console.WriteLine("Выход произведён");
                        break;
                    case 1:
                        Console.WriteLine("Выбранно сложенние матриц");
                        if (n1 != n2 && m1 != m2)
                        {
                            Console.WriteLine("Матрицы нельзя сложить");
                        }
                        else
                        {
                            double[][] sum_of_matrix = new double[n1][];
                            create_double_matrix(sum_of_matrix, m1);


                            for (int i = 0; i < n1; i++)
                            {
                                for (int j = 0; j < m1; j++)
                                {
                                    sum_of_matrix[i][j] = matrix1[i][j] + matrix2[i][j];
                                }
                            }

                            Console.WriteLine("Полученная матрица");
                            print_double_matrix(sum_of_matrix);

                        }
                            break;


                    case 2:
                        Console.WriteLine("Выбранно умножение матриц");

                        if (n1 != m2)
                        {
                            Console.WriteLine("Матрицы нельзя умножить");
                        }

                        else
                        {
                            double[][] mult_of_matrix = matrix_multiplication(matrix1, matrix2);
                            Console.WriteLine("Полученная матрица");
                            print_double_matrix(mult_of_matrix);
                        }
                            break;
                    case 3:
                        Console.WriteLine("Выбранно нахождение определителя");
                        if (n1 != m1)
                        {
                            Console.WriteLine("Нельзя найти определитель для первой матрицы");
                        }
                        else
                        {
                            double deter1 = determinant(matrix1);
                            Console.WriteLine($"Детерминант первой матрицы: {deter1}");
                        }



                        if (n2 != m2)
                        {
                            Console.WriteLine("Нельзя найти определитель для второй матрицы");
                        }
                        else
                        {
                            double deter2 = determinant(matrix2);
                            Console.WriteLine($"Детерминант первой матрицы: {deter2}");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Выбранно нахождение обратной матрицы");

                        if (n1 != m1)
                        {
                            Console.WriteLine("Обратной матрицы для первой не существует");
                        }
                        else if (determinant(matrix1) == 0)
                        {
                            Console.WriteLine("Обратной матрицы для первой не существует");
                        }
                        else
                        {
                            Console.WriteLine("Обратная матрица для первой");
                            double[][] invert_matrix1 = inverse_matrix(matrix1);
                            print_double_matrix(invert_matrix1);
                        }


                        if (n2 != m2)
                        {
                            Console.WriteLine("Обратной матрицы для второй не существует");
                        }
                        else if (determinant(matrix2) == 0)
                        {
                            Console.WriteLine("Обратной матрицы для второй не существует");
                        }
                        else
                        {
                            Console.WriteLine("Обратная матрица для второй");
                            double[][] invert_matrix2 = inverse_matrix(matrix2);
                            print_double_matrix(invert_matrix2);
                        }
                        break;

                    case 5:
                        double[][] trans1 = transpon_matrix(matrix1);
                        double[][] trans2 = transpon_matrix(matrix2);

                        Console.WriteLine("Транспонированная первая матрица");
                        print_double_matrix(trans1);
                        Console.WriteLine("Транспонированная вторая матрица");
                        print_double_matrix(trans2);



                        break;

                    case 6:
                        Console.WriteLine("Выбранно нахождение корней системы уравнений, заданных матрицей (AX = B)");

                        double det = determinant(matrix1);
                        if (n1 != m2)
                        {
                            Console.WriteLine("Нельзя найти корни системы, тк матрицы не соответствуют друг другу");
                        }
                        else if (det == 0)
                        {
                            Console.WriteLine("Нельзя найти корни системы, тк нет обратной матрицы для первой матрицы");
                        }
                        else
                        {
                            double[][] matrix_A = new double[n1][];
                            create_double_matrix(matrix_A, m1);

                            matrix_A = inverse_matrix(matrix1);

                            double[][] matrix_X = matrix_multiplication(matrix2, matrix_A);

                            Console.WriteLine("Полученная матрица корней");
                            print_double_matrix(matrix_X);
                        }
                        break;

                    default:
                        Console.WriteLine("Не верный ввод");
                        break;
                }
            } while (oper != 0);

            

        }
    }

}

