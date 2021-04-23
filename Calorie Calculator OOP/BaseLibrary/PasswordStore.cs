using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaseLibrary
{
    public class PasswordStore
    {
        public string LoginUser { get; set; }
        public string PassUser { get; set; }

        public PasswordStore(string loginUser, string passUser)
        {
            this.LoginUser = loginUser;
            this.PassUser = passUser;
        }
        public static List<PasswordStore> Users { get; set; }
         static PasswordStore()
        {
            Users = new List<PasswordStore>();
        }
        

        public bool IsAdmin()
        {
            if (LoginUser == "admin" && PassUser == "0000")
            {
                return true;
            }
            else { return false; }
        }

        public static class DataBasePass
        {
            public static string PassPath { get; set; } = "C:\\Users\\User\\Desktop\\Goodline кафедра\\Homework\\Calorie Calculator OOP\\PassDataBase.txt";
            public static bool SavePass(List<PasswordStore> passStore)
            {
                StreamWriter fileIn;
                try
                {
                    using (fileIn = new StreamWriter(PassPath, true))
                    {
                        foreach (var user in passStore)
                        {
                            fileIn.WriteLine(user.LoginUser);
                            fileIn.WriteLine(user.PassUser);
                        }
                        fileIn.Close();
                    }
                    using (fileIn = new StreamWriter(PassPath, false))
                    {
                        foreach (var user in passStore)
                        {
                            fileIn.WriteLine(user.LoginUser);
                            fileIn.WriteLine(user.PassUser);
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

            public static List<PasswordStore> LoadPassDB()
            {
                List<PasswordStore> passStore = new List<PasswordStore>();
                StreamReader fileOut;
                try
                {
                    if (File.Exists(PassPath))
                    {
                        fileOut = new StreamReader(PassPath);
                        while (!fileOut.EndOfStream)
                        {
                            string login = fileOut.ReadLine();
                            string pass = fileOut.ReadLine();
                            passStore.Add(new PasswordStore(login, pass));
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
                return passStore;
            }
        }

    }
}
