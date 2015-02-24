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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBox1.Location = new System.Drawing.Point(0, 128);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(305, 126);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox1.Location = new System.Drawing.Point(3, 98);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(60, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "DwSys:";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox2.Location = new System.Drawing.Point(3, 68);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(58, 17);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "JobNr: ";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(177, 95);
			this.textBox1.MaxLength = 14;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(111, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "#JJJJMMTT-NNNN";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox3.Location = new System.Drawing.Point(177, 72);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 17);
			this.checkBox3.TabIndex = 4;
			this.checkBox3.Text = "Incident Nummer";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 68);
			this.textBox2.MaxLength = 9;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(104, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(67, 95);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(104, 20);
			this.textBox3.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Herr / Frau";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(3, 27);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(162, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "TelefonNr.:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(162, 27);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(126, 20);
			this.textBox5.TabIndex = 10;
			// 
			// cptShortNotes_EMailNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "cptShortNotes_EMailNote";
			this.Size = new System.Drawing.Size(305, 254);
			this.Load += new System.EventHandler(this.cptShortNotes_EMailNote_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
