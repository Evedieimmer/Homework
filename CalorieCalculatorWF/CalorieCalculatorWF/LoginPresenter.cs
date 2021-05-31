using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class LoginPresenter
    {

        public Repository Repository;

        public LoginForm View;
        public LoginPresenter(LoginForm view, Repository repository)
        {
            Repository = repository;
            View = view;
        }

        public void Autentification(string pass, string log)
        {
            if (Repository.IsLogin(pass, log) != 0)
            {
                //if (Repository.IsLogin(pass, log) == 1)
                //{
                //    //to admin
                //}
                ShowFormMenu();
            }
            else
            {
                MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
            }
        }

        public void ShowRegistration()
        {
            FormRegistration registForm = new FormRegistration();
            registForm.Show();
        }

        public void ShowFormMenu()
        {
            FormMenu menuForm = new FormMenu();
            menuForm.Show();
        }
    }
}
