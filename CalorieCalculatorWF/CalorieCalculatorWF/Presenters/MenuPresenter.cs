using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculatorWF
{
    public class MenuPresenter
    {
        public Repository Repository;
        public FormMenu View;

        public MenuPresenter(FormMenu view, Repository repository)
        {
            Repository = repository;
            View = view;
        }

        public string ShowHelloNameUser()
        {
            UserInfo user =  Repository.GetUserProfile(IdUser.Id);
            string name = user.NameUser;
            return name;
        }
        public bool IsAdmin()
        {
            if (IdUser.Id != 1)
            {
                return false;
            }
            else { return true; }
        }
    }
}
