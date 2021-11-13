namespace _04_Простой_редактор_текста
{
    partial class FindDialog
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
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxWordOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistr = new System.Windows.Forms.CheckBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFind.Location = new System.Drawing.Point(15, 142);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(81, 20);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(189, 20);
            this.textBoxFind.TabIndex = 1;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(81, 66);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(189, 20);
            this.textBoxReplace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заменить";
            // 
            // checkBoxWordOnly
            // 
            this.checkBoxWordOnly.AutoSize = true;
            this.checkBoxWordOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWordOnly.Location = new System.Drawing.Point(12, 108);
            this.checkBoxWordOnly.Name = "checkBoxWordOnly";
            this.checkBoxWordOnly.Size = new System.Drawing.Size(104, 17);
            this.checkBoxWordOnly.TabIndex = 7;
            this.checkBoxWordOnly.Text = "Слово целиком";
            this.checkBoxWordOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistr
            // 
            this.checkBoxRegistr.AutoSize = true;
            this.checkBoxRegistr.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRegistr.Location = new System.Drawing.Point(148, 108);
            this.checkBoxRegistr.Name = "checkBoxRegistr";
            this.checkBoxRegistr.Size = new System.Drawing.Size(122, 17);
            this.checkBoxRegistr.TabIndex = 8;
            this.checkBoxRegistr.Text = "Различать регистр";
            this.checkBoxRegistr.UseVisualStyleBackColor = true;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(106, 142);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonCancel.Location = new System.Drawing.Point(195, 142);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FindDialog
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(292, 184);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.checkBoxRegistr);
            this.Controls.Add(this.checkBoxWordOnly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonFind);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 215);
            this.Name = "FindDialog";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FindDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxWordOnly;
        private System.Windows.Forms.CheckBox checkBoxRegistr;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonCancel;
    }
}