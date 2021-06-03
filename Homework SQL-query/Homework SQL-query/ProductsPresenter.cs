using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_SQL_query
{
    public class ProductsPresenter
    {
        public ProductModel model;
        public Form1 View;
        public ProductsPresenter(Form1 view, ProductModel ProdModel)
        {
            View = view;
            model = ProdModel;
        }
        public List<Product> UserGetList()
        {
            return model.Products;
        }

        public void UserAdd(TextBox tbCalorie, TextBox tbName)
        {
            int calo = 0;
            if (tbCalorie.Text.Trim() == "" || tbName.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!int.TryParse(tbCalorie.Text, out calo))
            {
                MessageBox.Show("Не получилось прочесть калории!", "Ошибка!");
                return;
            }
            string name = tbName.Text.Trim();
            try
            {
                model.UserAdd(name, calo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
            View.ListBoxUpdate();
        }

        public void UserRemove(Product prod)
        {
            try
            {
                if (prod != null)
                    model.UserRemove(prod);
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
            View.ListBoxUpdate();
        }
    }
}

