using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
