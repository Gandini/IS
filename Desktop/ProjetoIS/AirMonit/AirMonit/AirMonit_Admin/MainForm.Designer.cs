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
            this.btnStatistics = new System.Windows.Forms.Button();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.groupBoxAlarms = new System.Windows.Forms.GroupBox();
            this.groupBoxSensors = new System.Windows.Forms.GroupBox();
            this.checkBoxSensorsFilterDate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxO3 = new System.Windows.Forms.ListBox();
            this.listBoxNO2 = new System.Windows.Forms.ListBox();
            this.listBoxCO = new System.Windows.Forms.ListBox();
            this.dtp_sensorData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEvents = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.groupBoxCities = new System.Windows.Forms.GroupBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
=======
            this.btnUpdateEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.groupBoxCities = new System.Windows.Forms.GroupBox();
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.groupBoxAlarms.SuspendLayout();
            this.groupBoxSensors.SuspendLayout();
            this.groupBoxEvents.SuspendLayout();
            this.groupBoxCities.SuspendLayout();
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
            this.listBoxCidades.Location = new System.Drawing.Point(24, 35);
            this.listBoxCidades.Name = "listBoxCidades";
            this.listBoxCidades.Size = new System.Drawing.Size(373, 354);
            this.listBoxCidades.TabIndex = 0;
            this.listBoxCidades.SelectedIndexChanged += new System.EventHandler(this.listBoxCidades_SelectedIndexChanged);
            // 
            // dtp_startDate
            // 
<<<<<<< HEAD
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(248, 405);
=======
            this.dtp_startDate.Enabled = false;
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(141, 401);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.dtp_startDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_startDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 31);
            this.dtp_startDate.TabIndex = 2;
            // 
            // dtp_endDate
            // 
<<<<<<< HEAD
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(569, 405);
=======
            this.dtp_endDate.Enabled = false;
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(462, 401);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.dtp_endDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_endDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(200, 31);
            this.dtp_endDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(137, 410);
=======
            this.label2.Location = new System.Drawing.Point(30, 406);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(465, 410);
=======
            this.label3.Location = new System.Drawing.Point(358, 406);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "End date:";
            // 
            // chkBoxFilterDate
            // 
            this.chkBoxFilterDate.AutoSize = true;
<<<<<<< HEAD
            this.chkBoxFilterDate.Location = new System.Drawing.Point(793, 406);
=======
            this.chkBoxFilterDate.Enabled = false;
            this.chkBoxFilterDate.Location = new System.Drawing.Point(686, 402);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.chkBoxFilterDate.Name = "chkBoxFilterDate";
            this.chkBoxFilterDate.Size = new System.Drawing.Size(169, 29);
            this.chkBoxFilterDate.TabIndex = 9;
            this.chkBoxFilterDate.Text = "Filter by date";
            this.chkBoxFilterDate.UseVisualStyleBackColor = true;
            this.chkBoxFilterDate.CheckedChanged += new System.EventHandler(this.chkBoxFilterDate_CheckedChanged);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Location = new System.Drawing.Point(24, 419);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(373, 41);
            this.btnStatistics.TabIndex = 17;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 25;
            this.listBoxAlarms.Location = new System.Drawing.Point(26, 30);
            this.listBoxAlarms.Name = "listBoxAlarms";
<<<<<<< HEAD
            this.listBoxAlarms.Size = new System.Drawing.Size(1025, 354);
=======
            this.listBoxAlarms.Size = new System.Drawing.Size(829, 354);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.listBoxAlarms.TabIndex = 19;
            // 
            // groupBoxAlarms
            // 
            this.groupBoxAlarms.Controls.Add(this.listBoxAlarms);
            this.groupBoxAlarms.Controls.Add(this.dtp_startDate);
            this.groupBoxAlarms.Controls.Add(this.dtp_endDate);
            this.groupBoxAlarms.Controls.Add(this.label2);
            this.groupBoxAlarms.Controls.Add(this.label3);
            this.groupBoxAlarms.Controls.Add(this.chkBoxFilterDate);
<<<<<<< HEAD
            this.groupBoxAlarms.Location = new System.Drawing.Point(1009, 516);
            this.groupBoxAlarms.Name = "groupBoxAlarms";
            this.groupBoxAlarms.Size = new System.Drawing.Size(1079, 462);
=======
            this.groupBoxAlarms.Location = new System.Drawing.Point(874, 516);
            this.groupBoxAlarms.Name = "groupBoxAlarms";
            this.groupBoxAlarms.Size = new System.Drawing.Size(870, 462);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.groupBoxAlarms.TabIndex = 20;
            this.groupBoxAlarms.TabStop = false;
            this.groupBoxAlarms.Text = "Alarms";
            // 
            // groupBoxSensors
            // 
            this.groupBoxSensors.Controls.Add(this.checkBoxSensorsFilterDate);
            this.groupBoxSensors.Controls.Add(this.label6);
            this.groupBoxSensors.Controls.Add(this.label5);
            this.groupBoxSensors.Controls.Add(this.label4);
            this.groupBoxSensors.Controls.Add(this.listBoxO3);
            this.groupBoxSensors.Controls.Add(this.listBoxNO2);
            this.groupBoxSensors.Controls.Add(this.listBoxCO);
            this.groupBoxSensors.Controls.Add(this.dtp_sensorData);
            this.groupBoxSensors.Controls.Add(this.label1);
            this.groupBoxSensors.Location = new System.Drawing.Point(454, 14);
            this.groupBoxSensors.Name = "groupBoxSensors";
            this.groupBoxSensors.Size = new System.Drawing.Size(1290, 482);
            this.groupBoxSensors.TabIndex = 21;
            this.groupBoxSensors.TabStop = false;
            this.groupBoxSensors.Text = "Sensors";
            // 
            // checkBoxSensorsFilterDate
            // 
            this.checkBoxSensorsFilterDate.AutoSize = true;
<<<<<<< HEAD
=======
            this.checkBoxSensorsFilterDate.Enabled = false;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.checkBoxSensorsFilterDate.Location = new System.Drawing.Point(703, 433);
            this.checkBoxSensorsFilterDate.Name = "checkBoxSensorsFilterDate";
            this.checkBoxSensorsFilterDate.Size = new System.Drawing.Size(169, 29);
            this.checkBoxSensorsFilterDate.TabIndex = 26;
            this.checkBoxSensorsFilterDate.Text = "Filter by date";
            this.checkBoxSensorsFilterDate.UseVisualStyleBackColor = true;
            this.checkBoxSensorsFilterDate.CheckedChanged += new System.EventHandler(this.checkBoxSensorsFilterDate_CheckedChanged);
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
<<<<<<< HEAD
=======
            this.dtp_sensorData.Enabled = false;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.dtp_sensorData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_sensorData.Location = new System.Drawing.Point(470, 432);
            this.dtp_sensorData.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_sensorData.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_sensorData.Name = "dtp_sensorData";
            this.dtp_sensorData.Size = new System.Drawing.Size(200, 31);
            this.dtp_sensorData.TabIndex = 2;
            this.dtp_sensorData.ValueChanged += new System.EventHandler(this.dtp_sensorData_ValueChanged);
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
            // groupBoxEvents
            // 
<<<<<<< HEAD
            this.groupBoxEvents.Controls.Add(this.listBoxEvents);
            this.groupBoxEvents.Location = new System.Drawing.Point(12, 516);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(978, 414);
=======
            this.groupBoxEvents.Controls.Add(this.btnUpdateEvents);
            this.groupBoxEvents.Controls.Add(this.listBoxEvents);
            this.groupBoxEvents.Location = new System.Drawing.Point(12, 516);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(845, 462);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.groupBoxEvents.TabIndex = 22;
            this.groupBoxEvents.TabStop = false;
            this.groupBoxEvents.Text = "Uncommon Events";
            // 
<<<<<<< HEAD
=======
            // btnUpdateEvents
            // 
            this.btnUpdateEvents.Location = new System.Drawing.Point(24, 406);
            this.btnUpdateEvents.Name = "btnUpdateEvents";
            this.btnUpdateEvents.Size = new System.Drawing.Size(799, 41);
            this.btnUpdateEvents.TabIndex = 18;
            this.btnUpdateEvents.Text = "Update events list";
            this.btnUpdateEvents.UseVisualStyleBackColor = true;
            this.btnUpdateEvents.Click += new System.EventHandler(this.btnUpdateEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(24, 30);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(799, 354);
            this.listBoxEvents.TabIndex = 0;
            // 
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            // groupBoxCities
            // 
            this.groupBoxCities.Controls.Add(this.listBoxCidades);
            this.groupBoxCities.Controls.Add(this.btnStatistics);
            this.groupBoxCities.Location = new System.Drawing.Point(12, 14);
            this.groupBoxCities.Name = "groupBoxCities";
            this.groupBoxCities.Size = new System.Drawing.Size(422, 482);
            this.groupBoxCities.TabIndex = 23;
            this.groupBoxCities.TabStop = false;
            this.groupBoxCities.Text = "Cities";
<<<<<<< HEAD
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(24, 30);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(928, 354);
            this.listBoxEvents.TabIndex = 0;
=======
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(2389, 1302);
=======
            this.ClientSize = new System.Drawing.Size(1960, 1117);
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            this.Controls.Add(this.groupBoxCities);
            this.Controls.Add(this.groupBoxEvents);
            this.Controls.Add(this.groupBoxAlarms);
            this.Controls.Add(this.groupBoxSensors);
            this.Name = "MainForm";
            this.Text = "Administration App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAlarms.ResumeLayout(false);
            this.groupBoxAlarms.PerformLayout();
            this.groupBoxSensors.ResumeLayout(false);
            this.groupBoxSensors.PerformLayout();
            this.groupBoxEvents.ResumeLayout(false);
            this.groupBoxCities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCidades;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoxFilterDate;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.GroupBox groupBoxAlarms;
        private System.Windows.Forms.GroupBox groupBoxSensors;
        private System.Windows.Forms.ListBox listBoxCO;
        private System.Windows.Forms.DateTimePicker dtp_sensorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEvents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxO3;
        private System.Windows.Forms.ListBox listBoxNO2;
        private System.Windows.Forms.CheckBox checkBoxSensorsFilterDate;
        private System.Windows.Forms.GroupBox groupBoxCities;
        private System.Windows.Forms.ListBox listBoxEvents;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button btnUpdateEvents;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
    }
}

