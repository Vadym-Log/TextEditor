using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _04_Простой_редактор_текста
{
	static class Program
    {
        public static SimpleNotepadForm simpleNotepadForm;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            simpleNotepadForm = new SimpleNotepadForm();
            Application.Run(simpleNotepadForm);
		}
	}
}
