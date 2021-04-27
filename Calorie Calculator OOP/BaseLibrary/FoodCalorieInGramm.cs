using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaseLibrary
{
    public class FoodCalorieInGramm: ProductStore
    {
        public FoodCalorieInGramm(string product, int calorie)
        {
            this.Product = product;
            this.Calorie = calorie;
        }

        public static List<FoodCalorieInGramm> FoodList { get; set; }
        static FoodCalorieInGramm()
        {
            FoodList = new List<FoodCalorieInGramm>();
        }

        public static class DataBaseFood
        {
            public static string FoodPath { get; set; } = "C:\\Users\\User\\Desktop\\Goodline кафедра\\Homework\\Calorie Calculator OOP\\FoodDataBase.txt";
            public static bool SaveFood(List<FoodCalorieInGramm> foodStore)
            {
                StreamWriter fileIn;
                try
                {
                    using (fileIn = new StreamWriter(FoodPath, true))
                    {
                        foreach (var item in foodStore)
                        {
                            fileIn.WriteLine(item.Product);
                            fileIn.WriteLine(item.Calorie);
                        }
                        fileIn.Close();
                    }
                    using (fileIn = new StreamWriter(FoodPath, false))
                    {
                        foreach (var item in foodStore)
                        {
                            fileIn.WriteLine(item.Product);
                            fileIn.WriteLine(item.Calorie);
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

            public static List<FoodCalorieInGramm> LoadFoodDB()
            {
                List<FoodCalorieInGramm> foodStore = new List<FoodCalorieInGramm>();
                StreamReader fileOut;
                try
                {
                    if (File.Exists(FoodPath))
                    {
                        fileOut = new StreamReader(FoodPath);
                        while (!fileOut.EndOfStream)
                        {
                            string product = fileOut.ReadLine();
                            int calorie = int.Parse(fileOut.ReadLine());
                            foodStore.Add(new FoodCalorieInGramm(product, calorie));
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
                return foodStore;
            }
        }

    }
}
