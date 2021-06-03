using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWF.Forms;
using System.Windows.Forms;


namespace CalorieCalculatorWF
{
    public class DiaryPresenter
    {
        public Repository Repository;
        public FormDiary View;

        public DiaryPresenter(FormDiary view, Repository repository)
        {
            Repository = repository;
            View = view;
        }

        public void RemoveFromMenu(DateTimePicker date, string nameProd, int calorie, int weight, int typeEat)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            Repository.RemoveMenu(dateEat, nameProd, calorie, weight, typeEat, IdUser.Id);
            //RemoveMenu(DateTime date, string nameProd, int calorie, int weight, int typeEat, int userid)
        }

        public void AddProdInMenu(DateTimePicker date, ComboBox prod, TextBox weight, int type)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            Products list = Repository.SearchCalorieandIdProd(prod.Text);
            int prodId = list.ProductsId;
            int calorieProd = list.Calorie;
            int wei;
            if (!int.TryParse(weight.Text.Trim(), out wei))
            {
                MessageBox.Show("Не получилось прочесть вес!", "Ошибка!");
                return;
            }
            int calorieEat = (calorieProd * wei) / 100;
            Repository.AddMenu(dateEat, type, prodId, IdUser.Id, calorieEat, wei);
        }

        public int UserBmr()
        {
            UserInfo selected = Repository.GetUserProfile(IdUser.Id);
            int? bmr = selected.BMR;
            int userBmr;
            if (!int.TryParse(bmr.ToString(), out userBmr))
            {
                return 0;
            }
            return userBmr;
        }

        public int BmrCount(DateTimePicker date)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            int? bmr = UserBmr();
            int? summ = Repository.GetSummBmr(IdUser.Id, dateEat);
            int? bmrBalance = bmr - summ;
            int nowBmr;
            if (!int.TryParse(bmrBalance.ToString(), out nowBmr))
            {
                return UserBmr();
            }
            return nowBmr;
        }
        public void LoadProducts()
        {
            View.LoadInComboBox(Repository.LoadNameProd());
        }

        public void LoadBreakfast(DateTimePicker date)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            View.LoadDGVBreakfast(Repository.SearchBreakfast(dateEat, IdUser.Id));
        }

        public void LoadDinner(DateTimePicker date)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            View.LoadDGVDinner(Repository.SearchDinner(dateEat, IdUser.Id));
        }

        public void LoadEneningDinner(DateTimePicker date)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            View.LoadDGVEneningDinner(Repository.SearchEveningDinner(dateEat, IdUser.Id));
        }
        public void LoadSnack(DateTimePicker date)
        {
            DateTime dateEat = DateTime.Parse(date.Value.ToShortDateString());
            View.LoadDGVSnack(Repository.SearchShack(dateEat, IdUser.Id));
        }
    }
}
