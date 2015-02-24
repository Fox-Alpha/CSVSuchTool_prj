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
		
		public cptShortNotes_EMailNote()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/// <summary>
		/// Initializieren der Felder Belegungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void cptShortNotes_EMailNote_Load(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
			labTimeDate.Text = string.Format("{0}", DateTime.Now.ToShortDateString());
			
			tbIncidentNo.Text = string.Format("{0:yyyyMMdd}-0000", DateTime.Today);
		}
		
		public void cptShortNotes_EMailNote_Reset()
		{
			
		}
	}
}
