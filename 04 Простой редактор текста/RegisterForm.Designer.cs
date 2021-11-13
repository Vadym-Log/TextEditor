namespace _04_Простой_редактор_текста
{
	partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxFavoriteOS = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxOS = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBoxSendNews = new System.Windows.Forms.CheckBox();
            this.checkBoxSendLetter = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGender.SuspendLayout();
            this.groupBoxOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зарегистрируйте свою копию программы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Квалификация";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(115, 85);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Начальная",
            "Средняя",
            "Высокая",
            "Специалист",
            "Эксперт"});
            this.comboBoxLevel.Location = new System.Drawing.Point(115, 117);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLevel.TabIndex = 6;
            this.comboBoxLevel.Text = "Начальная";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "День Вашего рождения";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(32, 179);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Оставьте Ваш комментарий";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(32, 371);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(460, 76);
            this.textBoxComment.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(104, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Зарегистрировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(337, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxFavoriteOS
            // 
            this.textBoxFavoriteOS.Enabled = false;
            this.textBoxFavoriteOS.Location = new System.Drawing.Point(24, 114);
            this.textBoxFavoriteOS.Name = "textBoxFavoriteOS";
            this.textBoxFavoriteOS.Size = new System.Drawing.Size(163, 20);
            this.textBoxFavoriteOS.TabIndex = 13;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButton2);
            this.groupBoxGender.Controls.Add(this.radioButton1);
            this.groupBoxGender.Location = new System.Drawing.Point(279, 51);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(187, 50);
            this.groupBoxGender.TabIndex = 14;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(119, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Жен.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Муж.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxOS
            // 
            this.groupBoxOS.Controls.Add(this.radioButton5);
            this.groupBoxOS.Controls.Add(this.radioButton4);
            this.groupBoxOS.Controls.Add(this.textBoxFavoriteOS);
            this.groupBoxOS.Controls.Add(this.radioButton3);
            this.groupBoxOS.Location = new System.Drawing.Point(279, 130);
            this.groupBoxOS.Name = "groupBoxOS";
            this.groupBoxOS.Size = new System.Drawing.Size(200, 152);
            this.groupBoxOS.TabIndex = 15;
            this.groupBoxOS.TabStop = false;
            this.groupBoxOS.Text = "Любимая ОС";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(24, 82);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(113, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Другая (укажите)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Linux";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "MS Windows";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendNews
            // 
            this.checkBoxSendNews.AutoSize = true;
            this.checkBoxSendNews.Checked = true;
            this.checkBoxSendNews.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendNews.Location = new System.Drawing.Point(279, 297);
            this.checkBoxSendNews.Name = "checkBoxSendNews";
            this.checkBoxSendNews.Size = new System.Drawing.Size(135, 17);
            this.checkBoxSendNews.TabIndex = 16;
            this.checkBoxSendNews.Text = "Подписка на новости";
            this.checkBoxSendNews.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendLetter
            // 
            this.checkBoxSendLetter.AutoSize = true;
            this.checkBoxSendLetter.Checked = true;
            this.checkBoxSendLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendLetter.Location = new System.Drawing.Point(279, 332);
            this.checkBoxSendLetter.Name = "checkBoxSendLetter";
            this.checkBoxSendLetter.Size = new System.Drawing.Size(196, 17);
            this.checkBoxSendLetter.TabIndex = 17;
            this.checkBoxSendLetter.Text = "Подписка на электронную газету";
            this.checkBoxSendLetter.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(523, 501);
            this.Controls.Add(this.checkBoxSendLetter);
            this.Controls.Add(this.checkBoxSendNews);
            this.Controls.Add(this.groupBoxOS);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(531, 532);
            this.Name = "RegisterForm";
            this.Text = "Регистрация программы";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxOS.ResumeLayout(false);
            this.groupBoxOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxLevel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxComment;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxFavoriteOS;
		private System.Windows.Forms.GroupBox groupBoxGender;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBoxOS;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.CheckBox checkBoxSendNews;
		private System.Windows.Forms.CheckBox checkBoxSendLetter;
		private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxEmail;
	}
}