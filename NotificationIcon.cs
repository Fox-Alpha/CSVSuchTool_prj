/*
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

namespace AC_Telefonbuch
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
			
			//notificationMenu = new ContextMenu(InitializeMenu());
			notificationMenu = new ContextMenuStrip();
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			//notifyIcon.ContextMenu = notificationMenu;
			notificationMenu.Name = "iconContextMenu";
			notifyIcon.ContextMenuStrip = notificationMenu;
			notifyIcon.Text = "CSV - Suchtool für die Tray Anzeige";
			
			notificationMenu.Items.AddRange(InitializeMenu());
			notificationMenu.Opening += menuPopup;
			
			AC_Telefonbuch.Properties.Application.Default.Reload();
			AC_Telefonbuch.Properties.Application.Default.Upgrade();
			
			if (!string.IsNullOrWhiteSpace(AC_Telefonbuch.Properties.Application.Default.sourceFile)) {
				strFileName = AC_Telefonbuch.Properties.Application.Default.sourceFile;
			}

			foreach (ToolStripItem tsi in notificationMenu.Items) { //.Find("Suche", true);
				if (Equals(tsi.GetType(), new ToolStripTextBox().GetType())) {
					//Debug.WriteLine("TextBox im Menu gefunden");
					((ToolStripTextBox)tsi).ToolTipText = "Schnellsuche";
					((ToolStripTextBox)tsi).Text = "Schnellsuche";
					((ToolStripTextBox)tsi).KeyUp += menuTextBoxKeyUp;
					((ToolStripTextBox)tsi).Enter += menuTextBoxEnter;
					
					//break;
				} else if (Equals(tsi.GetType(), new ToolStripMenuItem().GetType())) {
					if (((ToolStripMenuItem)tsi).Name == "trayMenuOpenApp") {
						System.Drawing.Font MyFont = new System.Drawing.Font(
							                             ((ToolStripMenuItem)tsi).Font,
							                             FontStyle.Bold);
						((ToolStripMenuItem)tsi).Tag = false;
					}
				}
				//Debug.WriteLine("TextBox im Menu nicht gefunden " + tsi.GetType().ToString());
			}
		}
		
		private ToolStripItem[] InitializeMenu()
		{
//			MenuItem[] menu = new MenuItem[] {
//				new MenuItem("About", menuAboutClick),
//				new MenuItem("Exit", menuExitClick),
//				
//			};
			ToolStripItem[] menu = new ToolStripItem[] {
				new ToolStripTextBox("Suche"),
				new ToolStripMenuItem("Anzeigen", null, menuOpenClick, "trayMenuOpenApp"),
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
			
			bool isFirstInstance;
			
			mf = null;
			mf = new MainForm();
			
			sdf = null;
			sdf = new ShowDataForm();

			
			//	Anhand einer eindeutig benannten Mutex, feststellen ob bereits eine Instanz der Anwendung läuft
			using (Mutex mtx = new Mutex(true, "AC_Telefonbuch", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					
					//TODO: Option für das Anzeigen des Hauptfensters beim start erstellen
					// - Beim Schließen des Hauptfensters wird die Anwendung geschlossen.
					// - Keine neue Instanz des Hauptfensters erzeugen
//					if(AC_Telefonbuch.Properties.Settings.Default.showMainFormOnStart)
//						Application.Run(new MainForm());
//					else
					Application.Run(new DummyForm());
					
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
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
			if (mf.IsDisposed || mf == null) {
				mf = new MainForm();
			}
			
			ToolStripMenuItem mI = sender as ToolStripMenuItem;
			
			if (mI != null && mf != null) {
				if (!(bool)mI.Tag) {
					mf.ShowInTaskbar = true;
					mI.Tag = true;
					mf.Show();
					//mI.Tag = false;
				} else {
					mf.Hide();
					mf.ShowInTaskbar = false;
					mI.Tag = false;
				}
			}
			
		}

		private void IconDoubleClick(object sender, EventArgs e)
		{
			//Hauptfenster der Anwendung anzeigen
			if (mf.IsDisposed || mf == null) {
				mf = new MainForm();
			}
			
			NotifyIcon nI = null;
			if ((nI = sender as NotifyIcon) != null) {
			
				if ((nI.ContextMenuStrip.Items[1] as ToolStripMenuItem != null) && mf != null) {
					if (!mf.CanFocus) {
						mf.ShowInTaskbar = true;
						mf.Show();
						nI.ContextMenuStrip.Items[1].Tag = true;
					} else {
						mf.Hide();
						mf.ShowInTaskbar = false;
						nI.ContextMenuStrip.Items[1].Tag = false;
					}
					nI.ContextMenuStrip.Items[1].Text = (bool)nI.ContextMenuStrip.Items[1].Tag == true ? "Ausblenden" : "Anzeigen";
				}				
			}
		}
		
		private void menuTextBoxEnter(object sender, EventArgs e)
		{
			if (sender is TextBox) {
				((TextBox)sender).SelectAll();
			}
		}
		
		private void menuTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter) {
				//Suche ausführen und Ergebnis anzeigen.
				//Hauptfenster der Anwendung anzeigen
				ToolStripTextBox miTB = null;

				if ((miTB = sender as ToolStripTextBox) != null) {				
					//ToolsFenster für Such Ergebnisse
					#region ToolWindow
					if (sdf.IsDisposed || sdf == null) {
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
		
		private void menuPopup(object sender, EventArgs e)
		{
			//Hauptfenster der Anwendung anzeigen
			if (mf.IsDisposed || mf == null) {
				mf = new MainForm();
			}
			
			ContextMenuStrip cms = null;
			if ((cms = sender as ContextMenuStrip) != null) {
				ToolStripItem[] mI = cms.Items.Find("Anzeigen", true);
				
				if ((cms.Items[1] as ToolStripMenuItem != null) && mf != null) {
					if (mf.CanFocus) {
						cms.Items[1].Tag = true;
					} else {
						cms.Items[1].Tag = false;
					}
					cms.Items[1].Text = (bool)cms.Items[1].Tag == true ? "Ausblenden" : "Anzeigen";
				}
				
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
