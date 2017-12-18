namespace AirMonit_Admin
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartNO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartO3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNO2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartO3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCO
            // 
            chartArea1.Name = "ChartAreaCO";
            this.chartCO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCO.Legends.Add(legend1);
            this.chartCO.Location = new System.Drawing.Point(6, 30);
            this.chartCO.Name = "chartCO";
            series1.ChartArea = "ChartAreaCO";
            series1.Legend = "Legend1";
            series1.Name = "Maximum";
            series2.ChartArea = "ChartAreaCO";
            series2.Legend = "Legend1";
            series2.Name = "Average";
            series3.ChartArea = "ChartAreaCO";
            series3.Legend = "Legend1";
            series3.Name = "Minimum";
            this.chartCO.Series.Add(series1);
            this.chartCO.Series.Add(series2);
            this.chartCO.Series.Add(series3);
            this.chartCO.Size = new System.Drawing.Size(655, 439);
            this.chartCO.TabIndex = 0;
            this.chartCO.Text = "chartCO";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(193, 9);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(200, 31);
            this.dtpDay.TabIndex = 15;
            this.dtpDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Statistics by day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Statistics by hour:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(860, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 29);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Filter by hour";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpHour
            // 
            this.dtpHour.CustomFormat = "HH:mm";
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHour.Location = new System.Drawing.Point(631, 9);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.Size = new System.Drawing.Size(200, 31);
            this.dtpHour.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartCO);
            this.groupBox1.Location = new System.Drawing.Point(17, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 485);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxCO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartNO2);
            this.groupBox2.Location = new System.Drawing.Point(709, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 485);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxNO2";
            // 
            // chartNO2
            // 
            chartArea2.Name = "ChartAreaNO2";
            this.chartNO2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNO2.Legends.Add(legend2);
            this.chartNO2.Location = new System.Drawing.Point(6, 30);
            this.chartNO2.Name = "chartNO2";
            series4.ChartArea = "ChartAreaNO2";
            series4.Legend = "Legend1";
            series4.Name = "Maximum";
            series5.ChartArea = "ChartAreaNO2";
            series5.Legend = "Legend1";
            series5.Name = "Average";
            series6.ChartArea = "ChartAreaNO2";
            series6.Legend = "Legend1";
            series6.Name = "Minimum";
            this.chartNO2.Series.Add(series4);
            this.chartNO2.Series.Add(series5);
            this.chartNO2.Series.Add(series6);
            this.chartNO2.Size = new System.Drawing.Size(655, 439);
            this.chartNO2.TabIndex = 0;
            this.chartNO2.Text = "chartNO2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartO3);
            this.groupBox3.Location = new System.Drawing.Point(1402, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 485);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBoxO3";
            // 
            // chartO3
            // 
            chartArea3.Name = "ChartAreaO3";
            this.chartO3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartO3.Legends.Add(legend3);
            this.chartO3.Location = new System.Drawing.Point(6, 30);
            this.chartO3.Name = "chartO3";
            series7.ChartArea = "ChartAreaO3";
            series7.Legend = "Legend1";
            series7.Name = "Maximum";
            series8.ChartArea = "ChartAreaO3";
            series8.Legend = "Legend1";
            series8.Name = "Average";
            series9.ChartArea = "ChartAreaO3";
            series9.Legend = "Legend1";
            series9.Name = "Minimum";
            this.chartO3.Series.Add(series7);
            this.chartO3.Series.Add(series8);
            this.chartO3.Series.Add(series9);
            this.chartO3.Size = new System.Drawing.Size(655, 439);
            this.chartO3.TabIndex = 0;
            this.chartO3.Text = "chartO3";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2099, 1107);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpHour);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDay);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNO2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartO3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCO;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNO2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartO3;
    }
}