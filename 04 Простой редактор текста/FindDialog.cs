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
    public partial class FindDialog : Form
    {
        SimpleNotepadForm notepadForm;
        public FindDialog()
        {
            InitializeComponent();            
        }
        private void FindDialog_Load(object sender, EventArgs e)
        {
            notepadForm = (SimpleNotepadForm)(this.Owner);
        }

        public string FindStr
        {
            get
            {
                return textBoxFind.Text;
            }
        }

        public string Replace
        {
            get
            {
                return textBoxReplace.Text;
            }
        }

        public bool WordOnly
        {
            get
            {
                return checkBoxWordOnly.Checked;
            }
        }

        public bool Registr
        {
            get
            {
                return checkBoxRegistr.Checked;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        { 
            int startIndex;
            if (notepadForm.richTextBox1.SelectionLength != 0)
                startIndex = notepadForm.richTextBox1.SelectionStart +
                    notepadForm.richTextBox1.SelectionLength;
            else if (notepadForm.richTextBox1.SelectionStart == notepadForm.richTextBox1.Text.Length)
                startIndex = 0;
            else
                startIndex = notepadForm.richTextBox1.SelectionStart;
            RichTextBoxFinds buffFind = 0;            
            try
            {                
                if (textBoxFind.Text != "")
                {                    
                    if (WordOnly)
                        buffFind = RichTextBoxFinds.WholeWord | RichTextBoxFinds.None;
                    if (Registr)
                        buffFind = RichTextBoxFinds.MatchCase | RichTextBoxFinds.None;
                    if (WordOnly && Registr)
                        buffFind = RichTextBoxFinds.WholeWord | RichTextBoxFinds.MatchCase | RichTextBoxFinds.None;

                    notepadForm.richTextBox1.SelectionStart =
                            notepadForm.richTextBox1.Find(FindStr, startIndex,
                                    (notepadForm.richTextBox1.Text.Length), buffFind);
                    notepadForm.richTextBox1.SelectionLength = FindStr.Length;
                    notepadForm.Activate();                    
                }
            }
            catch { }
            if (textBoxFind.Text != "")
            {
                if (notepadForm.richTextBox1.SelectedText != "" &&
    startIndex == notepadForm.richTextBox1.SelectionStart + notepadForm.richTextBox1.SelectionLength
                            || notepadForm.richTextBox1.SelectedText == "" && startIndex != 0)
                    MessageBox.Show("Достигнут конец документа.\nНачните поиск с начала", "Конец поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (notepadForm.richTextBox1.SelectedText == "" && startIndex == 0)
                    MessageBox.Show("Вхождений искомой подстроки в документе не найдено", "Конец поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (textBoxReplace.Text != "" && notepadForm.richTextBox1.SelectedText != "")
            {
                notepadForm.richTextBox1.SelectedText = textBoxReplace.Text;
                notepadForm.Activate();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
