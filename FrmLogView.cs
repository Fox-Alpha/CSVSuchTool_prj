/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 12.06.2014
 * Zeit: 14:37
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace AC_Telefonbuch
{
	/// <summary>
	/// Description of FrmLogView.
	/// </summary>
	public partial class FrmLogView : Form
	{
		string _logToView;
		
		public string logToView {
			get { return _logToView; }
			set { 
					if (value != null && File.Exists(value)) {
						_logToView = value; 
					}
					else value = "";
				}
		}
		
		bool editor;
		
		public bool Editor {
			get { return editor; }
			set { 
					editor = value;
					rtbLogView.ReadOnly = !value;
				}
		}
		
		string _openedFile;
		
		public string openedFile {
			get { return _openedFile; }
			set { _openedFile = value; }
		}
		
		public FrmLogView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			logToView = null;						
		}
		
		/// <summary>
		/// Ausgewählte Log Datei in eigenen Fenster anzeigen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void FrmLogView_Load(object sender, System.EventArgs e)
		{
			if(!string.IsNullOrWhiteSpace(logToView))
			{
				try 
				{
					using(TextReader tr = File.OpenText(logToView))
			        {
						rtbLogView.Clear();
						rtbLogView.AppendText(tr.ReadToEnd());
						
						rtbLogView.Modified = false;
						openedFile = logToView;
					}
					rtbLogView.SelectionStart = 0;
				} 
				#region Exceptions
				catch (IOException ioe) 
				{
					Debug.WriteLine("logToView - IOException: {0}", new Object[] {ioe.Message});
					rtbLogView.Text = string.Format("logToView - IOException: {0}", ioe.Message);
				}
				catch (ArgumentException ae)
				{
					Debug.WriteLine("logToView - ArgumentException: {0}", new Object[] {ae.Message});
					rtbLogView.Text = string.Format("logToView - ArgumentException: {0}", ae.Message);
				}
				catch (Exception ex)
				{
					Debug.WriteLine("logToView - unbekannte Exception: {0}", new Object[] {ex.Message});
					rtbLogView.Text = string.Format("logToView - unbekannte Exception: {0}", ex.Message);
				}
				#endregion
			}
		}
		void FrmLogView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(rtbLogView.Modified)
			{
				if(MessageBox.Show("Sollen die Änderungen gespeichert werden.", "Änderungen speichern ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false)==DialogResult.Yes)
				{
					using(StreamWriter sw = new StreamWriter(openedFile, false, Encoding.UTF8))
					{
						sw.WriteLine(rtbLogView.Text);
					}
				}
			}
		}
	}
}
