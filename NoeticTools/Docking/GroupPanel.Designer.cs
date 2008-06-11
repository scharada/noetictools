namespace NoeticTools.Docking
{
    partial class GroupPanel
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
            this.bannerLabel = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(0, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(47, 13);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "Banner";
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.Color.Chocolate;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalLine.Location = new System.Drawing.Point(0, 13);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(165, 1);
            this.horizontalLine.TabIndex = 1;
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.bannerLabel);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(165, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Panel horizontalLine;
    }
}