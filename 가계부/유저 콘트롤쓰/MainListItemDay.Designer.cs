namespace 가계부
{
    partial class MainListItemDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainListItemDay));
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelYearMonth = new System.Windows.Forms.Label();
            this.labelDayWeek = new System.Windows.Forms.Label();
            this.labelInCome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutCome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(50, 46);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(500, 2);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 0;
            this.pictureBoxLine.TabStop = false;
            // 
            // labelDay
            // 
            this.labelDay.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDay.Location = new System.Drawing.Point(3, 5);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(40, 40);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "17";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYearMonth
            // 
            this.labelYearMonth.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelYearMonth.Location = new System.Drawing.Point(47, 5);
            this.labelYearMonth.Name = "labelYearMonth";
            this.labelYearMonth.Size = new System.Drawing.Size(49, 15);
            this.labelYearMonth.TabIndex = 2;
            this.labelYearMonth.Text = "2017.10";
            // 
            // labelDayWeek
            // 
            this.labelDayWeek.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelDayWeek.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDayWeek.ForeColor = System.Drawing.Color.White;
            this.labelDayWeek.Location = new System.Drawing.Point(47, 24);
            this.labelDayWeek.Name = "labelDayWeek";
            this.labelDayWeek.Size = new System.Drawing.Size(49, 19);
            this.labelDayWeek.TabIndex = 3;
            this.labelDayWeek.Text = "화요일";
            this.labelDayWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInCome
            // 
            this.labelInCome.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelInCome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelInCome.Location = new System.Drawing.Point(242, 3);
            this.labelInCome.Name = "labelInCome";
            this.labelInCome.Size = new System.Drawing.Size(123, 38);
            this.labelInCome.TabIndex = 5;
            this.labelInCome.Text = "50,000";
            this.labelInCome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(362, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "원";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(527, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "원";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutCome
            // 
            this.labelOutCome.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOutCome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOutCome.Location = new System.Drawing.Point(407, 4);
            this.labelOutCome.Name = "labelOutCome";
            this.labelOutCome.Size = new System.Drawing.Size(123, 38);
            this.labelOutCome.TabIndex = 7;
            this.labelOutCome.Text = "125,000";
            this.labelOutCome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainListItemDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutCome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInCome);
            this.Controls.Add(this.labelDayWeek);
            this.Controls.Add(this.labelYearMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.pictureBoxLine);
            this.Name = "MainListItemDay";
            this.Size = new System.Drawing.Size(600, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelYearMonth;
        private System.Windows.Forms.Label labelDayWeek;
        private System.Windows.Forms.Label labelInCome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutCome;
    }
}
