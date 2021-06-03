using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWF.Forms
{
    public partial class FormDiary : Form
    {
        public DiaryPresenter diaryPresenter;
        public FormDiary()
        {
            InitializeComponent();
            Repository repository = new Repository();
            diaryPresenter = new DiaryPresenter(this, repository);
            diaryPresenter.LoadBreakfast(dtpChoose);
            diaryPresenter.LoadDinner(dtpChoose);
            diaryPresenter.LoadEneningDinner(dtpChoose);
            diaryPresenter.LoadSnack(dtpChoose);
            diaryPresenter.LoadProducts();
            LabelBMR();
            ChangeProgressBar();
        }

        public void LabelBMR()
        {
            lbCount.Text = (diaryPresenter.BmrCount(dtpChoose)).ToString();
            lbBmr.Text = (diaryPresenter.UserBmr()).ToString();
        }
        public void ChangeProgressBar()
        {
            pbBMR.Maximum = diaryPresenter.UserBmr();
            pbBMR.Minimum = 0;
            pbBMR.Step += 1;//to doo
            pbBMR.Value = diaryPresenter.BmrCount(dtpChoose);
        }
        public void LoadInComboBox(List<string> prod)
        {
            foreach(var i in prod)
            {
                cbProducts.Items.Add(i);
            }
        }

        public void LoadDGVBreakfast(List<ModelMenu> menu)
        {
            dgvBreakfast.DataSource = menu;
        }
        public void LoadDGVDinner(List<ModelMenu> menu)
        {
            dgvDinner.DataSource = menu;
        }
        public void LoadDGVEneningDinner(List<ModelMenu> menu)
        {
            dgvEveningDinner.DataSource = menu;
        }
        public void LoadDGVSnack(List<ModelMenu> menu)
        {
            dgvSnack.DataSource = menu;
        }
        private void DtpChoose_ValueChanged(object sender, EventArgs e)
        {
            diaryPresenter.LoadBreakfast(dtpChoose);
            diaryPresenter.LoadDinner(dtpChoose);
            diaryPresenter.LoadEneningDinner(dtpChoose);
            diaryPresenter.LoadSnack(dtpChoose);
            diaryPresenter.LoadProducts();
            LabelBMR();
            ChangeProgressBar();
        }

        private void AddBreakfast_Click(object sender, EventArgs e)
        {
            if(cbProducts.Text.Trim() != "" && tbWeightProd.Text.Trim() != "")
            {
                diaryPresenter.AddProdInMenu(dtpChoose, cbProducts, tbWeightProd, 1);
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка!");
                return;
            }
            diaryPresenter.LoadBreakfast(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnAddDinner_Click(object sender, EventArgs e)
        {
            if (cbProducts.Text.Trim() != "" && tbWeightProd.Text.Trim() != "")
            {
                diaryPresenter.AddProdInMenu(dtpChoose, cbProducts, tbWeightProd, 2);
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка!");
                return;
            }
            diaryPresenter.LoadDinner(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnAddEveningDinner_Click(object sender, EventArgs e)
        {
            if (cbProducts.Text.Trim() != "" && tbWeightProd.Text.Trim() != "")
            {
                diaryPresenter.AddProdInMenu(dtpChoose, cbProducts, tbWeightProd, 3);
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка!");
                return;
            }
            diaryPresenter.LoadEneningDinner(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnAddSnack_Click(object sender, EventArgs e)
        {
            if (cbProducts.Text.Trim() != "" && tbWeightProd.Text.Trim() != "")
            {
                diaryPresenter.AddProdInMenu(dtpChoose, cbProducts, tbWeightProd, 4);
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка!");
                return;
            }
            diaryPresenter.LoadSnack(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnDeleteBreakfast_Click(object sender, EventArgs e)
        {
            diaryPresenter.RemoveFromMenu(dtpChoose,
                dgvBreakfast.SelectedCells[0].Value.ToString(),
                int.Parse(dgvBreakfast.SelectedCells[1].Value.ToString()),
                int.Parse(dgvBreakfast.SelectedCells[2].Value.ToString()), 1);
            diaryPresenter.LoadBreakfast(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnDeleteDinner_Click(object sender, EventArgs e)
        {
            diaryPresenter.RemoveFromMenu(dtpChoose,
               dgvDinner.SelectedCells[0].Value.ToString(),
               int.Parse(dgvDinner.SelectedCells[1].Value.ToString()),
               int.Parse(dgvDinner.SelectedCells[2].Value.ToString()), 2);
            diaryPresenter.LoadDinner(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnDeleteEveningDinner_Click(object sender, EventArgs e)
        {
            diaryPresenter.RemoveFromMenu(dtpChoose,
               dgvEveningDinner.SelectedCells[0].Value.ToString(),
               int.Parse(dgvEveningDinner.SelectedCells[1].Value.ToString()),
               int.Parse(dgvEveningDinner.SelectedCells[2].Value.ToString()), 3);
            diaryPresenter.LoadEneningDinner(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }

        private void BtnDeleteSnack_Click(object sender, EventArgs e)
        {
            diaryPresenter.RemoveFromMenu(dtpChoose,
              dgvSnack.SelectedCells[0].Value.ToString(),
              int.Parse(dgvSnack.SelectedCells[1].Value.ToString()),
              int.Parse(dgvSnack.SelectedCells[2].Value.ToString()), 4);
            diaryPresenter.LoadSnack(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }
    }
}
