namespace NoeticTools.PlugIns.UI
{
	partial class HeaderPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rightPlaceHolder = new NoeticTools.Windows.Forms.PlaceHolderControl();
			this.headerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rightPlaceHolder
			// 
			this.rightPlaceHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rightPlaceHolder.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightPlaceHolder.Location = new System.Drawing.Point(503, 10);
			this.rightPlaceHolder.Name = "rightPlaceHolder";
			this.rightPlaceHolder.Size = new System.Drawing.Size(115, 25);
			this.rightPlaceHolder.TabIndex = 5;
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.Location = new System.Drawing.Point(10, 10);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(131, 25);
			this.headerLabel.TabIndex = 2;
			this.headerLabel.Text = "Header Text";
			// 
			// HeaderPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Controls.Add(this.rightPlaceHolder);
			this.Controls.Add(this.headerLabel);
			this.Name = "HeaderPanel";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(628, 45);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private NoeticTools.Windows.Forms.PlaceHolderControl rightPlaceHolder;
	}
}