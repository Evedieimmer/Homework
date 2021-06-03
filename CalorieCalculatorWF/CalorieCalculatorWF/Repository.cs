using System;
using System.Collections.Generic;
using System.Linq;

namespace CalorieCalculatorWF
{
    public class ProdModel
    {
        public string NameProd { get; set; }
        public int Calorie { get; set; }
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ModelMenu
    {
        public string NameProd { get; set; }
        public int? Calorie { get; set; }
        public int? Weight { get; set; }
    }
    public class NameProd
    {
        public string Name { get; set; }
    }

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

        public void AddProduct(string name, int calorie, int type)
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
                db.SaveChanges();
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
                db.SaveChanges();
            }
        }

        public LifeStyle SearchStyle(string style)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                LifeStyle styleList = new LifeStyle();
                styleList = db.LifeStyle.FirstOrDefault(x => x.Style == style);
                return styleList;
            }
        }

        public int SearchGender(string gender)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                Gender user = new Gender();
                user = db.Gender.FirstOrDefault(x => x.GenderType == gender);
                return user.GenderId;
            }
        }

        public void AddMenu(DateTime date, int typeEatId, int prodId, int userId, int calorie, int weight)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.UserMenu.Any(x => x.ProductsId == prodId && x.TypeEatingId == typeEatId))
                {
                    UserMenu prodChange = db.UserMenu.Where(x => x.ProductsId == prodId && x.TypeEatingId == typeEatId).FirstOrDefault();
                    prodChange.WeightProduct += weight;
                    prodChange.Calorie += calorie;
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
                    db.SaveChanges();
                }
            }
        }

        public void AddPassLog(string pass, string log)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                if (db.PassStore.Any(x => x.Pass == pass && x.Login == log))
                    throw (new Exception("Такие логин и пароль уже существуют!"));
                PassStore passLog = new PassStore { Pass = pass, Login = log };
                db.PassStore.Add(passLog);
                db.SaveChanges();
            }
        }

        public int SearchPassId(string pass, string log)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                PassStore passList = new PassStore();
                passList = db.PassStore.FirstOrDefault(x => x.Pass == pass && x.Login == log);
                return passList.PassStoreId;
            }
        }

        public int SearchIdTypeProd(string prod)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                TypeProduct typeList = new TypeProduct();
                typeList = db.TypeProduct.FirstOrDefault(x => x.TypeProd == prod);
                return typeList.TypeProductId;
            }
        }

        public void RemoveUser(int id)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo user = db.UserInfo.FirstOrDefault(x => x.UserId == id);
                PassStore pass = db.PassStore.FirstOrDefault(x => x.PassStoreId == user.PassStoreId);
                db.UserInfo.Remove(user);
                db.PassStore.Remove(pass);
                db.SaveChanges();
            }
        }

        public void RemoveMenu(UserMenu menu)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                db.UserMenu.Remove(menu);
            }
        }

        public void RemoveProduct(string nameProd)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                Products prod = db.Products.FirstOrDefault(x => x.NameProduct == nameProd);
                db.Products.Remove(prod);
                db.SaveChanges();
            }
        }

        public void ChangeMenu(UserMenu menu, int calorie, int weight)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                menu.WeightProduct = weight;
                menu.Calorie = calorie;
                db.SaveChanges();
            }
        }

        public int IsLogin(string pass, string log)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                int idUser;
                try
                {
                    idUser = db.PassStore.Where(x => x.Pass == pass && x.Login == log).Select(x => x.PassStoreId).First();
                    return idUser;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public UserInfo GetUserProfile(int passId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo user = new UserInfo();
                user = db.UserInfo.FirstOrDefault(x => x.PassStoreId == passId);
                return user;
            }
        }

        public string GetUserGender(int? genderId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                Gender user = new Gender();
                user = db.Gender.FirstOrDefault(x => x.GenderId == genderId);
                return user.GenderType;
            }
        }

        public LifeStyle GetUserLifeStyle(int? idStyle)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                LifeStyle userStyle = new LifeStyle();
                userStyle = db.LifeStyle.FirstOrDefault(x => x.LifeStyleId == idStyle);
                return userStyle;
            }
        }

        public void ChangeNameUser(int iduser, string name)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == iduser).First();
                userChange.NameUser = name;
                db.SaveChanges();
            }
        }

        public void ChangeAgeUser(int iduser, int age)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == iduser).First();
                userChange.Age = age;
                db.SaveChanges();
            }
        }

        public void ChangeWeightUser(int iduser, double weight)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == iduser).First();
                userChange.Weight = weight;
                db.SaveChanges();
            }
        }

        public void ChangeHeightUser(int iduser, double height)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == iduser).First();
                userChange.Height = height;
                db.SaveChanges();
            }
        }

        public void ChangeBMRUser(int iduser, int bmr)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                UserInfo userChange = db.UserInfo.Where(x => x.UserId == iduser).First();
                userChange.BMR = bmr;
                db.SaveChanges();
            }
        }

        public List<ProdModel> LoadProd()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                //db.Products.Load();
                //List<Products> prodList = db.Products.ToList<Products>();
                var products = db.Products.Select(x => new ProdModel
                {
                    NameProd = x.NameProduct,
                    Calorie = x.Calorie
                });
                return products.ToList();
            }
        }

        public List<ProdModel> SearchProductsFood()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var foodList = db.Products.Where(x => x.TypeProductId == 2).Select(x => new ProdModel
                {
                    NameProd = x.NameProduct,
                    Calorie = x.Calorie
                });
                return foodList.ToList();
            }
        }

        public List<ProdModel> SearchProductsDrink()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var drinkList = db.Products.Where(x => x.TypeProductId == 1).Select(x => new ProdModel
                {
                    NameProd = x.NameProduct,
                    Calorie = x.Calorie
                });
                return drinkList.ToList();
            }
        }

        public List<UserModel> LoadUsers()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var users = db.UserInfo.Select(x => new UserModel
                {
                    Id = x.UserId,
                    Name = x.NameUser
                });
                return users.ToList();
            }
        }

        public List<ModelMenu> SearchBreakfast(DateTime date, int userId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var breakfast = from UserMenu in db.UserMenu
                                join Products in db.Products on UserMenu.ProductsId equals Products.ProductsId
                                where UserMenu.UserId == userId
                                where UserMenu.Date == date
                                where UserMenu.TypeEatingId == 1
                                select new ModelMenu
                                {
                                    NameProd = Products.NameProduct,
                                    Calorie = UserMenu.Calorie,
                                    Weight = UserMenu.WeightProduct
                                };

                return breakfast.ToList();
            }
        }

        public List<ModelMenu> SearchDinner(DateTime date, int userId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var dinner = from UserMenu in db.UserMenu
                             join Products in db.Products on UserMenu.ProductsId equals Products.ProductsId
                             where UserMenu.UserId == userId
                             where UserMenu.Date == date
                             where UserMenu.TypeEatingId == 2
                             select new ModelMenu
                             {
                                 NameProd = Products.NameProduct,
                                 Calorie = UserMenu.Calorie,
                                 Weight = UserMenu.WeightProduct
                             };

                return dinner.ToList();
            }
        }

        public List<ModelMenu> SearchEveningDinner(DateTime date, int userId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var eveningDinner = from UserMenu in db.UserMenu
                                    join Products in db.Products on UserMenu.ProductsId equals Products.ProductsId
                                    where UserMenu.UserId == userId
                                    where UserMenu.Date == date
                                    where UserMenu.TypeEatingId == 3
                                    select new ModelMenu
                                    {
                                        NameProd = Products.NameProduct,
                                        Calorie = UserMenu.Calorie,
                                        Weight = UserMenu.WeightProduct
                                    };

                return eveningDinner.ToList();
            }
        }

        public List<ModelMenu> SearchShack(DateTime date, int userId)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var snack = from UserMenu in db.UserMenu
                            join Products in db.Products on UserMenu.ProductsId equals Products.ProductsId
                            where UserMenu.UserId == userId
                            where UserMenu.Date == date
                            where UserMenu.TypeEatingId == 4
                            select new ModelMenu
                            {
                                NameProd = Products.NameProduct,
                                Calorie = UserMenu.Calorie,
                                Weight = UserMenu.WeightProduct
                            };

                return snack.ToList();
            }
        }
        public List<string> LoadNameProd()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                List<string> prod = db.Products.Select(x => x.NameProduct).ToList();
                return prod;
            }
        }

        public int? GetSummBmr(int idUser, DateTime data)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                int? summ = db.UserMenu.Where(x => x.UserId == idUser).Where(x => x.Date == data).Sum(x => x.Calorie);
                return summ;
            }
        }

        public Products SearchCalorieandIdProd(string name)
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                Products prod = db.Products.FirstOrDefault(x => x.NameProduct == name);
                return prod;
            }
        }
    }
}
