namespace NoeticTools.Docking
{
    partial class DockContentPanel
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
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.bannerTitle = new System.Windows.Forms.Label();
            this.bannerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bannerPanel.Controls.Add(this.bannerTitle);
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(292, 29);
            this.bannerPanel.TabIndex = 7;
            // 
            // bannerTitle
            // 
            this.bannerTitle.AutoSize = true;
            this.bannerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerTitle.ForeColor = System.Drawing.Color.Black;
            this.bannerTitle.Location = new System.Drawing.Point(4, 4);
            this.bannerTitle.Name = "bannerTitle";
            this.bannerTitle.Size = new System.Drawing.Size(97, 17);
            this.bannerTitle.TabIndex = 0;
            this.bannerTitle.Text = "Banner Title";
            // 
            // DockContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.bannerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DockContentPanel";
            this.bannerPanel.ResumeLayout(false);
            this.bannerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Label bannerTitle;
    }
}