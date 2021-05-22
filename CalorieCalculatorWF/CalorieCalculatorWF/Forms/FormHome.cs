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
        private int num;
        public FormHome()
        {
            InitializeComponent();
            num = 0;
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
