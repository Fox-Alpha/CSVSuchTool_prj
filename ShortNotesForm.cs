/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 18.02.2015
 * Zeit: 14:44
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace CSVSuchTool
{
	/// <summary>
	/// Description of ShortNotesForm.
	/// </summary>
	public partial class ShortNotesForm : Form
	{
		//	####
		#region Properties

		string _currentTemplateName;
		
		public string currentTemplateName {
			get { return _currentTemplateName; }
			set { _currentTemplateName = value; }
		}
		
		bool _templateLoaded;
		
		public bool templateLoaded {
			get { return _templateLoaded; }
			set { _templateLoaded = value; }
		}
		
		UserControl ucEditor = null;
		
		#endregion Properties
		//	####
		
		//	####
		#region Formular Funktionen und Events
		public ShortNotesForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			templateLoaded = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/// <summary>
		/// Anzeige des Formulares
		/// Wenn kein Template geladen wurde, dann den SimpleEditor laden
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ShortNotesForm_Shown(object sender, EventArgs e)
		{
			if (ucEditor == null) 
			{
				ucEditor = new cptShortNote_SimpleText();
				ucEditor.Dock = DockStyle.Fill;
//				ucEditor.Parent = this;
//				this.AddOwnedForm(ucEditor);
				this.Controls.Add(ucEditor);
				
				if (ucEditor.Tag.ToString() != string.Empty) 
				{
					currentTemplateName = ucEditor.Tag.ToString().Split('|')[0] ?? "";
					this.Text += ucEditor.Tag.ToString().Split('|')[1] ?? "";
				
					templateLoaded = true;
					
					Rectangle clrec = this.ClientRectangle;
					
					ucEditor.SetBounds(clrec.X, clrec.Y, clrec.Width, clrec.Height);
					
//					ucEditor.Location.X = ;
//					ucEditor.Location.Y = Y;
//					ucEditor.Size.Width = ;
//					ucEditor.Size.Height = ;
				}
					
				}
			}
		
		
		#endregion Formular Funktionen und Events
		//	####
		
		//	####
		#region	Editortemplates
		
		//TODO: MenuItems Dynamisch nach Verfügbarkeit anlegen
		//		Templates eventuell als dll bereitstellen
		/// <summary>
		/// Template Kompnente für den einfachen Editor laden und Anzeigen.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void textEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ucEditor != null && (!ucEditor.IsDisposed || !ucEditor.Disposing)) {
				this.Controls.Remove(ucEditor);
				ucEditor.Dispose();
				templateLoaded = false;
			}
			ucEditor = new cptShortNote_SimpleText();
//			ucEditor.Dock = DockStyle.Fill;
			templateLoaded = true;
		}
		void ShortNotesForm_ClientSizeChanged(object sender, EventArgs e)
		{
			if (ucEditor == null) 
			{
				ucEditor = new cptShortNote_SimpleText();
//				ucEditor.Dock = DockStyle.Fill;
				this.Controls.Add(ucEditor);
				
				if (ucEditor.Tag.ToString() != string.Empty) 
				{
					templateLoaded = true;
					
					Rectangle clrec = this.ClientRectangle;
					
					ucEditor.SetBounds(clrec.X, clrec.Y, clrec.Width, clrec.Height);
					
//					ucEditor.Location.X = ;
//					ucEditor.Location.Y = Y;
//					ucEditor.Size.Width = ;
//					ucEditor.Size.Height = ;
					
				}
			}
		}
	
		#endregion Editortemplates
		//	####
	}
}
