
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
