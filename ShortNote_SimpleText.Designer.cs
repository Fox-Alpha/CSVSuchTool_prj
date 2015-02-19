/*
 * Created by SharpDevelop.
 * User: buck
 * Date: 19.02.2015
 * Time: 13:10
 * 
 */
namespace CSVSuchTool
{
	partial class cptShortNote_SimpleText
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtbShortNoteText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbShortNoteText
			// 
			this.rtbShortNoteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbShortNoteText.Location = new System.Drawing.Point(0, 0);
			this.rtbShortNoteText.Name = "rtbShortNoteText";
			this.rtbShortNoteText.Size = new System.Drawing.Size(484, 388);
			this.rtbShortNoteText.TabIndex = 0;
			this.rtbShortNoteText.Text = "";
			// 
			// cptShortNote_SimpleText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.rtbShortNoteText);
			this.Name = "cptShortNote_SimpleText";
			this.Size = new System.Drawing.Size(484, 388);
			this.Tag = "cptShortNote_SimpleText|Simple Note";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.RichTextBox rtbShortNoteText;
	}
}
