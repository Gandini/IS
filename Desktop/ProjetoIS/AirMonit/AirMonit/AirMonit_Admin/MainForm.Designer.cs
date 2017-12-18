namespace AirMonit_Admin
{
    partial class MainForm
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
            this.listBoxCidades = new System.Windows.Forms.ListBox();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxFilterDate = new System.Windows.Forms.CheckBox();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btn_listaCidades = new System.Windows.Forms.Button();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxO3 = new System.Windows.Forms.ListBox();
            this.listBoxNO2 = new System.Windows.Forms.ListBox();
            this.btn_sensorData = new System.Windows.Forms.Button();
            this.listBoxCO = new System.Windows.Forms.ListBox();
            this.dtp_sensorData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCidades
            // 
            this.listBoxCidades.FormattingEnabled = true;
            this.listBoxCidades.ItemHeight = 25;
            this.listBoxCidades.Items.AddRange(new object[] {
            "All",
            "Leiria",
            "Porto",
            "Coimbra"});
            this.listBoxCidades.Location = new System.Drawing.Point(12, 67);
            this.listBoxCidades.Name = "listBoxCidades";
            this.listBoxCidades.Size = new System.Drawing.Size(561, 329);
            this.listBoxCidades.TabIndex = 0;
            this.listBoxCidades.SelectedIndexChanged += new System.EventHandler(this.listBoxCidades_SelectedIndexChanged);
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(248, 405);
            this.dtp_startDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_startDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 31);
            this.dtp_startDate.TabIndex = 2;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(569, 405);
            this.dtp_endDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_endDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(200, 31);
            this.dtp_endDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "End date:";
            // 
            // chkBoxFilterDate
            // 
            this.chkBoxFilterDate.AutoSize = true;
            this.chkBoxFilterDate.Location = new System.Drawing.Point(793, 406);
            this.chkBoxFilterDate.Name = "chkBoxFilterDate";
            this.chkBoxFilterDate.Size = new System.Drawing.Size(169, 29);
            this.chkBoxFilterDate.TabIndex = 9;
            this.chkBoxFilterDate.Text = "Filter by date";
            this.chkBoxFilterDate.UseVisualStyleBackColor = true;
            this.chkBoxFilterDate.CheckedChanged += new System.EventHandler(this.chkBoxFilterDate_CheckedChanged);
            // 
            // listViewEvents
            // 
            this.listViewEvents.Location = new System.Drawing.Point(24, 30);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(1001, 325);
            this.listViewEvents.TabIndex = 15;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Location = new System.Drawing.Point(12, 435);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(561, 41);
            this.btnStatistics.TabIndex = 17;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btn_listaCidades
            // 
            this.btn_listaCidades.Location = new System.Drawing.Point(12, 14);
            this.btn_listaCidades.Name = "btn_listaCidades";
            this.btn_listaCidades.Size = new System.Drawing.Size(561, 35);
            this.btn_listaCidades.TabIndex = 18;
            this.btn_listaCidades.Text = "Obter lista de cidades";
            this.btn_listaCidades.UseVisualStyleBackColor = true;
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 25;
            this.listBoxAlarms.Location = new System.Drawing.Point(26, 30);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(1025, 354);
            this.listBoxAlarms.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAlarms);
            this.groupBox1.Controls.Add(this.dtp_startDate);
            this.groupBox1.Controls.Add(this.dtp_endDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkBoxFilterDate);
            this.groupBox1.Location = new System.Drawing.Point(1156, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 462);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxO3);
            this.groupBox2.Controls.Add(this.listBoxNO2);
            this.groupBox2.Controls.Add(this.btn_sensorData);
            this.groupBox2.Controls.Add(this.listBoxCO);
            this.groupBox2.Controls.Add(this.dtp_sensorData);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(595, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1291, 508);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(854, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "O3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "NO2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "CO";
            // 
            // listBoxO3
            // 
            this.listBoxO3.FormattingEnabled = true;
            this.listBoxO3.ItemHeight = 25;
            this.listBoxO3.Location = new System.Drawing.Point(859, 63);
            this.listBoxO3.Name = "listBoxO3";
            this.listBoxO3.Size = new System.Drawing.Size(416, 354);
            this.listBoxO3.TabIndex = 22;
            // 
            // listBoxNO2
            // 
            this.listBoxNO2.FormattingEnabled = true;
            this.listBoxNO2.ItemHeight = 25;
            this.listBoxNO2.Location = new System.Drawing.Point(437, 63);
            this.listBoxNO2.Name = "listBoxNO2";
            this.listBoxNO2.Size = new System.Drawing.Size(408, 354);
            this.listBoxNO2.TabIndex = 21;
            // 
            // btn_sensorData
            // 
            this.btn_sensorData.Location = new System.Drawing.Point(686, 427);
            this.btn_sensorData.Name = "btn_sensorData";
            this.btn_sensorData.Size = new System.Drawing.Size(201, 41);
            this.btn_sensorData.TabIndex = 20;
            this.btn_sensorData.Text = "Get sensor data";
            this.btn_sensorData.UseVisualStyleBackColor = true;
            this.btn_sensorData.Click += new System.EventHandler(this.btn_sensorData_Click);
            // 
            // listBoxCO
            // 
            this.listBoxCO.FormattingEnabled = true;
            this.listBoxCO.ItemHeight = 25;
            this.listBoxCO.Location = new System.Drawing.Point(15, 63);
            this.listBoxCO.Name = "listBoxCO";
            this.listBoxCO.Size = new System.Drawing.Size(407, 354);
            this.listBoxCO.TabIndex = 19;
            // 
            // dtp_sensorData
            // 
            this.dtp_sensorData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_sensorData.Location = new System.Drawing.Point(470, 432);
            this.dtp_sensorData.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_sensorData.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_sensorData.Name = "dtp_sensorData";
            this.dtp_sensorData.Size = new System.Drawing.Size(200, 31);
            this.dtp_sensorData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewEvents);
            this.groupBox3.Location = new System.Drawing.Point(12, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1052, 414);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uncommon Events";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2389, 1302);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_listaCidades);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.listBoxCidades);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCidades;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoxFilterDate;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btn_listaCidades;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCO;
        private System.Windows.Forms.DateTimePicker dtp_sensorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sensorData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxO3;
        private System.Windows.Forms.ListBox listBoxNO2;
    }
}

