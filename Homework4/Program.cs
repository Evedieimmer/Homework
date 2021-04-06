using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Домашняя работа № 4");
            Console.WriteLine("1) Минимальное и максимальное значение");
            Console.WriteLine("2) Уникальные числа");
            Console.WriteLine("3) Вывод отсортированного рандомного массива");
            Console.WriteLine("4) Выход");
            Console.Write("\r\nВыберите номер: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MinMax(); break;
                case "2":
                    UniqNumber();
                    break;
                case "3":
                    RandomNumber();
                    break;
                case "4":
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Main();
                    break;
            }

            void MinMax()
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                try
                {
                    List<int> numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
                    int min = numbers.Select(x => x).OrderBy(x => x).First();
                    int max = numbers.Select(x => x).OrderByDescending(x => x).First();
                    Console.WriteLine($"Максимальное значение: {max}");
                    Console.WriteLine($"Минимальное значение: {min}");

                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    Main();
                }
                catch
                {
                    Console.Write("Вводите целые числа через пробел!");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    MinMax();
                }

            }
            void UniqNumber()
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                try
                {
                    int count = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).Distinct().OrderBy(x => x).Count();
                    Console.WriteLine($"Kоличество уникальных значений: {count}");

                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    Main();
                }
                catch
                {
                    Console.Write("Вводите целые числа через пробел!");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    UniqNumber();
                }

            }
            void RandomNumber()
            {
                Random rnd = new Random();
                int[] rndNum = new int[50];
                for (int i = 0; i < 50; i++)
                {
                    rndNum[i] = rnd.Next(0, 25);
                }
                Console.WriteLine("Рандомный массив:");
                foreach (int i in rndNum)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                int[] arr = rndNum.Where(x => x >= 10 & x <= 20).Distinct().OrderBy(x => x).ToArray();
                Console.WriteLine(" ");
                Console.WriteLine("Новый массив:");
                foreach (int i in arr)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                Main();
            }
        }
    }
}
