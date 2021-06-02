using System;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class RegistrationPresenter
    {
        public Repository Repository;
        public FormRegistration View;
        public RegistrationPresenter(FormRegistration view, Repository repository)
        {
            Repository = repository;
            View = view;
        }
        public int AddUserPass(string pass, string log)
        {
            Repository.AddPassLog(pass, log);
            int idPass = Repository.SearchPassId(pass, log);
            return idPass;
        }

        public void AddUser(TextBox name, TextBox age, TextBox weight, TextBox height, RadioButton gender, RadioButton lifestyle, TextBox pass, TextBox log)
        {
            int idPass = AddUserPass(pass.Text.Trim(), log.Text.Trim());
            LifeStyle listStyle = Repository.SearchStyle(lifestyle.Text);
            int idStyle = listStyle.LifeStyleId;
            double styleValue = listStyle.Value;
            int idGen = Repository.SearchGender(gender.Text);
            double bmr;
            int newAge = CheckAge(age.Text);
            double newHei = CheckHei(height.Text);
            double newWei = CheckWei(weight.Text);
            if (idGen == 1)
            {
                bmr = Math.Round((88.36 + (13.4 * newWei) + (4.8 * newHei) - (5.7 * newAge)) * styleValue);
            }
            else { bmr = Math.Round((447.6 + (9.2 * newWei) + (3.1 * newHei) - (4.3 * newAge)) * styleValue); }
            Repository.AddUser(name.Text, newAge, newWei, newHei, idGen, idStyle, Convert.ToInt32(bmr), idPass);
            MessageBox.Show("Вы успешно зарегистрированы!");
        }

            public int CheckAge(string age)
        {
            int newAge;
            if (!int.TryParse(age, out newAge))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return 0;
            }
            if (newAge > 7 && newAge < 150)
            {
                return newAge;
            }
            else
            {
                MessageBox.Show("Вводите реальный возраст!");
                return 0;
            }
        }

        public double CheckWei(string weight)
        {
            double newWeight;
            if (!double.TryParse(weight, out newWeight))
            {
                MessageBox.Show("Не получилось прочесть вес!", "Ошибка!");
                return 0;
            }
            if (newWeight > 20 && newWeight < 500)
            {
                return newWeight;
            }
            else
            {
                MessageBox.Show("Вводите реальный вес!");
                return 0;
            }
        }

        public double CheckHei(string height)
        {
            double newHeight;
            if (!double.TryParse(height, out newHeight))
            {
                MessageBox.Show("Не получилось прочесть рост!", "Ошибка!");
                return 0;
            }
            if (newHeight > 60 && newHeight < 300)
            {
                return (newHeight / 100);
            }
            else
            {
                MessageBox.Show("Вводите реальный рост!");
                return 0;
            }
        }


    }
}
