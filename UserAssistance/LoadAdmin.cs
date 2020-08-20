using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserAssistance
{
	/// <summary>
	/// Description of LoadAdmin.
	/// </summary>
	public partial class LoadAdmin : Form
	{
		public LoadAdmin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			LoadPassword();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
void Button1Click(object sender, EventArgs e){
	if((textBox1.Text.Length>0)&&(textBox2.Text.Length>0)){
		include.SaveLoginPassword(textBox1.Text,textBox2.Text);
	}

		}
void Button2Click(object sender, EventArgs e){
	textBox1.Text="";
	textBox2.Text="";
	include.DelKey();
		}
public void LoadPassword(){
	string [] s=include.LoadLoginPassword();
	if(s!=null){
	textBox1.Text=s[0];
	textBox2.Text=s[1];
		}
		
}
	}
	
}
