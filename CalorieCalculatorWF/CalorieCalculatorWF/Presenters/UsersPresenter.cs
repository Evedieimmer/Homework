using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWF.Forms;
using System.Windows.Forms;

namespace CalorieCalculatorWF
{
    public class UsersPresenter
    {
        public Repository Repository;
        public FormUsers View;

        public UsersPresenter(FormUsers view, Repository repository)
        {
            Repository = repository;
            View = view;
        }

        public void LoadUsers()
        {
            View.LoadInDataGridUsers(Repository.LoadUsers());
        }

        public void RemoveUser(TextBox id)
        {
            int userId;
            if (!int.TryParse(id.Text.Trim(), out userId))
            {
                MessageBox.Show("Не получилось прочесть ID!", "Ошибка!");
                return;
            }
            Repository.RemoveUser(userId);
        }
    }
}
