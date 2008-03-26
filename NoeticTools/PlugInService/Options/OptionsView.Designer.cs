namespace NoeticTools.PlugIns.Options
{
	partial class OptionsView
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
			this.pluginsListView = new System.Windows.Forms.ListView();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pluginsListView
			// 
			this.pluginsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pluginsListView.Location = new System.Drawing.Point(0, 0);
			this.pluginsListView.MultiSelect = false;
			this.pluginsListView.Name = "pluginsListView";
			this.pluginsListView.Size = new System.Drawing.Size(101, 336);
			this.pluginsListView.TabIndex = 0;
			this.pluginsListView.UseCompatibleStateImageBehavior = false;
			this.pluginsListView.View = System.Windows.Forms.View.List;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 45);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.pluginsListView);
			this.splitContainer.Panel1MinSize = 75;
			this.splitContainer.Panel2MinSize = 100;
			this.splitContainer.Size = new System.Drawing.Size(502, 336);
			this.splitContainer.SplitterDistance = 101;
			this.splitContainer.TabIndex = 2;
			// 
			// OptionsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 381);
			this.Controls.Add(this.splitContainer);
			this.HeaderText = "Options";
			this.Name = "OptionsView";
			this.TabText = "Options";
			this.Text = "OptionsView";
			this.Load += new System.EventHandler(this.OptionsView_Load);
			this.Controls.SetChildIndex(this.splitContainer, 0);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListView pluginsListView;

	}
}