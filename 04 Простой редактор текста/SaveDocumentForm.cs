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
	public partial class SaveDocumentForm : Form
	{
		public SaveDocumentForm()
		{
			InitializeComponent();
		}

		private void buttonYes_Click(object sender, EventArgs e)
		{			
			DialogResult = DialogResult.Yes;
		}

		private void buttonNo_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
