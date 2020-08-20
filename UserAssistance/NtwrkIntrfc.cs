
using System;
using System.Management;
using System.Collections;
using System.Collections.Generic;

namespace UserAssistance
{
	/// <summary>
	/// Description of ListNetworkInterface.
	/// </summary>
	public class NtwrkIntrfc
	{
		public string _ID;
		public string _Name;
		public string _Description;
		public string _IP;
		public List<string> _Gateway=new List<string>();
		public string  _Mask;
		public string  _MAC;
		public List<string> _DHCP=new List<string>();
		public List<string> _DNS = new List<string>();
		public Object _Obj;
		//public List<string> 			
	}
}
