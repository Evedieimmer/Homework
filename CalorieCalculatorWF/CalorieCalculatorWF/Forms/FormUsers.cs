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
    public partial class FormUsers : Form
    {
        public UsersPresenter usersPresenter;
        public FormUsers()
        {
            InitializeComponent();
            Repository repository = new Repository();
            usersPresenter = new UsersPresenter(this, repository);
            usersPresenter.LoadUsers();
        }

        public void LoadInDataGridUsers(List<UserModel> user)
        {
                dgvUsers.DataSource = user;
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (tbIdUser.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели ID!", "Ошибка!");
                return;
            }
            usersPresenter.RemoveUser(tbIdUser);
            usersPresenter.LoadUsers();
            MessageBox.Show("Пользователь успешно удален");
        }
    }
}
