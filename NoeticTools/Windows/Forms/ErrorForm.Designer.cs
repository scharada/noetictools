namespace NoeticTools.Windows.Forms
{
	partial class ErrorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
			this.leftPanel = new System.Windows.Forms.Panel();
			this.exlaimLabel = new System.Windows.Forms.Label();
			this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
			this.messagePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.okButton = new System.Windows.Forms.Button();
			this.leftPanel.SuspendLayout();
			this.messagePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.OrangeRed;
			this.leftPanel.Controls.Add(this.exlaimLabel);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(130, 318);
			this.leftPanel.TabIndex = 0;
			// 
			// exlaimLabel
			// 
			this.exlaimLabel.AutoSize = true;
			this.exlaimLabel.Font = new System.Drawing.Font("OpenSymbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exlaimLabel.ForeColor = System.Drawing.Color.Black;
			this.exlaimLabel.Location = new System.Drawing.Point(36, 66);
			this.exlaimLabel.Name = "exlaimLabel";
			this.exlaimLabel.Size = new System.Drawing.Size(59, 80);
			this.exlaimLabel.TabIndex = 0;
			this.exlaimLabel.Text = "!";
			// 
			// messageRichTextBox
			// 
			this.messageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.messageRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageRichTextBox.Location = new System.Drawing.Point(10, 10);
			this.messageRichTextBox.Name = "messageRichTextBox";
			this.messageRichTextBox.ReadOnly = true;
			this.messageRichTextBox.Size = new System.Drawing.Size(527, 257);
			this.messageRichTextBox.TabIndex = 1;
			this.messageRichTextBox.Text = "";
			// 
			// messagePanel
			// 
			this.messagePanel.Controls.Add(this.messageRichTextBox);
			this.messagePanel.Controls.Add(this.panel1);
			this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messagePanel.Location = new System.Drawing.Point(130, 0);
			this.messagePanel.Name = "messagePanel";
			this.messagePanel.Padding = new System.Windows.Forms.Padding(10);
			this.messagePanel.Size = new System.Drawing.Size(547, 318);
			this.messagePanel.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.okButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(10, 267);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(527, 41);
			this.panel1.TabIndex = 2;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(226, 9);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// ErrorForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 318);
			this.Controls.Add(this.messagePanel);
			this.Controls.Add(this.leftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorForm";
			this.Text = "CFA Reader Error";
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.messagePanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Label exlaimLabel;
		private System.Windows.Forms.RichTextBox messageRichTextBox;
		private System.Windows.Forms.Panel messagePanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button okButton;
	}
}