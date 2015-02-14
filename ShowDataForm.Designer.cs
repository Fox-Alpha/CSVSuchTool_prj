/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 16.12.2014
 * Zeit: 15:30
 * 
 */
namespace AC_Telefonbuch
{
	partial class ShowDataForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDataForm));
			this.tsNavigation = new System.Windows.Forms.ToolStrip();
			this.tsButtFirstSet = new System.Windows.Forms.ToolStripButton();
			this.tsButtPrevSet = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsDataIndex = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsButtNextSet = new System.Windows.Forms.ToolStripButton();
			this.tsButtLastSet = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsButtClose = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsMainView = new System.Windows.Forms.ToolStripButton();
			this.tsTextSearch = new System.Windows.Forms.ToolStripTextBox();
			this.tsNavigation.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsNavigation
			// 
			this.tsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsButtFirstSet,
			this.tsButtPrevSet,
			this.toolStripSeparator1,
			this.tsDataIndex,
			this.toolStripSeparator3,
			this.tsButtNextSet,
			this.tsButtLastSet,
			this.toolStripSeparator2,
			this.tsButtClose});
			this.tsNavigation.Location = new System.Drawing.Point(0, 0);
			this.tsNavigation.Name = "tsNavigation";
			this.tsNavigation.Size = new System.Drawing.Size(264, 25);
			this.tsNavigation.TabIndex = 3;
			this.tsNavigation.Text = "toolStrip1";
			// 
			// tsButtFirstSet
			// 
			this.tsButtFirstSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtFirstSet.Image = ((System.Drawing.Image)(resources.GetObject("tsButtFirstSet.Image")));
			this.tsButtFirstSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtFirstSet.Name = "tsButtFirstSet";
			this.tsButtFirstSet.Size = new System.Drawing.Size(23, 22);
			this.tsButtFirstSet.Tag = "0";
			this.tsButtFirstSet.Text = "Zum ersten Datensatz springen";
			this.tsButtFirstSet.Click += new System.EventHandler(this.tsButtFirstSet_Click);
			// 
			// tsButtPrevSet
			// 
			this.tsButtPrevSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtPrevSet.Image = ((System.Drawing.Image)(resources.GetObject("tsButtPrevSet.Image")));
			this.tsButtPrevSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtPrevSet.Name = "tsButtPrevSet";
			this.tsButtPrevSet.Size = new System.Drawing.Size(23, 22);
			this.tsButtPrevSet.Text = "Zum vorherigen Datensatz springen";
			this.tsButtPrevSet.Click += new System.EventHandler(this.tsButtPrevSet_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsDataIndex
			// 
			this.tsDataIndex.AutoSize = false;
			this.tsDataIndex.Name = "tsDataIndex";
			this.tsDataIndex.Size = new System.Drawing.Size(85, 22);
			this.tsDataIndex.Text = "X / Y";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsButtNextSet
			// 
			this.tsButtNextSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtNextSet.Image = ((System.Drawing.Image)(resources.GetObject("tsButtNextSet.Image")));
			this.tsButtNextSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtNextSet.Name = "tsButtNextSet";
			this.tsButtNextSet.Size = new System.Drawing.Size(23, 22);
			this.tsButtNextSet.Text = "Zum nächsten Datensatz springen";
			this.tsButtNextSet.Click += new System.EventHandler(this.tsButtNextSet_Click);
			// 
			// tsButtLastSet
			// 
			this.tsButtLastSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtLastSet.Image = ((System.Drawing.Image)(resources.GetObject("tsButtLastSet.Image")));
			this.tsButtLastSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtLastSet.Name = "tsButtLastSet";
			this.tsButtLastSet.Size = new System.Drawing.Size(23, 22);
			this.tsButtLastSet.Text = "Zum letzten Datensatz springen";
			this.tsButtLastSet.Click += new System.EventHandler(this.tsButtLastSet_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsButtClose
			// 
			this.tsButtClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsButtClose.Image = ((System.Drawing.Image)(resources.GetObject("tsButtClose.Image")));
			this.tsButtClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsButtClose.Name = "tsButtClose";
			this.tsButtClose.Size = new System.Drawing.Size(23, 22);
			this.tsButtClose.Text = "Fenster Schließen";
			this.tsButtClose.Click += new System.EventHandler(this.closeDataForm_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsMainView,
			this.tsTextSearch});
			this.toolStrip1.Location = new System.Drawing.Point(0, 173);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(264, 25);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsMainView
			// 
			this.tsMainView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsMainView.Image = ((System.Drawing.Image)(resources.GetObject("tsMainView.Image")));
			this.tsMainView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsMainView.Name = "tsMainView";
			this.tsMainView.Size = new System.Drawing.Size(124, 22);
			this.tsMainView.Text = "Haupfenser Anzeigen";
			this.tsMainView.Click += new System.EventHandler(this.tsMainView_Click);
			// 
			// tsTextSearch
			// 
			this.tsTextSearch.Name = "tsTextSearch";
			this.tsTextSearch.Size = new System.Drawing.Size(100, 25);
			this.tsTextSearch.ToolTipText = "Neue Suche";
			this.tsTextSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsTextSearch_KeyUp);
			// 
			// ShowDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(5, 0);
			this.ClientSize = new System.Drawing.Size(264, 198);
			this.ControlBox = false;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tsNavigation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 200);
			this.Name = "ShowDataForm";
			this.ShowInTaskbar = false;
			this.tsNavigation.ResumeLayout(false);
			this.tsNavigation.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsMainView;
		private System.Windows.Forms.ToolStripTextBox tsTextSearch;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStrip tsNavigation;
		private System.Windows.Forms.ToolStripButton tsButtFirstSet;
		private System.Windows.Forms.ToolStripButton tsButtPrevSet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tsDataIndex;
		private System.Windows.Forms.ToolStripButton tsButtNextSet;
		private System.Windows.Forms.ToolStripButton tsButtLastSet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsButtClose;
	}
}
