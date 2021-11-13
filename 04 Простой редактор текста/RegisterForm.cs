using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04_Простой_редактор_текста
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if (rb.Checked)
				textBoxFavoriteOS.Enabled = true;
			else
				textBoxFavoriteOS.Enabled = false;
		}

		public string UserName
		{
			get
			{
				return textBoxName.Text;
			}
		}
		public string UserEmail
		{
			get
			{
				return textBoxEmail.Text;
			}
		}
		public string UserLevel
		{
			get
			{
				return comboBoxLevel.Text;
			}
		}
		public string UserComment
		{
			get
			{
				return textBoxComment.Text;
			}
		}
		public string UserGender
		{
			get
			{
				for (int i = 0; i < groupBoxGender.Controls.Count; i++)
				{
					RadioButton rb = (RadioButton)groupBoxGender.Controls[i];
					if (rb.Checked)
						return rb.Text;
				}
				return "";
			}
		}
		public string FavoritesOS
		{
			get
			{
				for (int i = 0; i < groupBoxOS.Controls.Count; i++)
				{
					if (groupBoxOS.Controls[i] is RadioButton)
					{
						RadioButton rb = (RadioButton)groupBoxOS.Controls[i];
						if (rb.Checked)
						{
							if (rb.Name != radioButton5.Name)
								return rb.Text;
							else
								return textBoxFavoriteOS.Text;
						}
					}
				}
				return "";
			}
		}
		public string SendNews
		{
			get
			{
				if (checkBoxSendNews.Checked)
					return "Yes";
				else
					return "No";
			}
		}
		public string SendLetter
		{
			get
			{
				if (checkBoxSendLetter.Checked)
					return "Yes";
				else
					return "No";
			}
		}
		public string UserBirthDay
		{
			get
			{
				DateTime dt = monthCalendar1.SelectionStart;
				return dt.Day + "." + dt.Month + "." + dt.Year;
			}
		}

		private void textBoxName_Validating(object sender, CancelEventArgs e)
		{
            if (textBoxName.Text.Length == 0)
			{
				errorProvider1.SetError(textBoxName, "Не указано имя");
			}
			else
				errorProvider1.SetError(textBoxName, "");
		}

		private void textBoxEmail_Validating(object sender, CancelEventArgs e)
		{
            string email = textBoxEmail.Text;
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1 ||
                email.IndexOf('@') > email.IndexOf('.') ||
                email.IndexOf('@') == 0 || email.IndexOf('.') == 0 ||
                email.EndsWith(".") == true ||
                email.IndexOf('.') - email.IndexOf('@') == 1)
                errorProvider1.SetError(textBoxEmail, "Неправильный E-mail адрес");
            else
                errorProvider1.SetError(textBoxEmail, "");
        }
	}
}
