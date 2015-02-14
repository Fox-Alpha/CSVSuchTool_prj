/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 12.06.2014
 * Zeit: 14:37
 * 
 */
namespace AC_Telefonbuch
{
	partial class FrmLogView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.rtbLogView = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbLogView
			// 
			this.rtbLogView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbLogView.Location = new System.Drawing.Point(0, 0);
			this.rtbLogView.Name = "rtbLogView";
			this.rtbLogView.ReadOnly = true;
			this.rtbLogView.Size = new System.Drawing.Size(884, 762);
			this.rtbLogView.TabIndex = 0;
			this.rtbLogView.Text = "";
			// 
			// FrmLogView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 762);
			this.Controls.Add(this.rtbLogView);
			this.Name = "FrmLogView";
			this.Text = "Changelog";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogView_FormClosing);
			this.Load += new System.EventHandler(this.FrmLogView_Load);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.RichTextBox rtbLogView;
	}
}
