using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
