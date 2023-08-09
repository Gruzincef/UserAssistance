/*
 * Создано в SharpDevelop.
 * Пользователь: Белый Господин
 * Дата: 10.05.2020
 * Время: 13:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace UserAssistance
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.отображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OffAutoRunDev = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Принтеры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 70);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(188, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Полное удаление принтеров";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Очистить очередь печати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сеть";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Перезагрузить сеть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удалить общий доступ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Открыть общий доступ к папке";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выключить обнаружение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Включить обнаружение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(10, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(285, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Кэш";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 104);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(208, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Удалить временные файлы windows";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(208, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Очистить временные файлы 1С";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Очистить кэш браузеров";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Очистить кэш Java";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.Button7Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBox1);
            this.tabPage4.Controls.Add(this.menuStrip2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(285, 302);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ЭЦП";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 46);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(273, 244);
            this.checkedListBox1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отображениеToolStripMenuItem,
            this.действиеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(279, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // отображениеToolStripMenuItem
            // 
            this.отображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllToolStripMenuItem,
            this.OldToolStripMenuItem,
            this.ShowToolStripMenuItem});
            this.отображениеToolStripMenuItem.Name = "отображениеToolStripMenuItem";
            this.отображениеToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.отображениеToolStripMenuItem.Text = "Отображение";
            // 
            // AllToolStripMenuItem
            // 
            this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
            this.AllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AllToolStripMenuItem.Text = "Все";
            this.AllToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItem_Click);
            // 
            // OldToolStripMenuItem
            // 
            this.OldToolStripMenuItem.Name = "OldToolStripMenuItem";
            this.OldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OldToolStripMenuItem.Text = "Устаревшие";
            this.OldToolStripMenuItem.Click += new System.EventHandler(this.OldToolStripMenuItem_Click);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowToolStripMenuItem.Text = "Показать";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveListToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.DeleteOldToolStripMenuItem,
            this.SaveAllToolStripMenuItem,
            this.SaveSelectToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // SaveListToolStripMenuItem
            // 
            this.SaveListToolStripMenuItem.Name = "SaveListToolStripMenuItem";
            this.SaveListToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SaveListToolStripMenuItem.Text = "Сохранить список";
            this.SaveListToolStripMenuItem.Click += new System.EventHandler(this.SaveListToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // DeleteOldToolStripMenuItem
            // 
            this.DeleteOldToolStripMenuItem.Name = "DeleteOldToolStripMenuItem";
            this.DeleteOldToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.DeleteOldToolStripMenuItem.Text = "Удалить устаревшие";
            // 
            // SaveAllToolStripMenuItem
            // 
            this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
            this.SaveAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SaveAllToolStripMenuItem.Text = "Сохранить все";
            // 
            // SaveSelectToolStripMenuItem
            // 
            this.SaveSelectToolStripMenuItem.Name = "SaveSelectToolStripMenuItem";
            this.SaveSelectToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SaveSelectToolStripMenuItem.Text = "Сохранить выделенное";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpisToolStripMenuItem
            // 
            this.OpisToolStripMenuItem.Name = "OpisToolStripMenuItem";
            this.OpisToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.OpisToolStripMenuItem.Text = "О программе";
            this.OpisToolStripMenuItem.Click += new System.EventHandler(this.OpisToolStripMenuItemClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.OffAutoRunDev);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(285, 302);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ИБ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OffAutoRunDev
            // 
            this.OffAutoRunDev.Location = new System.Drawing.Point(15, 6);
            this.OffAutoRunDev.Name = "OffAutoRunDev";
            this.OffAutoRunDev.Size = new System.Drawing.Size(209, 23);
            this.OffAutoRunDev.TabIndex = 0;
            this.OffAutoRunDev.Text = "Отключить автозапуск устройств";
            this.OffAutoRunDev.UseVisualStyleBackColor = true;
            this.OffAutoRunDev.Click += new System.EventHandler(this.OffAutoRunDev_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 413);
            this.Name = "MainForm";
            this.Text = "Помошник пользователю";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem OpisToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem отображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSelectToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button OffAutoRunDev;
    }
}
