namespace CalorieCalculatorWF
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEditUser = new System.Windows.Forms.Panel();
            this.rBthFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelTitleLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleLogin
            // 
            this.panelTitleLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.panelTitleLogin.Controls.Add(this.label1);
            this.panelTitleLogin.Controls.Add(this.label3);
            this.panelTitleLogin.Controls.Add(this.pictureBox1);
            this.panelTitleLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleLogin.Location = new System.Drawing.Point(0, 0);
            this.panelTitleLogin.Name = "panelTitleLogin";
            this.panelTitleLogin.Size = new System.Drawing.Size(404, 80);
            this.panelTitleLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalorieCalculatorWF.Properties.Resources.Group_6__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelEditUser
            // 
            this.panelEditUser.Controls.Add(this.rBthFemale);
            this.panelEditUser.Controls.Add(this.rBtnMale);
            this.panelEditUser.Controls.Add(this.btnSaveUser);
            this.panelEditUser.Controls.Add(this.tbWeight);
            this.panelEditUser.Controls.Add(this.tbHeight);
            this.panelEditUser.Controls.Add(this.tbAge);
            this.panelEditUser.Controls.Add(this.tbName);
            this.panelEditUser.Controls.Add(this.label8);
            this.panelEditUser.Controls.Add(this.label10);
            this.panelEditUser.Controls.Add(this.label13);
            this.panelEditUser.Controls.Add(this.label12);
            this.panelEditUser.Controls.Add(this.label11);
            this.panelEditUser.Location = new System.Drawing.Point(12, 102);
            this.panelEditUser.Name = "panelEditUser";
            this.panelEditUser.Size = new System.Drawing.Size(380, 315);
            this.panelEditUser.TabIndex = 21;
            this.panelEditUser.Visible = false;
            // 
            // rBthFemale
            // 
            this.rBthFemale.AutoSize = true;
            this.rBthFemale.Location = new System.Drawing.Point(193, 128);
            this.rBthFemale.Name = "rBthFemale";
            this.rBthFemale.Size = new System.Drawing.Size(88, 21);
            this.rBthFemale.TabIndex = 32;
            this.rBthFemale.TabStop = true;
            this.rBthFemale.Text = "Женский";
            this.rBthFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(193, 101);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(86, 21);
            this.rBtnMale.TabIndex = 31;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Мужской";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveUser.Location = new System.Drawing.Point(88, 264);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(213, 35);
            this.btnSaveUser.TabIndex = 21;
            this.btnSaveUser.Text = "Сохранить изменения";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.UseWaitCursor = true;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(193, 205);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(171, 22);
            this.tbWeight.TabIndex = 30;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(193, 171);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(171, 22);
            this.tbHeight.TabIndex = 29;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(193, 61);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(171, 22);
            this.tbAge.TabIndex = 27;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 22);
            this.tbName.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Введите имя:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label10.Location = new System.Drawing.Point(23, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Введите рост:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label13.Location = new System.Drawing.Point(23, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "Введите возраст:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label12.Location = new System.Drawing.Point(23, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Выберите пол: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label11.Location = new System.Drawing.Point(23, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Введите вес:";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.panelEditUser);
            this.Controls.Add(this.panelTitleLogin);
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.panelTitleLogin.ResumeLayout(false);
            this.panelTitleLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEditUser.ResumeLayout(false);
            this.panelEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelEditUser;
        private System.Windows.Forms.RadioButton rBthFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}