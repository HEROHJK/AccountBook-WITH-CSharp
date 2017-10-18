namespace 가계부
{
    partial class MainListItem
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
            this.labelBigCategory = new System.Windows.Forms.Label();
            this.labelSmallCategory = new System.Windows.Forms.Label();
            this.labelMemo = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBigCategory
            // 
            this.labelBigCategory.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBigCategory.ForeColor = System.Drawing.Color.Gray;
            this.labelBigCategory.Location = new System.Drawing.Point(5, 0);
            this.labelBigCategory.Name = "labelBigCategory";
            this.labelBigCategory.Size = new System.Drawing.Size(60, 30);
            this.labelBigCategory.TabIndex = 0;
            this.labelBigCategory.Text = "식 비";
            this.labelBigCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBigCategory.Click += new System.EventHandler(this.ControlClick);
            // 
            // labelSmallCategory
            // 
            this.labelSmallCategory.ForeColor = System.Drawing.Color.Gray;
            this.labelSmallCategory.Location = new System.Drawing.Point(5, 30);
            this.labelSmallCategory.Name = "labelSmallCategory";
            this.labelSmallCategory.Size = new System.Drawing.Size(60, 20);
            this.labelSmallCategory.TabIndex = 1;
            this.labelSmallCategory.Text = "급식";
            this.labelSmallCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSmallCategory.Click += new System.EventHandler(this.ControlClick);
            // 
            // labelMemo
            // 
            this.labelMemo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMemo.Location = new System.Drawing.Point(120, 0);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(300, 30);
            this.labelMemo.TabIndex = 2;
            this.labelMemo.Text = "지에스25사당수석점";
            this.labelMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMemo.Click += new System.EventHandler(this.ControlClick);
            // 
            // labelBank
            // 
            this.labelBank.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBank.ForeColor = System.Drawing.Color.Gray;
            this.labelBank.Location = new System.Drawing.Point(166, 30);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(255, 20);
            this.labelBank.TabIndex = 3;
            this.labelBank.Text = "카카오뱅크";
            this.labelBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBank.Click += new System.EventHandler(this.ControlClick);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTime.ForeColor = System.Drawing.Color.Gray;
            this.labelTime.Location = new System.Drawing.Point(122, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(46, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "12:12";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTime.Click += new System.EventHandler(this.ControlClick);
            // 
            // labelMoney
            // 
            this.labelMoney.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMoney.ForeColor = System.Drawing.Color.Red;
            this.labelMoney.Location = new System.Drawing.Point(427, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(113, 50);
            this.labelMoney.TabIndex = 5;
            this.labelMoney.Text = "30,000";
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMoney.Click += new System.EventHandler(this.ControlClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(536, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "원";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.ControlClick);
            // 
            // MainListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.labelMemo);
            this.Controls.Add(this.labelSmallCategory);
            this.Controls.Add(this.labelBigCategory);
            this.Name = "MainListItem";
            this.Size = new System.Drawing.Size(600, 50);
            this.Click += new System.EventHandler(this.ControlClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBigCategory;
        private System.Windows.Forms.Label labelSmallCategory;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label1;
    }
}
