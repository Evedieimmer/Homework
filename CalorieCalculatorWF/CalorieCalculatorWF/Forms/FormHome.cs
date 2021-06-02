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
    public partial class FormHome : Form
    {
        public HomePresenter homePresenter;
        private int num;
        public FormHome()
        {
            InitializeComponent();
            num = 0;
            UserInfo userInfo = new UserInfo();
            Repository repository = new Repository();
            homePresenter = new HomePresenter(this, userInfo, repository);
            PrintProfile();
            
        }
        
        public void PrintProfile()
        {
            Dictionary<string, string> user = homePresenter.GetUserInfo();
            labelName.Text = user["name"];
            labelAge.Text = user["age"];
            labelGender.Text = user["gender"];
            labelWeight.Text = user["weight"];
            labelHeight.Text = user["height"];
            labelBMI.Text = user["bmi"];
            labelBMR.Text = user["bmr"];
        }
        public void FruitPictureVisible(bool visiblePicture, bool visibleEdit)
        {
            panelFruits.Visible = visiblePicture;
            panelEditUser.Visible = visibleEdit;
        }

        private void BtnIcon_Click(object sender, EventArgs e)
        {
            num++;
            if (num > 7)
                num = 0;
            lbIcon.ImageIndex = num;
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            FruitPictureVisible(false, true);
        }


        private void BtSaveUser_Click(object sender, EventArgs e)
        {
            if (tbChangeName.Text.Trim() != "")
            {
                homePresenter.EditName(tbChangeName);
            }
            if (tbChangeAge.Text.Trim() != "")
            {
                homePresenter.EditAge(tbChangeAge);
            }
            if (tbChangeHeight.Text.Trim() != "")
            {
                homePresenter.EditHeight(tbChangeHeight);
            }
            if (tbChangeWeight.Text.Trim() != "")
            {
                homePresenter.EditWeight(tbChangeWeight);
            }
            if (tbChangeBMR.Text.Trim() != "")
            {
                homePresenter.EditBmr(tbChangeBMR);
            }
            PrintProfile();
            FruitPictureVisible(true, false);
        }
    }
}
