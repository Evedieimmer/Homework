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
            diaryPresenter.LoadSnack(dtpChoose);
            LabelBMR();
            ChangeProgressBar();
        }
    }
}
