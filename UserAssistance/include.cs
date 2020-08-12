/*
 * Создано в SharpDevelop.
 * Пользователь: Белый Господин
 * Дата: 10.05.2020
 * Время: 14:48
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
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
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Security;

namespace UserAssistance
{
	/// <summary>
	/// Description of include.
	/// </summary>
public static class include{

//Задать сетевые настройки		
public static void SetIP(string ipAddress, string subnetMask, string gateway, string DNS)  {
		
	using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration")){
		using (var networkConfigs = networkConfigMng.GetInstances()){
			foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"])){
			using (var newIP = managementObject.GetMethodParameters("EnableStatic")) {
				// Set new IP address and subnet if needed
				if ((!String.IsNullOrEmpty(ipAddress)) || (!String.IsNullOrEmpty(subnetMask))) {
					if (!String.IsNullOrEmpty(ipAddress)) {
						newIP["IPAddress"] = new[] { ipAddress };
					}
					if (!String.IsNullOrEmpty(subnetMask)){
						newIP["SubnetMask"] = new[] { subnetMask };
					}
					managementObject.InvokeMethod("EnableStatic", newIP, null);
				}
				// Set mew gateway if needed
				if (!String.IsNullOrEmpty(gateway)) {
					using (var newGateway = managementObject.GetMethodParameters("SetGateways")){
						newGateway["DefaultIPGateway"] = new[] { gateway };
						newGateway["GatewayCostMetric"] = new[] { 1 };
						managementObject.InvokeMethod("SetGateways", newGateway, null);
					}
				}
 //newIP["DNSServerSearchOrder"] = DNS.Split(',');
//ManagementBaseObject setDNS = newIP.iInvokeMethod("SetDNSServerSearchOrder", newIP, null);
			}
			ManagementBaseObject newDNS =managementObject.GetMethodParameters("SetDNSServerSearchOrder");
			newDNS["DNSServerSearchOrder"] = DNS.Split(',');
			ManagementBaseObject setDNS =managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
		}
	}
}
}


//Получаем сетевые адаптеры
public static NtwrkIntrfc[] ListNetworkInterface(){
	NetworkInterface[] nics=NetworkInterface.GetAllNetworkInterfaces();
	NtwrkIntrfc[] device = new NtwrkIntrfc[nics.Length];
	for(int x=0;x<=nics.Length-1;x++){
		device[x]=new NtwrkIntrfc();
		if(nics[x].GetIPProperties().UnicastAddresses.Count!=0){
			device[x]._IP=nics[x].GetIPProperties().UnicastAddresses[0].IPv4Mask.ToString();
		}
		device[x]._ID=nics[x].Id;
		device[x]._Description=nics[x].Description;
		device[x]._ID=nics[x].Id;
		device[x]._Name=nics[x].Name;
		device[x]._MAC=nics[x].GetPhysicalAddress().ToString();
		if(nics[x].GetIPProperties().DhcpServerAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().DhcpServerAddresses.Count-1;y++)
				device[x]._DHCP.Add(nics[x].GetIPProperties().DhcpServerAddresses[y].ToString());
				
		if(nics[x].GetIPProperties().DnsAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().DnsAddresses.Count-1;y++)
				device[x]._DNS.Add(nics[x].GetIPProperties().DnsAddresses[y].ToString());
		
		if(nics[x].GetIPProperties().GatewayAddresses.Count!=0)
			for(int y=0;y<=nics[x].GetIPProperties().GatewayAddresses.Count-1;y++)
				device[x]._Gateway.Add(nics[x].GetIPProperties().GatewayAddresses[y].ToString());
	
		}
	return device;
	}
	
public static void viklsetevoeobn(){			
	string command="/C sc config Dnscache start= auto & ";
	command+=" net stop Dnscache /y & ";
	command+=" sc config SSDPSRV start= disabled & ";
	command+=" net stop SSDPSRV /y & ";
	command+=" sc config upnphost start= disabled & ";
	command+=" net stop upnphost /y & ";
	command+=" sc config FDResPub  start= disabled & ";
	command+=" net stop FDResPub /y & ";
	command+=" sc config lmhosts start= disabled & ";
	command+=" net stop lmhosts /y & ";
	command+=" sc config Browser start= disabled & ";
	command+=" net stop Browser /y & ";	
	command+=" sc config MpsSvc start= disabled & ";
	command+=" net stop MpsSvc /y & ";
	command+=" netsh advfirewall firewall set rule group=\"обнаружение сети\" new enable=no & ";
	command+=" netsh advfirewall firewall set rule group=\"общий доступ к файлам и принтерам\" new enable=no &";
//	command+=" REG ADD HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa /v forceguest /t REG_DWORD /d 1 /f & ";
//	command+=" REG ADD HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa /v LmCompatibilityLevel /t REG_DWORD /d 0 /f  ";
	command+=" pause";
	System.Diagnostics.Process.Start("cmd.exe", command);
	}
public static void vklsetevoeobn(){
	string command="/C sc config Dnscache start= auto & ";
	command+=" net start Dnscache & ";
	command+=" sc config SSDPSRV start= auto & ";
	command+=" net start SSDPSRV & ";
	command+=" sc config upnphost start= auto & ";
	command+=" net start upnphost & ";
	command+=" sc config FDResPub start= auto & ";
	command+=" net start FDResPub & ";
	command+=" sc config lmhosts start= auto & ";
	command+=" net start lmhosts & ";
	command+=" sc config Browser start= disabled & ";
	command+=" net stop Browser & ";	
	command+=" sc config MpsSvc start= auto & ";
	command+=" net start MpsSvc & ";
	command+=" netsh advfirewall firewall set rule group=\"обнаружение сети\" new enable=yes & ";
	command+=" netsh advfirewall firewall set rule group=\"общий доступ к файлам и принтерам\" new enable=Yes & ";
	command+=" REG ADD HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa /v forceguest /t REG_DWORD /d 1 /f & ";
	command+=" REG ADD HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa /v LmCompatibilityLevel /t REG_DWORD /d 0 /f  & ";
	command+=" pause";
	System.Diagnostics.Process.Start("cmd.exe", command);

}


public static RSAParameters _publicKey;
public static RSAParameters _privateKey;
public static string _publicKeyString;
public static string _privateKeyString;
public static RSACryptoServiceProvider rsa;
//сохранение логина и пароля
public static void SaveLoginPassword(string login, string pass){
	AssignNewKey();
	File.WriteAllBytes("lgn", CryptoKey(login));
	File.WriteAllBytes("pss", CryptoKey(pass));
}
public static string[] LoadLoginPassword(){
	string[] s=new string[2];
	if(LoadPrivateKey()){
		if((File.Exists("lgn"))&&(File.Exists("pss"))){
			s[0]=DecryptoKey(File.ReadAllBytes("lgn"));
			s[1]=DecryptoKey(File.ReadAllBytes("pss"));
			return s;
		} else return null;
	}else return null;
}

public static SecureString ConvertPasStrSec(string pass){
	if(pass==null) throw new ArgumentNullException("password");
	var secpas=new SecureString();
	foreach(char c in pass){
		secpas.AppendChar(c);
	}
	secpas.MakeReadOnly();
	return secpas;
	
}
//удаляем ключи
public static void DelKey(){
	if(File.Exists("key")) File.Delete("key");
	if(File.Exists("pss")) File.Delete("pss");
	if(File.Exists("lgn")) File.Delete("lgn");
	_publicKeyString="";
	_privateKeyString="";
	if(rsa!=null)
	rsa.Clear();
}
//генерируем ключ
public static void AssignNewKey(){
	rsa=new  RSACryptoServiceProvider(2048);
	//rsa = new RSACryptoServiceProvider(2048);
	//using (var rsa = new RSACryptoServiceProvider(2048)){                
		rsa.PersistKeyInCsp = false;               
		_privateKeyString=rsa.ToXmlString(true);
		_publicKey = rsa.ExportParameters(false);
		_privateKey = rsa.ExportParameters(true); 
		if(File.Exists("key")) File.Delete("key");
		File.AppendAllText("key",_privateKeyString);		
    // }
}

//Загружаем приватный ключ
public static bool LoadPrivateKey(){
	if(File.Exists("key")){
		using (var rsa = new RSACryptoServiceProvider(2048)){                
			rsa.FromXmlString(File.ReadAllText("key"));
			rsa.PersistKeyInCsp = false;
			_privateKeyString=rsa.ToXmlString(true);
			_privateKey = rsa.ExportParameters(true);
			return true;
			
 		}
	} else{
		return false;
	}
}
//шифруем текст
public static byte[] CryptoKey(string txt){
	return rsa.Encrypt(Encoding.Default.GetBytes(txt),true);

	//}
}
private static byte[] DeBitconvert(string s){
	string[] ss=s.Split('-');
	byte[] array=new byte[ss.Length];
	for(int i=0;i<ss.Length;i++) array[i]=Convert.ToByte(ss[i],16);
	return array;
}

public static string DecryptoKey(byte[] bt){
	RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(2048);
	rsa.FromXmlString(File.ReadAllText("key"));
	//_privateKey=rsa.ExportParameters(true);
	//byte[] s=Encoding.Default.GetBytes(key);
	Encoding encoding=Encoding.Default;
	return encoding.GetString(rsa.Decrypt(bt,true));
}
/*
public static bool TestUser(string user,string pass){
	if(Members
	
}
*/	
}
}

