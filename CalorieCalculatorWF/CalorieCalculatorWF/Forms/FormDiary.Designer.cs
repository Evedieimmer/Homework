namespace CalorieCalculatorWF.Forms
{
    partial class FormDiary
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
            this.dgvBreakfast = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDinner = new System.Windows.Forms.DataGridView();
            this.dgvSnack = new System.Windows.Forms.DataGridView();
            this.dgvEveningDinner = new System.Windows.Forms.DataGridView();
            this.pbBMR = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBmr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpChoose = new System.Windows.Forms.DateTimePicker();
            this.tbWeightProd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.btnDeleteBreakfast = new System.Windows.Forms.Button();
            this.btnAddDinner = new System.Windows.Forms.Button();
            this.btnAddSnack = new System.Windows.Forms.Button();
            this.btnAddEveningDinner = new System.Windows.Forms.Button();
            this.AddBreakfast = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteDinner = new System.Windows.Forms.Button();
            this.btnDeleteEveningDinner = new System.Windows.Forms.Button();
            this.btnDeleteSnack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveningDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBreakfast
            // 
            this.dgvBreakfast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.dgvBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakfast.Location = new System.Drawing.Point(12, 50);
            this.dgvBreakfast.Name = "dgvBreakfast";
            this.dgvBreakfast.RowHeadersWidth = 51;
            this.dgvBreakfast.RowTemplate.Height = 24;
            this.dgvBreakfast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBreakfast.Size = new System.Drawing.Size(240, 162);
            this.dgvBreakfast.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Обед";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Завтрак";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.labelAge.Location = new System.Drawing.Point(48, 220);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(90, 37);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Ужин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(306, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Перекус";
            // 
            // dgvDinner
            // 
            this.dgvDinner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.dgvDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinner.Location = new System.Drawing.Point(270, 51);
            this.dgvDinner.Name = "dgvDinner";
            this.dgvDinner.RowHeadersWidth = 51;
            this.dgvDinner.RowTemplate.Height = 24;
            this.dgvDinner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDinner.Size = new System.Drawing.Size(240, 162);
            this.dgvDinner.TabIndex = 45;
            // 
            // dgvSnack
            // 
            this.dgvSnack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.dgvSnack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnack.Location = new System.Drawing.Point(270, 259);
            this.dgvSnack.Name = "dgvSnack";
            this.dgvSnack.RowHeadersWidth = 51;
            this.dgvSnack.RowTemplate.Height = 24;
            this.dgvSnack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSnack.Size = new System.Drawing.Size(240, 162);
            this.dgvSnack.TabIndex = 53;
            // 
            // dgvEveningDinner
            // 
            this.dgvEveningDinner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.dgvEveningDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEveningDinner.Location = new System.Drawing.Point(12, 259);
            this.dgvEveningDinner.Name = "dgvEveningDinner";
            this.dgvEveningDinner.RowHeadersWidth = 51;
            this.dgvEveningDinner.RowTemplate.Height = 24;
            this.dgvEveningDinner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEveningDinner.Size = new System.Drawing.Size(240, 162);
            this.dgvEveningDinner.TabIndex = 54;
            // 
            // pbBMR
            // 
            this.pbBMR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pbBMR.Location = new System.Drawing.Point(523, 185);
            this.pbBMR.Name = "pbBMR";
            this.pbBMR.Size = new System.Drawing.Size(192, 28);
            this.pbBMR.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(519, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Осталось:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(606, 113);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(34, 18);
            this.lbCount.TabIndex = 61;
            this.lbCount.Text = "bmr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(653, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Калорий";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(569, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Из:";
            // 
            // lbBmr
            // 
            this.lbBmr.AutoSize = true;
            this.lbBmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBmr.Location = new System.Drawing.Point(606, 139);
            this.lbBmr.Name = "lbBmr";
            this.lbBmr.Size = new System.Drawing.Size(34, 18);
            this.lbBmr.TabIndex = 61;
            this.lbBmr.Text = "bmr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(653, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Калорий";
            // 
            // dtpChoose
            // 
            this.dtpChoose.Location = new System.Drawing.Point(523, 51);
            this.dtpChoose.Name = "dtpChoose";
            this.dtpChoose.Size = new System.Drawing.Size(200, 22);
            this.dtpChoose.TabIndex = 64;
            this.dtpChoose.ValueChanged += new System.EventHandler(this.DtpChoose_ValueChanged);
            // 
            // tbWeightProd
            // 
            this.tbWeightProd.Location = new System.Drawing.Point(522, 331);
            this.tbWeightProd.Name = "tbWeightProd";
            this.tbWeightProd.Size = new System.Drawing.Size(193, 22);
            this.tbWeightProd.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(521, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 71;
            this.label12.Text = "Название:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(521, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 72;
            this.label13.Text = "Вес:";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(522, 282);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(191, 24);
            this.cbProducts.TabIndex = 73;
            // 
            // btnDeleteBreakfast
            // 
            this.btnDeleteBreakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBreakfast.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteBreakfast.FlatAppearance.BorderSize = 0;
            this.btnDeleteBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBreakfast.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_минус_30;
            this.btnDeleteBreakfast.Location = new System.Drawing.Point(215, 13);
            this.btnDeleteBreakfast.Name = "btnDeleteBreakfast";
            this.btnDeleteBreakfast.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteBreakfast.TabIndex = 74;
            this.btnDeleteBreakfast.UseVisualStyleBackColor = true;
            this.btnDeleteBreakfast.Click += new System.EventHandler(this.BtnDeleteBreakfast_Click);
            // 
            // btnAddDinner
            // 
            this.btnAddDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDinner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDinner.FlatAppearance.BorderSize = 0;
            this.btnAddDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDinner.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_плюс_30;
            this.btnAddDinner.Location = new System.Drawing.Point(435, 15);
            this.btnAddDinner.Name = "btnAddDinner";
            this.btnAddDinner.Size = new System.Drawing.Size(37, 35);
            this.btnAddDinner.TabIndex = 57;
            this.btnAddDinner.UseVisualStyleBackColor = true;
            this.btnAddDinner.Click += new System.EventHandler(this.BtnAddDinner_Click);
            // 
            // btnAddSnack
            // 
            this.btnAddSnack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSnack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSnack.FlatAppearance.BorderSize = 0;
            this.btnAddSnack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSnack.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_плюс_30;
            this.btnAddSnack.Location = new System.Drawing.Point(435, 223);
            this.btnAddSnack.Name = "btnAddSnack";
            this.btnAddSnack.Size = new System.Drawing.Size(37, 35);
            this.btnAddSnack.TabIndex = 56;
            this.btnAddSnack.UseVisualStyleBackColor = true;
            this.btnAddSnack.Click += new System.EventHandler(this.BtnAddSnack_Click);
            // 
            // btnAddEveningDinner
            // 
            this.btnAddEveningDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEveningDinner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddEveningDinner.FlatAppearance.BorderSize = 0;
            this.btnAddEveningDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEveningDinner.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_плюс_30;
            this.btnAddEveningDinner.Location = new System.Drawing.Point(177, 223);
            this.btnAddEveningDinner.Name = "btnAddEveningDinner";
            this.btnAddEveningDinner.Size = new System.Drawing.Size(37, 35);
            this.btnAddEveningDinner.TabIndex = 55;
            this.btnAddEveningDinner.UseVisualStyleBackColor = true;
            this.btnAddEveningDinner.Click += new System.EventHandler(this.BtnAddEveningDinner_Click);
            // 
            // AddBreakfast
            // 
            this.AddBreakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBreakfast.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddBreakfast.FlatAppearance.BorderSize = 0;
            this.AddBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBreakfast.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_плюс_30;
            this.AddBreakfast.Location = new System.Drawing.Point(177, 13);
            this.AddBreakfast.Name = "AddBreakfast";
            this.AddBreakfast.Size = new System.Drawing.Size(37, 35);
            this.AddBreakfast.TabIndex = 52;
            this.AddBreakfast.UseVisualStyleBackColor = true;
            this.AddBreakfast.Click += new System.EventHandler(this.AddBreakfast_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_яркая_луна_30;
            this.pictureBox4.Location = new System.Drawing.Point(273, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_восход_30;
            this.pictureBox3.Location = new System.Drawing.Point(14, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_солнце_30;
            this.pictureBox2.Location = new System.Drawing.Point(271, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_закат_солнца_30;
            this.pictureBox1.Location = new System.Drawing.Point(15, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeleteDinner
            // 
            this.btnDeleteDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDinner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteDinner.FlatAppearance.BorderSize = 0;
            this.btnDeleteDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDinner.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_минус_30;
            this.btnDeleteDinner.Location = new System.Drawing.Point(473, 15);
            this.btnDeleteDinner.Name = "btnDeleteDinner";
            this.btnDeleteDinner.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteDinner.TabIndex = 75;
            this.btnDeleteDinner.UseVisualStyleBackColor = true;
            this.btnDeleteDinner.Click += new System.EventHandler(this.BtnDeleteDinner_Click);
            // 
            // btnDeleteEveningDinner
            // 
            this.btnDeleteEveningDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEveningDinner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteEveningDinner.FlatAppearance.BorderSize = 0;
            this.btnDeleteEveningDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEveningDinner.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_минус_30;
            this.btnDeleteEveningDinner.Location = new System.Drawing.Point(217, 223);
            this.btnDeleteEveningDinner.Name = "btnDeleteEveningDinner";
            this.btnDeleteEveningDinner.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteEveningDinner.TabIndex = 76;
            this.btnDeleteEveningDinner.UseVisualStyleBackColor = true;
            this.btnDeleteEveningDinner.Click += new System.EventHandler(this.BtnDeleteEveningDinner_Click);
            // 
            // btnDeleteSnack
            // 
            this.btnDeleteSnack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSnack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteSnack.FlatAppearance.BorderSize = 0;
            this.btnDeleteSnack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSnack.Image = global::CalorieCalculatorWF.Properties.Resources.icons8_минус_30;
            this.btnDeleteSnack.Location = new System.Drawing.Point(473, 223);
            this.btnDeleteSnack.Name = "btnDeleteSnack";
            this.btnDeleteSnack.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteSnack.TabIndex = 77;
            this.btnDeleteSnack.UseVisualStyleBackColor = true;
            this.btnDeleteSnack.Click += new System.EventHandler(this.BtnDeleteSnack_Click);
            // 
            // FormDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.btnDeleteSnack);
            this.Controls.Add(this.btnDeleteEveningDinner);
            this.Controls.Add(this.btnDeleteDinner);
            this.Controls.Add(this.btnDeleteBreakfast);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbWeightProd);
            this.Controls.Add(this.dtpChoose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbBmr);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbBMR);
            this.Controls.Add(this.btnAddDinner);
            this.Controls.Add(this.btnAddSnack);
            this.Controls.Add(this.btnAddEveningDinner);
            this.Controls.Add(this.dgvEveningDinner);
            this.Controls.Add(this.dgvSnack);
            this.Controls.Add(this.AddBreakfast);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBreakfast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.label3);
            this.Name = "FormDiary";
            this.Text = "Дневник калорий";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveningDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBreakfast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button AddBreakfast;
        private System.Windows.Forms.DataGridView dgvSnack;
        private System.Windows.Forms.DataGridView dgvEveningDinner;
        private System.Windows.Forms.Button btnAddEveningDinner;
        private System.Windows.Forms.Button btnAddSnack;
        private System.Windows.Forms.Button btnAddDinner;
        private System.Windows.Forms.ProgressBar pbBMR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBmr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpChoose;
        private System.Windows.Forms.TextBox tbWeightProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Button btnDeleteBreakfast;
        private System.Windows.Forms.Button btnDeleteDinner;
        private System.Windows.Forms.Button btnDeleteEveningDinner;
        private System.Windows.Forms.Button btnDeleteSnack;
    }
}