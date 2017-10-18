namespace 가계부
{
    partial class InOutComeForm
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
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.buttonSelectCategory = new System.Windows.Forms.Button();
            this.buttonSelectBank = new System.Windows.Forms.Button();
            this.bankMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(7, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 35);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "수 입";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(166, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 35);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "지 출";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-2, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "은 행 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(-2, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "분 류 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(-2, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "금 액 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(-2, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "내 용 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd HH:MM:ss";
            this.dateTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(15, 43);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(307, 22);
            this.dateTime.TabIndex = 6;
            // 
            // textBoxBank
            // 
            this.textBoxBank.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBank.Location = new System.Drawing.Point(88, 81);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.ReadOnly = true;
            this.textBoxBank.Size = new System.Drawing.Size(177, 22);
            this.textBoxBank.TabIndex = 7;
            this.textBoxBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxCategory.Location = new System.Drawing.Point(88, 116);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(177, 22);
            this.textBoxCategory.TabIndex = 8;
            this.textBoxCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMoney.Location = new System.Drawing.Point(88, 151);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(234, 22);
            this.textBoxMoney.TabIndex = 9;
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMemo.Location = new System.Drawing.Point(88, 186);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(234, 22);
            this.textBoxMemo.TabIndex = 10;
            this.textBoxMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(7, 236);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 67);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "등 록";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddCancel.Location = new System.Drawing.Point(166, 236);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(160, 67);
            this.buttonAddCancel.TabIndex = 12;
            this.buttonAddCancel.Text = "취 소";
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // buttonSelectCategory
            // 
            this.buttonSelectCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSelectCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSelectCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectCategory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSelectCategory.Location = new System.Drawing.Point(266, 116);
            this.buttonSelectCategory.Name = "buttonSelectCategory";
            this.buttonSelectCategory.Size = new System.Drawing.Size(56, 22);
            this.buttonSelectCategory.TabIndex = 13;
            this.buttonSelectCategory.Text = "선 택";
            this.buttonSelectCategory.UseVisualStyleBackColor = true;
            this.buttonSelectCategory.Click += new System.EventHandler(this.buttonSelectCategory_Click);
            // 
            // buttonSelectBank
            // 
            this.buttonSelectBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSelectBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSelectBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectBank.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSelectBank.Location = new System.Drawing.Point(266, 81);
            this.buttonSelectBank.Name = "buttonSelectBank";
            this.buttonSelectBank.Size = new System.Drawing.Size(56, 22);
            this.buttonSelectBank.TabIndex = 14;
            this.buttonSelectBank.Text = "선 택";
            this.buttonSelectBank.UseVisualStyleBackColor = true;
            this.buttonSelectBank.Click += new System.EventHandler(this.buttonSelectBank_Click);
            // 
            // bankMenu
            // 
            this.bankMenu.Name = "bankMenu";
            this.bankMenu.ShowImageMargin = false;
            this.bankMenu.Size = new System.Drawing.Size(36, 4);
            // 
            // categoryMenu
            // 
            this.categoryMenu.Name = "categoryMenu";
            this.categoryMenu.ShowImageMargin = false;
            this.categoryMenu.Size = new System.Drawing.Size(36, 4);
            // 
            // InOutComeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.buttonSelectBank);
            this.Controls.Add(this.buttonSelectCategory);
            this.Controls.Add(this.buttonAddCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxBank);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InOutComeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "등록";
            this.Load += new System.EventHandler(this.InOutComeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.Button buttonSelectCategory;
        private System.Windows.Forms.Button buttonSelectBank;
        private System.Windows.Forms.ContextMenuStrip bankMenu;
        private System.Windows.Forms.ContextMenuStrip categoryMenu;
    }
}