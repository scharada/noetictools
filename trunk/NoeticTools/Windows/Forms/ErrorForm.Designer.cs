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
			this.leftPanel = new System.Windows.Forms.Panel();
			this.exlaimLabel = new System.Windows.Forms.Label();
			this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
			this.messagePanel = new System.Windows.Forms.Panel();
			this.leftPanel.SuspendLayout();
			this.messagePanel.SuspendLayout();
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
			this.messageRichTextBox.Size = new System.Drawing.Size(527, 298);
			this.messageRichTextBox.TabIndex = 1;
			this.messageRichTextBox.Text = "";
			// 
			// messagePanel
			// 
			this.messagePanel.Controls.Add(this.messageRichTextBox);
			this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messagePanel.Location = new System.Drawing.Point(130, 0);
			this.messagePanel.Name = "messagePanel";
			this.messagePanel.Padding = new System.Windows.Forms.Padding(10);
			this.messagePanel.Size = new System.Drawing.Size(547, 318);
			this.messagePanel.TabIndex = 2;
			// 
			// ErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 318);
			this.Controls.Add(this.messagePanel);
			this.Controls.Add(this.leftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorForm";
			this.ShowIcon = false;
			this.Text = "CFA Reader Error";
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.messagePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Label exlaimLabel;
		private System.Windows.Forms.RichTextBox messageRichTextBox;
		private System.Windows.Forms.Panel messagePanel;
	}
}