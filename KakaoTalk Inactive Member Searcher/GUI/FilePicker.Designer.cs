namespace KIMS.GUI
{
    partial class FilePicker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathFinder = new System.Windows.Forms.Button();
            this.CriteriaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Inactive = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.Active = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathFinder
            // 
            this.PathFinder.Location = new System.Drawing.Point(93, 11);
            this.PathFinder.Name = "PathFinder";
            this.PathFinder.Size = new System.Drawing.Size(75, 23);
            this.PathFinder.TabIndex = 1;
            this.PathFinder.Text = "찾기 (&F)...";
            this.PathFinder.UseVisualStyleBackColor = true;
            this.PathFinder.Click += new System.EventHandler(this.PathFinderClick);
            // 
            // CriteriaDateTimePicker
            // 
            this.CriteriaDateTimePicker.Enabled = false;
            this.CriteriaDateTimePicker.Location = new System.Drawing.Point(12, 39);
            this.CriteriaDateTimePicker.Name = "CriteriaDateTimePicker";
            this.CriteriaDateTimePicker.Size = new System.Drawing.Size(156, 21);
            this.CriteriaDateTimePicker.TabIndex = 2;
            this.CriteriaDateTimePicker.ValueChanged += new System.EventHandler(this.CriteriaDateTimePickerValueChanged);
            // 
            // Inactive
            // 
            this.Inactive.Enabled = false;
            this.Inactive.Location = new System.Drawing.Point(12, 66);
            this.Inactive.Name = "Inactive";
            this.Inactive.Size = new System.Drawing.Size(75, 23);
            this.Inactive.TabIndex = 3;
            this.Inactive.Text = "잠수 찾기";
            this.Inactive.UseVisualStyleBackColor = true;
            this.Inactive.Click += new System.EventHandler(this.IactiveClick);
            // 
            // Path
            // 
            this.Path.Enabled = false;
            this.Path.Location = new System.Drawing.Point(12, 12);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(75, 21);
            this.Path.TabIndex = 0;
            // 
            // Active
            // 
            this.Active.Location = new System.Drawing.Point(93, 66);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(75, 23);
            this.Active.TabIndex = 4;
            this.Active.Text = "활동 찾기";
            this.Active.UseVisualStyleBackColor = true;
            this.Active.Click += new System.EventHandler(this.ActiveClick);
            // 
            // FilePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 99);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.Inactive);
            this.Controls.Add(this.CriteriaDateTimePicker);
            this.Controls.Add(this.PathFinder);
            this.Controls.Add(this.Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilePicker";
            this.Text = "KakaoTalk Inactive Member Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PathFinder;
        private System.Windows.Forms.DateTimePicker CriteriaDateTimePicker;
        private System.Windows.Forms.Button Inactive;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button Active;
    }
}

