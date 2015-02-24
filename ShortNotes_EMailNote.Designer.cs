/*
 * Created by SharpDevelop.
 * User: buck
 * Date: 24.02.2015
 * Time: 12:40
 * 
 */
namespace CSVSuchTool
{
	partial class cptShortNotes_EMailNote
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.cbDwSysNo = new System.Windows.Forms.CheckBox();
			this.cbJobNo = new System.Windows.Forms.CheckBox();
			this.tbIncidentNo = new System.Windows.Forms.TextBox();
			this.cbIncidentNo = new System.Windows.Forms.CheckBox();
			this.tbJobNo = new System.Windows.Forms.TextBox();
			this.tbDwSysNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbAnrufer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.rbMann = new System.Windows.Forms.RadioButton();
			this.rbFrau = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.labTimeDate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 143);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(302, 102);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// cbDwSysNo
			// 
			this.cbDwSysNo.AutoSize = true;
			this.cbDwSysNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbDwSysNo.Location = new System.Drawing.Point(3, 98);
			this.cbDwSysNo.Name = "cbDwSysNo";
			this.cbDwSysNo.Size = new System.Drawing.Size(60, 17);
			this.cbDwSysNo.TabIndex = 4;
			this.cbDwSysNo.Text = "DwSys:";
			this.cbDwSysNo.UseVisualStyleBackColor = true;
			// 
			// cbJobNo
			// 
			this.cbJobNo.AutoSize = true;
			this.cbJobNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbJobNo.Location = new System.Drawing.Point(3, 68);
			this.cbJobNo.Name = "cbJobNo";
			this.cbJobNo.Size = new System.Drawing.Size(58, 17);
			this.cbJobNo.TabIndex = 2;
			this.cbJobNo.Text = "JobNr: ";
			this.cbJobNo.UseVisualStyleBackColor = true;
			// 
			// tbIncidentNo
			// 
			this.tbIncidentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIncidentNo.Enabled = false;
			this.tbIncidentNo.Location = new System.Drawing.Point(191, 95);
			this.tbIncidentNo.MaxLength = 14;
			this.tbIncidentNo.Name = "tbIncidentNo";
			this.tbIncidentNo.Size = new System.Drawing.Size(111, 20);
			this.tbIncidentNo.TabIndex = 7;
			this.tbIncidentNo.Text = "#JJJJMMTT-NNNN";
			// 
			// cbIncidentNo
			// 
			this.cbIncidentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIncidentNo.AutoSize = true;
			this.cbIncidentNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbIncidentNo.Location = new System.Drawing.Point(191, 72);
			this.cbIncidentNo.Name = "cbIncidentNo";
			this.cbIncidentNo.Size = new System.Drawing.Size(104, 17);
			this.cbIncidentNo.TabIndex = 6;
			this.cbIncidentNo.Text = "Incident Nummer";
			this.cbIncidentNo.UseVisualStyleBackColor = true;
			// 
			// tbJobNo
			// 
			this.tbJobNo.Location = new System.Drawing.Point(67, 68);
			this.tbJobNo.MaxLength = 9;
			this.tbJobNo.Name = "tbJobNo";
			this.tbJobNo.Size = new System.Drawing.Size(104, 20);
			this.tbJobNo.TabIndex = 3;
			// 
			// tbDwSysNo
			// 
			this.tbDwSysNo.Location = new System.Drawing.Point(67, 95);
			this.tbDwSysNo.Name = "tbDwSysNo";
			this.tbDwSysNo.Size = new System.Drawing.Size(104, 20);
			this.tbDwSysNo.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Herr / Frau";
			// 
			// tbAnrufer
			// 
			this.tbAnrufer.Location = new System.Drawing.Point(3, 16);
			this.tbAnrufer.Name = "tbAnrufer";
			this.tbAnrufer.Size = new System.Drawing.Size(168, 20);
			this.tbAnrufer.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(191, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "TelefonNr.:";
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox5.Location = new System.Drawing.Point(191, 29);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(111, 20);
			this.textBox5.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Firma:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 20);
			this.textBox1.TabIndex = 11;
			// 
			// rbMann
			// 
			this.rbMann.AutoSize = true;
			this.rbMann.Location = new System.Drawing.Point(16, 0);
			this.rbMann.Name = "rbMann";
			this.rbMann.Size = new System.Drawing.Size(45, 17);
			this.rbMann.TabIndex = 12;
			this.rbMann.TabStop = true;
			this.rbMann.Text = "Herr";
			this.rbMann.UseVisualStyleBackColor = true;
			// 
			// rbFrau
			// 
			this.rbFrau.AutoSize = true;
			this.rbFrau.Location = new System.Drawing.Point(87, 0);
			this.rbFrau.Name = "rbFrau";
			this.rbFrau.Size = new System.Drawing.Size(46, 17);
			this.rbFrau.TabIndex = 13;
			this.rbFrau.TabStop = true;
			this.rbFrau.Text = "Frau";
			this.rbFrau.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox1.Location = new System.Drawing.Point(191, 120);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(101, 17);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "An ServiceDesk";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// labTimeDate
			// 
			this.labTimeDate.Location = new System.Drawing.Point(6, 122);
			this.labTimeDate.MaximumSize = new System.Drawing.Size(165, 15);
			this.labTimeDate.Name = "labTimeDate";
			this.labTimeDate.Size = new System.Drawing.Size(165, 15);
			this.labTimeDate.TabIndex = 15;
			this.labTimeDate.Text = "Zeit / Datum";
			// 
			// cptShortNotes_EMailNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labTimeDate);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.rbFrau);
			this.Controls.Add(this.rbMann);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbAnrufer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDwSysNo);
			this.Controls.Add(this.tbJobNo);
			this.Controls.Add(this.cbIncidentNo);
			this.Controls.Add(this.tbIncidentNo);
			this.Controls.Add(this.cbJobNo);
			this.Controls.Add(this.cbDwSysNo);
			this.Controls.Add(this.richTextBox1);
			this.MinimumSize = new System.Drawing.Size(305, 225);
			this.Name = "cptShortNotes_EMailNote";
			this.Size = new System.Drawing.Size(305, 249);
			this.Tag = "cptShortNotes_EMailNote|Telefon Notizen";
			this.Load += new System.EventHandler(this.cptShortNotes_EMailNote_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label labTimeDate;
		private System.Windows.Forms.RadioButton rbMann;
		private System.Windows.Forms.RadioButton rbFrau;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbIncidentNo;
		private System.Windows.Forms.TextBox tbJobNo;
		private System.Windows.Forms.TextBox tbDwSysNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbAnrufer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.CheckBox cbDwSysNo;
		private System.Windows.Forms.CheckBox cbJobNo;
		private System.Windows.Forms.TextBox tbIncidentNo;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
