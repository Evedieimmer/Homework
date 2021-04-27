using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaseLibrary
{
    public class DrinkablesCalorieInMililiter: ProductStore
    {
        public DrinkablesCalorieInMililiter(string product, int calorie)
        {
            this.Product = product;
            this.Calorie = calorie;
        }

        public static List<DrinkablesCalorieInMililiter> DrinkList { get; set; }
        static DrinkablesCalorieInMililiter()
        {
            DrinkList = new List<DrinkablesCalorieInMililiter>();
        }

        public static class DataBaseDrink
        {
            public static string DrinkPath { get; set; } = "C:\\Users\\User\\Desktop\\Goodline кафедра\\Homework\\Calorie Calculator OOP\\DrinkDataBase.txt";
            public static bool SaveDrink(List<DrinkablesCalorieInMililiter> drinkStore)
            {
                StreamWriter fileIn;
                try
                {
                    using (fileIn = new StreamWriter(DrinkPath, true))
                    {
                        foreach (var item in drinkStore)
                        {
                            fileIn.WriteLine(item.Product);
                            fileIn.WriteLine(item.Calorie);
                        }
                        fileIn.Close();
                    }
                    using (fileIn = new StreamWriter(DrinkPath, false))
                    {
                        foreach (var item in drinkStore)
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

            public static List<DrinkablesCalorieInMililiter> LoadDrinkDB()
            {
                List<DrinkablesCalorieInMililiter> drinkStore = new List<DrinkablesCalorieInMililiter>();
                StreamReader fileOut;
                try
                {
                    if (File.Exists(DrinkPath))
                    {
                        fileOut = new StreamReader(DrinkPath);
                        while (!fileOut.EndOfStream)
                        {
                            string product = fileOut.ReadLine();
                            int calorie = int.Parse(fileOut.ReadLine());
                            drinkStore.Add(new DrinkablesCalorieInMililiter(product, calorie));
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
                return drinkStore;
            }
        }

    }
}
