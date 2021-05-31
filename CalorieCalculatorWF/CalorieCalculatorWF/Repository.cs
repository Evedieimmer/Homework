using System;
using System.Collections.Generic;
using System.Linq;


namespace CalorieCalculatorWF
{

    public class Repository
    {
        //public List<LifeStyle> lifeStyleModels = new List<LifeStyle>();//справочник
        //public List<Gender> genderModels = new List<Gender>();//справочник
        //public List<Products> productsModels = new List<Products>();
        //public List<TypeEating> typeEatingModels = new List<TypeEating>();//справочник
        //public List<TypeProduct> typeProductModels = new List<TypeProduct>();//справочник
        //public List<UserInfo> userInfoModels = new List<UserInfo>();
        //public List<UserMenu> userMenuModels = new List<UserMenu>();
        //public List<PassStore> passStoreModels = new List<PassStore>();

        //public Repository()
        //{
        //    using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
        //    {
        //        genderModels = db.Gender.ToList();
        //        lifeStyleModels = db.LifeStyle.ToList();
        //        productsModels = db.Products.ToList();
        //        typeEatingModels = db.TypeEating.ToList();
        //        typeProductModels = db.TypeProduct.ToList();
        //        userInfoModels = db.UserInfo.ToList();
        //        userMenuModels = db.UserMenu.ToList();
        //        passStoreModels = db.PassStore.ToList();
        //    }
        //}

        public void AddProducts(string name, int calorie, int type)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.Products.Any(x => x.NameProduct == name && x.Calorie == calorie))
                    throw (new Exception("Такой продукт уже существует!"));
                Products prod = new Products
                {
                    Calorie = calorie,
                    NameProduct = name,
                    TypeProductId = type
                };
                db.Products.Add(prod);
            }
        }

        public void AddUser(string name, int age, double weight, double height, int genderId, int lifeStyleId, int bmr, int passStoreId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.UserInfo.Any(x => x.NameUser == name && x.PassStoreId == passStoreId))
                    throw (new Exception("Такой профиль уже существует!"));
                UserInfo user = new UserInfo
                {
                    NameUser = name,
                    Age = age,
                    Weight = weight,
                    Height = height,
                    GenderId = genderId,
                    LifeStyleId = lifeStyleId,
                    BMR = bmr,
                    PassStoreId = passStoreId
                };
                db.UserInfo.Add(user);
            }
        }

        public void AddMenu(DateTime date, int typeEatId, int prodId, int userId, int calorie, int weight)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.UserMenu.Any(x => x.ProductsId == prodId && x.TypeEatingId == typeEatId))
                {
                    UserMenu prodChange = db.UserMenu.Where(x => x.ProductsId == prodId && x.TypeEatingId == typeEatId).FirstOrDefault();
                    prodChange.WeightProduct = weight;
                    prodChange.Calorie = calorie;
                    db.SaveChanges();
                }
                else
                {
                    UserMenu menu = new UserMenu
                    {
                        Date = date,
                        TypeEatingId = typeEatId,
                        ProductsId = prodId,
                        UserId = userId,
                        Calorie = calorie,
                        WeightProduct = weight
                    };
                    db.UserMenu.Add(menu);
                }
            }
        }

        public void AddPassLog(string pass, string log)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.PassStore.Any(x => x.Pass == pass && x.Login == log))
                    throw (new Exception("Такие логин и пароль уже существуют!"));
                PassStore passLog = new PassStore
                {
                    Pass = pass,
                    Login = log
                };
                db.PassStore.Add(passLog);
            }
        }

        public void RemoveUser(UserInfo user)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                db.UserInfo.Remove(user);
            }
        }

        public void RemoveMenu(UserMenu menu)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                db.UserMenu.Remove(menu);
            }
        }

        public void RemoveProduct(Products prod)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                db.Products.Remove(prod);
            }
        }

        public void ChangeUser(UserInfo user, string name, int age, double weight, double height, int bmr)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == user.UserId).First();
                if (name != null)
                {
                    userChange.NameUser = name;
                    db.SaveChanges();
                }
                if (age != 0)
                {
                    userChange.Age = age;
                    db.SaveChanges();
                }
                if (weight != 0)
                {
                    userChange.Weight = weight;
                    db.SaveChanges();
                }
                if (height != 0)
                {
                    userChange.Height = height;
                    db.SaveChanges();
                }
                if (bmr != 0)
                {
                    userChange.BMR = bmr;
                    db.SaveChanges();
                }
            }
        }
        public void ChangeMenu(UserMenu menu,int calorie, int weight)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                menu.WeightProduct = weight;
                menu.Calorie = calorie;
                db.SaveChanges();
            }
        }

        public void ChangeProduct(Products prod, string name, int calorie)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                prod.NameProduct = name;
                prod.Calorie = calorie;
                db.SaveChanges();
            }
        }
        public int IsLogin(string pass, string log)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                int idUser;
                if (db.PassStore.Any(x => x.Pass == pass && x.Login == log) == true)
                {
                    idUser = db.PassStore.Where(x => x.Pass == pass && x.Login == log).Select(x => x.PassStoreId).First();
                    return idUser;
                }
                return 0;
            }
        }
    }
}
