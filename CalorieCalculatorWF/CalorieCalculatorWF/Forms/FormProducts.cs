using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalorieCalculatorWF.Forms
{
    public partial class FormProducts : Form
    {
        public ProductsPresenter productsPresenter;
        public FormProducts()
        {
            InitializeComponent();
            Products products = new Products();
            Repository repository = new Repository();
            productsPresenter = new ProductsPresenter(this, products, repository);
            productsPresenter.LoadProducts();
            CreateBtnDelete();
        }
        
        public void CreateBtnDelete()
        {
            Button btnDelete = new Button();
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnDelete.Location = new System.Drawing.Point(382, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(160, 27);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new EventHandler(btnDelete_Click);

            Label lbForAdmin = new Label();
            lbForAdmin.AutoSize = true;
            lbForAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbForAdmin.Location = new System.Drawing.Point(378, 285);
            lbForAdmin.Name = "lbForAdmin";
            lbForAdmin.Size = new System.Drawing.Size(229, 18);
            lbForAdmin.TabIndex = 69;
            lbForAdmin.Text = "введи название, чтобы удалить";

            if (IdUser.Id == 1)
            {
                this.Controls.Add(btnDelete);
                this.Controls.Add(lbForAdmin);
            }
            else
            {
                this.Controls.Remove(btnDelete);
                this.Controls.Remove(lbForAdmin);
            }
        }
        private void FormProducts_Load(object sender, EventArgs e)
        { }

        public void LoadInDataGridView(List<ProdModel> prod)
        {
            dgvProducts.DataSource = prod;
        }


        private void BtnOnlyEat_Click(object sender, EventArgs e)
        {
            productsPresenter.LoadFood();
        }

        private void BtnOnlyDrink_Click(object sender, EventArgs e)
        {
            productsPresenter.LoadDrink();
        }

        private void BtnAllProduct_Click(object sender, EventArgs e)
        {
            productsPresenter.LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tbNameProd.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели название!", "Ошибка!");
                return;
            }
            productsPresenter.Remove(tbNameProd.Text.Trim());
            MessageBox.Show("Продукт успешно удален");
            productsPresenter.LoadProducts();
        }

        public RadioButton RbType(RadioButton rb1, RadioButton rb2)
        {
            if (rb1.Checked)
            {
                return rb1;
            }
            if (rb2.Checked)
            {
                return rb2;
            }
            else
            {
                MessageBox.Show("Вы не выбрали вид продукта!", "Ошибка!");
                return null;
            }
        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            if(tbNameProd.Text.Trim() == "" && tbCalorie.Text.Trim() == "")
            {
                {
                    MessageBox.Show("Введите значения!", "Ошибка!");
                    return;
                }
            }
            RadioButton type = RbType(rbFood, rbDrink);
            productsPresenter.AddProduct(tbNameProd, tbCalorie, type);
            productsPresenter.LoadProducts();
        }
        
    }
}
