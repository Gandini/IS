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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea4.Name = "ChartAreaCO";
            this.chartCO.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCO.Legends.Add(legend4);
            this.chartCO.Location = new System.Drawing.Point(6, 30);
            this.chartCO.Name = "chartCO";
            series10.ChartArea = "ChartAreaCO";
            series10.Legend = "Legend1";
            series10.Name = "Maximum";
            series11.ChartArea = "ChartAreaCO";
            series11.Legend = "Legend1";
            series11.Name = "Average";
            series12.ChartArea = "ChartAreaCO";
            series12.Legend = "Legend1";
            series12.Name = "Minimum";
            this.chartCO.Series.Add(series10);
            this.chartCO.Series.Add(series11);
            this.chartCO.Series.Add(series12);
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
            chartArea5.Name = "ChartAreaNO2";
            this.chartNO2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartNO2.Legends.Add(legend5);
            this.chartNO2.Location = new System.Drawing.Point(6, 30);
            this.chartNO2.Name = "chartNO2";
            series13.ChartArea = "ChartAreaNO2";
            series13.Legend = "Legend1";
            series13.Name = "Maximum";
            series14.ChartArea = "ChartAreaNO2";
            series14.Legend = "Legend1";
            series14.Name = "Average";
            series15.ChartArea = "ChartAreaNO2";
            series15.Legend = "Legend1";
            series15.Name = "Minimum";
            this.chartNO2.Series.Add(series13);
            this.chartNO2.Series.Add(series14);
            this.chartNO2.Series.Add(series15);
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
            chartArea6.Name = "ChartAreaO3";
            this.chartO3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartO3.Legends.Add(legend6);
            this.chartO3.Location = new System.Drawing.Point(6, 30);
            this.chartO3.Name = "chartO3";
            series16.ChartArea = "ChartAreaO3";
            series16.Legend = "Legend1";
            series16.Name = "Maximum";
            series17.ChartArea = "ChartAreaO3";
            series17.Legend = "Legend1";
            series17.Name = "Average";
            series18.ChartArea = "ChartAreaO3";
            series18.Legend = "Legend1";
            series18.Name = "Minimum";
            this.chartO3.Series.Add(series16);
            this.chartO3.Series.Add(series17);
            this.chartO3.Series.Add(series18);
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