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
    public partial class LoginForm : Form
    {
        public LoginPresenter loginPresenter;
        public LoginForm()
        {
            InitializeComponent();
            Repository repository = new Repository();
            loginPresenter = new LoginPresenter(this, repository);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbPass.Text.Trim() == "" || tbLogin.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                loginPresenter.Autentification(tbPass.Text, tbLogin.Text);
            }
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            loginPresenter.ShowRegistration();
        }
    }
}
