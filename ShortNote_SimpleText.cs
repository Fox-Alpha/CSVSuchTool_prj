/*
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
	}
}
