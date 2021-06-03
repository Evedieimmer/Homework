using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWF.Forms;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class ProductsPresenter
    {
        public Repository Repository;
        public Products Model;
        public FormProducts View;

        public ProductsPresenter(FormProducts view, Products model, Repository repository)
        {
            Repository = repository;
            Model = model;
            View = view;
        }

        public void LoadProducts()
        {
            View.LoadInDataGridView(Repository.LoadProd());
        }

        public void LoadFood()
        {
            View.LoadInDataGridView(Repository.SearchProductsFood());
        }

        public void LoadDrink()
        {
            View.LoadInDataGridView(Repository.SearchProductsDrink());
        }

        public void AddProduct(TextBox name, TextBox calorie, RadioButton type)
        {

            int newCalorie;
            if (!int.TryParse(calorie.Text.Trim(), out newCalorie))
            {
                MessageBox.Show("Не получилось прочесть калории!", "Ошибка!");
                return;
            }
            int newType = Repository.SearchIdTypeProd(type.Text);
            Repository.AddProduct(name.Text.Trim(), newCalorie, newType);
        }

        public void Remove(string name)
        {
            Repository.RemoveProduct(name);
        }
    }
}
