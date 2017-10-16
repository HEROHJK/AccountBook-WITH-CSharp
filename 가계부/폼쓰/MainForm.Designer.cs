namespace 가계부
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInCome = new System.Windows.Forms.Label();
            this.labelOutCome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainCalendar1 = new 가계부.MainCalendar();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(2, 103);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(600, 500);
            this.treeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "수입";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInCome
            // 
            this.labelInCome.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelInCome.Location = new System.Drawing.Point(0, 77);
            this.labelInCome.Name = "labelInCome";
            this.labelInCome.Size = new System.Drawing.Size(200, 23);
            this.labelInCome.TabIndex = 3;
            this.labelInCome.Text = "0";
            this.labelInCome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOutCome
            // 
            this.labelOutCome.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOutCome.Location = new System.Drawing.Point(200, 77);
            this.labelOutCome.Name = "labelOutCome";
            this.labelOutCome.Size = new System.Drawing.Size(200, 23);
            this.labelOutCome.TabIndex = 5;
            this.labelOutCome.Text = "0";
            this.labelOutCome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(200, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "지출";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotal.Location = new System.Drawing.Point(400, 77);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(200, 23);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(400, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "합계";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetting.Location = new System.Drawing.Point(247, 2);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(175, 43);
            this.ButtonSetting.TabIndex = 9;
            this.ButtonSetting.Text = "관 리";
            this.ButtonSetting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(428, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "등 록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainCalendar1
            // 
            this.mainCalendar1.Location = new System.Drawing.Point(1, 2);
            this.mainCalendar1.Name = "mainCalendar1";
            this.mainCalendar1.Size = new System.Drawing.Size(240, 43);
            this.mainCalendar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSetting);
            this.Controls.Add(this.mainCalendar1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelOutCome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelInCome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInCome;
        private System.Windows.Forms.Label labelOutCome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label6;
        private MainCalendar mainCalendar1;
        private System.Windows.Forms.Button ButtonSetting;
        private System.Windows.Forms.Button button1;
    }
}