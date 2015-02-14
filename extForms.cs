/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 10.07.2014
 * Zeit: 11:15
 * 
 */
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ExtendedForms
{
	/// <summary>
	/// Description of extForms.
	/// </summary>
	public class extForms
	{
		string _strTitel;
		
		public enum exFormOptions
		{
			DameWarePfad,
			HostListe,
			None
		};
		
		public string strTitel {
			get { return _strTitel; }
			set { _strTitel = value; }
		}
		
		string _strFileFilter;
		
		public string strFileFilter {
			get { return _strFileFilter; }
			set { _strFileFilter = value; }
		}
		
		/// <summary>
		/// ctor
		/// </summary>
		/// <param name="eFo">Option für die Vorbelegung</param>
		public extForms(exFormOptions eFo)
		{
			switch (eFo) 
			{
				case exFormOptions.DameWarePfad:
					strFileFilter = "DameWare Anwendung (DWRCC.exe)|DWRCC.exe";
					strTitel = "DameWare Mini Remote Control";
					break;
				
				case exFormOptions.HostListe:
					strFileFilter = "Hostliste (*.txt)|*.txt";
					strTitel = "Datei mit Zeilenbasierter Hostliste";
					break;

				case exFormOptions.None:
					strFileFilter = "Datei auswählen (*.*)|*.*";
					strTitel = "Datei Auswählen";
					break;
			}
		}
		/// <summary>
		/// Eingabedialog mit Dateiauswahldialog
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public DialogResult ShowInputDialog(ref string input)
	    {
	        System.Drawing.Size size = new System.Drawing.Size(300, 70);
	        Form inputBox = new Form();
	
	        inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
	        inputBox.ClientSize = size;
	        inputBox.Text = strTitel;
	
	        System.Windows.Forms.TextBox textBox = new TextBox();
	        textBox.Size = new System.Drawing.Size(size.Width - 100, 23);
	        textBox.Location = new System.Drawing.Point(5, 5);
	        textBox.Text = input;
	        inputBox.Controls.Add(textBox);
			
			FileDialog fd = new OpenFileDialog();
			fd.CheckFileExists = true;
			fd.Filter = strFileFilter;
	
	        Button okButton = new Button();
	        okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
	        okButton.Name = "okButton";
	        okButton.Size = new System.Drawing.Size(75, 23);
	        okButton.Text = "&Speichern";
	        okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
	        inputBox.Controls.Add(okButton);
	
	        Button cancelButton = new Button();
	        cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
	        cancelButton.Name = "cancelButton";
	        cancelButton.Size = new System.Drawing.Size(75, 23);
	        cancelButton.Text = "A&brechen";
	        cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
	        inputBox.Controls.Add(cancelButton);
			
	        Button chooseButton = new Button();
	        //chooseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
	        chooseButton.Name = "chooseButton";
	        chooseButton.Size = new System.Drawing.Size(75, 23);
	        chooseButton.Text = "D&urchsuchen";
	        chooseButton.Location = new System.Drawing.Point(size.Width - 80, 5);
			
			chooseButton.Click += delegate(object sender, EventArgs e) {
				if(fd.ShowDialog() == DialogResult.OK)
					textBox.Text = fd.FileName;
			};
			
	        inputBox.Controls.Add(chooseButton);
			
	        
	        inputBox.CancelButton = cancelButton;
			
			if(!string.IsNullOrWhiteSpace(input))
				textBox.Text = input;
			
	        DialogResult result = inputBox.ShowDialog();
	        input = textBox.Text;
	        inputBox.Dispose();
	        
	        return result;
	    }
		
		/// <summary>
		/// Info Dialog für die Anwendung
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public DialogResult ShowInfoDialog()
		{
			//
			//	Was muss angezeigt werden ?
			//
			//	Autor
			//	Erstellungsdatum
			//	Version
	        System.Drawing.Size size = new System.Drawing.Size(250, 250);
	        Form aboutBox = new Form();
	
	        aboutBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
	        aboutBox.ClientSize = size;
	        aboutBox.Text = "Info über ...";
			
			//Info Lables
			Label labTitle = new Label();
			//labTitle.Text = Application.ProductName.ToString();
			labTitle.Text = Application.ProductName;
			labTitle.BackColor = Color.Blue;
			labTitle.Size = new System.Drawing.Size(200, 21);
			labTitle.Location = new System.Drawing.Point(10,30);
			aboutBox.Controls.Add(labTitle);
			
			Label labVersion = new Label();
			labVersion.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			labVersion.BackColor = Color.Blue;
			labVersion.Size = new System.Drawing.Size(200, 21);
			labVersion.Location = new System.Drawing.Point(10,50);
			aboutBox.Controls.Add(labVersion);

			Label labCopy = new Label();
			labCopy.Text = "Copyright: Dirk Buck,(c) 2014";
			labCopy.BackColor = Color.Blue;
			labCopy.Size = new System.Drawing.Size(200, 21);
			labCopy.Location = new System.Drawing.Point(10, 70);
			aboutBox.Controls.Add(labCopy);
			
			Label labDescr = new Label();
			labDescr.Text = "Vereinfachen der täglichen Routine";
			labDescr.BackColor = Color.Blue;
			labDescr.Size = new System.Drawing.Size(200, 21);
			labDescr.Location = new System.Drawing.Point(10, 90);
			aboutBox.Controls.Add(labDescr);
			
	        Button okButton = new Button();
	        okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
	        okButton.Name = "okButton";
	        okButton.Size = new System.Drawing.Size(80, 24);
	        okButton.Text = "&Schließen";
	        okButton.Location = new System.Drawing.Point(aboutBox.ClientSize.Width / 2 -40, aboutBox.ClientSize.Height - 45);
	        aboutBox.Controls.Add(okButton);

			DialogResult result = aboutBox.ShowDialog();
	        
	        aboutBox.Dispose();
	        
	        return result;
		}

	}
}
