using CalorieCalculatorWF.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class HomePresenter
    {
        public Repository Repository;
        public UserInfo Model;
        public FormHome View;
        public HomePresenter(FormHome view, UserInfo model, Repository repository)
        {
            Repository = repository;
            Model = model;
            View = view;
        }

    }
}
