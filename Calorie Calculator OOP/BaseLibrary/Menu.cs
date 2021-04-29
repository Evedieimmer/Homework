using System;
using System.IO;
using System.Linq;


namespace BaseLibrary
{
    public class Menu
    {
        ConsoleKey key = ConsoleKey.Enter;
        public double bmr;
        public string Error() { return "\r\nВы ошиблись при вводе, попробуй снова"; }
        public void Begin()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Приветствуем тебя в калькуляторе калорий!");
                DecorLine();
                Console.WriteLine("Что будем делать?:");
                Console.WriteLine("(1) - Вход");
                Console.WriteLine("(2) - Регистрация");
                Console.WriteLine("(3) - Выход");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        ChahgeOrProductMenu(Autentificate());
                        break;
                    case ConsoleKey.D2:
                        AddUserInfo(Registration());
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine(" До свидания!");
        }

        public string Autentificate()
        {
            Console.Clear();
            Console.WriteLine("Выполните вход");
            DecorLine();
            Console.Write("Введите логин:");
            string login = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Введите пароль:");
            string pass = Console.ReadLine();
            PasswordStore person = new PasswordStore(login, pass);
            if (person.IsAdmin() == true)
            {
                AdminMenu();
                return login;

            }
            else
            {
                PasswordStore.Users = PasswordStore.DataBasePass.LoadPassDB();
                foreach (var user in PasswordStore.Users)
                {
                    if (user.LoginUser == login && user.PassUser == pass)
                    {
                        return login;
                    }
                    else
                    {
                        Console.WriteLine("Логин или пароль введены не правильно!");
                        Console.ReadKey();
                        Autentificate();
                        return null;
                    }
                }
                return null;
            }
        }

        public void AdminMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Привет, админ!");
                DecorLine();
                Console.WriteLine("(1) - добавить новые продукты");
                Console.WriteLine("(2) - удалить продукты");
                Console.WriteLine("(3) - вывод списка продуктов");
                Console.WriteLine("(4) - выход из аккаунта");
                Console.WriteLine("(5) - выход");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        string a = AddInProductCalorie("");
                        break;
                    case ConsoleKey.D2:
                        DeleteInProductCalorie();
                        break;
                    case ConsoleKey.D3:
                        string b = PrintProduct();
                        break;
                    case ConsoleKey.D4:
                        Begin();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D5);
            Console.WriteLine("До свидания!");
        }

        public string Registration()
        {
            Console.Clear();
            PasswordStore.Users = PasswordStore.DataBasePass.LoadPassDB();
            Console.WriteLine("Создание нового аккаунта");
            DecorLine();
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Введите пароль:");
            string pass = Console.ReadLine();

            PasswordStore person = new PasswordStore(login, pass);
            while (person.LoginUser.Trim() == "" && person.PassUser.Trim() == "")
            {
                Console.Write("Не все поля заполнены! Попробуйте снова!");
                Console.ReadKey();
                Registration();
            }

            PasswordStore.Users.Add(person);
            PasswordStore.DataBasePass.SavePass(PasswordStore.Users);
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
            return login;
        }
        public void DecorLine() { Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); }
        public void ChangeUserInfo(string log)
        {
            UserInfo.DataBaseInfoUser.LoadPassDB();
            string loginUser = log;
            Console.WriteLine("Расскажи немного о себе!");
            string nameUser = NameUser();
            double ageUser = AgeUser();
            double weightUser = WeightUser();
            double heightUser = HeightUser();
            string gender = Gender();
            double lifeStyle = LifeStyleCheck();
            double bmr;
            if (gender == "мужской")
            {
                bmr = Math.Round((88.36 + (13.4 * weightUser) + (4.8 * heightUser) - (5.7 * ageUser)) * lifeStyle);
            }
            else { bmr = Math.Round((447.6 + (9.2 * weightUser) + (3.1 * heightUser) - (4.3 * ageUser)) * lifeStyle); }
            DecorLine();
            double bmi = Math.Round(weightUser / (heightUser * heightUser));
            foreach (var item in UserInfo.InfoUser.Where(x => x.LoginUser == log).ToList())
            {
                UserInfo.InfoUser.Remove(item);
            }
            UserInfo user = new UserInfo(loginUser, nameUser, ageUser, weightUser, heightUser, gender, lifeStyle, bmr, bmi);
            UserInfo.InfoUser.Add(user);
            UserInfo.DataBaseInfoUser.SavePass(UserInfo.InfoUser);
            ChahgeOrProductMenu(log);


        }
        public void AddUserInfo(string log)
        {
            string loginUser = log;
            Console.WriteLine("Для начала расскажи немного о себе!");
            string nameUser = NameUser();
            double ageUser = AgeUser();
            double weightUser = WeightUser();
            double heightUser = HeightUser();
            string gender = Gender();
            double lifeStyle = LifeStyleCheck();
            double bmr;
            if (gender == "мужской")
            {
                bmr = Math.Round((88.36 + (13.4 * weightUser) + (4.8 * heightUser) - (5.7 * ageUser)) * lifeStyle);
            }
            else { bmr = Math.Round((447.6 + (9.2 * weightUser) + (3.1 * heightUser) - (4.3 * ageUser)) * lifeStyle); }
            DecorLine();
            double bmi = Math.Round(weightUser / (heightUser * heightUser));

            UserInfo user = new UserInfo(loginUser, nameUser, ageUser, weightUser, heightUser, gender, lifeStyle, bmr, bmi);
            UserInfo.InfoUser.Add(user);
            UserInfo.DataBaseInfoUser.SavePass(UserInfo.InfoUser);
            ChahgeOrProductMenu(log);
        }

        public string NameUser()
        {
            DecorLine();
            Console.WriteLine("Введи свое имя:");
            string nameUser = Console.ReadLine();
            while (nameUser.Trim() == "")
            {
                Console.WriteLine(Error());
                Console.ReadKey();
                NameUser();
            }
            return nameUser;
        }

        public double AgeUser()
        {
            DecorLine();
            Console.WriteLine("Введи свой возраст:");// from 7 to 150
            try
            {
                double ageUser = Convert.ToDouble(Console.ReadLine());
                if (ageUser > 7 && ageUser < 150)
                {
                    return ageUser;
                }
                else
                {
                    Console.WriteLine(Error());
                    AgeUser();
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine(Error());
                AgeUser();
                return 0;
            }
        }

        public double WeightUser()
        {
            DecorLine();
            Console.WriteLine("Введи свой вес:");// from 10 to 500
            try
            {
                double weightUser = Convert.ToDouble(Console.ReadLine());
                if (weightUser > 10 && weightUser < 500)
                {
                    return weightUser;
                }
                else
                {
                    Console.WriteLine(Error());
                    WeightUser();
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine(Error());
                WeightUser();
                return 0;
            }
        }
        public double HeightUser()
        {
            DecorLine();
            Console.WriteLine("Введи свой рост в см:");//from 30 to 3000
            try
            {
                double heightUser = Convert.ToDouble(Console.ReadLine());
                if (heightUser > 30 && heightUser < 3000)
                {
                    heightUser /= 100.0;
                    return heightUser;
                }
                else
                {
                    Console.WriteLine(Error());
                    HeightUser();
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine(Error());
                HeightUser();
                return 0;
            }
        }
        public double LifeStyleCheck()
        {
            DecorLine();
            Console.WriteLine("И выбери свой образ жизни:");
            Console.WriteLine("(1) - Сидячий образ жизни без нагрузок");
            Console.WriteLine("(2) - малоактивный");
            Console.WriteLine("(3) - активный");
            Console.WriteLine("(4) - ежедневные интенсивные тренировки");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    return 1.2;
                case "2":
                    return 1.375;
                case "3":
                    return 1.55;
                case "4":
                    return 1.725;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    LifeStyleCheck();
                    return 0;
            }
        }
        public string Gender()
        {
            DecorLine();
            Console.WriteLine("И свой пол:");
            Console.WriteLine("(1) - мужской");
            Console.WriteLine("(2) - женский");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    return "мужской";
                case "2":
                    return "женский";
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Gender();
                    return null;
            }
        }
        public string BodyMassIndex(double bmi)
        {
            string massIndex = "";
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

        public void ChahgeOrProductMenu(string log)
        {
            do
            {
                Console.Clear();
                DecorLine();
                UserInfo.InfoUser = UserInfo.DataBaseInfoUser.LoadPassDB();
                foreach (var item in UserInfo.InfoUser.Where(x => x.LoginUser == log).ToList())
                {
                    Console.WriteLine($"Ваши данные, {item.NameUser}");
                    Console.WriteLine($"Пол, {item.Gender}");
                    Console.WriteLine($"Возраст: {item.AgeUser} лет");
                    Console.WriteLine($"Рост: {item.HeightUser} м");
                    Console.WriteLine($"Вес: {item.WeightUser} кг");
                    Console.WriteLine(BodyMassIndex(item.BMI));
                    Console.WriteLine($"Ваше рекомендуемое количество калорий в день: {item.BMR}");
                    Console.WriteLine();
                }
                DecorLine();
                Console.WriteLine("Выберите дальнейшие действия:");
                Console.WriteLine("(1) - перейти к созданию меню");
                Console.WriteLine("(2) - изменить суточную норму калорий");
                Console.WriteLine("(3) - изменить профиль");
                Console.WriteLine("(4) - выход из аккаунта");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        ProductMenu(log);
                        break;
                    case ConsoleKey.D2:
                        ToChangeBMR(log);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ChangeUserInfo(log);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Begin();
        }

        public double ToChangeBMR(string log)
        {
            Console.Clear();
            Console.Write("Введите суточную норму калорий: ");
            try
            {
                bmr = int.Parse(Console.ReadLine());
                foreach (var item in UserInfo.InfoUser.Where(x => x.LoginUser == log).ToList())
                {
                    item.BMR = bmr;
                    UserInfo.DataBaseInfoUser.SavePass(UserInfo.InfoUser);
                }
                ChahgeOrProductMenu(log);
                return bmr;

            }
            catch
            {
                Console.WriteLine("Вводите только цифры");
                Console.WriteLine("\r\nНажмите Enter, чтобы ввести заново");
                ToChangeBMR(log);
                return 0;
            }

        }

        public void ProductMenu(string log)
        {
            do
            {
                Console.Clear();
                UserInfo.DataBaseInfoUser.LoadPassDB();
                foreach (var item in UserInfo.InfoUser.Where(x => x.LoginUser == log).ToList())
                {
                    bmr = item.BMR;
                }
                Console.WriteLine($"Осталось: {bmr}");
                DecorLine();
                Console.WriteLine("Ваше меню:");
                Console.WriteLine("***********");

                Console.WriteLine("Завтрак:");
                Console.WriteLine(">>>>>>>>>");
                if (UserMenu.breakfast == null)
                { Console.WriteLine("Пока пусто..."); }
                else
                {
                    foreach (var item in UserMenu.breakfast)
                    {
                        Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
                    }
                }

                Console.WriteLine("Обед:");
                Console.WriteLine(">>>>>>>>>");
                if (UserMenu.dinner == null)
                { Console.WriteLine("Пока пусто..."); }
                else
                {
                    foreach (var item in UserMenu.dinner)
                    {
                        Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
                    }
                }

                Console.WriteLine("Ужин:");
                Console.WriteLine(">>>>>>>>>");
                if (UserMenu.eveningDinner == null)
                { Console.WriteLine("Пока пусто..."); }
                else
                {
                    foreach (var item in UserMenu.eveningDinner)
                    {
                        Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
                    }
                }

                DecorLine();
                Console.WriteLine();
                Console.WriteLine("(1) - добавить продукт на завтрак");
                Console.WriteLine("(2) - добавить продукт на обед");
                Console.WriteLine("(3) - добавить продукт на ужин");
                Console.WriteLine("(4) - удалить продукт на завтрак");
                Console.WriteLine("(5) - удалить продукт на обед");
                Console.WriteLine("(6) - удалить продукт на ужин");
                Console.WriteLine("(7) - сохранить в файл");
                Console.WriteLine("(8) - посмотреть глобальный список");
                Console.WriteLine("(9) - добавить продукт в глобальный список");
                Console.WriteLine("(0) - назад");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        AddBreakfast(log);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("");
                        AddDinner(log);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("");
                        AddEveningDinner(log);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("");
                        DeleteBreakfast(log);
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("");
                        DeleteDinner(log);
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("");
                        DeleteEveningDinner(log);
                        break;
                    case ConsoleKey.D7:
                        ToFile();
                        break;
                    case ConsoleKey.D8:
                        string a = PrintProduct();
                        break;
                    case ConsoleKey.D9:
                        string b = AddInProductCalorie(log);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D0);
            ChahgeOrProductMenu(log);
        }

        public void DeleteBreakfast(string log)
        {
            Console.WriteLine("Введите название продукта для удаления:");
            string print = Console.ReadLine();
            try
            {
                foreach (var item in UserMenu.breakfast.Where(x => x.Product.Contains(print)))
                {
                    UserMenu.breakfast.Remove(item);
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
            }
            ProductMenu(log);
        }

        public void DeleteDinner(string log)
        {
            Console.WriteLine("Введите название продукта для удаления:");
            string print = Console.ReadLine();
            try
            {
                foreach (var item in UserMenu.dinner.Where(x => x.Product.Contains(print)))
                {
                    UserMenu.dinner.Remove(item);
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
            }
            ProductMenu(log);
        }

        public void DeleteEveningDinner(string log)
        {
            Console.WriteLine("Введите название продукта для удаления:");
            string print = Console.ReadLine();
            try
            {
                foreach (var item in UserMenu.eveningDinner.Where(x => x.Product.Contains(print)))
                {
                    UserMenu.eveningDinner.Remove(item);
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
            }
            ProductMenu(log);
        }

        public string PrintProduct()
        {
            Console.Clear();
            DrinkablesCalorieInMililiter.DrinkList = DrinkablesCalorieInMililiter.DataBaseDrink.LoadDrinkDB();
            FoodCalorieInGramm.FoodList = FoodCalorieInGramm.DataBaseFood.LoadFoodDB();
            Console.WriteLine("Все напитки:");
            Console.WriteLine("*************");
            foreach (var item in DrinkablesCalorieInMililiter.DrinkList)
            {
                Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
            }
            Console.WriteLine("");
            Console.WriteLine("Все продукты и блюда:");
            Console.WriteLine("**********************");
            foreach (var item in FoodCalorieInGramm.FoodList)
            {
                Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
            Console.ReadKey();
            return null;
        }

        public string AddBreakfast(string log)
        {
            DrinkablesCalorieInMililiter.DrinkList = DrinkablesCalorieInMililiter.DataBaseDrink.LoadDrinkDB();
            FoodCalorieInGramm.FoodList = FoodCalorieInGramm.DataBaseFood.LoadFoodDB();
            Console.WriteLine("Введите название продукта:");
            string print = Console.ReadLine();
            try
            {
                if (DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var drink in DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)))
                    {
                        string product = drink.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = drink.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.breakfast.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }

                }
                if (FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var food in FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)))
                    {
                        string product = food.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = food.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.breakfast.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }
                }
                ProductMenu(log);
                return null;

            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                ProductMenu(log);
                return null;
            }
        }
        public string AddDinner(string log)
        {

            DrinkablesCalorieInMililiter.DrinkList = DrinkablesCalorieInMililiter.DataBaseDrink.LoadDrinkDB();
            FoodCalorieInGramm.FoodList = FoodCalorieInGramm.DataBaseFood.LoadFoodDB();
            Console.WriteLine("Введите название продукта:");
            string print = Console.ReadLine();
            try
            {
                if (DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var drink in DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)))
                    {
                        string product = drink.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = drink.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.dinner.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }
                }
                if (FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var food in FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)))
                    {
                        string product = food.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = food.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.dinner.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }
                }
                ProductMenu(log);
                return null;
            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                ProductMenu(log);
                return null;
            }
        }
        public string AddEveningDinner(string log)
        {

            DrinkablesCalorieInMililiter.DrinkList = DrinkablesCalorieInMililiter.DataBaseDrink.LoadDrinkDB();
            FoodCalorieInGramm.FoodList = FoodCalorieInGramm.DataBaseFood.LoadFoodDB();
            Console.WriteLine("Введите название продукта:");
            string print = Console.ReadLine();
            try
            {
                if (DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var drink in DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)))
                    {
                        string product = drink.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = drink.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.eveningDinner.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }
                }
                if (FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)).Count() > 0)
                {
                    foreach (var food in FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)))
                    {
                        string product = food.Product;
                        Console.WriteLine("Введите массу в граммах:");
                        int mass = int.Parse(Console.ReadLine());
                        int calorie = food.Calorie;
                        int totalCalorie = mass * calorie / 100;
                        UserMenu prod = new UserMenu(product, totalCalorie);
                        UserMenu.eveningDinner.Add(prod);
                        bmr -= totalCalorie;
                        ProductMenu(log);
                        return null;
                    }
                }
                ProductMenu(log);
                return null;
            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                ProductMenu(log);
                return null;
            }
        }

        public string DeleteInProductCalorie()
        {
            do
            {
                Console.Clear();
                DecorLine();
                Console.WriteLine("Что вы хотите удалить?");
                Console.WriteLine("(1) - напиток");
                Console.WriteLine("(2) - продукт");
                Console.WriteLine("(3) - назад");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        DeleteDrink();
                        return null;
                    case ConsoleKey.D2:
                        Console.WriteLine("");
                        DeleteFood();
                        return null;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            return null;
        }
        public string AddInProductCalorie(string log)
        {
            do
            {
                Console.Clear();
                DecorLine();
                Console.WriteLine("Что вы хотите добавить?");
                Console.WriteLine("(1) - напиток");
                Console.WriteLine("(2) - продукт");
                Console.WriteLine("(3) - назад");
                Console.WriteLine("\r\nВыберите номер: ");
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        AddDrink(log);
                        return null;
                    case ConsoleKey.D2:
                        Console.WriteLine("");
                        AddFood(log);
                        return null;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            return null;
        }

        public string AddFood(string log)
        {
            Console.WriteLine("Введите название продукта:");
            string namefood = Console.ReadLine();
            Console.WriteLine("Введите количество калорий в 100гр");
            try
            {
                int caloriefood = int.Parse(Console.ReadLine());
                FoodCalorieInGramm food = new FoodCalorieInGramm(namefood, caloriefood);
                FoodCalorieInGramm.FoodList.Add(food);
                FoodCalorieInGramm.DataBaseFood.SaveFood(FoodCalorieInGramm.FoodList);
                return null;
            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели калории");
                Console.Write("\r\nНажмите Enter, чтобы вернуться назад");
                Console.ReadKey();
                return null;
            }
        }
        public string AddDrink(string log)
        {
            Console.WriteLine("Введите название напитка:");
            string namedrink = Console.ReadLine();
            Console.WriteLine("Введите количество калорий в 100гр");
            try
            {
                int caloriedrink = int.Parse(Console.ReadLine());
                DrinkablesCalorieInMililiter drink = new DrinkablesCalorieInMililiter(namedrink, caloriedrink);
                DrinkablesCalorieInMililiter.DrinkList.Add(drink);
                DrinkablesCalorieInMililiter.DataBaseDrink.SaveDrink(DrinkablesCalorieInMililiter.DrinkList);
                return null;
            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели калории");
                Console.Write("\r\nНажмите Enter, чтобы вернуться назад");
                Console.ReadKey();
                return null;
            }
        }

        public string DeleteFood()
        {
            Console.WriteLine("Введите название продукта для удаления:");
            string namefood = Console.ReadLine();
            try
            {
                foreach (var item in FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(namefood)))
                {
                    FoodCalorieInGramm.FoodList.Remove(item);
                    break;
                }
                return null;
            }
            catch
            {
                Console.WriteLine("Такого продукта не существует");
                Console.Write("\r\nНажмите Enter, чтобы вернуться назад");
                Console.ReadKey();
                return null;
            }
        }

        public string DeleteDrink()
        {
            Console.WriteLine("Введите название напитка для удаления:");
            string print = Console.ReadLine();
            try
            {
                foreach (var item in DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)))
                {
                    DrinkablesCalorieInMililiter.DrinkList.Remove(item);
                    break;
                }
                return null;
            }
            catch
            {
                Console.WriteLine("Такого продукта не существует");
                Console.Write("\r\nНажмите Enter, чтобы вернуться назад");
                Console.ReadKey();
                return null;
            }
        }

        public bool ToFile()
        {
            string path = "C:\\UserMenu.txt";

            StreamWriter fileIn;
            try
            {
                using (fileIn = new StreamWriter(path))
                {
                    fileIn.WriteLine("Ваше меню:");
                    fileIn.WriteLine("***********");

                    fileIn.WriteLine("Завтрак:");
                    fileIn.WriteLine(">>>>>>>>>");
                    if (UserMenu.breakfast == null)
                    { fileIn.WriteLine("Пока пусто..."); }
                    else
                    {
                        foreach (var item in UserMenu.breakfast)
                        {
                            fileIn.WriteLine($"{item.Product} - {item.Calorie} калорий");
                        }
                    }

                    fileIn.WriteLine("Обед:");
                    fileIn.WriteLine(">>>>>>>>>");
                    if (UserMenu.dinner == null)
                    { fileIn.WriteLine("Пока пусто..."); }
                    else
                    {
                        foreach (var item in UserMenu.dinner)
                        {
                            fileIn.WriteLine($"{item.Product} - {item.Calorie} калорий");
                        }
                    }

                    fileIn.WriteLine("Ужин:");
                    fileIn.WriteLine(">>>>>>>>>");
                    if (UserMenu.eveningDinner == null)
                    { fileIn.WriteLine("Пока пусто..."); }
                    else
                    {
                        foreach (var item in UserMenu.eveningDinner)
                        {
                            fileIn.WriteLine($"{item.Product} - {item.Calorie} калорий");
                        }
                    }

                    fileIn.Close();
                }
                Console.WriteLine(" Ваш файл создан! Чтобы продолжить, нажмите Enter");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
                return false;
            }
            return true;

        }

    }
}
