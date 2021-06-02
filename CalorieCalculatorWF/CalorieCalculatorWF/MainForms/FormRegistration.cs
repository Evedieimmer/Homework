using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public partial class FormRegistration : Form
    {
        public RegistrationPresenter registrationPresenter;
        public FormRegistration()
        {
            InitializeComponent();
            Repository repository = new Repository();
            registrationPresenter = new RegistrationPresenter(this, repository);
        }

        public RadioButton RbGender(RadioButton rb1, RadioButton rb2)
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
                MessageBox.Show("Вы не выбрали пол!", "Ошибка!");
                return null;
            }
        }
        public RadioButton RbLifeStyle(RadioButton rb1, RadioButton rb2, RadioButton rb3, RadioButton rb4)
        {
            if (rb1.Checked)
            {
                return rb1;
            }
            if (rb2.Checked)
            {
                return rb2;
            }
            if (rb3.Checked)
            {
                return rb3;
            }
            if (rb4.Checked)
            {
                return rb4;
            }
            else
            {
                MessageBox.Show("Вы не выбрали образ жизни!", "Ошибка!");
                return null;
            }
        }
        private void BtnSaveNewUser_Click(object sender, EventArgs e)
        {
            RadioButton style = RbLifeStyle(rbStyle1, rbStyle2, rbStyle3, rbStyle4);
            RadioButton gen = RbGender(rbFemale, rbMale);
            registrationPresenter.AddUser(tbNewName, tbNewAge, tbNewWeight, tbNewHeight, gen, style, tbNewPass, tbNewLogin);
        }
    }
}
