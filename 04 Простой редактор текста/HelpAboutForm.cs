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
	public partial class HelpAboutForm : Form
	{
		public HelpAboutForm()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
			System.Diagnostics.Process.Start(linkLabel1.Text);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel2.Links[linkLabel2.Links.IndexOf(e.Link)].Visited = true;
			System.Diagnostics.Process.Start("mailto:" + linkLabel2.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
