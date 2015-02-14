/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 16.12.2014
 * Zeit: 15:30
 * 
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using LumenWorks.Framework.IO.Csv;
using System.Text.RegularExpressions; 

namespace AC_Telefonbuch
{
	/// <summary>
	/// Description of ShowDataForm.
	/// </summary>
	public partial class ShowDataForm : Form
	{
		List<List<string>> _dataList;
		
		public List<List<string>> dataList {
			get { return _dataList; }
			set { _dataList = value; }
		}
		
		static string mailITSD = "it-service-desk@alpha-com.de";
		static string mailIncident = "servicedesk@alpha-com.de";

		List<string> _mailSubjects;
		
		public List<string> mailSubjects {
			get { return _mailSubjects; }
			set { _mailSubjects = value; }
		}
		
		List<string> _mailBodys;
		
		public List<string> mailBodys {
			get { return _mailBodys; }
			set { _mailBodys = value; }
		}
		
		Label[] _labCaptionList;
		
		public Label[] labCaptionList {
			get { return _labCaptionList; }
			set { _labCaptionList = value; }
		}
		
		Label[] _labDataCaption;
		
		public Label[] labDataCaption {
			get { return _labDataCaption; }
			set { _labDataCaption = value; }
		}
		
		int _currDataSet;
		
		public int currDataSet {
			get { return _currDataSet; }
			set { _currDataSet = value; }
		}
		
		int _maxDataSet;
		
		public int maxDataSet {
			get { return _maxDataSet; }
			set { _maxDataSet = value; }
		}
		
		int _iFieldCount;
		
		public int iFieldCount {
			get { return _iFieldCount; }
			set { _iFieldCount = value; }
		}
		
		Point labPos;
		
		public ShowDataForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dataList = new List<List<string>>();
			
			//####
			#region Email an Empfänger

			// [0] Leere EMail an Empfänger
			// [1] EMail mit Anruf Notiz an Empfänger
			// [2] Leere EMail an Empfänger mit CC IT-SD
			// [3] EMail an Empfänger mit Info zu einem Incident
			mailSubjects = new List<string>() 
				{
				"KEIN Betreff",
				"Anruf entgegen genommen ",
				"KEIN Betreff",
				"[#YYYYMMDD-NNNN] Zur Info"
				};
			mailBodys = new List<string>() 
				{
				"Kein Text",
				"Herr/Frau xy hat im IT-SD angerufen und bittet um Rückruf\nDwSys: \nJobNr.: \nTel: ",
				"Kein Text",
				"Kein Text"
				};
			#endregion EMail an Empfänger
			//####
			
			foreach (ToolStripMenuItem ctx in ctxMailOptions.Items) {
				ctx.Click += linkLabelEMailTo_Click;
			}
		}
		public bool ReadCsv(string search, string strFileName)
		{
			//
			//	keine Datei zum suchen
			//
			if (!File.Exists(strFileName)){

				MessageBox.Show("Es wurde keine Datei für die Suche angegeben");
				return false;
			}
			//	Kein Text für Suche eingegegen
			if(string.IsNullOrWhiteSpace(search)) {
				MessageBox.Show("Es wurde kein Suchbegriff angegeben");
				return false;
			}
			//
			//	Funktion beenden
			//	####
			
			iFieldCount = 0;
		    
		    using (CsvReader csv =
		           new CsvReader(new StreamReader(strFileName), true, ';', '\"', '\"', '#', ValueTrimmingOptions.All, 4096))
		    {
				//	Anzahl der Spalten
		        iFieldCount = csv.FieldCount;

		        //	Namen der Spalten 
		        string[] headers = csv.GetFieldHeaders();		        
		        
		        string strSearchTerm = search;
			    int iSearchInColumn = 0;

			    dataList.Clear();
			    //
			    //	Füllen der Labels für Feldbeschriftung
			    //TODO: Umstellen auf Label Erstellung aus einem Dictonary
			    //		Umlagern in DisplayResult()
			    //
			    labCaptionList = new Label[iFieldCount];
			    labPos = new Point(15, 30);
				for (int i = 0; i < iFieldCount; i++)
	            {
					labCaptionList[i] = new Label();
					labCaptionList[i].Text = headers[i];
					labCaptionList[i].Name = "labColumnName"+i;
					labCaptionList[i].AutoSize = true;
					labCaptionList[i].Location = new Point(labPos.X, labPos.Y + 18*i);
	            }
				//	#####
				
				//
				//Suchen und merken der Zeilen in denen ein Match erreicht wurde
				//
		        while (csv.ReadNextRecord())
		        {
					List<string> strLine = new List<string>();
					
					if (!(string.IsNullOrWhiteSpace(search)))
   		            {
   		            	if (Regex.IsMatch(csv[iSearchInColumn], strSearchTerm, RegexOptions.IgnoreCase))
						{
		   		            for (int i = 0; i < iFieldCount; i++)
				            {
		   		            	strLine.Add(csv[i]);
				            }
		   		            dataList.Add(new List<string>(strLine));
						}
					}
   		            //else
					//{
					//}
   		            strLine.Clear();
		        }
		        //	####
		    }
			//Anzeigen der Ergenisse
			displayResult();
			// 	Rückmeldung ob Ergebnisse vorliegen
			return dataList.Count > 0;
		}
		
		void displayResult(int Index = 0)
		{
			if (dataList.Count == 0){

				MessageBox.Show("Es wurden keine Ergebnisse mit der Suche gefunden");
				return;
			}
			//	Arrays für Labels der Ergebnisanzeige
		    labDataCaption = new Label[iFieldCount];
		    //	Startposition der Labels
		    labPos = new Point(this.Width-15, 30);
		    
		    //Maximale Breite eines Labels um die Position zum rechten Rand zu ermitteln
		    //TODO: Umstellen auf Label Erstellung aus einem Dictonary
		    int iMaxWidth = 0; 
		    Control[] labControls = null;
			for (int i = 0; i < iFieldCount; i++)
            {
				
				List<string> lData = dataList.Count > 0 ? dataList[Index] : null;	//TODO: Ausgewählten Index abrufen, bei Start immer Index 0 //TODO: Prüfen ob Daten "gefunden" wurden

				if ((labControls = Controls.Find("labData_"+i, true)).Length > 0) {
					if (labControls[0] is Label) {
						labDataCaption[i] = labControls[0] as Label ?? new Label();
					} 
					else if(labControls[0] is LinkLabel)
					{
						labDataCaption[i] = labControls[0] as LinkLabel ?? new LinkLabel();
					}
				}
				
				if(labDataCaption[i] == null)
				{				
					labDataCaption[i] = new Label();
					labDataCaption[i].AutoSize = true;
				}
				
				labDataCaption[i].Name = "labData_" + i;
					
				if (Regex.IsMatch(lData.ToArray()[i], @"^[a-zäöüßA-ZÄÖÜ0-9_-]{1,}[a-zA-Z0-9_\-\.]*[a-zäöüßA-ZÄÖÜ0-9_-]{1,}@[a-zäöüA-ZÄÖÜ0-9_\-\.]{2,}\.[a-zäöü]{2,4}$")) {
					string[] pattern = {"ä","ö","ü","ß"};
					string[] replace = {"ae","oe","ue","ss"};
					
					if (Regex.IsMatch(lData.ToArray()[i], @"[äöüßÄÖÜ]{1,}")) {
						for (int r = 0; r < 4; r++) {
							lData[i] = Regex.Replace(lData.ToArray()[i], pattern[r], replace[r]);
						}
					}
					
					if(!(labDataCaption[i] is LinkLabel))
					{
						//Image Liste für Email Symbol erstellen, Symbol aus Resource nutzen. Symbolgröße anpassen
						ImageList imgList;
						imgList = new ImageList();

						var bmpMail = new Bitmap(Resource.mail_view);
						imgList.Images.Add(bmpMail);
						imgList.ImageSize = new Size(16, 16);
						//#####
					  	Controls.RemoveByKey("labData_"+i);
						labDataCaption[i] = new LinkLabel();
						labDataCaption[i].Name = "labData_" + i;
						Controls.Add(labDataCaption[i]);
				    	labDataCaption[i].Click += linkLabelEMailTo_Click;
				    	labDataCaption[i].ContextMenuStrip = ctxMailOptions;
				    	labDataCaption[i].ImageList = imgList;
				    	labDataCaption[i].ImageIndex = 0;
						labDataCaption[i].TextAlign = ContentAlignment.MiddleRight; 
						labDataCaption[i].FlatStyle = FlatStyle.Flat;
				    	labDataCaption[i].AutoEllipsis = true;
						labDataCaption[i].ImageAlign = ContentAlignment.MiddleLeft;
						labDataCaption[i].Height = 18;
					}
				}
				
				labDataCaption[i].Text = lData != null ? lData.ToArray()[i] : "Keine Daten gefunden";
				
				iMaxWidth = iMaxWidth > labDataCaption[i].PreferredWidth ? iMaxWidth : labDataCaption[i].PreferredWidth;
            }
			
			iMaxWidth = iMaxWidth+15 > Width/2 ? Width/2 : iMaxWidth;
			
			int c = 0;
			//
			//	MArgin, Padding und Position jedes Datenlabels anpassen
			//
			foreach (Label labTmp in labDataCaption) {
				labTmp.Padding = labTmp.ImageIndex >= 0 ? new Padding(20,0,0,0) : new Padding(0);;
				labTmp.Margin = new Padding(3);
				labTmp.Location = c > 0 ? new Point(labPos.X-iMaxWidth, labDataCaption[c-1].Location.Y + 18) : new Point(labPos.X-iMaxWidth, labPos.Y + 15*c);
				c++;
			}
			//	####
			
			//
			//	Setzen der Indizes für die Steuerung der Anzeige
			//
			maxDataSet = dataList.Count-1;
			currDataSet = Index;
			tsButtNextSet.Tag = currDataSet +1 <= maxDataSet ? currDataSet +1 : maxDataSet;
			tsButtPrevSet.Tag = currDataSet -1 >= 0 ?currDataSet -1 : 0;
			tsButtFirstSet.Tag = 0;
			tsButtLastSet.Tag = maxDataSet;
			tsDataIndex.Text = string.Format("{0} / {1}", currDataSet+1, maxDataSet+1);
			
			tsButtFirstSet.Enabled = currDataSet > 0;
			tsButtPrevSet.Enabled = currDataSet > 0;
			tsButtNextSet.Enabled = maxDataSet >= currDataSet+1;
			tsButtLastSet.Enabled = maxDataSet > currDataSet;
			
			//	####
			
    		this.Controls.AddRange(labCaptionList);
    		this.Controls.AddRange(labDataCaption);
		}
		
		void linkLabelEMailTo_Click(object sender, EventArgs e)
		{
			object tsmi;
			object parent = null;
			string recipient = "";
			int iMailIndex = -1;
			
			if((tsmi = sender as ToolStripMenuItem) != null)
			{
				parent = ((ToolStripMenuItem)tsmi).GetCurrentParent(); //.Parent;
				((ContextMenuStrip)parent).SourceControl.Text;
				parent = ((Control)parent).GetContainerControl();
//				((ToolStripMenuItem)tsmi).GetCurrentParent().GetContainerControl();
				recipient = ((LinkLabel)parent).Text ?? string.Empty;;
				iMailIndex = Convert.ToInt32(((LinkLabel)parent).Tag);
			}
	
			if((tsmi = sender as LinkLabel) != null)
			{
				parent = ((LinkLabel)sender);
				recipient = ((LinkLabel)parent).Text;
				iMailIndex = 0; //Convert.ToInt32(((LinkLabel)parent).Tag);
			}
			
			if(!string.IsNullOrWhiteSpace(recipient))
			{
				//prüfen auf gültige EMail Adresse und ersetzen von Umlauten
				if (Regex.IsMatch(recipient, @"^[a-zäöüßA-ZÄÖÜ0-9_-]{1,}[a-zA-Z0-9_\-\.]*[a-zäöüßA-ZÄÖÜ0-9_-]{1,}@[a-zäöüA-ZÄÖÜ0-9_\-\.]{2,}\.[a-zäöü]{2,4}$")) {
					string[] pattern = {"ä","ö","ü","ß"};
					string[] replace = {"ae","oe","ue","ss"};
					
					if (Regex.IsMatch(recipient, @"[äöüßÄÖÜ]{1,}")) {
						for (int r = 0; r < 4; r++) {
							recipient = Regex.Replace(recipient, pattern[r], replace[r]);
						}
					}
//					ProcessStartInfo psi = new ProcessStartInfo();
//					psi.FileName = "";
//					psi.Verb = "Open";
//					psi.UseShellExecute = false;
//					psi.Arguments = "mailto:" + string.Format("{0}?cc={1}&subject={2}&body={3}",recipient, mailITSD, mailSubjects[iMailIndex] ?? "", mailBodys[iMailIndex] ?? "");
					string tmp = string.Format("mailto:{0}?cc={1}&subject={2}&body={3}",recipient, mailITSD, mailSubjects[iMailIndex] ?? "''", mailBodys[iMailIndex] ?? "''");
					
					tmp = Regex.Replace(tmp, " ", "%20");
//					Process.Start(string.Format("mailto:{0}?subject={2}&cc={1}&body={3}",recipient, mailITSD, mailSubjects[iMailIndex] ?? "", mailBodys[iMailIndex] ?? ""));
					Process.Start(tmp);
					
//					Process.Start(string.Format("mailto:someone@example.com?subject=This%20is%20the%20subject&cc=someone_else@example.com&body=This%20is%20the%20body"));
				}
			}
		}
		void closeDataForm_Click(object sender, EventArgs e)
		{
			Close();
		}
		void tsButtFirstSet_Click(object sender, EventArgs e)
		{
			displayResult(0);
		}
		void tsButtPrevSet_Click(object sender, EventArgs e)
		{
			displayResult(currDataSet-1);
		}
		void tsButtNextSet_Click(object sender, EventArgs e)
		{
			displayResult(currDataSet+1);
		}
		void tsButtLastSet_Click(object sender, EventArgs e)
		{
			displayResult(maxDataSet);
		}
		void tsTextSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				//Suche ausführen und Ergebnis anzeigen.
				ToolStripTextBox miTB = null;

				if((miTB = sender as ToolStripTextBox) != null)
				{				
					//ToolsFenster für Such Ergebnisse
					#region ToolWindow
					Properties.Application.Default.Reload();
					string strFileName = Properties.Application.Default.sourceFile;
					
					this.Show();	
					
					if (!ReadCsv(miTB.Text, strFileName))
					{
						MessageBox.Show("Es wurden keine Ergebnisse mit der Suche gefunden");
						return;
					}

					this.Location =  new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width-5, Screen.PrimaryScreen.WorkingArea.Height - this.Height-5);
					this.Focus();
					#endregion
				}
			}
		}
		void tsMainView_Click(object sender, EventArgs e)
		{
			if(NotificationIcon.notificationMenu != null)
			//Hauptfenster der Anwendung anzeigen
			if (NotificationIcon.mf.IsDisposed || NotificationIcon.mf == null) {
				NotificationIcon.mf = new MainForm();
			}
			
			ToolStripItem mI = sender as ToolStripItem;
			
			if (mI != null && NotificationIcon.mf != null) {
				//if (!(bool)mI.Tag) {
					NotificationIcon.mf.ShowInTaskbar = true;
					mI.Tag = true;
					NotificationIcon.mf.Show();
					//mI.Tag = false;
//				} else {
//					NotificationIcon.mf.Hide();
//					NotificationIcon.mf.ShowInTaskbar = false;
//					mI.Tag = false;
//				}
			}
		}
	}
}
