namespace 가계부
{
    partial class BankSettingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankSettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNameCorrect = new System.Windows.Forms.Button();
            this.buttonBankDelete = new System.Windows.Forms.Button();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.textBoxNewBank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewBanks = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNameCorrect);
            this.groupBox1.Controls.Add(this.buttonBankDelete);
            this.groupBox1.Controls.Add(this.textBoxBalance);
            this.groupBox1.Controls.Add(this.textBoxBankName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보";
            // 
            // buttonNameCorrect
            // 
            this.buttonNameCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNameCorrect.Location = new System.Drawing.Point(8, 91);
            this.buttonNameCorrect.Name = "buttonNameCorrect";
            this.buttonNameCorrect.Size = new System.Drawing.Size(92, 52);
            this.buttonNameCorrect.TabIndex = 5;
            this.buttonNameCorrect.Text = "이름 수정";
            this.buttonNameCorrect.UseVisualStyleBackColor = true;
            this.buttonNameCorrect.Click += new System.EventHandler(this.buttonNameCorrect_Click);
            // 
            // buttonBankDelete
            // 
            this.buttonBankDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBankDelete.Location = new System.Drawing.Point(112, 91);
            this.buttonBankDelete.Name = "buttonBankDelete";
            this.buttonBankDelete.Size = new System.Drawing.Size(92, 52);
            this.buttonBankDelete.TabIndex = 4;
            this.buttonBankDelete.Text = "삭제";
            this.buttonBankDelete.UseVisualStyleBackColor = true;
            this.buttonBankDelete.Click += new System.EventHandler(this.buttonBankDelete_Click);
            this.buttonBankDelete.MouseLeave += new System.EventHandler(this.buttonBankDelete_MouseLeave);
            this.buttonBankDelete.MouseHover += new System.EventHandler(this.buttonBankDelete_MouseHover);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBalance.Location = new System.Drawing.Point(53, 64);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(151, 21);
            this.textBoxBalance.TabIndex = 3;
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBankName.Location = new System.Drawing.Point(53, 29);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(151, 21);
            this.textBoxBankName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "잔액 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddBank);
            this.groupBox2.Controls.Add(this.textBoxNewBank);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(218, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "등록";
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBank.Location = new System.Drawing.Point(112, 65);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(92, 52);
            this.buttonAddBank.TabIndex = 3;
            this.buttonAddBank.Text = "등록";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // textBoxNewBank
            // 
            this.textBoxNewBank.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxNewBank.Location = new System.Drawing.Point(53, 38);
            this.textBoxNewBank.Name = "textBoxNewBank";
            this.textBoxNewBank.Size = new System.Drawing.Size(151, 21);
            this.textBoxNewBank.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름 : ";
            // 
            // dataGridViewBanks
            // 
            this.dataGridViewBanks.AllowUserToAddRows = false;
            this.dataGridViewBanks.AllowUserToDeleteRows = false;
            this.dataGridViewBanks.AllowUserToResizeColumns = false;
            this.dataGridViewBanks.AllowUserToResizeRows = false;
            this.dataGridViewBanks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.balance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBanks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBanks.EnableHeadersVisualStyles = false;
            this.dataGridViewBanks.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewBanks.MultiSelect = false;
            this.dataGridViewBanks.Name = "dataGridViewBanks";
            this.dataGridViewBanks.ReadOnly = true;
            this.dataGridViewBanks.RowHeadersVisible = false;
            this.dataGridViewBanks.RowHeadersWidth = 100;
            this.dataGridViewBanks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBanks.RowTemplate.Height = 23;
            this.dataGridViewBanks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBanks.ShowEditingIcon = false;
            this.dataGridViewBanks.Size = new System.Drawing.Size(211, 299);
            this.dataGridViewBanks.TabIndex = 5;
            this.dataGridViewBanks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBanks_CellClick);
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "은행명";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 80;
            // 
            // balance
            // 
            this.balance.Frozen = true;
            this.balance.HeaderText = "잔액";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.balance.Width = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BankSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewBanks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BankSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "통장 설정";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankSettingForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNewBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddBank;
        private System.Windows.Forms.Button buttonNameCorrect;
        private System.Windows.Forms.Button buttonBankDelete;
        private System.Windows.Forms.DataGridView dataGridViewBanks;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}