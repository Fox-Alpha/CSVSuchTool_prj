﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 18.02.2015
 * Zeit: 14:44
 * 
 */
namespace CSVSuchTool
{
	partial class ShortNotesForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortNotesForm));
			this.statusStripShortNotes = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTipShortNotes = new System.Windows.Forms.ToolTip(this.components);
			this.tsContainer = new System.Windows.Forms.ToolStripContainer();
			this.toolStripShortNotes = new System.Windows.Forms.ToolStrip();
			this.neuToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.öffnenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.speichernToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ausschneidenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.kopierenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.einfügenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.textEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripShortNotes.SuspendLayout();
			this.tsContainer.TopToolStripPanel.SuspendLayout();
			this.tsContainer.SuspendLayout();
			this.toolStripShortNotes.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStripShortNotes
			// 
			this.statusStripShortNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabel2});
			this.statusStripShortNotes.Location = new System.Drawing.Point(0, 331);
			this.statusStripShortNotes.Name = "statusStripShortNotes";
			this.statusStripShortNotes.Size = new System.Drawing.Size(425, 22);
			this.statusStripShortNotes.TabIndex = 0;
			this.statusStripShortNotes.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
			this.toolStripStatusLabel1.Text = "Notiz für: NAME";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
			this.toolStripStatusLabel2.Text = "TT.MM-JJJ HH:MM";
			// 
			// toolTipShortNotes
			// 
			this.toolTipShortNotes.IsBalloon = true;
			this.toolTipShortNotes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipShortNotes.ToolTipTitle = "Kurznotizen";
			// 
			// tsContainer
			// 
			this.tsContainer.BottomToolStripPanelVisible = false;
			// 
			// tsContainer.ContentPanel
			// 
			this.tsContainer.ContentPanel.Size = new System.Drawing.Size(425, 306);
			this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tsContainer.LeftToolStripPanelVisible = false;
			this.tsContainer.Location = new System.Drawing.Point(0, 0);
			this.tsContainer.Name = "tsContainer";
			this.tsContainer.RightToolStripPanelVisible = false;
			this.tsContainer.Size = new System.Drawing.Size(425, 331);
			this.tsContainer.TabIndex = 2;
			this.tsContainer.Text = "toolStripContainer1";
			// 
			// tsContainer.TopToolStripPanel
			// 
			this.tsContainer.TopToolStripPanel.Controls.Add(this.toolStripShortNotes);
			// 
			// toolStripShortNotes
			// 
			this.toolStripShortNotes.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripShortNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.neuToolStripButton,
			this.öffnenToolStripButton,
			this.speichernToolStripButton,
			this.toolStripButton6,
			this.toolStripSeparator,
			this.ausschneidenToolStripButton,
			this.kopierenToolStripButton,
			this.einfügenToolStripButton,
			this.toolStripSeparator1,
			this.toolStripButton1,
			this.toolStripButton2,
			this.toolStripLabel1,
			this.toolStripButton3,
			this.toolStripButton4,
			this.toolStripSeparator2,
			this.toolStripButton5,
			this.toolStripDropDownButton1});
			this.toolStripShortNotes.Location = new System.Drawing.Point(3, 0);
			this.toolStripShortNotes.Name = "toolStripShortNotes";
			this.toolStripShortNotes.Size = new System.Drawing.Size(420, 25);
			this.toolStripShortNotes.TabIndex = 5;
			this.toolStripShortNotes.Text = "toolStrip1";
			// 
			// neuToolStripButton
			// 
			this.neuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.neuToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripButton.Image")));
			this.neuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.neuToolStripButton.Name = "neuToolStripButton";
			this.neuToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.neuToolStripButton.Text = "&Neu";
			// 
			// öffnenToolStripButton
			// 
			this.öffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.öffnenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripButton.Image")));
			this.öffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.öffnenToolStripButton.Name = "öffnenToolStripButton";
			this.öffnenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.öffnenToolStripButton.Text = "Ö&ffnen";
			// 
			// speichernToolStripButton
			// 
			this.speichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.speichernToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripButton.Image")));
			this.speichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.speichernToolStripButton.Name = "speichernToolStripButton";
			this.speichernToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.speichernToolStripButton.Text = "&Speichern";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "toolStripButton6";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// ausschneidenToolStripButton
			// 
			this.ausschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ausschneidenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ausschneidenToolStripButton.Image")));
			this.ausschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ausschneidenToolStripButton.Name = "ausschneidenToolStripButton";
			this.ausschneidenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.ausschneidenToolStripButton.Text = "&Ausschneiden";
			// 
			// kopierenToolStripButton
			// 
			this.kopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.kopierenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripButton.Image")));
			this.kopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.kopierenToolStripButton.Name = "kopierenToolStripButton";
			this.kopierenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.kopierenToolStripButton.Text = "&Kopieren";
			// 
			// einfügenToolStripButton
			// 
			this.einfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.einfügenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripButton.Image")));
			this.einfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.einfügenToolStripButton.Name = "einfügenToolStripButton";
			this.einfügenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.einfügenToolStripButton.Text = "&Einfügen";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.AutoSize = false;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
			this.toolStripLabel1.Text = "X / Y";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.textEditorToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// textEditorToolStripMenuItem
			// 
			this.textEditorToolStripMenuItem.Name = "textEditorToolStripMenuItem";
			this.textEditorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.textEditorToolStripMenuItem.Text = "Text Editor";
			this.textEditorToolStripMenuItem.ToolTipText = "Ein einfacher Text Editor";
			this.textEditorToolStripMenuItem.Click += new System.EventHandler(this.textEditorToolStripMenuItem_Click);
			// 
			// ShortNotesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 353);
			this.Controls.Add(this.tsContainer);
			this.Controls.Add(this.statusStripShortNotes);
			this.Icon = global::CSVSuchTool.Resource.DBSoft;
			this.Name = "ShortNotesForm";
			this.Text = "Kurznotizen";
			this.statusStripShortNotes.ResumeLayout(false);
			this.statusStripShortNotes.PerformLayout();
			this.tsContainer.TopToolStripPanel.ResumeLayout(false);
			this.tsContainer.TopToolStripPanel.PerformLayout();
			this.tsContainer.ResumeLayout(false);
			this.tsContainer.PerformLayout();
			this.toolStripShortNotes.ResumeLayout(false);
			this.toolStripShortNotes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem textEditorToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTipShortNotes;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.StatusStrip statusStripShortNotes;
		private System.Windows.Forms.ToolStrip toolStripShortNotes;
		private System.Windows.Forms.ToolStripButton neuToolStripButton;
		private System.Windows.Forms.ToolStripButton öffnenToolStripButton;
		private System.Windows.Forms.ToolStripButton speichernToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton ausschneidenToolStripButton;
		private System.Windows.Forms.ToolStripButton kopierenToolStripButton;
		private System.Windows.Forms.ToolStripButton einfügenToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripContainer tsContainer;
	}
}
