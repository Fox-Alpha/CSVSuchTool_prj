/*
 * Created by SharpDevelop.
 * User: buck
 * Date: 24.02.2015
 * Time: 12:40
 * 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ExtendedForms;

namespace CSVSuchTool
{
	/// <summary>
	/// Description of cptShortNotes_EMailNote.
	/// </summary>
	public partial class cptShortNotes_EMailNote : UserControl
	{
		public static bool canSendMail = true;
		
//		public bool canSendMail {
//			get { return _canSendMail; }
//			//set { _canSendMail = value; }
//		}
		
		string _recipient;
		
		public string recipient {
			get { return _recipient; }
			set { _recipient = value; }
		}
		
		public cptShortNotes_EMailNote()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			recipient = "";
		}
		
		/// <summary>
		/// Initializieren der Felder Belegungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void cptShortNotes_EMailNote_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			labTimeDate.Text = string.Format("{0}", DateTime.Now.ToString());
			
			tbIncidentNo.Text = string.Format("{0:yyyyMMdd}-0000", DateTime.Today);
		}
		
		public void cptShortNotes_EMailNote_Reset()
		{
			labTimeDate.Text = string.Format("{0}", DateTime.Now.ToString());
			
			tbIncidentNo.Text = string.Format("{0:yyyyMMdd}-0000", DateTime.Today);
			
			cbIncidentNo.Checked = false;
			
			rbMann.Checked = false;
			rbFrau.Checked = false;
			
			cbJobNo.Checked = false;
			cbDwSysNo.Checked = false;
			
			tbAnrufer.Text = "";
			tbDwSysNo.Text = "";
			tbJobNo.Text = "";
			tbTelefonNo.Text = "";
			tbFirma.Text = "";
		}
		
		//
		//	Anrede auswählen
		//
		void rbMann_CheckedChanged(object sender, EventArgs e)
		{
			rbFrau.Checked = !rbMann.Checked;
		}
		void rbFrau_CheckedChanged(object sender, EventArgs e)
		{
			rbMann.Checked = !rbFrau.Checked;
		}
		
		/// <summary>
		/// Aktivieren der Incident Nummer Eingabe
		/// Automatich senden an IT-SD in CC, wenn Empfänger.
		/// Ansonsten SD als Empfänger setzen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void cbIncidentNo_CheckedChanged(object sender, EventArgs e)
		{
			cbToServiceDesk.Checked = cbIncidentNo.Checked;
			tbIncidentNo.Enabled = cbIncidentNo.Checked;
		}
		//	####
		
		List<string> getTextForMail()
		{
			string sendTo = ""; //TODO: Wenn kein Empfänger übergeben wurde, abfrage
			string sendCC = "";
			string sendSubject = "";
			string sendBody = "";
			string lf = "%0A%0D";
			
			if (!(rbFrau.Checked || rbMann.Checked) && string.IsNullOrWhiteSpace(tbAnrufer.Text)) {
				MessageBox.Show("Bitte Anrede auswählen", "keine Anrede !");
				return null;
			}
			
			if(!string.IsNullOrWhiteSpace(recipient))
				sendTo = recipient;
			else
			{
				extForms exF = new extForms(extForms.exFormOptions.None);
				exF.strTitel = "Bitte Empfänger eingeben";
				exF.ShowInputDialog(ref sendTo);
				
				if (cbToServiceDesk.Checked) {
					sendCC = "Servicedesk@alpha-com.de";
				}
				
				sendSubject = string.Format("Anruf entgegengenommen: {0} {1}  {2}", rbFrau.Checked ? "Frau" : "Herr", tbAnrufer.Text, !string.IsNullOrWhiteSpace(tbFirma.Text) ? "/ " + tbFirma.Text: "");
				
				sendBody = string.Format("{0} {1} hat im IT-SD angerufen.{3}", rbFrau.Checked ? "Frau" : "Herr", tbAnrufer.Text,lf);
				
				if (!string.IsNullOrWhiteSpace(tbFirma.Text)) {
					sendBody = string.Format("{0}Firma: {1}{2}", sendBody, tbFirma.Text, lf);
				}
				
				if (!string.IsNullOrWhiteSpace(tbTelefonNo.Text)) {
					sendBody = string.Format("{0}Telefon: {1}{2}", sendBody, tbTelefonNo.Text, lf);
				}
				
				if (cbJobNo.Checked) {
					sendBody = string.Format("{0}JobNo: {1}{2}", sendBody, tbJobNo.Text, lf);
				}
				if (cbDwSysNo.Checked) {
					sendBody = string.Format("{0}DwSysNo: {1}{2}", sendBody, tbDwSysNo.Text, lf);
				}
			}
			
			return new List<string>(){sendTo, sendCC, sendSubject, sendBody};
		}
	}
}
