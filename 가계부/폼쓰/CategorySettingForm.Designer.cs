namespace 가계부
{
    partial class CategorySettingForm
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
            this.comboBoxBigCategory = new System.Windows.Forms.ComboBox();
            this.buttonBigDelete = new System.Windows.Forms.Button();
            this.buttonAddBig = new System.Windows.Forms.Button();
            this.dataGridViewSmallCategory = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddSmall = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonSmallDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmallCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBigCategory
            // 
            this.comboBoxBigCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBigCategory.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxBigCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBigCategory.FormattingEnabled = true;
            this.comboBoxBigCategory.Location = new System.Drawing.Point(12, 12);
            this.comboBoxBigCategory.Name = "comboBoxBigCategory";
            this.comboBoxBigCategory.Size = new System.Drawing.Size(222, 24);
            this.comboBoxBigCategory.TabIndex = 0;
            this.comboBoxBigCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxBigCategory_SelectedIndexChanged);
            // 
            // buttonBigDelete
            // 
            this.buttonBigDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonBigDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBigDelete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBigDelete.Location = new System.Drawing.Point(240, 145);
            this.buttonBigDelete.Name = "buttonBigDelete";
            this.buttonBigDelete.Size = new System.Drawing.Size(88, 133);
            this.buttonBigDelete.TabIndex = 2;
            this.buttonBigDelete.Text = "대분류\r\n\r\n삭 제";
            this.buttonBigDelete.UseVisualStyleBackColor = true;
            this.buttonBigDelete.Click += new System.EventHandler(this.buttonBigDelete_Click);
            // 
            // buttonAddBig
            // 
            this.buttonAddBig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAddBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBig.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddBig.Location = new System.Drawing.Point(240, 42);
            this.buttonAddBig.Name = "buttonAddBig";
            this.buttonAddBig.Size = new System.Drawing.Size(88, 103);
            this.buttonAddBig.TabIndex = 3;
            this.buttonAddBig.Text = "대분류\r\n\r\n등 록";
            this.buttonAddBig.UseVisualStyleBackColor = true;
            this.buttonAddBig.Click += new System.EventHandler(this.buttonAddBig_Click);
            // 
            // dataGridViewSmallCategory
            // 
            this.dataGridViewSmallCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmallCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dataGridViewSmallCategory.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewSmallCategory.Name = "dataGridViewSmallCategory";
            this.dataGridViewSmallCategory.RowHeadersVisible = false;
            this.dataGridViewSmallCategory.RowTemplate.Height = 23;
            this.dataGridViewSmallCategory.Size = new System.Drawing.Size(222, 236);
            this.dataGridViewSmallCategory.TabIndex = 4;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            // 
            // buttonAddSmall
            // 
            this.buttonAddSmall.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAddSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSmall.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAddSmall.Location = new System.Drawing.Point(329, 42);
            this.buttonAddSmall.Name = "buttonAddSmall";
            this.buttonAddSmall.Size = new System.Drawing.Size(88, 103);
            this.buttonAddSmall.TabIndex = 5;
            this.buttonAddSmall.Text = "소분류\r\n\r\n등 록";
            this.buttonAddSmall.UseVisualStyleBackColor = true;
            this.buttonAddSmall.Click += new System.EventHandler(this.buttonAddSmall_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxCategoryName.Location = new System.Drawing.Point(240, 12);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(177, 26);
            this.textBoxCategoryName.TabIndex = 6;
            // 
            // buttonSmallDelete
            // 
            this.buttonSmallDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSmallDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSmallDelete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSmallDelete.Location = new System.Drawing.Point(329, 145);
            this.buttonSmallDelete.Name = "buttonSmallDelete";
            this.buttonSmallDelete.Size = new System.Drawing.Size(88, 133);
            this.buttonSmallDelete.TabIndex = 7;
            this.buttonSmallDelete.Text = "소분류\r\n\r\n삭 제";
            this.buttonSmallDelete.UseVisualStyleBackColor = true;
            this.buttonSmallDelete.Click += new System.EventHandler(this.buttonSmallDelete_Click);
            // 
            // CategorySettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 292);
            this.Controls.Add(this.buttonSmallDelete);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.buttonAddSmall);
            this.Controls.Add(this.dataGridViewSmallCategory);
            this.Controls.Add(this.buttonAddBig);
            this.Controls.Add(this.buttonBigDelete);
            this.Controls.Add(this.comboBoxBigCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategorySettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "분류 등넉^^";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmallCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBigCategory;
        private System.Windows.Forms.Button buttonBigDelete;
        private System.Windows.Forms.Button buttonAddBig;
        private System.Windows.Forms.DataGridView dataGridViewSmallCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button buttonAddSmall;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonSmallDelete;
    }
}