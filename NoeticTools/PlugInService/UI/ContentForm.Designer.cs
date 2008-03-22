namespace NoeticTools.PlugIns.UI
{
	partial class ContentForm
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
			this.headerPanel = new HeaderPanel();
			this.placeHolderControl = new NoeticTools.Windows.Forms.PlaceHolderControl();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Padding = new System.Windows.Forms.Padding(10);
			this.headerPanel.Size = new System.Drawing.Size(723, 45);
			this.headerPanel.TabIndex = 0;
			// 
			// placeHolderControl
			// 
			this.placeHolderControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.placeHolderControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.placeHolderControl.Location = new System.Drawing.Point(0, 45);
			this.placeHolderControl.Name = "placeHolderControl";
			this.placeHolderControl.Size = new System.Drawing.Size(723, 300);
			this.placeHolderControl.TabIndex = 1;
			// 
			// ContentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 345);
			this.Controls.Add(this.placeHolderControl);
			this.Controls.Add(this.headerPanel);
			this.Name = "ContentForm";
			this.ShowIcon = false;
			this.TabText = "ContentForm";
			this.Text = "ContentForm";
			this.ResumeLayout(false);

		}

		#endregion

		private HeaderPanel headerPanel;
		private NoeticTools.Windows.Forms.PlaceHolderControl placeHolderControl;

	}
}