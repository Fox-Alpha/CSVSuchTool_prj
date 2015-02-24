/*
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
			this.tsShortNotesFirstEntry = new System.Windows.Forms.ToolStripButton();
			this.tsShortNotesPrevEntry = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tsShortNotesNextEntry = new System.Windows.Forms.ToolStripButton();
			this.tsShortNotesLastEntry = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsShortNotesClose = new System.Windows.Forms.ToolStripButton();
			this.tsShortNotesLoadTemplate = new System.Windows.Forms.ToolStripDropDownButton();
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
			this.tsShortNotesFirstEntry,
			this.tsShortNotesPrevEntry,
			this.toolStripLabel1,
			this.tsShortNotesNextEntry,
			this.tsShortNotesLastEntry,
			this.toolStripSeparator2,
			this.tsShortNotesClose,
			this.tsShortNotesLoadTemplate});
			this.toolStripShortNotes.Location = new System.Drawing.Point(3, 0);
			this.toolStripShortNotes.Name = "toolStripShortNotes";
			this.toolStripShortNotes.Size = new System.Drawing.Size(422, 25);
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
			this.neuToolStripButton.Click += new System.EventHandler(this.neuToolStripButton_Click);
			// 
			// öffnenToolStripButton
			// 
			this.öffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.öffnenToolStripButton.Enabled = false;
			this.öffnenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripButton.Image")));
			this.öffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.öffnenToolStripButton.Name = "öffnenToolStripButton";
			this.öffnenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.öffnenToolStripButton.Text = "Ö&ffnen";
			this.öffnenToolStripButton.Click += new System.EventHandler(this.öffnenToolStripButton_Click);
			// 
			// speichernToolStripButton
			// 
			this.speichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.speichernToolStripButton.Enabled = false;
			this.speichernToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripButton.Image")));
			this.speichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.speichernToolStripButton.Name = "speichernToolStripButton";
			this.speichernToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.speichernToolStripButton.Text = "&Speichern";
			this.speichernToolStripButton.Click += new System.EventHandler(this.speichernToolStripButton_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Enabled = false;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "toolStripButton6";
			this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
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
			this.ausschneidenToolStripButton.Click += new System.EventHandler(this.ausschneidenToolStripButton_Click);
			// 
			// kopierenToolStripButton
			// 
			this.kopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.kopierenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripButton.Image")));
			this.kopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.kopierenToolStripButton.Name = "kopierenToolStripButton";
			this.kopierenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.kopierenToolStripButton.Text = "&Kopieren";
			this.kopierenToolStripButton.Click += new System.EventHandler(this.kopierenToolStripButton_Click);
			// 
			// einfügenToolStripButton
			// 
			this.einfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.einfügenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripButton.Image")));
			this.einfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.einfügenToolStripButton.Name = "einfügenToolStripButton";
			this.einfügenToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.einfügenToolStripButton.Text = "&Einfügen";
			this.einfügenToolStripButton.Click += new System.EventHandler(this.einfügenToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsShortNotesFirstEntry
			// 
			this.tsShortNotesFirstEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesFirstEntry.Enabled = false;
			this.tsShortNotesFirstEntry.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesFirstEntry.Image")));
			this.tsShortNotesFirstEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesFirstEntry.Name = "tsShortNotesFirstEntry";
			this.tsShortNotesFirstEntry.Size = new System.Drawing.Size(23, 22);
			this.tsShortNotesFirstEntry.Text = "toolStripButton1";
			this.tsShortNotesFirstEntry.Click += new System.EventHandler(this.tsShortNotesFirstEntry_Click);
			// 
			// tsShortNotesPrevEntry
			// 
			this.tsShortNotesPrevEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesPrevEntry.Enabled = false;
			this.tsShortNotesPrevEntry.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesPrevEntry.Image")));
			this.tsShortNotesPrevEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesPrevEntry.Name = "tsShortNotesPrevEntry";
			this.tsShortNotesPrevEntry.Size = new System.Drawing.Size(23, 22);
			this.tsShortNotesPrevEntry.Text = "toolStripButton2";
			this.tsShortNotesPrevEntry.Click += new System.EventHandler(this.tsShortNotesPrevEntry_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.AutoSize = false;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
			this.toolStripLabel1.Text = "X / Y";
			// 
			// tsShortNotesNextEntry
			// 
			this.tsShortNotesNextEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesNextEntry.Enabled = false;
			this.tsShortNotesNextEntry.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesNextEntry.Image")));
			this.tsShortNotesNextEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesNextEntry.Name = "tsShortNotesNextEntry";
			this.tsShortNotesNextEntry.Size = new System.Drawing.Size(23, 22);
			this.tsShortNotesNextEntry.Text = "toolStripButton3";
			this.tsShortNotesNextEntry.Click += new System.EventHandler(this.tsShortNotesNextEntry_Click);
			// 
			// tsShortNotesLastEntry
			// 
			this.tsShortNotesLastEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesLastEntry.Enabled = false;
			this.tsShortNotesLastEntry.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesLastEntry.Image")));
			this.tsShortNotesLastEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesLastEntry.Name = "tsShortNotesLastEntry";
			this.tsShortNotesLastEntry.Size = new System.Drawing.Size(23, 22);
			this.tsShortNotesLastEntry.Text = "toolStripButton4";
			this.tsShortNotesLastEntry.Click += new System.EventHandler(this.tsShortNotesLastEntry_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsShortNotesClose
			// 
			this.tsShortNotesClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesClose.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesClose.Image")));
			this.tsShortNotesClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesClose.Name = "tsShortNotesClose";
			this.tsShortNotesClose.Size = new System.Drawing.Size(23, 22);
			this.tsShortNotesClose.Text = "toolStripButton5";
			this.tsShortNotesClose.Click += new System.EventHandler(this.tsShortNotesClose_Click);
			// 
			// tsShortNotesLoadTemplate
			// 
			this.tsShortNotesLoadTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsShortNotesLoadTemplate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.textEditorToolStripMenuItem});
			this.tsShortNotesLoadTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsShortNotesLoadTemplate.Image")));
			this.tsShortNotesLoadTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsShortNotesLoadTemplate.Name = "tsShortNotesLoadTemplate";
			this.tsShortNotesLoadTemplate.Size = new System.Drawing.Size(29, 20);
			this.tsShortNotesLoadTemplate.Text = "toolStripDropDownButton1";
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
			this.Shown += new System.EventHandler(this.ShortNotesForm_Shown);
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
		private System.Windows.Forms.ToolStripDropDownButton tsShortNotesLoadTemplate;
		private System.Windows.Forms.ToolStripMenuItem textEditorToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTipShortNotes;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsShortNotesClose;
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
		private System.Windows.Forms.ToolStripButton tsShortNotesFirstEntry;
		private System.Windows.Forms.ToolStripButton tsShortNotesPrevEntry;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton tsShortNotesNextEntry;
		private System.Windows.Forms.ToolStripButton tsShortNotesLastEntry;
		private System.Windows.Forms.ToolStripContainer tsContainer;
	}
}
