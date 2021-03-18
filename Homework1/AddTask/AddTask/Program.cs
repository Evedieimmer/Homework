using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTask
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1 - шахматная доска");
            Console.WriteLine("2 - конвертер из арабских в римские цифры");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: Chess(); break;
                case 2: Roman(); break;
            }

            void Roman()
            {
                Console.WriteLine("Введите число, которое нужно конвертировать");
                Dictionary<int, string> ra = new Dictionary<int, string>
                {   { 1000, "M" }, { 900, "CM" }, { 500, "D" },
                    { 400, "CD" },{ 100, "C" },{ 90 , "XC" },
                    { 50 , "L" },  { 40 , "XL" },  { 10 , "X" },
                    { 9  , "IX" },  { 5  , "V" },  { 4  , "IV" },  { 1  , "I" } };

                string Convert(int number) =>
                    ra.Where(x => x.Key <= number)
                        .Select(d => d.Value + Convert(number - d.Key))
                        .FirstOrDefault();

                Console.WriteLine("римские:" + Convert(int.Parse(Console.ReadLine())));
                Console.ReadKey();
                CloseOrMenu();
            }


            void Chess()
            {
                Console.WriteLine("Введите количество шашек");
                int chess = int.Parse(Console.ReadLine());
                if (chess % 4 == 0)
                {
                    Console.WriteLine("Да");
                }
                else Console.WriteLine("Нет");
                Console.ReadKey();
                CloseOrMenu();
                // по идее мы должны были считать уравнение прогрессии и сравнивать с введенным числом
                // но задача позволяет сделать все намного проще
                // формула для рассчета будет: x/4 + 1, но т.к. мы проверяем на целочисленность, то +1 можно отбросить.
            }

            void CloseOrMenu()
            {
                Console.Clear();
                Console.WriteLine("Чтобы вернутся в меню, нажми 1 \n" +
                    "Чтобы закрыть приложение нажми любую клавишу и enter");
                try
                {
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1) { Main(); }
                }
                catch
                {
                    Console.Out.Close();
                }
            }
        }
    }
}
