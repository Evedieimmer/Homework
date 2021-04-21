using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkWithCollectionLinq
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> productCalorieIn100g = new Dictionary<string, int>
                {{ "молоко 3.5% ", 63 },
                { "яблоко", 52 },
                { "кофе черный с сахаром", 16 },
                { "лапша", 137 },
                { "брокколи", 34 },
                { "банан", 89 },
                { "картофель отваренный", 89 },
                { "картофель жаренный", 149 },
                { "сметана 10%", 117 },
                { "майонез", 390 },
                { "чай с сахаром", 20 }};
            Menu();

            void Menu()
            {
                Console.Clear();
                PrintLine();
                Console.WriteLine("Список продуктов - калории содержащиеся в 100г продукта:");
                PrintLine();
                foreach (KeyValuePair<string, int> keyValue in productCalorieIn100g)
                {
                    Console.WriteLine($"{keyValue.Key}  -  {keyValue.Value} калорий");
                }
                PrintLine();
                Console.WriteLine("Что будем делать?:");
                Console.WriteLine("(1) - добавление нового продукта");
                Console.WriteLine("(2) - удаление продукта по названию");
                Console.WriteLine("(3) - вывод списка содержащего определенную букву или набор букв");
                Console.WriteLine("(4) - сумма калорий всего списка");
                Console.WriteLine("(5) - самый калорийный продукт");
                Console.WriteLine("(6) - самый низкокалорийный продукт");
                Console.WriteLine("(7) - Выход");
                Console.Write("\r\nВыберите номер: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        DeleteProduct();
                        break;
                    case "3":
                        ListSearch();
                        break;
                    case "4":
                        SumCalorie();
                        break;
                    case "5":
                        MaxCalorie();
                        break;
                    case "6":
                        MinCalorie();
                        break;
                    case "7":
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }
          
            void PrintLine() { Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); }

            void AddProduct() 
            {
                Console.WriteLine("Введите название продукта:");
                string product = Console.ReadLine();
                Console.WriteLine("Введите количество калорий, содержащихся в 100г");
                try
                {
                    int calorie = int.Parse(Console.ReadLine());
                    productCalorieIn100g.Add(product, calorie);
                    Console.WriteLine("Продукт успешно добавлен!");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    Menu();
                }
                catch
                {
                    Console.WriteLine("Вводите калории цифрами!:");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    Menu();
                }
            }

            void DeleteProduct()
            {
                Console.WriteLine("Введите название продукта для удаления:");
                string delete = Console.ReadLine();
                try
                {
                    string product = productCalorieIn100g.Keys.Where(x => x.Contains(delete)).First();
                    productCalorieIn100g.Remove(product);
                    Console.WriteLine("Продукт успешно удален!");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    Menu();
                }
                catch
                {
                    Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    Menu();
                }
            }

            void ListSearch()
            {
                Console.WriteLine("Введите букву или набор букв");
                string text = Console.ReadLine();
                try
                {
                    var search = productCalorieIn100g.Where(x => x.Key.Contains(text)).ToList();
                    foreach (var item in search)
                    {
                        Console.WriteLine($"{item.Key}  -  {item.Value} калорий");
                    }

                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    Menu();
                }
                catch
                {
                    Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                    Console.Write("\r\nНажмите Enter, чтобы продолжить");
                    Console.ReadKey();
                    Menu();
                }
            }

            void SumCalorie()
            {
                int summ = productCalorieIn100g.Values.Aggregate((a, b) => a + b);
                Console.WriteLine($"Сумма всех калорий составляет: {summ}");
                Console.Write("\r\nНажмите Enter, чтобы продолжить");
                Console.ReadKey();
                Menu();
            }

           void MaxCalorie()
            {
                int calorie = productCalorieIn100g.Max(x => x.Value);
                string max = productCalorieIn100g.FirstOrDefault(x => x.Value == calorie).Key;
                Console.WriteLine($"Самый калорийный продукт: {max}");
                Console.Write("\r\nНажмите Enter, чтобы продолжить");
                Console.ReadKey();
                Menu();
            }

            void MinCalorie()
            {
                int calorie = productCalorieIn100g.Min(x => x.Value);
                string min = productCalorieIn100g.FirstOrDefault(x => x.Value == calorie).Key;
                Console.WriteLine($"Самый низкокалорийный продукт: {min}");
                Console.Write("\r\nНажмите Enter, чтобы продолжить");
                Console.ReadKey();
                Menu();
            }
        }
    }
}
