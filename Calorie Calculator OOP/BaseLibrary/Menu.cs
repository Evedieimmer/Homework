using System;
using System.Linq;

namespace BaseLibrary
{
    public class Menu
    {
        public double bmr;
        public string Error() { return "\r\nВы ошиблись при вводе, попробуй снова"; }
        public void Begin()
        {
            Console.WriteLine("Приветствуем тебя в калькуляторе калорий!");
            DecorLine();
            Console.WriteLine("Что будем делать?:");
            Console.WriteLine("(1) - Вход");
            Console.WriteLine("(2) - Регистрация");
            Console.WriteLine("(3) - Выход");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    ChahgeOrProductMenu();
                    break;
                case "2":
                    AddUserInfo();
                    break;
                case "3":
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Begin();
                    break;
            }
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
            PasswordStore.Users = PasswordStore.DataBasePass.LoadPassDB();
            PasswordStore person = new PasswordStore(login, pass);
            if (person.IsAdmin() == true)
            {
                Console.WriteLine("одмееен!");
                return login;
                //переход к работе одмена
            }
            else
            {
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

        public string Registration()
        {
            Console.Clear();
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
        public void AddUserInfo()
        {
            string loginUser = Registration();
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
            //закинули в текстовик

            ChahgeOrProductMenu();
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

        public string ToPrintProfile()
        {

            string log = Autentificate();
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
            bmr = Convert.ToDouble(UserInfo.InfoUser.Where(x => x.LoginUser == log).Select(x => x.BMR));
            return log;
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

        public void ChahgeOrProductMenu()
        {
            string log = ToPrintProfile();
            Console.WriteLine("Выберите дальнейшие действия:");
            Console.WriteLine("(1) - перейти к созданию меню");
            Console.WriteLine("(2) - изменить суточную норму калорий");
            Console.WriteLine("(3) - изменить профиль");
            Console.WriteLine("(4) - выход из аккаунта");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    //ProductMenu(); 
                    break;
                case "2":
                    ToChangeBMR(log);
                    break;
                case "3":
                    Console.Clear();
                    //NameUser();
                    break;
                case "4":
                    Console.WriteLine("До свидания!");
                    Begin();
                    break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    ChahgeOrProductMenu();
                    break;
            }
        }

        public void ToChangeBMR(string log)
        {
            string login = log;
            Console.Clear();
            Console.Write("Введите суточную норму калорий: ");
            try
            {
                bmr = int.Parse(Console.ReadLine());
                foreach (var item in UserInfo.InfoUser.Where(x => x.LoginUser == log).ToList())
                {
                    item.BMR = bmr;
                }
                ChahgeOrProductMenu();

            }
            catch
            {
                Console.WriteLine("Вводите только цифры");
                Console.WriteLine("\r\nНажмите Enter, чтобы ввести заново");
                ToChangeBMR(login);
            }

        }

        public void ProductMenu()
        {

            Console.Clear();
            Console.WriteLine($"Осталось: {bmr}");
            DecorLine();
            Console.WriteLine("Ваше меню:");
            Console.WriteLine("***********");
            Console.WriteLine("Завтрак:");
            Console.WriteLine(">>>>>>>>>");
            foreach (var item in UserMenu.breakfast)
            {
                Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
            }
            Console.WriteLine("Обед:");
            Console.WriteLine(">>>>>>>>>");
            foreach (var item in UserMenu.dinner)
            {
                Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
            }
            Console.WriteLine("Ужин:");
            Console.WriteLine(">>>>>>>>>");
            foreach (var item in UserMenu.eveningDinner)
            {
                Console.WriteLine($"{item.Product} - {item.Calorie} калорий");
            }

            DecorLine();
            Console.WriteLine();
            Console.WriteLine("(1) - добавить продукт на завтрак");
            Console.WriteLine("(2) - добавить продукт на обед");
            Console.WriteLine("(3) - добавить продукт на ужин");
            Console.WriteLine("(4) - изменить продукт");
            Console.WriteLine("(5) - удалить продукт");
            Console.WriteLine("(6) - сохранить в файл");
            Console.WriteLine("(7) - добавить продукт в глобальный список");
            Console.WriteLine("(8) - назад");
            Console.WriteLine("(9) - выход из аккаунта");
            Console.Write("\r\nВыберите номер: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddBreakfast();
                    break;
                case "2":
                    AddDinner();
                    break;
                case "3":
                    AddEveningDinner();
                    break;
                case "4":
                    //ChangeProduct();
                    break;
                case "5":
                    //DeleteProduct();
                    break;
                case "6":
                    //ToExcel(); TODO
                    break;
                case "7":
                    //AddInProductCalorie();
                    break;
                case "8":
                    ChahgeOrProductMenu();
                    break;
                case "9": Console.WriteLine("До свидания!"); Begin(); break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    ProductMenu();
                    break;
            }

        }

        public void AddBreakfast()
        {
            Console.WriteLine("Введите название продукта:");
            string print = Console.ReadLine();
            try
            {
                if (DrinkablesCalorieInMililiter.DrinkList.Where(x => x.Product.Contains(print)) != null)
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
                        ProductMenu();
                    }
                }
                if (FoodCalorieInGramm.FoodList.Where(x => x.Product.Contains(print)) != null)
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
                        ProductMenu();
                    }
                }

            }
            catch
            {
                Console.WriteLine("Такого продукта нет, либо вы ввели неправильно");
                Console.Write("\r\nНажмите Enter, чтобы вернуться в меню");
                Console.ReadKey();
                ProductMenu();
            }
        }
        public void AddDinner() { }
        public void AddEveningDinner() { }
    }
}
