﻿/*
 * Created by SharpDevelop.
 * User: buck
 * Date: 19.02.2015
 * Time: 13:10
 * 
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CSVSuchTool
{
	/// <summary>
	/// Description of ShortNote_SimpleText.
	/// </summary>
	public partial class cptShortNote_SimpleText : UserControl
	{
		//	####
		#region Properties
		
		protected bool _canSendMail;
		
		[EditorBrowsable(EditorBrowsableState.Always)] 
		[Browsable(true)]
		[Description("Legt fest ob aus dem Control eien Mail generiert werden kann")] 
		[Category("Appearance")] 
		public bool canSendMail {
			get { return _canSendMail; }
			set { _canSendMail = value; }
		}
		
		#endregion Properties
		//	####
		
		//	####
		#region Formular Funktionen
		
		public cptShortNote_SimpleText()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CptShortNote_SimpleTextLoad(object sender, EventArgs e)
		{
			this.Dock = DockStyle.Fill;
		}
		
		/// <summary>
		/// Zurücksetzen der Templatekomponente
		/// </summary>
		public void CptShortNote_SimpleTextReset()
		{
			rtbShortNoteText.Clear();
		}
		
		#endregion Formular Funktionen
		//	####

		//	####
		#region Kontextmenu
		void CtxMenuSimpleEditorSelectAllClick(object sender, EventArgs e)
		{
	
		}
		void CtxMenuSimpleEditorKopierenClick(object sender, EventArgs e)
		{
	
		}
		void CtxMenuSimpleEditorEinfügenClick(object sender, EventArgs e)
		{
	
		}
		void CtxMenuSimpleEditorAusschneidenClick(object sender, EventArgs e)
		{
	
		}
		void CtxMenuSimpleEditorlöschenClick(object sender, EventArgs e)
		{
	
		}
		
		#endregion Kontextmenu
		//	####
	}
}
