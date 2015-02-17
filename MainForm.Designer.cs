/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 12.12.2014
 * Zeit: 09:19
 * 
 */
namespace CSVSuchTool
{
	partial class MainForm
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.labSourceFile = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttSourceFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.labSourceFile);
			this.panel1.Controls.Add(this.tbSearch);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.buttSourceFile);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 59);
			this.panel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(241, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Suche in:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(312, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(167, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// labSourceFile
			// 
			this.labSourceFile.AutoSize = true;
			this.labSourceFile.Location = new System.Drawing.Point(12, 26);
			this.labSourceFile.Name = "labSourceFile";
			this.labSourceFile.Size = new System.Drawing.Size(107, 13);
			this.labSourceFile.TabIndex = 9;
			this.labSourceFile.Text = "Zuerst Quelle wählen";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(312, 6);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(167, 20);
			this.tbSearch.TabIndex = 8;
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Suche nach";
			// 
			// buttSourceFile
			// 
			this.buttSourceFile.AutoSize = true;
			this.buttSourceFile.Location = new System.Drawing.Point(121, 4);
			this.buttSourceFile.Name = "buttSourceFile";
			this.buttSourceFile.Size = new System.Drawing.Size(84, 23);
			this.buttSourceFile.TabIndex = 6;
			this.buttSourceFile.Text = "Quelle wählen";
			this.buttSourceFile.UseVisualStyleBackColor = true;
			this.buttSourceFile.Click += new System.EventHandler(this.ButtSourceFileClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Quelldatei für Suche";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 59);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(504, 407);
			this.panel2.TabIndex = 2;
			// 
			// listView1
			// 
			this.listView1.AllowColumnReorder = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(504, 407);
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1ColumnClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Voller Name";
			this.columnHeader1.Width = 127;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Durchwahl";
			this.columnHeader2.Width = 64;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tel. Extern";
			this.columnHeader3.Width = 114;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "E-Mail Adresse";
			this.columnHeader4.Width = 194;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 466);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = global::CSVSuchTool.Resource.DBSoft;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labSourceFile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttSourceFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
