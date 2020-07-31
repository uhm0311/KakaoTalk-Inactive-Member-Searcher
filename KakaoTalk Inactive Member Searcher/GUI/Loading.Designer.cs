namespace KIMS.GUI
{
    partial class Loading
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
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 12);
            this.Progress.Maximum = 1000;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(100, 23);
            this.Progress.Step = 1;
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Progress.TabIndex = 0;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 45);
            this.Controls.Add(this.Progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progress;
    }
}