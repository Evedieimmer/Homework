using System;
using System.Windows.Forms;

namespace CalorieCalculatorWF.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            CreateBtnDelete();
            CreateBtnEdit();
        }
        public void CreateBtnEdit()
        {
            Button btnEdit = new Button();
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnEdit.Location = new System.Drawing.Point(382, 275);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(160, 27);
            btnEdit.TabIndex = 48;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            if (IdUser.Id == 1)
            {
                this.Controls.Add(btnEdit);
            }
            else
            {
                this.Controls.Remove(btnEdit);
            }
        }
            public void CreateBtnDelete()
        {
            Button btnDelete = new Button();
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnDelete.Location = new System.Drawing.Point(382, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(160, 27);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            if (IdUser.Id == 1)
            {
                this.Controls.Add(btnDelete);
            }
            else
            {
                this.Controls.Remove(btnDelete);
            }
        }
        private void FormProducts_Load(object sender, EventArgs e)
        { }
    }
}
