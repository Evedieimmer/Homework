using CalorieCalculatorWF.Forms;
using System.Collections.Generic;
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
        public string ShowNameUser()
        {
            UserInfo user = Repository.GetUserProfile(IdUser.Id);
            string name = user.NameUser;
            return name;
        }
        public int? ShowAgeUser()
        {
            UserInfo user = Repository.GetUserProfile(IdUser.Id);
            int? age = user.Age;
            return age;
        }
        public Dictionary<string, string> GetUserInfo()
        {
            Dictionary<string, string> user = new Dictionary<string, string>();
            UserInfo selected = Repository.GetUserProfile(IdUser.Id);
            LifeStyle style = Repository.GetUserLifeStyle(selected.LifeStyleId);
            user.Add("name", selected.NameUser);
            user.Add("age", selected.Age.ToString());
            user.Add("weight", selected.Weight.ToString());
            user.Add("height", selected.Height.ToString());
            user.Add("gender", Repository.GetUserGender(selected.GenderId));
            user.Add("bmi", style.Value.ToString());
            user.Add("bmr", selected.BMR.ToString());
            return user;
        }

        public void EditName(TextBox name)
        {
            Repository.ChangeNameUser(IdUser.Id, name.Text.Trim());
        }

        public void EditAge(TextBox age)
        {
            int newAge;
            if (!int.TryParse(age.Text.Trim(), out newAge))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            if (newAge > 7 && newAge < 150)
            {
                Repository.ChangeAgeUser(IdUser.Id, newAge);
            }
            else
            {
                MessageBox.Show("Вводите реальный возраст!");
                return;
            } 
        }

        public void EditHeight(TextBox height)
        {
            double newHeight;
            if (!double.TryParse(height.Text.Trim(), out newHeight))
            {
                MessageBox.Show("Не получилось прочесть рост!", "Ошибка!");
                return;
            }
            if (newHeight > 60 && newHeight < 300)
            {
                Repository.ChangeHeightUser(IdUser.Id, newHeight / 100);
            }
            else
            {
                MessageBox.Show("Вводите реальный рост!");
                return;
            }
        }

        public void EditWeight(TextBox weight)
        {
            double newWeight;
            if (!double.TryParse(weight.Text.Trim(), out newWeight))
            {
                MessageBox.Show("Не получилось прочесть вес!", "Ошибка!");
                return;
            }
            if (newWeight > 20 && newWeight < 500)
            {
                Repository.ChangeWeightUser(IdUser.Id, newWeight);
            }
            else
            {
                MessageBox.Show("Вводите реальный вес!");
                return;
            }
        }

        public void EditBmr(TextBox bmr)
        {
            int newBmr;
            if (!int.TryParse(bmr.Text.Trim(), out newBmr))
            {
                MessageBox.Show("Не получилось прочесть СНК!", "Ошибка!");
                return;
            }
            if (newBmr > 800 && newBmr < 5000)
            {
                Repository.ChangeBMRUser(IdUser.Id, newBmr);
            }
            else
            {
                MessageBox.Show("Нереальное количество калорий в день!");
                return;
            }
            
        }
    }
}
