using System;
using System.Collections.Generic;
using System.IO;

namespace BaseLibrary
{
    public class UserInfo
    {
        public string LoginUser { get; set; }
        public string NameUser { get; set; }
        public double AgeUser { get; set; }
        public double WeightUser { get; set; }
        public double HeightUser { get; set; }
        public string Gender { get; set; }
        public double LifeStyle { get; set; }
        public double BMR { get; set; }
        public double BMI { get; set; }

        public UserInfo(string login, string name, double age, double weight, double height, string gender, double lifeStyle, double bmr, double bmi)
        {
            this.LoginUser = login;
            this.NameUser = name;
            this.AgeUser = age;
            this.WeightUser = weight;
            this.HeightUser = height;
            this.Gender = gender;
            this.LifeStyle = lifeStyle;
            this.BMR = bmr;
            this.BMI = bmi;
        }

        public static List<UserInfo> InfoUser { get; set; }
        static UserInfo()
        {
            InfoUser = new List<UserInfo>();
        }

        public static class DataBaseInfoUser
        {
            public static string PassPath { get; set; } = "C:\\Users\\User\\Desktop\\Goodline кафедра\\Homework\\Calorie Calculator OOP\\UserInfo.txt";
            public static bool SavePass(List<UserInfo> userStore)
            {
                StreamWriter fileIn;
                try
                {
                    using (fileIn = new StreamWriter(PassPath, true))
                    {
                        foreach (var user in userStore)
                        {
                            fileIn.WriteLine(user.LoginUser);
                            fileIn.WriteLine(user.NameUser);
                            fileIn.WriteLine(user.AgeUser);
                            fileIn.WriteLine(user.WeightUser);
                            fileIn.WriteLine(user.HeightUser);
                            fileIn.WriteLine(user.Gender);
                            fileIn.WriteLine(user.LifeStyle);
                            fileIn.WriteLine(user.BMR);
                            fileIn.WriteLine(user.BMI);
                        }
                        fileIn.Close();
                    }
                    using (fileIn = new StreamWriter(PassPath, false))
                    {
                        foreach (var user in userStore)
                        {
                            fileIn.WriteLine(user.LoginUser);
                            fileIn.WriteLine(user.NameUser);
                            fileIn.WriteLine(user.AgeUser);
                            fileIn.WriteLine(user.WeightUser);
                            fileIn.WriteLine(user.HeightUser);
                            fileIn.WriteLine(user.Gender);
                            fileIn.WriteLine(user.LifeStyle);
                            fileIn.WriteLine(user.BMR);
                            fileIn.WriteLine(user.BMI);
                        }
                        fileIn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка! {ex.Message}");
                    return false;
                }
                return true;
            }

            public static List<UserInfo> LoadPassDB()
            {
                List<UserInfo> userStore = new List<UserInfo>();
                StreamReader fileOut;
                try
                {
                    if (File.Exists(PassPath))
                    {
                        fileOut = new StreamReader(PassPath);
                        while (!fileOut.EndOfStream)
                        {
                            string login = fileOut.ReadLine();
                            string name = fileOut.ReadLine();
                            double age = Convert.ToDouble(fileOut.ReadLine());
                            double weight = Convert.ToDouble(fileOut.ReadLine());
                            double height = Convert.ToDouble(fileOut.ReadLine());
                            string gender = fileOut.ReadLine();
                            double lifeStyle = Convert.ToDouble(fileOut.ReadLine());
                            double bmr = Convert.ToDouble(fileOut.ReadLine());
                            double bmi = Convert.ToDouble(fileOut.ReadLine());

                            userStore.Add(new UserInfo(login, name, age, weight, height, gender, lifeStyle, bmr, bmi));
                        }
                        fileOut.Close();
                    }
                    else
                        throw new Exception("Файла не существует!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка! {ex.Message}");
                    return null;
                }
                return userStore;
            }
        }

    }
}
