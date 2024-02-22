using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices ;
using System.Threading;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace UserAssistance
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button5Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете перезагрузку сетевых адаптеров?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				//command="/C netsh int ip reset all &";
				command = "/C netsh winsock reset & ";
				command += " ipconfig /flushdns  & ";
				//Список сетевых адаптеров
				NtwrkIntrfc[] adapter = include.ListNetworkInterface();

				for (int i = 0; i < adapter.Count(); i++)
				{
					command += " netsh interface set interface name=\"" + adapter[i]._Name + "\" admin=DISABLED & ";
					command += " netsh interface set interface name=\"" + adapter[i]._Name + "\" admin=ENABLED & ";
					command += " netsh interface ip set dns \"" + adapter[i]._Name + "\" static 8.8.8.8 &";
					command += " netsh interface ip add dns \"" + adapter[i]._Name + "\"  8.8.0.0 &";
				}
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}
		//Очистить очередь печати
		void Button6Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете очистку очереди печати?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C sc config spooler start= auto & ";
				command += " net start spooler & ";
				command += " net stop spooler & ";
				command += " del %systemroot%\\system32\\spool\\printers\\*.shd /F /S /Q & ";
				command += " del %systemroot%\\system32\\spool\\printers\\*.spl /F /S /Q & ";
				command += " net start spooler ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}

		}
		//Отключить сетевое обнаружение
		void Button2Click(object sender, EventArgs e)
		{
			DialogResult dialogresult = MessageBox.Show("Подтверждаете отключение сетевого обнаружения?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
				include.viklsetevoeobn();
		}
		//Включить сетевое обнаружение	
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult dialogresult = MessageBox.Show("Подтверждаете включение сетевого обнаружения?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
				include.vklsetevoeobn();
		}


		void Button3Click(object sender, EventArgs e)
		{
			string command;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				//include.vklsetevoeobn();
				string s = new System.IO.DirectoryInfo(folderBrowserDialog1.SelectedPath).Name;
				command = "/C net share " + s + "=" + folderBrowserDialog1.SelectedPath + " & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}

		void Button4Click(object sender, EventArgs e)
		{

		}
		void Button8Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете?", "Подтверждаете чистку кэша браузеров?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C taskkill /F /IM iexplore.exe & ";
				command += " taskkill /F /IM opera.exe & ";
				command += " taskkill /F /IM firefox.exe & ";
				command += " taskkill /F /IM chrome.exe & ";
				//command+=" rundll32.exe InetCpl.cpl,ClearMyTracksByProcess 8 & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
				//— удаление временных файлов[/code]
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");
				/*[code]*/
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");
				//— удаление журнала посещений 
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1");
				//— удаление данных веб-форм[/code] 
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16");
				//— удаление сохраненных паролей[/code]
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 32");
				//— полная очистка кэша браузера[/code]
				System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 255");
				/**/
			}

		}
		//Очистить кэш java
		void Button7Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете?", "Подтверждаете очистку кэша java?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C javaws –clearcache & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}
		//Очистить временных файлов
		void Button10Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете?", "Подтверждаете очистку временных файлов Windows?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C del /q/f/s/a %TEMP%\\* & ";
				command += " del /q/f/s/a %SytemRoot%\\TEMP\\* & ";
				command += " del /q/f/s/a c:\\TEMP\\* & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}
		//Очистить кэш 1с
		void Button9Click(object sender, EventArgs e)
		{
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете?", "Подтверждаете очистку кэша 1С?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C del /q/f/s/a %APPDATA%\\Local\\1C\\*.* & ";
				command += " rd /q/f/s/a %APPDATA%\\Local\\1C\\ & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}


		//Удалить принтеры		
		void Button12Click(object sender, EventArgs e)
		{
			string system32_path = Environment.SystemDirectory;
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете полное удаление принтеров?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C sc config spooler start= auto & ";
				command += " net start spooler & ";
				command += " net stop spooler & ";
				command += " del %systemroot%\\system32\\spool\\printers\\*.shd /F /S /Q & ";
				command += " del %systemroot%\\system32\\spool\\printers\\*.spl /F /S /Q & ";
				command += " REG DELETE HKLM\\System\\CurrentControlSet\\Control\\Print\\Printers /f & ";
				command += " REG ADD HKLM\\System\\CurrentControlSet\\Control\\Print\\Printers /f & ";
				command += " REG DELETE HKLM\\System\\CurrentControlSet\\Control\\Print\\Environments\\WindowsNTx86\\Drivers\\Version-3 /f & ";
				command += " REG ADD HKLM\\System\\CurrentControlSet\\Control\\Print\\Environments\\WindowsNTx86\\Drivers\\Version-3 /f & ";
				command += " REG DELETE \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Print\\Environments\\Windows x64\\Drivers\\Version-3\" /f & ";
				command += " REG ADD \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Print\\Environments\\Windows x64\\Drivers\\Version-3\" /f & ";
				command += " REG DELETE \"HKCU\\Printers\\Connections\" /f & ";
				command += " REG ADD \"HKCU\\Printers\\Connections\" /f & ";
				command += " REG DELETE \"HKCU\\Printers\\DevModePerUser\" /f & ";
				command += " REG ADD \"HKCU\\Printers\\DevModePerUser\" /f & ";
				command += " REG DELETE \"HKCU\\Printers\\DevModes2\" /f & ";
				command += " REG ADD \"HKCU\\Printers\\DevModes2\" /f & ";


				string fg = system32_path + "\\spool\\prtprocs\\w32x86";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (item.Name != "winprint.dll")
						{
							if (System.IO.File.Exists(fg + "\\" + item.Name))
							{
								command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
							}
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				fg = system32_path + "\\spool\\prtprocs\\x64";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (item.Name != "winprint.dll")
						{
							if (System.IO.File.Exists(fg + "\\" + item.Name))
							{
								command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
							}
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				fg = system32_path + "\\Spool\\Printers";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (System.IO.File.Exists(fg + "\\" + item.Name))
						{
							command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				fg = system32_path + "\\Spool\\Drivers\\w32x86";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (System.IO.File.Exists(fg + "\\" + item.Name))
						{
							command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				fg = system32_path + "\\Spool\\Drivers\\x64";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (System.IO.File.Exists(fg + "\\" + item.Name))
						{
							command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				fg = system32_path + "\\Spool\\SERVERS";
				if (System.IO.Directory.Exists(fg))
				{
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fg);
					foreach (var item in dir.GetFiles())
					{
						if (System.IO.File.Exists(fg + "\\" + item.Name))
						{
							command += "	DEL " + fg + "\\" + item.Name + "  /F /S /Q & ";
						}
					}
					foreach (var item in dir.GetDirectories())
					{
						if (System.IO.Directory.Exists(fg + "\\" + item.Name))
						{
							command += "	RD " + fg + "\\" + item.Name + " /s/q & ";
						}
					}
				}
				/*В ветке HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Print\Monitors, список записей должен выглядеть следующим образом.

			BJ Language Monitor
			Local Port
			PJL Language Monitor
			Standard TCP/IP Port
			USB Monitor
		*/
				command += " net start spooler & ";
				command += " pause";
				System.Diagnostics.Process.Start("cmd.exe", command);

			}
		}





		void OpisToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"https://github.com/Gruzincef/UserAssistance");
		}

		private void AllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checkedListBox1.Items.Clear();
			var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
			store.Open(OpenFlags.ReadOnly);
			foreach (var cert in store.Certificates)
			{

				checkedListBox1.Items.Add(cert.Subject);
			}
			store.Close();
		}

		private void OldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checkedListBox1.Items.Clear();
			X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
			store.Open(OpenFlags.ReadOnly);

			// Получаем список сертификатов
			X509Certificate2Collection certificates = store.Certificates;

			// Фильтруем устаревшие сертификаты
			var expiredCertificates = certificates.Find(X509FindType.FindByTimeExpired, DateTime.Now, false);

			// Выводим информацию о каждом устаревшем сертификате
			foreach (var certificate in expiredCertificates)
			{
				checkedListBox1.Items.Add(certificate.GetExpirationDateString() + ": " + certificate.Subject);
			}

			// Закрываем хранилище
			store.Close();

		}

		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
			store.Open(OpenFlags.ReadOnly);
			MyForm form = new MyForm();
			form.Show();
			string ecp = "";
			foreach (object item in checkedListBox1.CheckedItems)
			{
				int selectedIndex = checkedListBox1.Items.IndexOf(item);
				ecp += store.Certificates[selectedIndex].Subject + "\r\n" +
				store.Certificates[selectedIndex].GetExpirationDateString() + "\r\n" +
				store.Certificates[selectedIndex].GetEffectiveDateString() + "\r\n" +
				store.Certificates[selectedIndex].GetSerialNumberString() + "\r\n";

			}
			form.AddText(ecp);
			store.Close();
		}

		private void SaveListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
			store.Open(OpenFlags.ReadOnly);

			// Открываем диалоговое окно для выбора места сохранения
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Создаем файл для записи
				string filePath = saveFileDialog.FileName;
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					// Записываем заголовок таблицы
					writer.WriteLine("Subject,Issuer,ValidFrom,ValidTo");

					// Записываем данные сертификатов
					foreach (var certificate in store.Certificates)
					{
						writer.WriteLine($"{certificate.Subject},{certificate.Issuer},{certificate.NotBefore},{certificate.NotAfter}");
					}
					// Создаем объект XmlSerializer для сериализации списка сертификатов

				}
			}
		}

		private void OffAutoRunDev_Click(object sender, EventArgs e)
		{
			string system32_path = Environment.SystemDirectory;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете блокирование автозапуска внешних устройств?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				string keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer";
				RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
				RegistryKey subKey = baseKey.OpenSubKey(keyName);
				if (subKey == null)
				{
					subKey = baseKey.CreateSubKey(keyName);
					subKey.SetValue("NoFolderOptions", 1, RegistryValueKind.DWord);
					Console.WriteLine($"Раздел {keyName} создан.");
				}
				string valueName = "NoDriveTypeAutoRun";
				int valueData = 0; // 0xff в шестнадцатеричном формате равно 255 в десятичном формате
				subKey = baseKey.OpenSubKey(keyName, true);
				subKey.SetValue(valueName, valueData, RegistryValueKind.DWord);

				keyName = @"\SYSTEM\CurrentControlSet\services\Cdrom";
				baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
				subKey = baseKey.OpenSubKey(keyName);
				valueName = "AutoRun";
				valueData = 0; // 0xff в шестнадцатеричном формате равно 255 в десятичном формате
				subKey = baseKey.OpenSubKey(keyName, true);
				subKey.SetValue(valueName, valueData, RegistryValueKind.DWord);

				subKey.Close();
				baseKey.Close();
				dialogresult = MessageBox.Show("Автозапуск внешних устройств  заблокирован!", "ОК", MessageBoxButtons.OK);

			}
		}

		private void DelCeshUpdateWindows_Click(object sender, EventArgs e)
		{
			string system32_path = Environment.SystemDirectory;
			string command;
			DialogResult dialogresult = MessageBox.Show("Подтверждаете удаление кэша обновлений?", "Подтверждаете?", MessageBoxButtons.YesNo);
			if (dialogresult == DialogResult.Yes)
			{
				command = "/C  net stop wuauserv & ";
				command += " net stop cryptSvc & ";
				command += " net stop bits & ";
				command += " net stop msiserver & ";
				command += " ren %SystemRoot%\\SoftwareDistribution SoftwareDistribution.old & ";
				command += " ren %SystemRoot%\\System32\\catroot2 Catroot2.old & ";
				command += " net start wuauserv & ";
				command += " net start cryptSvc & ";
				command += " net start bits & ";
				command += " net start msiserver & ";
				System.Diagnostics.Process.Start("cmd.exe", command);
			}
		}

        private void sfcscanow_Click(object sender, EventArgs e)
        {
			string system32_path = Environment.SystemDirectory;
            string command;
            DialogResult dialogresult = MessageBox.Show("Подтверждаете проведение проверки системных файлов?", "Подтверждаете?"+ "/C  sfc /scannow  & ", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                command = "/C %SystemRoot%\\sysNative\\sfc /scannow  & ";
                command += " pause";
                System.Diagnostics.Process.Start("cmd.exe", command);
            }

            
        }


    }
}