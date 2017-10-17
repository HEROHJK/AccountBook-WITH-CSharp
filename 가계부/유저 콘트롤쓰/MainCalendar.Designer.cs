namespace 가계부
{
    partial class MainCalendar
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalendarMonth = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalendarMonth
            // 
            this.buttonCalendarMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonCalendarMonth.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCalendarMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendarMonth.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonCalendarMonth.Location = new System.Drawing.Point(37, 0);
            this.buttonCalendarMonth.Name = "buttonCalendarMonth";
            this.buttonCalendarMonth.Size = new System.Drawing.Size(166, 43);
            this.buttonCalendarMonth.TabIndex = 9;
            this.buttonCalendarMonth.Text = "2017년 XX월";
            this.buttonCalendarMonth.UseVisualStyleBackColor = true;
            this.buttonCalendarMonth.Click += new System.EventHandler(this.buttonCalendarMonth_Click_1);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonNextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextMonth.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNextMonth.Location = new System.Drawing.Point(203, 0);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(37, 43);
            this.buttonNextMonth.TabIndex = 8;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click_1);
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonPreviousMonth.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousMonth.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPreviousMonth.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(37, 43);
            this.buttonPreviousMonth.TabIndex = 7;
            this.buttonPreviousMonth.Text = "<";
            this.buttonPreviousMonth.UseVisualStyleBackColor = true;
            this.buttonPreviousMonth.Click += new System.EventHandler(this.buttonPreviousMonth_Click_1);
            // 
            // MainCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCalendarMonth);
            this.Controls.Add(this.buttonNextMonth);
            this.Controls.Add(this.buttonPreviousMonth);
            this.Name = "MainCalendar";
            this.Size = new System.Drawing.Size(240, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendarMonth;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPreviousMonth;
    }
}
