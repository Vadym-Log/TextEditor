using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace _04_Простой_редактор_текста
{
	public partial class SimpleNotepadForm : Form
	{
		public SimpleNotepadForm()
		{
			InitializeComponent();            
			toolStripStatusLabel3.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
			toolStripStatusLabel3.ToolTipText = Convert.ToString(DateTime.Today.ToLongDateString());
		}

		private void SimpleNotepadForm_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
		}

		private void menuFileNew_Click(object sender, EventArgs e)
		{
			MenuFileNew();
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			MenuFileNew();
		}

		private void MenuFileNew()
		{
			if (m_DocumentChanged)
			{
				SaveDocumentForm dialog = new SaveDocumentForm();
				DialogResult result = dialog.ShowDialog();
				switch (result)
				{
					case DialogResult.Yes:
					{
						MenuFileSaveAs();
						break;
					}
					case DialogResult.Cancel:
					{
						return;
					}
				}
				richTextBox1.Clear();
				m_DocumentChanged = false;
			}
		}

		private void menuFileOpen_Click(object sender, EventArgs e)
		{
			MenuFileOpen();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			MenuFileOpen();
		}

		/// <summary>
		/// Открытие существующего файла
		/// </summary>
		private void MenuFileOpen()
		{
			if (m_DocumentChanged)
			{
				DialogResult result = MessageBox.Show("Документ изменён.\nСохранить изменения?",
					"Сохранение документа", MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				switch (result)
				{
					case DialogResult.Yes:
						{
							MenuFileSaveAs();
							break;
						}
					case DialogResult.Cancel:
						{
							return;
						}
				}
			}
			if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
			{
				try
				{
					richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
				}
				catch (ArgumentException ex)
				{
					richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
				}
				this.Text = "Файл [" + openFileDialog1.FileName + "]";
			}
			m_DocumentChanged = false;
		}

		private void menuFileSave_Click(object sender, EventArgs e)
		{
			MenuFileSaveAs();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			MenuFileSaveAs();
		}

		private void menuFileSaveAs_Click(object sender, EventArgs e)
		{
			MenuFileSaveAs();
		}

		/// <summary>
		/// Сохранение файла
		/// </summary>
		private void MenuFileSaveAs()
		{
			if (saveFileDialog1.FilterIndex == 2)
				saveFileDialog1.FileName = saveFileDialog1.FileName + ".rtf";
			else
				saveFileDialog1.FileName = saveFileDialog1.FileName + ".txt";
			
			if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
			{
				if (saveFileDialog1.FilterIndex == 2)
					richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
				else
					richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
			}
			this.Text = "Файл [" + saveFileDialog1.FileName + "]";
			m_DocumentChanged = false;
		}

		private void menuFilePageSetup_Click(object sender, EventArgs e)
		{
			MenuFilePageSetup();
		}

		/// <summary>
		/// Настройка параметров страницы
		/// </summary>
		private void MenuFilePageSetup()
		{
			pageSetupDialog1.ShowDialog();
		}

		private void menuFilePrintPreview_Click(object sender, EventArgs e)
		{
			MenuFilePrintPreview();
		}

		private void previewToolStripButton_Click(object sender, EventArgs e)
		{
			MenuFilePrintPreview();
		}

		/// <summary>
		/// StringReader для печати содержимого редактора текста
		/// </summary>
		private StringReader m_myReader;
		/// <summary>
		/// Номер распечатываемой страницы документа
		/// </summary>
		private uint m_PrintPageNumber;

		/// <summary>
		/// Предварительный просмотр перед печатью документа
		/// </summary>
		private void MenuFilePrintPreview()
		{
			m_PrintPageNumber = 1;
			string strText = this.richTextBox1.Text;
			m_myReader = new StringReader(strText);

			Margins margins = new Margins(100, 50, 50, 50);
			printDocument1.DefaultPageSettings.Margins = margins;
			printPreviewDialog1.ShowDialog();
			m_myReader.Close();
		}

		private void menuFilePrint_Click(object sender, EventArgs e)
		{
			MenuFilePrint();
		}

		private void printToolStripButton_Click(object sender, EventArgs e)
		{
			MenuFilePrint();
		}

		/// <summary>
		/// Печать документа
		/// </summary>
		private void MenuFilePrint()
		{
			m_PrintPageNumber = 1;
			string strText = this.richTextBox1.Text;
			m_myReader = new StringReader(strText);

			Margins margins = new Margins(100, 50, 50, 50);
			printDocument1.DefaultPageSettings.Margins = margins;
			if (printDialog1.ShowDialog() == DialogResult.OK)
				this.printDocument1.Print();
			m_myReader.Close();
		}

		/// <summary>
		/// Обработка события PrintPage
		/// </summary>
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			int lineCount = 0;  // счётчик строк
			float linesPerPage = 0;  // количество строк на одной странице
			float yLinePosition = 0;  // текущая позиция при печати по вертикальной оси
			string currentLine = null;  // текст текущей строки

			Font printFont = this.richTextBox1.Font;  // шрифт для печати текста
			SolidBrush printBrush = new SolidBrush(Color.Black);  // кисть для печати текста

			float leftMargin = e.MarginBounds.Left;  // размер отступа слева
			// размер отступа сверху
			float topMargin = e.MarginBounds.Top + 3 * printFont.GetHeight(e.Graphics);

			// вычисляем количество строк на одной странице с учётом отступа
			linesPerPage = (e.MarginBounds.Height - 
				6 * printFont.GetHeight(e.Graphics)) / printFont.GetHeight(e.Graphics);

			// цикл печати всех строк страницы
			while (lineCount < linesPerPage && ((currentLine = m_myReader.ReadLine()) != null))
			{ 
				// вычисляем позицию очередной распечатываемой строки
				yLinePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));
				// печатаем очередную строку
				e.Graphics.DrawString(currentLine, printFont, printBrush,
					leftMargin, yLinePosition, new StringFormat());
				lineCount++;  // переходим к следующей строке
			}
			// Печать колонтитулов страницы
			// номер текущей страницы
			string sPageNumber = "Page " + m_PrintPageNumber.ToString();
			// вычисляем размеры прямоугольной области, занимаемой верхним колонтитулом страницы
			SizeF stringSize = new SizeF();
			stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
				e.MarginBounds.Right - e.MarginBounds.Left);
			// печатаем номер страницы
			e.Graphics.DrawString(sPageNumber, printFont, printBrush,
				e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top, new StringFormat());
			// печатаем имя файла документа
			e.Graphics.DrawString(this.Text, printFont, printBrush,
				e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());

			// Кмсть для рисования горизонтальноц линии, отделяющей верхний колонтитул
			Pen colontitulPen = new Pen(Color.Black);
			colontitulPen.Width = 2;
			// рисуем верхнюю линию
			e.Graphics.DrawLine(colontitulPen, leftMargin,
				e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3, e.MarginBounds.Right,
				e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3);
			// рисуем линию, отделяющую нижний колонтитул документа
			e.Graphics.DrawLine(colontitulPen, leftMargin, e.MarginBounds.Bottom - 3,
				e.MarginBounds.Right, e.MarginBounds.Bottom - 3);
			// печатаем текст нижнего колонтитула
			e.Graphics.DrawString("SimpleNotepad, (c) Вадим Логвиненко",
				printFont, printBrush, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());

			// если напечатаны не все строки документа, переходим к следующей странице
			if (currentLine != null)
			{
				e.HasMorePages = true;
				m_PrintPageNumber++;
			}
			else  // иначе завершаем печать страницы
				e.HasMorePages = false;

			// освобождаем ненужные более ресурсы
			printBrush.Dispose();
			colontitulPen.Dispose();
		}
		/// <summary>
		/// Флаг для определения наличия каких-либо изменений в документе
		/// </summary>
		private bool m_DocumentChanged = false;
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            m_DocumentChanged = true;
            string s = "Строка № " + Convert.ToString(richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1);
            toolStripStatusLabel2.Text = s + " | Символов = " + richTextBox1.Text.Length.ToString();
        }        

		DialogResult dialogResult;
		private void menuFileExit_Click(object sender, EventArgs e)
		{
			if (m_DocumentChanged)
			{
				dialogResult = MessageBox.Show("Документ изменён.\nСохранить изменения?",
					"Сохранение документа", MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				switch (dialogResult)
				{
					case DialogResult.Yes:
						{
							MenuFileSaveAs();
							break;
						}
					case DialogResult.Cancel:
						{
							return;
						}
				}
			}
			this.Close();
		}

		private void menuEditUndo_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

		private void menuEditRedo_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            menuItemFind();
        }

        private void toolEditFind_Click(object sender, EventArgs e)
        {
            menuItemFind();
        }

        void menuItemFind()
        {
            FindDialog findDialog = new FindDialog();
            findDialog.Owner = this;
            findDialog.Show();
        }

		private void menuEditCut_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void cutToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void menuEditCopy_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void menuEditPaste_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void menuEditDelete_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void menuEditSelectAll_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void menuFormatFont_Click(object sender, EventArgs e)
		{
			if (fontDialog1.ShowDialog() == DialogResult.OK)
				richTextBox1.SelectionFont = fontDialog1.Font;
		}

		private void menuFormatColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
				richTextBox1.SelectionColor = colorDialog1.Color;
		}

		/// <summary>
		/// Установка отметки строк меню Font-->Style
		/// </summary>
		private void CheckMenuFontCharacterStyle()
		{
            try
            {
                if (richTextBox1.SelectionFont.Bold == true)
                    menuFormatStyleBold.Checked = true;
                else
                    menuFormatStyleBold.Checked = false;
                if (richTextBox1.SelectionFont.Italic == true)
                    menuFormatStyleItalic.Checked = true;
                else
                    menuFormatStyleItalic.Checked = false;
                if (richTextBox1.SelectionFont.Underline == true)
                    menuFormatStyleUnderline.Checked = true;
                else
                    menuFormatStyleUnderline.Checked = false;
                if (richTextBox1.SelectionFont.Strikeout == true)
                    menuFormatStyleStrikeout.Checked = true;
                else
                    menuFormatStyleStrikeout.Checked = false;
            }
            catch { }
		}
		private void richTextBox1_SelectionChanged(object sender, EventArgs e)
		{
			CheckMenuFontCharacterStyle();
		}
	
		private void menuFormatStyleBold_Click(object sender, EventArgs e)
		{
			SetBold();
		}

		/// <summary>
		/// Установка стиля символов Bold
		/// </summary>
		private void SetBold()
		{
			if (richTextBox1.SelectionFont != null)
			{
				Font currentFont = richTextBox1.SelectionFont;
				FontStyle newFontStyle;
				if (richTextBox1.SelectionFont.Bold == true)
					newFontStyle = FontStyle.Regular;
				else
					newFontStyle = FontStyle.Bold;
				richTextBox1.SelectionFont = 
					new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
				CheckMenuFontCharacterStyle();
			}
		}

		private void menuFormatStyleItalic_Click(object sender, EventArgs e)
		{
			SetItalic();
		}

		/// <summary>
		/// Установка стиля символов Italic
		/// </summary>
		private void SetItalic()
		{
			if (richTextBox1.SelectionFont != null)
			{
				Font currentFont = richTextBox1.SelectionFont;
				FontStyle newFontStyle;
				if (richTextBox1.SelectionFont.Italic == true)
					newFontStyle = FontStyle.Regular;
				else
					newFontStyle = FontStyle.Italic;
				richTextBox1.SelectionFont =
					new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
				CheckMenuFontCharacterStyle();
			}
		}

		private void menuFormatStyleUnderline_Click(object sender, EventArgs e)
		{
			SetUnderline();
		}

		/// <summary>
		/// Установка стиля символов Underline
		/// </summary>
		private void SetUnderline()
		{
			if (richTextBox1.SelectionFont != null)
			{
				Font currentFont = richTextBox1.SelectionFont;
				FontStyle newFontStyle;
				if (richTextBox1.SelectionFont.Underline == true)
					newFontStyle = FontStyle.Regular;
				else
					newFontStyle = FontStyle.Underline;
				richTextBox1.SelectionFont =
					new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
				CheckMenuFontCharacterStyle();
			}
		}

		private void menuFormatStyleStrikeout_Click(object sender, EventArgs e)
		{
			SetStrikeout();
		}

		/// <summary>
		/// Установка стиля символов Strikeout
		/// </summary>
		private void SetStrikeout()
		{
			if (richTextBox1.SelectionFont != null)
			{
				Font currentFont = richTextBox1.SelectionFont;
				FontStyle newFontStyle;
				if (richTextBox1.SelectionFont.Strikeout == true)
					newFontStyle = FontStyle.Regular;
				else
					newFontStyle = FontStyle.Strikeout;
				richTextBox1.SelectionFont =
					new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
				CheckMenuFontCharacterStyle();
			}
		}

		private void menuFormatAlignmentLeft_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void menuFormatAlignmentCenter_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void menuFormatAlignmentRight_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void menuHelpAbout_Click(object sender, EventArgs e)
		{
			Form dlgAbout = new HelpAboutForm();
			dlgAbout.ShowDialog();
		}

		private void helpToolStripButton_Click(object sender, EventArgs e)
		{
			Form dlgAbout = new HelpAboutForm();
			dlgAbout.ShowDialog();
		}

		private void registerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RegisterForm dialog = new RegisterForm();
			if (DialogResult.Yes == dialog.ShowDialog())
			{
                bool name = dialog.textBoxEmail.Text.Contains('@');
                int indexName= dialog.textBoxEmail.Text.IndexOf('@');
                bool point = dialog.textBoxEmail.Text.Contains('.');
                int indexPoint = dialog.textBoxEmail.Text.IndexOf('.');

                if (dialog.textBoxName.Text == "" || 
                    name == false || point == false || 
                    indexName > indexPoint || 
                    indexName == 0 || indexPoint == 0 ||
                    dialog.textBoxEmail.Text.EndsWith(".") == true ||
                    indexPoint - indexName == 1)
                {
                    MessageBox.Show("Неверно заполнены поля \"Ф.И.О.\" и \"E-mail\"", "Ошибка заполнения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

				string body = "Данные регистрации: ";
				body += " Name: " + dialog.UserName;
				body += ", Email: " + dialog.UserEmail;
				body += ", Level: " + dialog.UserLevel;
				body += ", Gender: " + dialog.UserGender;
				body += ", FavoriteOS: " + dialog.FavoritesOS;
				body += ", SendNews: " + dialog.SendNews;
				body += ", SendLetter: " + dialog.SendLetter;
				body += ", BirthDay: " + dialog.UserBirthDay;
				body += ", Comment: " + dialog.UserComment;

                System.Diagnostics.Process.Start("mailto:v-m@ukr.net?subject=Регистрация \"Simple Notepad\"&body=" + body);
			}
		}

		private void MenuMouseEnter(object sender, EventArgs e)
		{
			ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
			switch (menuItem.Text)
			{ 
				case "&File":
					toolStripStatusLabel1.Text = "Работа с документом";
					break;
				case "&New":
					toolStripStatusLabel1.Text = "Создание нового документа";
					break;
				case "&Open":
					toolStripStatusLabel1.Text = "Открытие документа";
					break;
				case "&Save":
					toolStripStatusLabel1.Text = "Сохранение текущего документа";
					break;
				case "Save &As":
					toolStripStatusLabel1.Text = "Сохранение нового документа";
					break;
				case "Page Setup":
					toolStripStatusLabel1.Text = "Настройка параметров страницы";
					break;
				case "Print Preview":
					toolStripStatusLabel1.Text = "Предварительный просмотр";
					break;
				case "&Print":
					toolStripStatusLabel1.Text = "Печать документа";
					break;
                case "E&xit":
					toolStripStatusLabel1.Text = "Конец работы";
					break;

                case "Ed&it":
                    toolStripStatusLabel1.Text = "Редактирование документа";
                    break;
                case "&Undo":
                    toolStripStatusLabel1.Text = "Отменить изменения";
                    break;
                case "&Redo":
                    toolStripStatusLabel1.Text = "Вернуть изменения";
                    break;
                case "&Cut":
                    toolStripStatusLabel1.Text = "Вырезать выделенное в буфер";
                    break;
                case "Cop&y":
                    toolStripStatusLabel1.Text = "Скопировать в буфер обмена";
                    break;
                case "Past&e":
                    toolStripStatusLabel1.Text = "Вставить из буфера обмена";
                    break;
                case "&Delete":
                    toolStripStatusLabel1.Text = "Удалить выделенное";
                    break;
                case "Select Al&l":
                    toolStripStatusLabel1.Text = "Выделить всё";
                    break;

                case "Forma&t":
                    toolStripStatusLabel1.Text = "Форматирование текста";
                    break;
                case "Font":
                    toolStripStatusLabel1.Text = "Изменить шрифт";
                    break;
                case "Color":
                    toolStripStatusLabel1.Text = "Изменить цвет";
                    break;
                case "Style":
                    toolStripStatusLabel1.Text = "Изменить стиль";
                    break;
                case "Bold":
                    toolStripStatusLabel1.Text = "Сделать жирным";
                    break;
                case "Italic":
                    toolStripStatusLabel1.Text = "Сделать наклонным";
                    break;
                case "Underline":
                    toolStripStatusLabel1.Text = "Сделать подчёркнутым";
                    break;
                case "Strikeout":
                    toolStripStatusLabel1.Text = "Сделать перечёркнутым";
                    break;
                case "Alignment":
                    toolStripStatusLabel1.Text = "Изменить расположение";
                    break;
                case "Left":
                    toolStripStatusLabel1.Text = "Выровнить слева";
                    break;
                case "Center":
                    toolStripStatusLabel1.Text = "Выровнить по центру";
                    break;
                case "Right":
                    toolStripStatusLabel1.Text = "Выровнить справа";
                    break;

                case "&Help":
                    toolStripStatusLabel1.Text = "Помощь";
                    break;
                case "About":
                    toolStripStatusLabel1.Text = "Справка о программе";
                    break;
                case "Register":
                    toolStripStatusLabel1.Text = "Регистрация программы";
                    break;
				default:
					toolStripStatusLabel1.Text = "";
					break;
			}
		}

		private void MenuMouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}
	}
}
