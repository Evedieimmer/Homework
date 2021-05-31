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
        }

        public void UpdateLabelInfo(UserInfo user)
        {
            labelName.Text = user.NameUser;
            labelAge.Text = user.Age.ToString();
            labelGender.Text = user.Gender.ToString();
            labelHeight.Text = user.Height.ToString();
            labelBMR.Text = user.BMR.ToString();
            //labelBMI.Text = BmiCount();

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
            panelFruitPicture.Visible = false;
            panelEditUser.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panelFruitPicture.Visible = true;
            panelEditUser.Visible = false;
        }
    }
}
