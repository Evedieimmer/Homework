using System;

namespace CalorieCalculator
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Приветствуем тебя в калькуляторе калорий!");
            Console.WriteLine("Для начала расскажи немного о себе!");

            Console.WriteLine("Введи свое имя:");
            string nameUser = Console.ReadLine();

            Console.WriteLine("Свой возраст:");
            double ageUser = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Свой вес:");
            double weightUser = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Свой рост в см:");
            double heightUser = Convert.ToDouble(Console.ReadLine());
            heightUser = heightUser/100.0;

            Console.WriteLine("Выбери свой пол:");
            Console.WriteLine("(1) - мужской");
            Console.WriteLine("(2) - женский");

            switch (Console.ReadLine())
            {
                case "1":
                    CountToMale(); break;
                case "2":
                    CountToFemale(); break;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу, попробуйте еще раз!");
                    Console.ReadKey();
                    Main();
                    break;
            }
             
            double LifeStyleCheck()
            {
                Console.Clear();
                Console.WriteLine("И выбери свой образ жизни:");
                Console.WriteLine("(1) - Сидячий образ жизни без нагрузок");
                Console.WriteLine("(2) - малоактивный");
                Console.WriteLine("(3) - активный");
                Console.WriteLine("(4) - ежедневные интенсивные тренировки");
                double lifeStyle = 0;
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
                return (lifeStyle);
            }

            // BMI - body mass index (индекс массы тела)
            // BMR - basal metabolic rate (кол-во калорий для норм. функционированния организма)
            double bmr;

            void CountToMale()
            {
                Console.WriteLine($"Привет, {nameUser}");
                double style = LifeStyleCheck();
                bmr = Math.Round((88.36 + (13.4 * weightUser) + (4.8 * heightUser) - (5.7 * ageUser)) * style);
                Console.WriteLine($"Рекомендуемое количество калорий в день: {bmr}");
                Console.WriteLine(BodyMassIndex());
                Console.ReadKey();
            }
            void CountToFemale()
            {
                Console.WriteLine($"Привет, {nameUser}");
                double style = LifeStyleCheck();
                bmr = Math.Round((447.6 + (9.2 * weightUser) + (3.1 * heightUser) - (4.3 * ageUser)) * style);
                Console.WriteLine($"Рекомендуемое количество калорий в день: {bmr}");
                Console.WriteLine(BodyMassIndex());
                Console.ReadKey();
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
                if(bmi > 40) 
                { massIndex = "Ожирение третьей степени"; }

                string answer = $"Индекс массы тела: {bmi} ({massIndex})";
                return (answer);
            }

        }
    }
}
