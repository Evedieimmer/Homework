using System;
using System.Collections.Generic;


namespace Homework3
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> formatList = new Dictionary<string, string>
                {{ ".css", "Cascading Style Sheets" },
                { ".js", "JavaScript" },
                { ".py", "Python" },
                { ".kt", "Kotlin" },
                { ".cs", "C Sharp" },
                { ".html", "Hypertext Markup Language" }};

            Console.Clear();
            Console.WriteLine("Домашняя работа № 3");
            Console.WriteLine("1) Работа почты");
            Console.WriteLine("2) Изменить список");
            Console.WriteLine("3) Выход");
            Console.Write("\r\nВыберите номер: ");

            switch (Console.ReadLine())
            {
                case "1":
                    PostTime(); break;
                case "2":
                    MenuList();
                    break;
                case "3":
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Main();
                    break;
            }

            void MenuList()
            {
                Console.Clear();
                Console.WriteLine("Работа с коллекцией Dictionary: 'расширение' - 'название языка'");
                Console.WriteLine("1) Добавить");
                Console.WriteLine("2) Удалить");
                Console.WriteLine("3) Изменить");
                Console.WriteLine("4) Поиск");
                Console.WriteLine("5) Вывести весь список");
                Console.WriteLine("6) Выход в главное меню");

                Console.Write("\r\nВыберите номер: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ToAddInList(); break;
                    case "2":
                        ToRemoveInList(); break;
                    case "3":
                        ToChangeList();
                        break;
                    case "4":
                        ToSearchInList();
                        break;
                    case "5":
                        ToWriteList();
                        break;
                    case "6":
                        Main();
                        break;
                    default:
                        break;
                }
            }
            void ToMenuList()
            {
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                MenuList();
            }

            void ToAddInList()
            {
                Console.WriteLine("Введите формат");
                string k = Console.ReadLine();
                Console.WriteLine("Введите полное название языка");
                string v = Console.ReadLine();
                try
                {
                    formatList.Add(k, v);
                    Console.WriteLine("Элемент успешно добавлен!");
                    ToMenuList();
                }
                catch
                {
                    Console.WriteLine("Такой элемент уже существует!");
                    ToMenuList();
                }
                formatList.Add(k, v);
                ToMenuList();

            }
            void ToRemoveInList()
            {
                Console.WriteLine("Введите короткое название");
                string search = Console.ReadLine();
                try
                {
                    formatList.Remove(search);
                    Console.WriteLine("Элемент успешно удален!");
                    ToMenuList();
                }
                catch
                {
                    Console.WriteLine("Такого элемента не существует!");
                    ToMenuList();
                }
            }
            void ToSearchInList()
            {
                Console.WriteLine("Введите короткое название");
                string search = Console.ReadLine();
                try
                {
                    string result = formatList[search];
                    Console.WriteLine($"Полное название: {result}");
                    ToMenuList();
                }
                catch
                {
                    Console.WriteLine("Такого элемента не существует!");
                    ToMenuList();
                }
            }
            void ToWriteList()
            {
                Console.WriteLine("Вывод списка");

                foreach (KeyValuePair<string, string> kvp in formatList)
                {
                    Console.WriteLine($"Формат = {kvp.Key}, Полное название языка = {kvp.Value}");
                }
                ToMenuList();
            }
            void ToChangeList()
            {
                Console.WriteLine("Введите короткое название");
                string search = Console.ReadLine();
                try
                {
                    string result = formatList[search];
                    Console.WriteLine($"Найденное название: {result}");
                    Console.WriteLine("Введите измененное название");
                    string newElement = Console.ReadLine();
                    formatList[search] = newElement;
                    Console.WriteLine("Элемент успешно изменен!");
                    ToMenuList();
                }
                catch
                {
                    Console.WriteLine("Такого элемента не существует!");
                    ToMenuList();
                }
            }

            void PostTime()
            {
                Console.WriteLine("Введите время работы почты в минутах");
                int timeWork = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество посетителей");
                int visitors = int.Parse(Console.ReadLine());
                var timeVisitList = new List<int>();
                Console.WriteLine("Введите время обслуживания");
                int j = 1;
                while (j <= visitors)
                {
                    Console.Write($"{j}-го посетителя:");
                    timeVisitList.Add(int.Parse(Console.ReadLine()));
                    j++;
                }
                int summ = 0;
                int i = 0;
                try {
                    while (summ < timeWork)
                    {
                        summ = summ + timeVisitList[i];
                        i++;
                    }
                    Console.WriteLine($"Количество не обслуженных посетителей: {visitors - i}");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    Main();
                }
                catch {
                    Console.WriteLine($"Все клиенты обслужены, сегодня работники почты могут уйти домой пораньше :)");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    Main();
                }
                
            }

        }
    }
}

