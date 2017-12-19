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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "TODO",
            "report0",
            "dia x"}, -1);
            this.listBoxCidades = new System.Windows.Forms.ListBox();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblAlarms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxFilterDate = new System.Windows.Forms.CheckBox();
            this.cBoxCityList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCidades
            // 
            this.listBoxCidades.Enabled = false;
            this.listBoxCidades.FormattingEnabled = true;
            this.listBoxCidades.ItemHeight = 25;
            this.listBoxCidades.Items.AddRange(new object[] {
            "a",
            "s",
            "d",
            "f",
            "g",
            "h",
            "j",
            "j",
            "k",
            "b",
            "d",
            "d",
            "sa",
            "as"});
            this.listBoxCidades.Location = new System.Drawing.Point(30, 151);
            this.listBoxCidades.Name = "listBoxCidades";
            this.listBoxCidades.Size = new System.Drawing.Size(561, 429);
            this.listBoxCidades.TabIndex = 0;
            // 
            // listViewAlarms
            // 
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "Date";
            this.listViewAlarms.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            listViewItem5.Tag = "Date";
            this.listViewAlarms.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listViewAlarms.Location = new System.Drawing.Point(825, 151);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(687, 213);
            this.listViewAlarms.TabIndex = 1;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(825, 443);
            this.dtpStartDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(1077, 443);
            this.dtpEndDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 31);
            this.dtpEndDate.TabIndex = 4;
            // 
            // lblAlarms
            // 
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Location = new System.Drawing.Point(820, 108);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(78, 25);
            this.lblAlarms.TabIndex = 5;
            this.lblAlarms.Text = "Alarms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1072, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "End date";
            // 
            // chkBoxFilterDate
            // 
            this.chkBoxFilterDate.AutoSize = true;
            this.chkBoxFilterDate.Location = new System.Drawing.Point(1343, 447);
            this.chkBoxFilterDate.Name = "chkBoxFilterDate";
            this.chkBoxFilterDate.Size = new System.Drawing.Size(169, 29);
            this.chkBoxFilterDate.TabIndex = 9;
            this.chkBoxFilterDate.Text = "Filter by date";
            this.chkBoxFilterDate.UseVisualStyleBackColor = true;
            this.chkBoxFilterDate.CheckedChanged += new System.EventHandler(this.chkBoxFilterDate_CheckedChanged);
            // 
            // cBoxCityList
            // 
            this.cBoxCityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCityList.FormattingEnabled = true;
            this.cBoxCityList.Items.AddRange(new object[] {
            "All Cities Teste",
            "LeiriaTeste",
            "LisboaTeste",
            "CoimbraTeste"});
            this.cBoxCityList.Location = new System.Drawing.Point(30, 73);
            this.cBoxCityList.Name = "cBoxCityList";
            this.cBoxCityList.Size = new System.Drawing.Size(561, 33);
            this.cBoxCityList.TabIndex = 11;
            this.cBoxCityList.SelectedIndexChanged += new System.EventHandler(this.cBoxCityList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "City to view:";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(820, 637);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(192, 25);
            this.lblEvents.TabIndex = 16;
            this.lblEvents.Text = "Uncommon Events";
            // 
            // listViewEvents
            // 
            this.listViewEvents.Location = new System.Drawing.Point(825, 680);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(881, 213);
            this.listViewEvents.TabIndex = 15;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Location = new System.Drawing.Point(196, 769);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(286, 41);
            this.btnStatistics.TabIndex = 17;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxCityList);
            this.Controls.Add(this.chkBoxFilterDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAlarms);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.listViewAlarms);
            this.Controls.Add(this.listBoxCidades);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCidades;
        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblAlarms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoxFilterDate;
        private System.Windows.Forms.ComboBox cBoxCityList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnStatistics;
    }
}

