using System.Windows.Forms;

namespace AirMonit_Alarm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCondition = new System.Windows.Forms.Button();
            this.editCondition = new System.Windows.Forms.Button();
            this.delCondition = new System.Windows.Forms.Button();
            this.activate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listaCondicoes = new System.Windows.Forms.ListBox();
            this.getConditions = new System.Windows.Forms.Button();
            this.labelCondicao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLigar = new System.Windows.Forms.Button();
            this.buttonDesligar = new System.Windows.Forms.Button();
            this.richTextBoxDadosSensor = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAlarmes = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados do Sensor:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addCondition
            // 
            this.addCondition.Location = new System.Drawing.Point(676, 315);
            this.addCondition.Name = "addCondition";
            this.addCondition.Size = new System.Drawing.Size(110, 27);
            this.addCondition.TabIndex = 5;
            this.addCondition.Text = "Adicionar condição";
            this.addCondition.UseVisualStyleBackColor = true;
            this.addCondition.Click += new System.EventHandler(this.addCondition_Click);
            // 
            // editCondition
            // 
            this.editCondition.Location = new System.Drawing.Point(260, 316);
            this.editCondition.Name = "editCondition";
            this.editCondition.Size = new System.Drawing.Size(98, 27);
            this.editCondition.TabIndex = 6;
            this.editCondition.Text = "Editar condição";
            this.editCondition.UseVisualStyleBackColor = true;
            this.editCondition.Click += new System.EventHandler(this.editCondition_Click);
            // 
            // delCondition
            // 
            this.delCondition.Location = new System.Drawing.Point(364, 317);
            this.delCondition.Name = "delCondition";
            this.delCondition.Size = new System.Drawing.Size(101, 26);
            this.delCondition.TabIndex = 7;
            this.delCondition.Text = "Apagar condição";
            this.delCondition.UseVisualStyleBackColor = true;
            this.delCondition.Click += new System.EventHandler(this.delCondition_Click);
            // 
            // activate
            // 
            this.activate.Location = new System.Drawing.Point(470, 317);
            this.activate.Name = "activate";
            this.activate.Size = new System.Drawing.Size(103, 26);
            this.activate.TabIndex = 10;
            this.activate.Text = "Ativar/Desativar";
            this.activate.UseVisualStyleBackColor = true;
            this.activate.Click += new System.EventHandler(this.activate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alarmes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Condição: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ativado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "desativado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Molecula:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "NO2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(63, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "CO";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(109, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 17);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "O3";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Operador:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(2, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 17);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "igual";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(54, 0);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(50, 17);
            this.radioButton7.TabIndex = 22;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "maior";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(107, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(54, 17);
            this.radioButton8.TabIndex = 23;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "menor";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(167, 0);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(49, 17);
            this.radioButton9.TabIndex = 24;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "entre";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Valor 2 (para operador entre):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(807, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mensagem:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(711, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 30;
            // 
            // listaCondicoes
            // 
            this.listaCondicoes.FormattingEnabled = true;
            this.listaCondicoes.Location = new System.Drawing.Point(351, 84);
            this.listaCondicoes.Name = "listaCondicoes";
            this.listaCondicoes.Size = new System.Drawing.Size(259, 225);
            this.listaCondicoes.TabIndex = 4;
            this.listaCondicoes.SelectedIndexChanged += new System.EventHandler(this.listaCondicoes_SelectedIndexChanged);
            // 
            // getConditions
            // 
            this.getConditions.Location = new System.Drawing.Point(384, 51);
            this.getConditions.Name = "getConditions";
            this.getConditions.Size = new System.Drawing.Size(98, 27);
            this.getConditions.TabIndex = 31;
            this.getConditions.Text = "Obter Condições";
            this.getConditions.UseVisualStyleBackColor = true;
            this.getConditions.Click += new System.EventHandler(this.getConditions_Click);
            // 
            // labelCondicao
            // 
            this.labelCondicao.AutoSize = true;
            this.labelCondicao.Location = new System.Drawing.Point(715, 78);
            this.labelCondicao.Name = "labelCondicao";
            this.labelCondicao.Size = new System.Drawing.Size(112, 13);
            this.labelCondicao.TabIndex = 32;
            this.labelCondicao.Text = "Condicao selecionada";
            this.labelCondicao.Click += new System.EventHandler(this.labelCondicao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(693, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 33);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(698, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 33);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.radioButton8);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Location = new System.Drawing.Point(707, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 32);
            this.panel3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ligar/Desligar receção de Dados dos Sensores:";
            // 
            // buttonLigar
            // 
            this.buttonLigar.Location = new System.Drawing.Point(249, 7);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.Size = new System.Drawing.Size(93, 30);
            this.buttonLigar.TabIndex = 38;
            this.buttonLigar.Text = "Ligar";
            this.buttonLigar.UseVisualStyleBackColor = true;
            this.buttonLigar.Click += new System.EventHandler(this.buttonLigar_Click);
            // 
            // buttonDesligar
            // 
            this.buttonDesligar.Location = new System.Drawing.Point(348, 7);
            this.buttonDesligar.Name = "buttonDesligar";
            this.buttonDesligar.Size = new System.Drawing.Size(93, 30);
            this.buttonDesligar.TabIndex = 39;
            this.buttonDesligar.Text = "Desligar";
            this.buttonDesligar.UseVisualStyleBackColor = true;
            this.buttonDesligar.Click += new System.EventHandler(this.buttonDesligar_Click);
            // 
            // richTextBoxDadosSensor
            // 
            this.richTextBoxDadosSensor.Location = new System.Drawing.Point(12, 84);
            this.richTextBoxDadosSensor.Name = "richTextBoxDadosSensor";
            this.richTextBoxDadosSensor.Size = new System.Drawing.Size(318, 225);
            this.richTextBoxDadosSensor.TabIndex = 42;
            this.richTextBoxDadosSensor.Text = "";
            this.richTextBoxDadosSensor.TextChanged += new System.EventHandler(this.richTextBoxDadosSensor_TextChanged_1);
            // 
            // richTextBoxAlarmes
            // 
            this.richTextBoxAlarmes.Location = new System.Drawing.Point(15, 372);
            this.richTextBoxAlarmes.Name = "richTextBoxAlarmes";
            this.richTextBoxAlarmes.Size = new System.Drawing.Size(779, 140);
            this.richTextBoxAlarmes.TabIndex = 43;
            this.richTextBoxAlarmes.Text = "";
            this.richTextBoxAlarmes.TextChanged += new System.EventHandler(this.richTextBoxAlarmes_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 524);
            this.Controls.Add(this.richTextBoxAlarmes);
            this.Controls.Add(this.richTextBoxDadosSensor);
            this.Controls.Add(this.buttonDesligar);
            this.Controls.Add(this.buttonLigar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCondicao);
            this.Controls.Add(this.getConditions);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activate);
            this.Controls.Add(this.delCondition);
            this.Controls.Add(this.editCondition);
            this.Controls.Add(this.addCondition);
            this.Controls.Add(this.listaCondicoes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AirMonit_Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCondition;
        private System.Windows.Forms.Button editCondition;
        private System.Windows.Forms.Button delCondition;
        private System.Windows.Forms.Button activate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listaCondicoes;
        private System.Windows.Forms.Button getConditions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Label labelCondicao;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button buttonLigar;
        private Button buttonDesligar;
        private RichTextBox richTextBoxDadosSensor;
        private RichTextBox richTextBoxAlarmes;
    }
}

