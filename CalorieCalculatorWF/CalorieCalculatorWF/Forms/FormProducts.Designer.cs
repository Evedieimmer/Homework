namespace CalorieCalculatorWF.Forms
{
    partial class FormProducts
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnOnlyEat = new System.Windows.Forms.Button();
            this.btnOnlyDrink = new System.Windows.Forms.Button();
            this.tbNameProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCalorie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbDrink = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 49);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(480, 365);
            this.dgvProducts.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "Список продуктов:";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.btnAddProd.FlatAppearance.BorderSize = 2;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProd.Location = new System.Drawing.Point(511, 310);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(213, 35);
            this.btnAddProd.TabIndex = 50;
            this.btnAddProd.Text = "Добавить";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.BtnAddProd_Click);
            // 
            // btnOnlyEat
            // 
            this.btnOnlyEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnlyEat.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnOnlyEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlyEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOnlyEat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOnlyEat.Location = new System.Drawing.Point(511, 49);
            this.btnOnlyEat.Name = "btnOnlyEat";
            this.btnOnlyEat.Size = new System.Drawing.Size(98, 52);
            this.btnOnlyEat.TabIndex = 51;
            this.btnOnlyEat.Text = "Только продукты";
            this.btnOnlyEat.UseVisualStyleBackColor = true;
            this.btnOnlyEat.Click += new System.EventHandler(this.BtnOnlyEat_Click);
            // 
            // btnOnlyDrink
            // 
            this.btnOnlyDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnlyDrink.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnOnlyDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlyDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOnlyDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOnlyDrink.Location = new System.Drawing.Point(626, 49);
            this.btnOnlyDrink.Name = "btnOnlyDrink";
            this.btnOnlyDrink.Size = new System.Drawing.Size(98, 52);
            this.btnOnlyDrink.TabIndex = 52;
            this.btnOnlyDrink.Text = "Только напитки";
            this.btnOnlyDrink.UseVisualStyleBackColor = true;
            this.btnOnlyDrink.Click += new System.EventHandler(this.BtnOnlyDrink_Click);
            // 
            // tbNameProd
            // 
            this.tbNameProd.Location = new System.Drawing.Point(511, 161);
            this.tbNameProd.Name = "tbNameProd";
            this.tbNameProd.Size = new System.Drawing.Size(213, 22);
            this.tbNameProd.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(508, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "название:";
            // 
            // tbCalorie
            // 
            this.tbCalorie.Location = new System.Drawing.Point(511, 207);
            this.tbCalorie.Name = "tbCalorie";
            this.tbCalorie.Size = new System.Drawing.Size(213, 22);
            this.tbCalorie.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(508, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "содержание калорий в 100г:";
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Location = new System.Drawing.Point(3, 3);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(83, 21);
            this.rbFood.TabIndex = 64;
            this.rbFood.TabStop = true;
            this.rbFood.Text = "напиток";
            this.rbFood.UseVisualStyleBackColor = true;
            // 
            // rbDrink
            // 
            this.rbDrink.AutoSize = true;
            this.rbDrink.Location = new System.Drawing.Point(3, 30);
            this.rbDrink.Name = "rbDrink";
            this.rbDrink.Size = new System.Drawing.Size(82, 21);
            this.rbDrink.TabIndex = 65;
            this.rbDrink.TabStop = true;
            this.rbDrink.Text = "продукт";
            this.rbDrink.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(507, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Добавь свой продукт";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFood);
            this.panel1.Controls.Add(this.rbDrink);
            this.panel1.Location = new System.Drawing.Point(511, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 57);
            this.panel1.TabIndex = 67;
            // 
            // btnAllProduct
            // 
            this.btnAllProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllProduct.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAllProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllProduct.Location = new System.Drawing.Point(511, 12);
            this.btnAllProduct.Name = "btnAllProduct";
            this.btnAllProduct.Size = new System.Drawing.Size(213, 32);
            this.btnAllProduct.TabIndex = 68;
            this.btnAllProduct.Text = "Показать весь список";
            this.btnAllProduct.UseVisualStyleBackColor = true;
            this.btnAllProduct.Click += new System.EventHandler(this.BtnAllProduct_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.btnAllProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCalorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameProd);
            this.Controls.Add(this.btnOnlyDrink);
            this.Controls.Add(this.btnOnlyEat);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FormProducts";
            this.Text = "Продукты и напитки";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnOnlyEat;
        private System.Windows.Forms.Button btnOnlyDrink;
        private System.Windows.Forms.TextBox tbNameProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCalorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllProduct;
    }
}