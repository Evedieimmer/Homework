using System;
using System.Linq;


namespace Homework2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1 - поиск уникального элемента");
            Console.WriteLine("2 - поиск уникального элемента(чисто на linq)");
            Console.WriteLine("3 - симматричная матрица");
            var chose = int.Parse(Console.ReadLine());
            switch (chose)
            {
                case 1: UniqNum(); break;
                case 2: Unique(); break;
                case 3: Matrix(); break;
                default: Console.WriteLine("Ошибка, вы неправильно ввели номер!"); break;
            }

            //задание № 1 - весь запрос на linq
            //сложность: O(n) — линейная сложность
            void Unique() 
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                int nunu = Console.ReadLine().Split(" ").Select(x => x).Distinct().OrderBy(x => x).Count();
                Console.WriteLine($"Kоличество уникальных значений: {nunu}");
            }

            //задание № 1 - через циклы и linq
            //сложность: O(n) — линейная сложность
            void UniqNum() 
            {
                Console.WriteLine("Введите размерность, а затем элементы массива через пробел:");
                string[] numbers = Console.ReadLine().Split(" ");
                int length = int.Parse(numbers[0]);
                int[] mass = new int[length];
                int j = 1;
                for (int i = 0; i < length; i++)
                {
                    mass[i] = int.Parse(numbers[j]);
                    j++;
                }
                int[] uniqNumber = mass.Select(x => x).Distinct().OrderBy(x => x).ToArray();
                Console.Write("массив уникальных значений:");
                foreach (int i in uniqNumber)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
                Console.WriteLine($"количество уникальных значений: { uniqNumber.Length }");
            }

            // задание № 2 - зеркалим матрицы
            //сложность: O(n2) — квадратичная сложность
            void Matrix() 
            {
                string[] numbers = Console.ReadLine().Split(" ");
                int size = int.Parse(numbers[0]);
                int x = 1;
                int[,] matrix = new int[size, size];
                int[,] transposedMatrix = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[x]);
                        transposedMatrix[j, i] = int.Parse(numbers[x]);
                        x++;
                    }
                }
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (matrix[i, j] == transposedMatrix[i, j]) { count++; }
                    }
                }
                if (count == size * size)
                { Console.WriteLine("daaa"); }
                else
                { Console.WriteLine("neee"); }

                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(transposedMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
