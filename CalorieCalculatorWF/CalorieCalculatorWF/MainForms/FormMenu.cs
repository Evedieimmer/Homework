using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CalorieCalculatorWF
{
    public partial class FormMenu : Form
    {
        public MenuPresenter menuPresenter;
        //поля
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //конструктор
        public FormMenu()
        {
            InitializeComponent();
            random = new Random();
            Repository repository = new Repository();
            menuPresenter = new MenuPresenter(this, repository);
            VisibleAdminBtn();
            ShowName();
        }
        
        public void ShowName()
        {
            lbHelloName.Text = menuPresenter.ShowHelloNameUser();
        }

        public void VisibleAdminBtn()
        {
            btnUsers.Visible = menuPresenter.IsAdmin();
        }
        //методы
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            DisableButton();
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(49, 51, 75);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
            lbHelloName.Visible = false;
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void BtnDiary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDiary(), sender);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReport(), sender);
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUsers(), sender);
        }
    }
}
