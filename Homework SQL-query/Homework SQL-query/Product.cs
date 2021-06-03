using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_SQL_query
{
    public class Product
    {
        public string Name { get; set; }
        public int Calorie { get; set; }

        public Product(string name, int calorie)
        {
            Name = name;
            Calorie = calorie;
        }
        public override string ToString()
        {
            return $"{Name} {Calorie} калорий";
        }
    }

    public class ProductModel
    {
        public List<Product> Products = new List<Product>();
        public ProductModel()
        {
            Products = ProductDB.DBload();
        }

        public void UserAdd(string name, int calorie)
        {
            if (Products.Any(u => u.Name == name && u.Calorie == calorie))
                throw (new Exception("Данный пользователь уже существует!"));
            Products.Add(new Product(name, calorie));
            ProductDB.DBSave(Products);
        }

        public List<Product> UserRemove(Product prod)
        {
            Products.Remove(prod);
            ProductDB.DBProductDelete(prod);
            return Products;
        }


    }
}
