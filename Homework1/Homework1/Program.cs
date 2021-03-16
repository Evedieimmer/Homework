using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1 - число и месяц");
            Console.WriteLine("2 - координаты и путь");
            var chose = int.Parse(Console.ReadLine());
            switch (chose)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                default: Console.WriteLine("Ошибка, вы неправильно ввели номер!"); break;
            }
            void Task1()
            {
                Console.WriteLine("Введите число месяца");
                int num = int.Parse(Console.ReadLine())-1;
                string[] month = new string[] { "Январь", "Ферваль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
                if(num > 11)
                {
                    Console.WriteLine("Месяцев всего 12!");
                }
                else
                {
                    Console.WriteLine($"Название месяца: {month[num]}");
                }
                Console.ReadKey();
                
            }

            void Task2()
            {
                Console.WriteLine("Введите путь");
                string[] path = Console.ReadLine().ToLower().Split(" ");
                int x = 0;
                int y = 0;
                foreach (var i in path)
                {
                    switch (i)
                    {
                        case "с": y += 1; break;
                        case "ю": y += -1; break;
                        case "з": x += -1; break;
                        case "в": x += 1; break;
                    }
                }
                double hypotenuse = Math.Sqrt(x * x + y * y);
                if (hypotenuse == 0)
                {
                    if (x == 0)
                    {
                        Console.WriteLine($"координата х = {x}, координата у = {y}, путь = {Math.Abs(y)}");

                    }
                    else
                    {
                        Console.WriteLine($"координата х = {x}, координата у = {y}, путь = {Math.Abs(x)}");
                    }
                }
                else
                {
                    Console.WriteLine($"координата х = {x}, координата у = {y}, путь = {hypotenuse}");
                }
            }
            
        }
    }
}
