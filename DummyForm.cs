/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Dirk Buck
 * Datum: 23.01.2015
 * Zeit: 23:15
 * 
 */
using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace AC_Telefonbuch
{
	/// <summary>
	/// Description of DummyForm.
	/// </summary>
	public partial class DummyForm : Form
	{
		#region Properties
		TaskbarManager tm = null;
		JumpList CustomJumpList = null;

		/// <summary>
		/// Installierte Version des Total Commanders
		/// </summary>
		string _strTCmdVersion;
		public string strTCmdVersion {
			get { return _strTCmdVersion; }
			set { _strTCmdVersion = value; }
		}
		
		/// <summary>
		/// Installations Pfad des Total Commanders
		/// </summary>
		string _strTCmdPath;
		public string strTCmdPath {
			get { return _strTCmdPath; }
			set { _strTCmdPath = value; }
		}
		
		string _strSourceFile;
		
		public string strSourceFile {
			get { return _strSourceFile; }
			set { _strSourceFile = value; }
		}
		#endregion


		public DummyForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//
			//	Kommandozeilen Parameter abfangen und verarbeiten
			//	-Hostfile="PfadZurListeMitHostAdresse"
			//	-Damware="PfadZurDameWareExe"   --- Wenn abweichend von Standard Installationspfad
			//	-Checkliste="Pfad zur xls Checkliste"
			//
			if (!string.IsNullOrWhiteSpace(Environment.CommandLine)) {
				Debug.WriteLine(Environment.CommandLine.ToString(), "Programm Start Parameter");
				strSourceFile = ParseCmdLineParam("sourcefile", Environment.CommandLine);
			}
			
			//
			//	Funktionen der Win7 Taskbar nutzen
			//
			tm = TaskbarManager.Instance;
			tm.ApplicationId = "CSV - SuchTool";
		}

		/// <summary>
		/// Auslesen der Parameter aus dem Kommandozeilen Aufruf
		/// </summary>
		/// <param name="key"></param>
		/// <param name="cmdline"></param>
		/// <returns></returns>
		public static string ParseCmdLineParam(string key, string cmdline)
		{
			string res = "";
			try {
				int start = cmdline.IndexOf(key);
				start += key.Length + 1;
				int end = cmdline.IndexOf(" -", start);
				//end = end-2;
				int length = 0;
				if (end > 0) {
					length = end - start;
				} else {
					length = cmdline.Length - start;
				}
				res = cmdline.Substring(start, length);
			} catch (System.Exception ex) {
				Debug.WriteLine(ex.Message);
			}
			return res;
		}
		void DummyFormShown(object sender, EventArgs e)
		{
			createTaksJumpList();	
			Hide();
			ShowInTaskbar = true;
		}
		
		/// <summary>
		/// Einträge in der JumpList (Aufgaben) des Tasks erzeugen
		/// 1. Notizen - StikyNot.exe
		/// 2. Snipping - Snipping.exe
		/// 3. Notepad - Notepad.exe
		/// </summary>
		void createTaksJumpList()
		{
			CustomJumpList = JumpList.CreateJumpList();

			CustomJumpList.ClearAllUserTasks();
			
			JumpListLink EntryNote = new JumpListLink(@"%windir%\system32\StikyNot.exe", "Notizen");
			EntryNote.IconReference = new IconReference(@"%windir%\system32\StikyNot.exe", 0);
			CustomJumpList.AddUserTasks(EntryNote);

			JumpListLink EntrySnipp = new JumpListLink(@"%windir%\system32\SnippingTool.exe", "Snipping");
			EntrySnipp.IconReference = new IconReference(@"%windir%\system32\SnippingTool.exe", 0);
			CustomJumpList.AddUserTasks(EntrySnipp);

			JumpListLink EntryNotepad = new JumpListLink(@"%windir%\system32\Notepad.exe", "Notepad");
			EntryNotepad.IconReference = new IconReference(@"%windir%\system32\Notepad.exe", 0);
			CustomJumpList.AddUserTasks(EntryNotepad);
			
			JumpListLink EntryCmd = new JumpListLink(@"%windir%\system32\cmd.exe", "Eingabeaufforderung");
			EntryCmd.IconReference = new IconReference(@"%windir%\system32\cmd.exe", 0);
			CustomJumpList.AddUserTasks(EntryCmd);

			if (!string.IsNullOrWhiteSpace(strTCmdPath)) {
				JumpListLink EntryTCM = new JumpListLink(strTCmdPath, "Total Commander - " + strTCmdVersion);
				EntryTCM.IconReference = new IconReference(strTCmdPath, 0);
				CustomJumpList.AddUserTasks(EntryTCM);
			}

			CustomJumpList.Refresh();			
		}
		
		/// <summary>
		/// Legt einen neuen Eintrag in der Jumpliste der Taskleiste an
		/// Umgeht die Recentliste mit eigener Kategorie
		/// Aufruf direkt an DameWare
		/// </summary>
		void addToJumpListRecent(string strSourceFile)
		{
			// eigene Kategorie anlegen
			JumpListCustomCategory CustomCategory = new JumpListCustomCategory("Suchdateien");
			
			
			// in diese Link zu einer Datei anlegen
			string strDwTemp = "-sourcefile=" + strSourceFile;
			JumpListLink myJumpLinkA = new JumpListLink(Application.ExecutablePath, strSourceFile);
			myJumpLinkA.Arguments = strDwTemp;
			myJumpLinkA.IconReference =	new IconReference(Application.ExecutablePath, 0);
				
			CustomCategory.AddJumpListItems(myJumpLinkA);
			
			CustomJumpList.AddCustomCategories(CustomCategory);
			
			CustomJumpList.Refresh();
			
			
		}
		
		/// <summary>
		/// Prüft ob der in den Eigenschaften vorbelegte Pfad zu DameWare gültig ist
		/// Falls dies nicht so ist, dann wird der Pfad aus der Registry ausgelesen
		/// </summary>
		void checkTotalCommanderPath()
		{
			//
			//	Vorgabe der Processcomponenten Eigenschaft prüfen
			//
			//if (!File.Exists(prcDameWare.StartInfo.FileName)) 
			{
				RegistryKey tcpath = null;
				bool found = false;
				string installLocation = "";
				string displayVersion = "";
				
				//
				//	Zuerst im standard View der Registry schauen
				//	Ist gleich auf 32 und 64 Bit Systemen
				//	Bei 32 Bit Anwendungen auf 64 Bit System ist die Default View auch 32 Bit
				//
				tcpath = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
				
				
				//
				//	RegistryPfad zum Uninstall Schlüssel festlegen
				//
				tcpath = tcpath.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
				if (!string.IsNullOrWhiteSpace(tcpath.Name)) {
				
					//	In den Uninstall Schlüsseln nach DameWare suchen
					foreach (string strReg in tcpath.GetSubKeyNames()) {
						if (Regex.IsMatch(strReg, "Total Commander", RegexOptions.IgnoreCase)) {
							installLocation = tcpath.OpenSubKey(strReg).GetValue("installLocation").ToString();
							displayVersion = tcpath.OpenSubKey(strReg).GetValue("DisplayVersion").ToString();

							if (File.Exists(Path.Combine(installLocation + "TOTALCMD64.EXE"))) {
								strTCmdPath = Path.Combine(installLocation + "TOTALCMD64.EXE");
								strTCmdVersion = displayVersion;
								found = true;
								break;
							}
						}
					}
					tcpath.Close();
					//
					//	Wenn nicht gefunden und ein 64 Bit Sytem ist
					//	nochmal im 32 Bit Bereich suchen
					//	Bei 32 Bit Anwendung auf 64 Bit System explizit noch einmal 64Bit Registry durchsuchen
					//	64 Bit Anwendung auf 64 Bit System durchsucht nochmals 32 Bit Bereich der Registry
					//
					if (!found && Environment.Is64BitOperatingSystem) {
						if (!Environment.Is64BitProcess)
							tcpath = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						else
							tcpath = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
						
						tcpath = tcpath.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
						
						if (!string.IsNullOrWhiteSpace(tcpath.Name)) {
							installLocation = "";
							displayVersion = "";
						
							//	In den Uninstall Schlüsseln nach DameWare suchen
							foreach (string strReg in tcpath.GetSubKeyNames()) {
								if (Regex.Match(strReg, "Total", RegexOptions.IgnoreCase).Success) {
									installLocation = Path.GetDirectoryName(tcpath.OpenSubKey(strReg).GetValue("UninstallString").ToString());
									displayVersion = tcpath.OpenSubKey(strReg).GetValue("DisplayVersion").ToString();
		
									if (File.Exists(Path.Combine(installLocation + "\\TOTALCMD64.EXE"))) {
										strTCmdPath = Path.Combine(installLocation + "\\TOTALCMD64.EXE");
										strTCmdVersion = displayVersion;
										found = true;
										break;
									}
								}
							}
						}
					}
				}
				tcpath.Dispose();
			}
//			else 
//			{
//				//Standard Pfad für DameWare vorhanden
//				strDameWarePath = prcDameWare.StartInfo.FileName;
//			}
		}
	}
}
