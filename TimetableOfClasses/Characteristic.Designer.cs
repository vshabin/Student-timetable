﻿namespace TimetableOfClasses
{
	partial class Characteristic
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
			this.Ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Help = new System.Windows.Forms.Button();
			this.Numeration = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Day = new System.Windows.Forms.TabPage();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.Changes = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Third = new System.Windows.Forms.DomainUpDown();
			this.Second = new System.Windows.Forms.DomainUpDown();
			this.First = new System.Windows.Forms.DomainUpDown();
			this.Most = new System.Windows.Forms.DomainUpDown();
			this.Date = new System.Windows.Forms.TabPage();
			this.Bells = new System.Windows.Forms.TabPage();
			this.Cycles = new System.Windows.Forms.TabPage();
			this.Etc = new System.Windows.Forms.TabPage();
			this.SecondPair = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Numeration.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.Day.SuspendLayout();
			this.Changes.SuspendLayout();
			this.SuspendLayout();
			// 
			// Ok
			// 
			this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Ok.Location = new System.Drawing.Point(132, 418);
			this.Ok.Name = "Ok";
			this.Ok.Size = new System.Drawing.Size(75, 23);
			this.Ok.TabIndex = 0;
			this.Ok.Text = "ОК";
			this.Ok.UseVisualStyleBackColor = true;
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.Location = new System.Drawing.Point(213, 418);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "Отмена";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// Help
			// 
			this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Help.Location = new System.Drawing.Point(294, 418);
			this.Help.Name = "Help";
			this.Help.Size = new System.Drawing.Size(75, 23);
			this.Help.TabIndex = 2;
			this.Help.Text = "Справка";
			this.Help.UseVisualStyleBackColor = true;
			// 
			// Numeration
			// 
			this.Numeration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Numeration.Controls.Add(this.radioButton2);
			this.Numeration.Controls.Add(this.radioButton1);
			this.Numeration.Location = new System.Drawing.Point(13, 25);
			this.Numeration.Name = "Numeration";
			this.Numeration.Size = new System.Drawing.Size(321, 41);
			this.Numeration.TabIndex = 3;
			this.Numeration.TabStop = false;
			this.Numeration.Text = "Нумерация пар";
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(138, 20);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(65, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "С 1 по 8";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(65, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "С 0 по 7";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Day);
			this.tabControl1.Controls.Add(this.Date);
			this.tabControl1.Controls.Add(this.Bells);
			this.tabControl1.Controls.Add(this.Cycles);
			this.tabControl1.Controls.Add(this.Etc);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(357, 389);
			this.tabControl1.TabIndex = 4;
			// 
			// Day
			// 
			this.Day.Controls.Add(this.label6);
			this.Day.Controls.Add(this.checkBox1);
			this.Day.Controls.Add(this.SecondPair);
			this.Day.Controls.Add(this.domainUpDown1);
			this.Day.Controls.Add(this.label5);
			this.Day.Controls.Add(this.Changes);
			this.Day.Controls.Add(this.Numeration);
			this.Day.Location = new System.Drawing.Point(4, 22);
			this.Day.Name = "Day";
			this.Day.Padding = new System.Windows.Forms.Padding(3);
			this.Day.Size = new System.Drawing.Size(349, 363);
			this.Day.TabIndex = 0;
			this.Day.Text = "День";
			this.Day.UseVisualStyleBackColor = true;
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.domainUpDown1.Location = new System.Drawing.Point(278, 303);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(65, 20);
			this.domainUpDown1.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(33, 305);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(226, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Наибольшее число рабочих дней в неделю:";
			// 
			// Changes
			// 
			this.Changes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Changes.Controls.Add(this.label4);
			this.Changes.Controls.Add(this.label3);
			this.Changes.Controls.Add(this.label2);
			this.Changes.Controls.Add(this.label1);
			this.Changes.Controls.Add(this.Third);
			this.Changes.Controls.Add(this.Second);
			this.Changes.Controls.Add(this.First);
			this.Changes.Controls.Add(this.Most);
			this.Changes.Location = new System.Drawing.Point(13, 169);
			this.Changes.Name = "Changes";
			this.Changes.Size = new System.Drawing.Size(321, 123);
			this.Changes.TabIndex = 4;
			this.Changes.TabStop = false;
			this.Changes.Text = "Смены";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Наибольшее число пар в смену:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Третья смена начинается на паре:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Вторая смена начинается на паре:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Первая смена начинается на паре:";
			// 
			// Third
			// 
			this.Third.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Third.Location = new System.Drawing.Point(256, 97);
			this.Third.Name = "Third";
			this.Third.Size = new System.Drawing.Size(65, 20);
			this.Third.TabIndex = 8;
			// 
			// Second
			// 
			this.Second.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Second.Location = new System.Drawing.Point(256, 71);
			this.Second.Name = "Second";
			this.Second.Size = new System.Drawing.Size(65, 20);
			this.Second.TabIndex = 7;
			// 
			// First
			// 
			this.First.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.First.Location = new System.Drawing.Point(256, 45);
			this.First.Name = "First";
			this.First.Size = new System.Drawing.Size(65, 20);
			this.First.TabIndex = 6;
			// 
			// Most
			// 
			this.Most.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Most.Location = new System.Drawing.Point(256, 19);
			this.Most.Name = "Most";
			this.Most.Size = new System.Drawing.Size(65, 20);
			this.Most.TabIndex = 5;
			// 
			// Date
			// 
			this.Date.Location = new System.Drawing.Point(4, 22);
			this.Date.Name = "Date";
			this.Date.Padding = new System.Windows.Forms.Padding(3);
			this.Date.Size = new System.Drawing.Size(371, 489);
			this.Date.TabIndex = 1;
			this.Date.Text = "Даты";
			this.Date.UseVisualStyleBackColor = true;
			// 
			// Bells
			// 
			this.Bells.Location = new System.Drawing.Point(4, 22);
			this.Bells.Name = "Bells";
			this.Bells.Padding = new System.Windows.Forms.Padding(3);
			this.Bells.Size = new System.Drawing.Size(371, 489);
			this.Bells.TabIndex = 2;
			this.Bells.Text = "Звонки";
			this.Bells.UseVisualStyleBackColor = true;
			// 
			// Cycles
			// 
			this.Cycles.Location = new System.Drawing.Point(4, 22);
			this.Cycles.Name = "Cycles";
			this.Cycles.Padding = new System.Windows.Forms.Padding(3);
			this.Cycles.Size = new System.Drawing.Size(371, 489);
			this.Cycles.TabIndex = 3;
			this.Cycles.Text = "Циклы";
			this.Cycles.UseVisualStyleBackColor = true;
			// 
			// Etc
			// 
			this.Etc.Location = new System.Drawing.Point(4, 22);
			this.Etc.Name = "Etc";
			this.Etc.Padding = new System.Windows.Forms.Padding(3);
			this.Etc.Size = new System.Drawing.Size(371, 489);
			this.Etc.TabIndex = 4;
			this.Etc.Text = "Прочее";
			this.Etc.UseVisualStyleBackColor = true;
			// 
			// SecondPair
			// 
			this.SecondPair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SecondPair.AutoSize = true;
			this.SecondPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SecondPair.Location = new System.Drawing.Point(13, 72);
			this.SecondPair.Name = "SecondPair";
			this.SecondPair.Size = new System.Drawing.Size(232, 17);
			this.SecondPair.TabIndex = 7;
			this.SecondPair.Text = "Группа может приходить ко второй паре";
			this.SecondPair.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.Location = new System.Drawing.Point(13, 95);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(317, 17);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Перемены достаточно для перехода из корпуса в корпус";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(13, 125);
			this.label6.MaximumSize = new System.Drawing.Size(325, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(309, 28);
			this.label6.TabIndex = 9;
			this.label6.Text = "Настройки, приведённые ниже, могут быть изменены при задании характеристик групп " +
    "и преподавателей:";
			// 
			// Characteristic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 453);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Help);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Ok);
			this.Name = "Characteristic";
			this.Text = "Установки";
			this.Numeration.ResumeLayout(false);
			this.Numeration.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.Day.ResumeLayout(false);
			this.Day.PerformLayout();
			this.Changes.ResumeLayout(false);
			this.Changes.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Ok;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Help;
		private System.Windows.Forms.GroupBox Numeration;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Day;
		private System.Windows.Forms.TabPage Date;
		private System.Windows.Forms.TabPage Bells;
		private System.Windows.Forms.TabPage Cycles;
		private System.Windows.Forms.TabPage Etc;
		private System.Windows.Forms.GroupBox Changes;
		private System.Windows.Forms.DomainUpDown Third;
		private System.Windows.Forms.DomainUpDown Second;
		private System.Windows.Forms.DomainUpDown First;
		private System.Windows.Forms.DomainUpDown Most;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox SecondPair;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label6;
	}
}