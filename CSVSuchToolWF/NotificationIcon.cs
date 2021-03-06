﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 12.12.2014
 * Zeit: 09:15
 * 
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace CSVSuchTool
{
	public sealed class NotificationIcon
	{
		public NotifyIcon notifyIcon;
		static public ContextMenuStrip notificationMenu;
		
		string _strFileName;
		
		public string strFileName {
			get { return _strFileName; }
			set { _strFileName = value; }
		}
		
		static public MainForm mf;
		static public ShowDataForm sdf;
		
		#region Initialize icon and menu
		public NotificationIcon()
		{
			
			notifyIcon = new NotifyIcon();
			
			notificationMenu = new ContextMenuStrip();
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");

			notificationMenu.Name = "iconContextMenu";
			notifyIcon.ContextMenuStrip = notificationMenu;
#if DEBUG
			notifyIcon.Text = "CSV |DBG|- Suchtool für die toolTray Symbol";
#else
			notifyIcon.Text = "CSV - Suchtool für die toolTray Symbol";
#endif
			
			notificationMenu.Items.AddRange(InitializeMenu());
			notificationMenu.Opening += menuPopup;
			
			CSVSuchTool.Properties.Application.Default.Reload();
			CSVSuchTool.Properties.Application.Default.Upgrade();
			
			if (!string.IsNullOrWhiteSpace(CSVSuchTool.Properties.Application.Default.sourceFile)) {
				strFileName = CSVSuchTool.Properties.Application.Default.sourceFile;
			}

			foreach (ToolStripItem tsi in notificationMenu.Items) { //.Find("Suche", true);
				if (Equals(tsi.GetType(), new ToolStripTextBox().GetType())) {
					//Debug.WriteLine("TextBox im Menu gefunden");
					((ToolStripTextBox)tsi).ToolTipText = "Schnellsuche";
					((ToolStripTextBox)tsi).Text = "Schnellsuche";
					((ToolStripTextBox)tsi).KeyUp += menuTextBoxKeyUp;
					((ToolStripTextBox)tsi).Enter += menuTextBoxEnter;
                    ((ToolStripTextBox) tsi).GotFocus += menuTextBoxEnter;
                    //((ToolStripTextBox) tsi).CanSelect = true;
                    ((ToolStripTextBox) tsi).HideSelection = false;
                    //break;
                } else if (Equals(tsi.GetType(), new ToolStripMenuItem().GetType())) {
					//
					//	Anzeigen des Hauptfensters im Menü hervorheben
					//
					if (((ToolStripMenuItem)tsi).Name == "trayMenuOpenApp") {
						System.Drawing.Font MyFont = new System.Drawing.Font(
							                             ((ToolStripMenuItem)tsi).Font,
							                             FontStyle.Bold);
						((ToolStripMenuItem)tsi).Font = MyFont;
						((ToolStripMenuItem)tsi).Tag = false;
					}
					//
					//	Anzeigen des Ergebnisfenster Standard disablen
					//
					if (((ToolStripMenuItem)tsi).Name == "trayMenuOpenResult") {
						((ToolStripMenuItem)tsi).Enabled = false;
					}

				}
				//Debug.WriteLine("TextBox im Menu nicht gefunden " + tsi.GetType().ToString());
			}
		}
		
		private ToolStripItem[] InitializeMenu()
		{
			ToolStripItem[] menu = new ToolStripItem[] {
				new ToolStripTextBox("Suche"),
				new ToolStripSeparator(), 
				new ToolStripMenuItem("Anzeigen", null, menuOpenClick, "trayMenuOpenApp"),
				new ToolStripMenuItem("Ergebnisse", null, menuOpenResultClick, "trayMenuOpenResult"),
				new ToolStripSeparator(), 
				new ToolStripMenuItem("Changelog", null, menuShowChangelogClick, "trayMenuShowChangelog"),
				new ToolStripSeparator(), 
				new ToolStripMenuItem("Beenden", null, menuExitClick, "trayMenuExitApp")
			};
		
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
#if DEBUG
	string mutexName = "CSV - SUCHTOOL | DEBUG";
#else
	string mutexName = "CSV - SUCHTOOL | RELEASE";
#endif			
			
			bool isFirstInstance;
			
			mf = null;
//			mf = new MainForm();
			
			sdf = null;
//			sdf = new ShowDataForm();

			
			//	Anhand einer eindeutig benannten Mutex, feststellen ob bereits eine Instanz der Anwendung läuft
			//	TODO: Optionale Parameter zum Aufrufen der Anwendung erstellen
			using (Mutex mtx = new Mutex(true, mutexName, out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					
					//TODO: Option für das Anzeigen des Hauptfensters beim start erstellen
					// - Beim Schließen des Hauptfensters wird die Anwendung geschlossen.
					// - Keine neue Instanz des Hauptfensters erzeugen
					Application.Run(new DummyForm());
					
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
					//	Übergeben optionaler Parameter an bestehenden Prozess (evtl. erst nachfragen)
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			//TODO: Einen Infodialog implementieren
			MessageBox.Show("About This Application");
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void menuOpenClick(object sender, EventArgs e)
		{
			//Hauptfenster der Anwendung anzeigen
			if (mf == null) {
				mf = new MainForm();
			}
			if (mf.IsDisposed || mf.Disposing) {
				mf = new MainForm();
			}
			
			ToolStripMenuItem mI = sender as ToolStripMenuItem;
			
			if (mI != null && mf != null) {
				if (!(bool)mI.Tag) {
					mf.ShowInTaskbar = true;
					mI.Tag = true;
					mf.Show();
				} else {
					mf.Hide();
					mf.ShowInTaskbar = false;
					mI.Tag = false;
				}
			}
			
		}
		
		/// <summary>
		/// Öffnen des Ergebnisfensters, falls dieses im Hintergrund gerutscht ist
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuOpenResultClick(object sender, EventArgs e)
		{
			//Ergebnisfenster der Anwendung anzeigen
			ToolStripMenuItem mI = sender as ToolStripMenuItem;
			NotifyIcon nI = null;

			if (mI != null && sdf != null)
			{
				if(sdf.CanFocus)
				{
					sdf.Activate();
				}
			}
		}

		private void IconDoubleClick(object sender, EventArgs e)
		{
			NotifyIcon nI = null;
			
			//Datenfenster anzeigen, wenn möglich
			if (sdf != null && (nI = sender as NotifyIcon) != null) {
				if (!sdf.IsDisposed && !sdf.Disposing)
				{
					if(sdf.CanFocus){
						sdf.Activate();
					}
					else
					{
						sdf.Show();
						sdf.Activate();
					}
					return;
				}
			}

			if (mf == null) {
				mf = new MainForm();
			}
			else if(mf.IsDisposed || mf.Disposing)
			{
				mf = new MainForm();
			}
						
			// sonst Hauptfenster der Anwendung anzeigen			
			if ((nI = sender as NotifyIcon) != null  && mf != null)
			{
				if(!mf.CanFocus)
				{
					mf.Show();
				}
				else
					mf.Activate();
				
				mf.ShowInTaskbar = true;
			}
			else 
			{
				mf.Hide();
				mf.ShowInTaskbar = false;
			}
		}
		
		private void menuTextBoxEnter(object sender, EventArgs e)
		{
            ToolStripTextBox tbx; 
            if (sender is ToolStripTextBox)
            {
                tbx = sender as ToolStripTextBox;
                tbx.SelectAll ();
            }
		}
		
		private void menuTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter) {
				//Suche ausführen und Ergebnis anzeigen.
				ToolStripTextBox miTB = null;

				if ((miTB = sender as ToolStripTextBox) != null) {				
					//ToolsFenster für Such Ergebnisse
					#region ToolWindow
					if(sdf == null)
						sdf = new ShowDataForm();
					else if (sdf.IsDisposed || sdf.Disposing) {
						sdf = new ShowDataForm();
					}
					
					Properties.Application.Default.Reload();
					strFileName = Properties.Application.Default.sourceFile;
					
					sdf.Show();	
					sdf.ReadCsv(miTB.Text, strFileName);
					sdf.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - sdf.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - sdf.Height - 5);
					sdf.Focus();
					#endregion
				}
			}
		}
		
		/// <summary>
		/// Rechtsklick auf das Traysymbol
		/// Festlegen ob das Hauptfenster angezeigt werden oder ausgeblendet kann 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuPopup(object sender, EventArgs e)
		{
			ContextMenuStrip cms = null;
			if ((cms = sender as ContextMenuStrip) != null) 
			{
				//####
				//#	Anzeigen des Hauptfensters möglich ?
				//####
				ToolStripItem[] mI = cms.Items.Find("trayMenuOpenApp", true);
				
				
				if ((mI[0] as ToolStripMenuItem != null) && mf != null) {
						((ToolStripMenuItem)mI[0]).Tag = mf.CanFocus;

					((ToolStripMenuItem)mI[0]).Text = (bool)mI[0].Tag == true ? "Ausblenden" : "Anzeigen";
				}
				//####
				
				//####
				//#	Anzeigen des Ergebnisfensters
				//####
				mI = null;
				mI = cms.Items.Find("trayMenuOpenResult", true);
				if (mI[0] as ToolStripMenuItem != null && sdf != null)
				{
					((ToolStripMenuItem)mI[0]).Enabled = sdf.CanFocus;
				}
                //####


                //####
                //#	Focus auf Suchfeld legen
                //####
                mI = null;
                mI = cms.Items.Find ("Suche", true);
                if (Equals (mI[0].GetType (), new ToolStripTextBox ().GetType ()))
                    //if (mI [0] as ToolStripTextBox != null && sdf != null)
                {
                    //mI [0].Select ();
                    ((ToolStripTextBox) mI [0]).AcceptsTab = true;
                    ((ToolStripTextBox) mI [0]).Control.Focus ();//.TextBox.SelectAll ();//..Focus();
                    //((ToolStripTextBox) mI [0]).TextBox.Focus();
                    //this.ActiveControl = ((ToolStripTextBox) mI [0]).Control
                    //((ToolStripTextBox)  mI [0]).Text = "";
                }
                //####
            }
        }
		
		private void menuShowChangelogClick(object sender, EventArgs e)
		{
			//Anzeigen des Changelogs
			string strChgLog = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\text\\changelog.txt";
			if (File.Exists(strChgLog)) {
				FrmLogView FrmLogViewDlg = new FrmLogView();
				FrmLogViewDlg.logToView = strChgLog;
				FrmLogViewDlg.ShowDialog();
				//TODO:Anzeige für Systemeliste aktualisieren
				FrmLogViewDlg.Dispose();
			}
		}
		#endregion
	}
}
