namespace KIMS.GUI
{
    partial class MainForm
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
            this.Result = new System.Windows.Forms.DataGridView();
            this.닉네임 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.AllowUserToAddRows = false;
            this.Result.AllowUserToDeleteRows = false;
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.닉네임,
            this.Last});
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.RowTemplate.Height = 23;
            this.Result.Size = new System.Drawing.Size(776, 426);
            this.Result.TabIndex = 0;
            // 
            // 닉네임
            // 
            this.닉네임.FillWeight = 368F;
            this.닉네임.Frozen = true;
            this.닉네임.HeaderText = "Nickname";
            this.닉네임.Name = "닉네임";
            this.닉네임.ReadOnly = true;
            this.닉네임.Width = 368;
            // 
            // Last
            // 
            this.Last.FillWeight = 368F;
            this.Last.Frozen = true;
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Width = 368;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KakaoTalk Inactive Member Searcher";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn 닉네임;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
    }
}