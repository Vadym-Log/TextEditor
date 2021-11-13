namespace _04_Простой_редактор_текста
{
	partial class SimpleNotepadForm
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
			if (m_DocumentChanged && dialogResult != System.Windows.Forms.DialogResult.No)
				MenuFileSaveAs();
			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleNotepadForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFormatStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatStyleBold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatStyleItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatStyleUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatStyleStrikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAlignment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAlignmentLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAlignmentCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatAlignmentRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.previewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFormat,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFilePageSetup,
            this.menuFilePrintPreview,
            this.menuFilePrint,
            this.toolStripSeparator4,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 20);
            this.menuFile.Text = "&File";
            this.menuFile.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFile.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(148, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFileNew.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(148, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFileOpen.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(148, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFileSave.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(148, 22);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFileSaveAs.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuFilePageSetup
            // 
            this.menuFilePageSetup.Name = "menuFilePageSetup";
            this.menuFilePageSetup.Size = new System.Drawing.Size(148, 22);
            this.menuFilePageSetup.Text = "Page Setup";
            this.menuFilePageSetup.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFilePageSetup.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFilePageSetup.Click += new System.EventHandler(this.menuFilePageSetup_Click);
            // 
            // menuFilePrintPreview
            // 
            this.menuFilePrintPreview.Name = "menuFilePrintPreview";
            this.menuFilePrintPreview.Size = new System.Drawing.Size(148, 22);
            this.menuFilePrintPreview.Text = "Print Preview";
            this.menuFilePrintPreview.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFilePrintPreview.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFilePrintPreview.Click += new System.EventHandler(this.menuFilePrintPreview_Click);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.Size = new System.Drawing.Size(148, 22);
            this.menuFilePrint.Text = "&Print";
            this.menuFilePrint.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFilePrint.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(148, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFileExit.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.toolStripSeparator7,
            this.toolEditFind,
            this.toolStripSeparator2,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditDelete,
            this.toolStripSeparator3,
            this.menuEditSelectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(37, 20);
            this.menuEdit.Text = "Ed&it";
            this.menuEdit.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEdit.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Size = new System.Drawing.Size(128, 22);
            this.menuEditUndo.Text = "&Undo";
            this.menuEditUndo.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditUndo.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(128, 22);
            this.menuEditRedo.Text = "&Redo";
            this.menuEditRedo.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditRedo.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditRedo.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(125, 6);
            // 
            // toolEditFind
            // 
            this.toolEditFind.Name = "toolEditFind";
            this.toolEditFind.Size = new System.Drawing.Size(128, 22);
            this.toolEditFind.Text = "Find";
            this.toolEditFind.Click += new System.EventHandler(this.toolEditFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(128, 22);
            this.menuEditCut.Text = "&Cut";
            this.menuEditCut.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditCut.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(128, 22);
            this.menuEditCopy.Text = "Cop&y";
            this.menuEditCopy.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditCopy.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(128, 22);
            this.menuEditPaste.Text = "Past&e";
            this.menuEditPaste.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditPaste.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Name = "menuEditDelete";
            this.menuEditDelete.Size = new System.Drawing.Size(128, 22);
            this.menuEditDelete.Text = "&Delete";
            this.menuEditDelete.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditDelete.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditDelete.Click += new System.EventHandler(this.menuEditDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(125, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(128, 22);
            this.menuEditSelectAll.Text = "Select Al&l";
            this.menuEditSelectAll.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuEditSelectAll.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatFont,
            this.menuFormatColor,
            this.toolStripSeparator5,
            this.menuFormatStyle,
            this.menuFormatAlignment});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(53, 20);
            this.menuFormat.Text = "Forma&t";
            this.menuFormat.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormat.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuFormatFont
            // 
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.Size = new System.Drawing.Size(132, 22);
            this.menuFormatFont.Text = "Font";
            this.menuFormatFont.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatFont.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatFont.Click += new System.EventHandler(this.menuFormatFont_Click);
            // 
            // menuFormatColor
            // 
            this.menuFormatColor.Name = "menuFormatColor";
            this.menuFormatColor.Size = new System.Drawing.Size(132, 22);
            this.menuFormatColor.Text = "Color";
            this.menuFormatColor.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatColor.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatColor.Click += new System.EventHandler(this.menuFormatColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(129, 6);
            // 
            // menuFormatStyle
            // 
            this.menuFormatStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatStyleBold,
            this.menuFormatStyleItalic,
            this.menuFormatStyleUnderline,
            this.menuFormatStyleStrikeout});
            this.menuFormatStyle.Name = "menuFormatStyle";
            this.menuFormatStyle.Size = new System.Drawing.Size(132, 22);
            this.menuFormatStyle.Text = "Style";
            this.menuFormatStyle.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatStyle.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuFormatStyleBold
            // 
            this.menuFormatStyleBold.Name = "menuFormatStyleBold";
            this.menuFormatStyleBold.Size = new System.Drawing.Size(130, 22);
            this.menuFormatStyleBold.Text = "Bold";
            this.menuFormatStyleBold.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatStyleBold.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatStyleBold.Click += new System.EventHandler(this.menuFormatStyleBold_Click);
            // 
            // menuFormatStyleItalic
            // 
            this.menuFormatStyleItalic.Name = "menuFormatStyleItalic";
            this.menuFormatStyleItalic.Size = new System.Drawing.Size(130, 22);
            this.menuFormatStyleItalic.Text = "Italic";
            this.menuFormatStyleItalic.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatStyleItalic.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatStyleItalic.Click += new System.EventHandler(this.menuFormatStyleItalic_Click);
            // 
            // menuFormatStyleUnderline
            // 
            this.menuFormatStyleUnderline.Name = "menuFormatStyleUnderline";
            this.menuFormatStyleUnderline.Size = new System.Drawing.Size(130, 22);
            this.menuFormatStyleUnderline.Text = "Underline";
            this.menuFormatStyleUnderline.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatStyleUnderline.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatStyleUnderline.Click += new System.EventHandler(this.menuFormatStyleUnderline_Click);
            // 
            // menuFormatStyleStrikeout
            // 
            this.menuFormatStyleStrikeout.Name = "menuFormatStyleStrikeout";
            this.menuFormatStyleStrikeout.Size = new System.Drawing.Size(130, 22);
            this.menuFormatStyleStrikeout.Text = "Strikeout";
            this.menuFormatStyleStrikeout.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatStyleStrikeout.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatStyleStrikeout.Click += new System.EventHandler(this.menuFormatStyleStrikeout_Click);
            // 
            // menuFormatAlignment
            // 
            this.menuFormatAlignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatAlignmentLeft,
            this.menuFormatAlignmentCenter,
            this.menuFormatAlignmentRight});
            this.menuFormatAlignment.Name = "menuFormatAlignment";
            this.menuFormatAlignment.Size = new System.Drawing.Size(132, 22);
            this.menuFormatAlignment.Text = "Alignment";
            this.menuFormatAlignment.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatAlignment.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuFormatAlignmentLeft
            // 
            this.menuFormatAlignmentLeft.Name = "menuFormatAlignmentLeft";
            this.menuFormatAlignmentLeft.Size = new System.Drawing.Size(118, 22);
            this.menuFormatAlignmentLeft.Text = "Left";
            this.menuFormatAlignmentLeft.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatAlignmentLeft.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatAlignmentLeft.Click += new System.EventHandler(this.menuFormatAlignmentLeft_Click);
            // 
            // menuFormatAlignmentCenter
            // 
            this.menuFormatAlignmentCenter.Name = "menuFormatAlignmentCenter";
            this.menuFormatAlignmentCenter.Size = new System.Drawing.Size(118, 22);
            this.menuFormatAlignmentCenter.Text = "Center";
            this.menuFormatAlignmentCenter.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatAlignmentCenter.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatAlignmentCenter.Click += new System.EventHandler(this.menuFormatAlignmentCenter_Click);
            // 
            // menuFormatAlignmentRight
            // 
            this.menuFormatAlignmentRight.Name = "menuFormatAlignmentRight";
            this.menuFormatAlignmentRight.Size = new System.Drawing.Size(118, 22);
            this.menuFormatAlignmentRight.Text = "Right";
            this.menuFormatAlignmentRight.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuFormatAlignmentRight.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuFormatAlignmentRight.Click += new System.EventHandler(this.menuFormatAlignmentRight_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout,
            this.registerToolStripMenuItem});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(40, 20);
            this.menuHelp.Text = "&Help";
            this.menuHelp.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuHelp.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(125, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.menuHelpAbout.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuMouseLeave);
            this.registerToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuMouseEnter);
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(504, 251);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "c:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "\"Text file (*.txt)|*.txt|RTF file (*.rtf)|*.rtf\"";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "SimpleNotepad Document";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator10,
            this.previewToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator8,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator9,
            this.findToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 36);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(32, 33);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newToolStripButton.ToolTipText = "Создание документа";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(37, 33);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openToolStripButton.ToolTipText = "Открытие документа";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(35, 33);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolStripButton.ToolTipText = "Сохранение документа";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // previewToolStripButton
            // 
            this.previewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("previewToolStripButton.Image")));
            this.previewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewToolStripButton.Name = "previewToolStripButton";
            this.previewToolStripButton.Size = new System.Drawing.Size(49, 33);
            this.previewToolStripButton.Text = "Preview";
            this.previewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.previewToolStripButton.ToolTipText = "Предварительный просмотр";
            this.previewToolStripButton.Click += new System.EventHandler(this.previewToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(33, 33);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printToolStripButton.ToolTipText = "Печать документа";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripButton.Image")));
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(36, 33);
            this.undoToolStripButton.Text = "Undo";
            this.undoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.undoToolStripButton.ToolTipText = "Отменить";
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripButton.Image")));
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(36, 33);
            this.redoToolStripButton.Text = "Redo";
            this.redoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.redoToolStripButton.ToolTipText = "Вернуть";
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripButton.Image")));
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(31, 33);
            this.findToolStripButton.Text = "Find";
            this.findToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.findToolStripButton.Click += new System.EventHandler(this.findToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(28, 33);
            this.cutToolStripButton.Text = "&Cut";
            this.cutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cutToolStripButton.ToolTipText = "Вырезать текст";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(36, 33);
            this.copyToolStripButton.Text = "Cop&y";
            this.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.copyToolStripButton.ToolTipText = "Копировать текст";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(38, 33);
            this.pasteToolStripButton.Text = "Past&e";
            this.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteToolStripButton.ToolTipText = "Вставить текст";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(32, 33);
            this.helpToolStripButton.Text = "Help";
            this.helpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpToolStripButton.ToolTipText = "Показать справку";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(220, 17);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SimpleNotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimpleNotepadForm";
            this.Text = "Простой редактор текста";
            this.Load += new System.EventHandler(this.SimpleNotepadForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileNew;
		private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
		private System.Windows.Forms.ToolStripMenuItem menuFileSave;
		private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuFilePageSetup;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuEditCut;
		private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
		private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
		private System.Windows.Forms.ToolStripMenuItem menuEditDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
		private System.Windows.Forms.ToolStripMenuItem menuFormat;
		private System.Windows.Forms.ToolStripMenuItem menuFormatFont;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrintPreview;
		private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
		private System.Windows.Forms.ToolStripMenuItem menuFormatColor;
		private System.Windows.Forms.ToolStripMenuItem menuFormatStyle;
		private System.Windows.Forms.ToolStripMenuItem menuFormatAlignment;
		private System.Windows.Forms.ToolStripMenuItem menuFormatStyleBold;
		private System.Windows.Forms.ToolStripMenuItem menuFormatStyleItalic;
		private System.Windows.Forms.ToolStripMenuItem menuFormatStyleUnderline;
		private System.Windows.Forms.ToolStripMenuItem menuFormatStyleStrikeout;
		private System.Windows.Forms.ToolStripMenuItem menuFormatAlignmentLeft;
		private System.Windows.Forms.ToolStripMenuItem menuFormatAlignmentCenter;
		private System.Windows.Forms.ToolStripMenuItem menuFormatAlignmentRight;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripButton previewToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolEditFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        public System.Windows.Forms.RichTextBox richTextBox1;
	}
}

