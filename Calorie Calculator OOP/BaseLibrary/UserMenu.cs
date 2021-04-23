using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLibrary
{
    public class UserMenu
    {
        public string Product { get; set; }
        public int Calorie { get; set; }

        public UserMenu( string product, int calorie)
        {
            this.Product = product;
            this.Calorie = calorie;
        }

        public static List<UserMenu> MenuUser { get; set; }
        static UserMenu()
        {
            MenuUser = new List<UserMenu>();
        }


        public static List<UserMenu> breakfast { get; set; }
        
        public static List<UserMenu> dinner { get; set; }
        
        public static List<UserMenu> eveningDinner { get; set; }
      

    }
}
