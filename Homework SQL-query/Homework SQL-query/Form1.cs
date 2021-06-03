using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_SQL_query
{
    public partial class Form1 : Form
    {
        public ProductsPresenter productsPresenter;
        public Form1()
        {
            InitializeComponent();
            ProductModel productModel = new ProductModel();
            productsPresenter = new ProductsPresenter(this, productModel);
            ListBoxUpdate();
        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Product)listBoxProducts.SelectedItem == null)
            {
                tbName.Text = "";
                tbCalorie.Text = "";
            }
            else
            {
                tbCalorie.Text = ((Product)listBoxProducts.SelectedItem).Calorie.ToString();
                tbName.Text = ((Product)listBoxProducts.SelectedItem).Name;
            }
        }
        public void ListBoxUpdate()
        {
            listBoxProducts.Items.Clear();
            foreach (var user in productsPresenter.UserGetList())
                listBoxProducts.Items.Add(user);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            productsPresenter.UserAdd(tbCalorie, tbName);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((Product)listBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Ошибка выбора!");
                return;
            }
            productsPresenter.UserRemove((Product)listBoxProducts.SelectedItem);
            ListBoxUpdate();
        }

    }
}
