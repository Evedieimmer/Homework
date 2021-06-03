namespace CalorieCalculatorWF.Forms
{
    partial class FormReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvValues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(12, 12);
            this.chartReport.Name = "chartReport";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(581, 347);
            this.chartReport.TabIndex = 0;
            this.chartReport.Text = "chart1";
            // 
            // btnShowChart
            // 
            this.btnShowChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowChart.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnShowChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowChart.Location = new System.Drawing.Point(540, 379);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(192, 35);
            this.btnShowChart.TabIndex = 68;
            this.btnShowChart.Text = "Посмотреть отчет";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.BtnShowChart_Click);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(22, 392);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 22);
            this.dtpBegin.TabIndex = 69;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(274, 392);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Выберите дату начала:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Выберите дату окончания:";
            // 
            // dgvValues
            // 
            this.dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValues.Location = new System.Drawing.Point(599, 12);
            this.dgvValues.Name = "dgvValues";
            this.dgvValues.RowHeadersWidth = 51;
            this.dgvValues.RowTemplate.Height = 24;
            this.dgvValues.Size = new System.Drawing.Size(133, 347);
            this.dgvValues.TabIndex = 73;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.dgvValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.chartReport);
            this.Name = "FormReport";
            this.Text = "Отчеты";
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvValues;
    }
}