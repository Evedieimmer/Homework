using System;
using System.Collections.Generic;
using System.Linq;

namespace CalorieCalculator
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
                { "картофель отваренный", 87 },
                { "картофель жаренный", 149 },
                { "сметана 10%", 117 },
                { "майонез", 390 },
                { "чай с сахаром", 20 }};
            Dictionary<string, int> UserMenu = new Dictionary<string, int> { };
            Console.Clear();
            Console.WriteLine("Приветствуем тебя в калькуляторе калорий!");

            // BMI - body mass index (индекс массы тела)
            // BMR - basal metabolic rate (кол-во калорий для норм. функционированния организма)
            double bmr;
            string error = "\r\nВы ошиблись при вводе, попробуй снова";
            string nameUser;
            double ageUser;
            double weightUser;
            double heightUser;
            string gender = "";
            double lifeStyle = 0;

            Console.WriteLine("Что будем делать?:");
            Console.WriteLine("(1) - Начинаем!");
            Console.WriteLine("(2) - Выход");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Для начала расскажи немного о себе!");
                    NameUser();
                    break;
                case "2":
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Main();
                    break;
            }

            void NameUser()
            {
                Console.WriteLine("Введи свое имя:");
                nameUser = Console.ReadLine();
                AgeUser();
            }

            void AgeUser()
            {
                Console.WriteLine("Введи свой возраст:");// from 7 to 150
                try
                {
                    ageUser = Convert.ToDouble(Console.ReadLine());
                    if (ageUser > 7 && ageUser < 150)
                    {
                        WeightUser();
                    }
                    else
                    {
                        Console.WriteLine(error);
                        AgeUser();
                    }
                }
                catch
                {
                    Console.WriteLine(error);
                    AgeUser();
                }
            }

            void WeightUser()
            {
                Console.WriteLine("Введи свой вес:");// from 10 to 500
                try
                {
                    weightUser = Convert.ToDouble(Console.ReadLine());
                    if (weightUser > 10 && weightUser < 500)
                    {
                        HeightUser();
                    }
                    else
                    {
                        Console.WriteLine(error);
                        WeightUser();
                    }
                }
                catch
                {
                    Console.WriteLine(error);
                    WeightUser();
                }
            }

            void HeightUser()
            {
                Console.WriteLine("Введи свой рост в см:");//from 30 to 3000
                try
                {
                    heightUser = Convert.ToDouble(Console.ReadLine());
                    if (heightUser > 30 && heightUser < 3000)
                    {
                        heightUser /= 100.0;
                        LifeStyleCheck();
                    }
                    else
                    {
                        Console.WriteLine(error);
                        HeightUser();
                    }
                }
                catch
                {
                    Console.WriteLine(error);
                    HeightUser();
                }
            }

            void LifeStyleCheck()
            {
                Console.WriteLine();
                Console.WriteLine("И выбери свой образ жизни:");
                Console.WriteLine("(1) - Сидячий образ жизни без нагрузок");
                Console.WriteLine("(2) - малоактивный");
                Console.WriteLine("(3) - активный");
                Console.WriteLine("(4) - ежедневные интенсивные тренировки");
                Console.Write("\r\nВыберите номер: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        lifeStyle = 1.2; break;
                    case "2":
                        lifeStyle = 1.375; break;
                    case "3":
                        lifeStyle = 1.55; break;
                    case "4":
                        lifeStyle = 1.725; break;
                    default:
                        Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                        Console.ReadKey();
                        LifeStyleCheck();
                        break;
                }
                Gender();
            }

            void Gender()
            {
                Console.WriteLine();
                Console.WriteLine("И свой пол:");
                Console.WriteLine("(1) - мужской");
                Console.WriteLine("(2) - женский");
                Console.Write("\r\nВыберите номер: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        gender = "мужской";
                        CountToMale();
                        break;
                    case "2":
                        gender = "женский";
                        CountToFemale();
                        break;
                    default:
                        Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                        Console.ReadKey();
                        Gender();
                        break;
                }
            }

            void CountToMale()
            {
                bmr = Math.Round((88.36 + (13.4 * weightUser) + (4.8 * heightUser) - (5.7 * ageUser)) * lifeStyle);
                ChahgeOrProductMenu();
            }

            void CountToFemale()
            {
                bmr = Math.Round((447.6 + (9.2 * weightUser) + (3.1 * heightUser) - (4.3 * ageUser)) * lifeStyle);
                ChahgeOrProductMenu();
            }

            string BodyMassIndex()
            {
                double bmi = Math.Round(weightUser / (heightUser * heightUser));
                string massIndex = " ";
                if (bmi < 16.5)
                { massIndex = "Выраженный дефицит массы"; }
                if (bmi > 16.5 && bmi < 18.49)
                { massIndex = "Недостаточная (дефицит) масса тела"; }
                if (bmi > 18.5 && bmi < 24.99)
                { massIndex = "Норма"; }
                if (bmi > 25.0 && bmi < 29.99)
                { massIndex = "Избыточная масса тела (предожирение)"; }
                if (bmi > 30.0 && bmi < 34.99)
                { massIndex = "Ожирение первой степени"; }
                if (bmi > 35.0 && bmi < 39.99)
                { massIndex = "Ожирение второй степени"; }
                if (bmi > 40)
                { massIndex = "Ожирение третьей степени"; }

                string answer = $"Индекс массы тела: {bmi} ({massIndex})";
                return (answer);
            }

            void ChahgeOrProductMenu()
            {
                ToPrintProfile();
                Console.WriteLine("Выберите дальнейшие действия:");
                Console.WriteLine("(1) - перейти к созданию меню");
                Console.WriteLine("(2) - изменить суточную норму калорий");
                Console.WriteLine("(3) - изменить профиль");
                Console.WriteLine("(4) - выход");
                Console.Write("\r\nВыберите номер: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        ProductMenu(); break;
                    case "2":
                        ToChangeBMR(); break;
                    case "3":
                        Console.Clear();
                        NameUser(); break;
                    case "4": Console.WriteLine("До свидания!"); break;
                    default:
                        Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                        Console.ReadKey();
                        ChahgeOrProductMenu();
                        break;
                }
            }


            void ToPrintProfile()
            {
                Console.Clear();
                Console.WriteLine($"Ваши данные, {nameUser}");
                Console.WriteLine($"Пол: {gender}");
                Console.WriteLine($"Возраст: {ageUser} лет");
                Console.WriteLine($"Рост: {heightUser} м");
                Console.WriteLine($"Вес: {weightUser} кг");
                Console.WriteLine(BodyMassIndex());
                Console.WriteLine($"Ваше рекомендуемое количество калорий в день: {bmr}");
                Console.WriteLine();
            }

            double ToChangeBMR()
            {
                Console.Clear();
                Console.WriteLine($"Ваше рекомендуемое количество калорий в день: {bmr}");
                Console.Write("Введите суточную норму калорий: ");
                try
                {
                    bmr = int.Parse(Console.ReadLine());
                    ChahgeOrProductMenu();
                    return (bmr);
                }
                catch
                {
                    Console.WriteLine("Вводите только цифры");
                    Console.WriteLine("\r\nНажмите Enter, чтобы ввести заново");
                    ToChangeBMR();
                    return (bmr);
                }

            }

            void ProductMenu()
            {
                Console.Clear();
                Console.WriteLine("(1) - добавить продукт");
                Console.WriteLine("(2) - изменить продукт");
                Console.WriteLine("(3) - удалить продукт");
                Console.WriteLine("(4) - вывести в Excel");
                Console.WriteLine("(5) - добавить новый продукт в основной список");
                Console.WriteLine("(6) - назад");
                Console.WriteLine("(7) - выход");
                Console.WriteLine($"Осталось: {bmr}");
                Console.WriteLine("Ваше меню:");
                foreach (KeyValuePair<string, int> keyValue in UserMenu)
                {
                    Console.WriteLine($"{keyValue.Key}  -  {keyValue.Value} калорий");
                }
                switch (Console.ReadLine())
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ChangeProduct();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        //ToExcel(); TODO
                        break;
                    case "5":
                        AddInProductCalorie();
                        break;
                    case "6":
                        ChahgeOrProductMenu();
                        break;
                    case "7": Console.WriteLine("До свидания!"); break;
                    default:
                        Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                        Console.ReadKey();
                        ProductMenu();
                        break;

                }

            }

            void AddInProductCalorie()
            {
                Console.WriteLine("Введите название продукта:");
                string product = Console.ReadLine();
                Console.WriteLine("Введите количество калорий, содержащихся в 100г");
                try
                {
                    int calorie = int.Parse(Console.ReadLine());
                    productCalorieIn100g.Add(product, calorie);
                    Console.WriteLine("Продукт успешно добавлен!");
                    ProductMenu();
                }
                catch
                {
                    Console.WriteLine("Вводите калории цифрами!:");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    ProductMenu();
                }


            }

            void AddProduct()
            {
                Console.WriteLine("Введите название продукта:");
                string print = Console.ReadLine();
                
                try
                {
                    string product = productCalorieIn100g.Keys.Where(x => x.Contains(print)).First();
                    Console.WriteLine("Введите массу в граммах:");
                    int mass = int.Parse(Console.ReadLine());
                    int calorie = productCalorieIn100g[product];
                    int totalCalorie = mass * calorie / 100;
                    UserMenu.Add(product, totalCalorie);
                    bmr -= totalCalorie;
                    ProductMenu();

                }
                catch
                {
                    Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    ProductMenu();
                }
            }

            void DeleteProduct()
            {
                Console.WriteLine("Введите название продукта для удаления:");
                string delete = Console.ReadLine();
                try
                {
                    string product = UserMenu.Keys.Where(x => x.Contains(delete)).First();
                    int calorie = UserMenu[product];
                    bmr += calorie;
                    UserMenu.Remove(product);
                    ProductMenu();
                }
                catch
                {
                    Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    ProductMenu();
                }
            }
            void ChangeProduct()
            {
                Console.WriteLine("Введите название продукта для удаления:");
                string change = Console.ReadLine();
                try
                {
                    string product = UserMenu.Keys.Where(x => x.Contains(change)).First(); 
                    int calorieChange = UserMenu[product]; 
                    bmr += calorieChange;
                    UserMenu.Remove(product);
                    int calorieList = productCalorieIn100g[productCalorieIn100g.Keys.Where(x => x == product).First()];
                    Console.WriteLine("Введите новую массу в граммах:");
                    int mass = int.Parse(Console.ReadLine());
                    int totalCalorie = mass * calorieList / 100;
                    UserMenu.Add(product, totalCalorie);
                    bmr -= totalCalorie;
                    ProductMenu();
                }
                catch
                {
                    Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                    Console.ReadKey();
                    ProductMenu();
                }
            }
        }
    }
}