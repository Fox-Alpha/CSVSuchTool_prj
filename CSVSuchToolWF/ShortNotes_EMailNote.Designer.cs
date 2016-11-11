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
			this.tbAnrufer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTelefonNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbFirma = new System.Windows.Forms.TextBox();
			this.rbMann = new System.Windows.Forms.RadioButton();
			this.rbFrau = new System.Windows.Forms.RadioButton();
			this.cbToServiceDesk = new System.Windows.Forms.CheckBox();
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
			this.richTextBox1.Size = new System.Drawing.Size(388, 102);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// cbDwSysNo
			// 
			this.cbDwSysNo.AutoSize = true;
			this.cbDwSysNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbDwSysNo.Location = new System.Drawing.Point(3, 98);
			this.cbDwSysNo.Name = "cbDwSysNo";
			this.cbDwSysNo.Size = new System.Drawing.Size(60, 17);
			this.cbDwSysNo.TabIndex = 11;
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
			this.cbJobNo.TabIndex = 10;
			this.cbJobNo.Text = "JobNr: ";
			this.cbJobNo.UseVisualStyleBackColor = true;
			// 
			// tbIncidentNo
			// 
			this.tbIncidentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbIncidentNo.Enabled = false;
			this.tbIncidentNo.Location = new System.Drawing.Point(277, 95);
			this.tbIncidentNo.MaxLength = 14;
			this.tbIncidentNo.Name = "tbIncidentNo";
			this.tbIncidentNo.Size = new System.Drawing.Size(111, 20);
			this.tbIncidentNo.TabIndex = 8;
			this.tbIncidentNo.Text = "#JJJJMMTT-NNNN";
			// 
			// cbIncidentNo
			// 
			this.cbIncidentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIncidentNo.AutoSize = true;
			this.cbIncidentNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbIncidentNo.Location = new System.Drawing.Point(277, 72);
			this.cbIncidentNo.Name = "cbIncidentNo";
			this.cbIncidentNo.Size = new System.Drawing.Size(104, 17);
			this.cbIncidentNo.TabIndex = 7;
			this.cbIncidentNo.Text = "Incident Nummer";
			this.cbIncidentNo.UseVisualStyleBackColor = true;
			this.cbIncidentNo.CheckedChanged += new System.EventHandler(this.cbIncidentNo_CheckedChanged);
			// 
			// tbJobNo
			// 
			this.tbJobNo.Location = new System.Drawing.Point(87, 67);
			this.tbJobNo.MaxLength = 9;
			this.tbJobNo.Name = "tbJobNo";
			this.tbJobNo.Size = new System.Drawing.Size(104, 20);
			this.tbJobNo.TabIndex = 5;
			// 
			// tbDwSysNo
			// 
			this.tbDwSysNo.Location = new System.Drawing.Point(87, 97);
			this.tbDwSysNo.Name = "tbDwSysNo";
			this.tbDwSysNo.Size = new System.Drawing.Size(104, 20);
			this.tbDwSysNo.TabIndex = 6;
			// 
			// tbAnrufer
			// 
			this.tbAnrufer.Location = new System.Drawing.Point(87, 16);
			this.tbAnrufer.Name = "tbAnrufer";
			this.tbAnrufer.Size = new System.Drawing.Size(132, 20);
			this.tbAnrufer.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(247, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "TelefonNr.:";
			// 
			// tbTelefonNo
			// 
			this.tbTelefonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTelefonNo.Location = new System.Drawing.Point(247, 29);
			this.tbTelefonNo.Name = "tbTelefonNo";
			this.tbTelefonNo.Size = new System.Drawing.Size(141, 20);
			this.tbTelefonNo.TabIndex = 4;
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
			// tbFirma
			// 
			this.tbFirma.Location = new System.Drawing.Point(87, 42);
			this.tbFirma.Name = "tbFirma";
			this.tbFirma.Size = new System.Drawing.Size(132, 20);
			this.tbFirma.TabIndex = 3;
			// 
			// rbMann
			// 
			this.rbMann.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbMann.AutoSize = true;
			this.rbMann.Location = new System.Drawing.Point(0, 13);
			this.rbMann.Name = "rbMann";
			this.rbMann.Size = new System.Drawing.Size(37, 23);
			this.rbMann.TabIndex = 0;
			this.rbMann.Text = "Herr";
			this.rbMann.UseVisualStyleBackColor = true;
			this.rbMann.CheckedChanged += new System.EventHandler(this.rbMann_CheckedChanged);
			// 
			// rbFrau
			// 
			this.rbFrau.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbFrau.AutoSize = true;
			this.rbFrau.Location = new System.Drawing.Point(43, 13);
			this.rbFrau.Name = "rbFrau";
			this.rbFrau.Size = new System.Drawing.Size(38, 23);
			this.rbFrau.TabIndex = 1;
			this.rbFrau.Text = "Frau";
			this.rbFrau.UseVisualStyleBackColor = true;
			this.rbFrau.CheckedChanged += new System.EventHandler(this.rbFrau_CheckedChanged);
			// 
			// cbToServiceDesk
			// 
			this.cbToServiceDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbToServiceDesk.AutoSize = true;
			this.cbToServiceDesk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbToServiceDesk.Location = new System.Drawing.Point(277, 120);
			this.cbToServiceDesk.Name = "cbToServiceDesk";
			this.cbToServiceDesk.Size = new System.Drawing.Size(101, 17);
			this.cbToServiceDesk.TabIndex = 12;
			this.cbToServiceDesk.Text = "An ServiceDesk";
			this.cbToServiceDesk.UseVisualStyleBackColor = true;
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
			this.Controls.Add(this.cbToServiceDesk);
			this.Controls.Add(this.rbFrau);
			this.Controls.Add(this.rbMann);
			this.Controls.Add(this.tbFirma);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbTelefonNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbAnrufer);
			this.Controls.Add(this.tbDwSysNo);
			this.Controls.Add(this.tbJobNo);
			this.Controls.Add(this.cbIncidentNo);
			this.Controls.Add(this.tbIncidentNo);
			this.Controls.Add(this.cbJobNo);
			this.Controls.Add(this.cbDwSysNo);
			this.Controls.Add(this.richTextBox1);
			this.MinimumSize = new System.Drawing.Size(305, 225);
			this.Name = "cptShortNotes_EMailNote";
			this.Size = new System.Drawing.Size(391, 249);
			this.Tag = "cptShortNotes_EMailNote|Telefon Notizen";
			this.Load += new System.EventHandler(this.cptShortNotes_EMailNote_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox cbToServiceDesk;
		private System.Windows.Forms.Label labTimeDate;
		private System.Windows.Forms.RadioButton rbMann;
		private System.Windows.Forms.RadioButton rbFrau;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbFirma;
		private System.Windows.Forms.CheckBox cbIncidentNo;
		private System.Windows.Forms.TextBox tbJobNo;
		private System.Windows.Forms.TextBox tbDwSysNo;
		private System.Windows.Forms.TextBox tbAnrufer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTelefonNo;
		private System.Windows.Forms.CheckBox cbDwSysNo;
		private System.Windows.Forms.CheckBox cbJobNo;
		private System.Windows.Forms.TextBox tbIncidentNo;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
