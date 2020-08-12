/*
 * Создано в SharpDevelop.
 * Пользователь: Белый Господин
 * Дата: 10.05.2020
 * Время: 13:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Diagnostics;
namespace UserAssistance
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			WindowsPrincipal principal=new WindowsPrincipal(WindowsIdentity.GetCurrent());
			bool hasAdministrativeRight=principal.IsInRole(WindowsBuiltInRole.Administrator);
			if(!hasAdministrativeRight){
				ProcessStartInfo processinfo=new ProcessStartInfo();
				processinfo.Verb="runas";
				processinfo.FileName=Application.ExecutablePath;
			/*	string [] s=include.LoadLoginPassword();
				if(s!=null){
					processinfo.UseShellExecute=false;
					processinfo.UserName=s[0];
					processinfo.Password=include.ConvertPasStrSec(s[1]);
				}*/
				try{
					Process.Start(processinfo);
				}catch(Win32Exception)  {
					
				}
				Application.Exit();
			} else{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			}
		}
		
	}
}
