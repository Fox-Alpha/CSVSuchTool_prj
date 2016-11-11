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
			this.components = new System.ComponentModel.Container();
			this.rtbShortNoteText = new System.Windows.Forms.RichTextBox();
			this.ctxMenuSimpleEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ctxMenuSimpleEditorSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuSimpleEditorKopieren = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuSimpleEditorEinfügen = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuSimpleEditorAusschneiden = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuSimpleEditorlöschen = new System.Windows.Forms.ToolStripMenuItem();
			this.ctxMenuSimpleEditor.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbShortNoteText
			// 
			this.rtbShortNoteText.ContextMenuStrip = this.ctxMenuSimpleEditor;
			this.rtbShortNoteText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbShortNoteText.Location = new System.Drawing.Point(0, 0);
			this.rtbShortNoteText.Name = "rtbShortNoteText";
			this.rtbShortNoteText.Size = new System.Drawing.Size(201, 179);
			this.rtbShortNoteText.TabIndex = 0;
			this.rtbShortNoteText.Text = "";
			// 
			// ctxMenuSimpleEditor
			// 
			this.ctxMenuSimpleEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ctxMenuSimpleEditorSelectAll,
			this.ctxMenuSimpleEditorKopieren,
			this.ctxMenuSimpleEditorEinfügen,
			this.ctxMenuSimpleEditorAusschneiden,
			this.ctxMenuSimpleEditorlöschen});
			this.ctxMenuSimpleEditor.Name = "ctxMenuSimpleEditor";
			this.ctxMenuSimpleEditor.Size = new System.Drawing.Size(200, 136);
			// 
			// ctxMenuSimpleEditorSelectAll
			// 
			this.ctxMenuSimpleEditorSelectAll.Name = "ctxMenuSimpleEditorSelectAll";
			this.ctxMenuSimpleEditorSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.ctxMenuSimpleEditorSelectAll.Size = new System.Drawing.Size(199, 22);
			this.ctxMenuSimpleEditorSelectAll.Text = "Alles Markieren";
			this.ctxMenuSimpleEditorSelectAll.Click += new System.EventHandler(this.CtxMenuSimpleEditorSelectAllClick);
			// 
			// ctxMenuSimpleEditorKopieren
			// 
			this.ctxMenuSimpleEditorKopieren.Name = "ctxMenuSimpleEditorKopieren";
			this.ctxMenuSimpleEditorKopieren.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.ctxMenuSimpleEditorKopieren.Size = new System.Drawing.Size(199, 22);
			this.ctxMenuSimpleEditorKopieren.Text = "Kopieren";
			this.ctxMenuSimpleEditorKopieren.Click += new System.EventHandler(this.CtxMenuSimpleEditorKopierenClick);
			// 
			// ctxMenuSimpleEditorEinfügen
			// 
			this.ctxMenuSimpleEditorEinfügen.Name = "ctxMenuSimpleEditorEinfügen";
			this.ctxMenuSimpleEditorEinfügen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.ctxMenuSimpleEditorEinfügen.Size = new System.Drawing.Size(199, 22);
			this.ctxMenuSimpleEditorEinfügen.Text = "Einfügen";
			this.ctxMenuSimpleEditorEinfügen.Click += new System.EventHandler(this.CtxMenuSimpleEditorEinfügenClick);
			// 
			// ctxMenuSimpleEditorAusschneiden
			// 
			this.ctxMenuSimpleEditorAusschneiden.Name = "ctxMenuSimpleEditorAusschneiden";
			this.ctxMenuSimpleEditorAusschneiden.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.ctxMenuSimpleEditorAusschneiden.Size = new System.Drawing.Size(199, 22);
			this.ctxMenuSimpleEditorAusschneiden.Text = "Ausschneiden";
			this.ctxMenuSimpleEditorAusschneiden.Click += new System.EventHandler(this.CtxMenuSimpleEditorAusschneidenClick);
			// 
			// ctxMenuSimpleEditorlöschen
			// 
			this.ctxMenuSimpleEditorlöschen.Name = "ctxMenuSimpleEditorlöschen";
			this.ctxMenuSimpleEditorlöschen.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.ctxMenuSimpleEditorlöschen.Size = new System.Drawing.Size(199, 22);
			this.ctxMenuSimpleEditorlöschen.Text = "Löschen";
			this.ctxMenuSimpleEditorlöschen.Click += new System.EventHandler(this.CtxMenuSimpleEditorlöschenClick);
			// 
			// cptShortNote_SimpleText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.rtbShortNoteText);
			this.Name = "cptShortNote_SimpleText";
			this.Size = new System.Drawing.Size(201, 179);
			this.Tag = "cptShortNote_SimpleText|Simple Note";
			this.Load += new System.EventHandler(this.CptShortNote_SimpleTextLoad);
			this.ctxMenuSimpleEditor.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.RichTextBox rtbShortNoteText;
		private System.Windows.Forms.ContextMenuStrip ctxMenuSimpleEditor;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuSimpleEditorSelectAll;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuSimpleEditorKopieren;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuSimpleEditorEinfügen;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuSimpleEditorAusschneiden;
		private System.Windows.Forms.ToolStripMenuItem ctxMenuSimpleEditorlöschen;
	}
}
