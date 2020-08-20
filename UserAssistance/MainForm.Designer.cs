
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
		private System.Windows.Forms.Button button11;
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
			this.button11 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button12);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(695, 543);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Принтеры";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(8, 86);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(251, 28);
			this.button12.TabIndex = 1;
			this.button12.Text = "Полное удаление принтеров";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(8, 20);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(251, 28);
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
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(352, 382);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Сеть";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(8, 215);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(247, 28);
			this.button5.TabIndex = 4;
			this.button5.Text = "Перезагрузить сеть";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 295);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(247, 28);
			this.button4.TabIndex = 3;
			this.button4.Text = "Удалить общий доступ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 154);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(247, 28);
			this.button3.TabIndex = 2;
			this.button3.Text = "Открыть общий доступ к папке";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 87);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(247, 28);
			this.button2.TabIndex = 1;
			this.button2.Text = "Выключить обнаружение";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 22);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 28);
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
			this.tabControl1.Location = new System.Drawing.Point(16, 15);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(360, 411);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button10);
			this.tabPage3.Controls.Add(this.button9);
			this.tabPage3.Controls.Add(this.button8);
			this.tabPage3.Controls.Add(this.button7);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(695, 543);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Кэш";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(8, 246);
			this.button10.Margin = new System.Windows.Forms.Padding(4);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(277, 28);
			this.button10.TabIndex = 3;
			this.button10.Text = "Удалить временные файлы windows";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(8, 161);
			this.button9.Margin = new System.Windows.Forms.Padding(4);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(277, 28);
			this.button9.TabIndex = 2;
			this.button9.Text = "Очистить временные файлы 1С";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(8, 85);
			this.button8.Margin = new System.Windows.Forms.Padding(4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(277, 28);
			this.button8.TabIndex = 1;
			this.button8.Text = "Очистить кэш браузеров";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(8, 21);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(277, 28);
			this.button7.TabIndex = 0;
			this.button7.Text = "Очистить кэш Java";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Visible = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(20, 434);
			this.button11.Margin = new System.Windows.Forms.Padding(4);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(315, 36);
			this.button11.TabIndex = 1;
			this.button11.Text = "Запуск от имени администратора";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Visible = false;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 433);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 480);
			this.Name = "MainForm";
			this.Text = "Помошник пользователю";
			this.tabPage2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button12;
	}
}
