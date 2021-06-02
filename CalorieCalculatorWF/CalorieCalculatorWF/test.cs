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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            ShowLog();
            NameUser(1);
        }
        public void ShowLog()
        {
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                listBox1.Items.Clear();
                foreach (PassStore pas in db.PassStore)
                {
                    listBox1.Items.Add(pas.Pass);
                    listBox1.Items.Add(pas.Login);
                }
            }
        }
        public void NameUser(int passId)
        {
            //string name;
            using (CalorieCalculatorDBEntities1 db = new CalorieCalculatorDBEntities1())
            {
                var names = db.UserInfo.Where(x => x.PassStoreId == passId).ToList();
                foreach (var i in names)
                {
                    label1.Text = i.NameUser;
                }
            }
        }
    }
}

