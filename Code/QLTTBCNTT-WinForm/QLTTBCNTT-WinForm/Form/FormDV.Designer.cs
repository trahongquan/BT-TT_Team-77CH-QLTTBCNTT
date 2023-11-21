namespace QLTTBCNTT_WinForm
{
    partial class FormDV
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
            this.dtgvDV = new System.Windows.Forms.DataGridView();
            this.AddDV = new System.Windows.Forms.Button();
            this.ModifyDV = new System.Windows.Forms.Button();
            this.DelDV = new System.Windows.Forms.Button();
            this.cbbDoi = new System.Windows.Forms.ComboBox();
            this.cbbTieudoan = new System.Windows.Forms.ComboBox();
            this.cbbLudoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDV
            // 
            this.dtgvDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDV.Location = new System.Drawing.Point(13, 13);
            this.dtgvDV.Name = "dtgvDV";
            this.dtgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDV.Size = new System.Drawing.Size(534, 425);
            this.dtgvDV.TabIndex = 0;
            this.dtgvDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDV_MouseClick);
            // 
            // AddDV
            // 
            this.AddDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDV.Location = new System.Drawing.Point(600, 61);
            this.AddDV.Name = "AddDV";
            this.AddDV.Size = new System.Drawing.Size(75, 23);
            this.AddDV.TabIndex = 1;
            this.AddDV.Text = "Thêm";
            this.AddDV.UseVisualStyleBackColor = true;
            this.AddDV.Click += new System.EventHandler(this.AddDV_Click);
            // 
            // ModifyDV
            // 
            this.ModifyDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyDV.Location = new System.Drawing.Point(709, 60);
            this.ModifyDV.Name = "ModifyDV";
            this.ModifyDV.Size = new System.Drawing.Size(75, 23);
            this.ModifyDV.TabIndex = 2;
            this.ModifyDV.Text = "Sửa";
            this.ModifyDV.UseVisualStyleBackColor = true;
            this.ModifyDV.Click += new System.EventHandler(this.ModifyDV_Click);
            // 
            // DelDV
            // 
            this.DelDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelDV.Location = new System.Drawing.Point(818, 59);
            this.DelDV.Name = "DelDV";
            this.DelDV.Size = new System.Drawing.Size(75, 23);
            this.DelDV.TabIndex = 3;
            this.DelDV.Text = "Xóa";
            this.DelDV.UseVisualStyleBackColor = true;
            this.DelDV.Click += new System.EventHandler(this.DelTDV_Click);
            // 
            // cbbDoi
            // 
            this.cbbDoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDoi.FormattingEnabled = true;
            this.cbbDoi.Items.AddRange(new object[] {
            "Đội 1",
            "Đội 2",
            "Đội 3",
            "Đội 4",
            "Đội 5",
            "Đội 6",
            "Đội 7",
            "Đội 8",
            "Đội 9"});
            this.cbbDoi.Location = new System.Drawing.Point(707, 144);
            this.cbbDoi.Name = "cbbDoi";
            this.cbbDoi.Size = new System.Drawing.Size(161, 21);
            this.cbbDoi.TabIndex = 4;
            // 
            // cbbTieudoan
            // 
            this.cbbTieudoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTieudoan.FormattingEnabled = true;
            this.cbbTieudoan.Items.AddRange(new object[] {
            "Tiểu đoàn 1",
            "Tiểu đoàn 2",
            "Tiểu đoàn 3"});
            this.cbbTieudoan.Location = new System.Drawing.Point(707, 194);
            this.cbbTieudoan.Name = "cbbTieudoan";
            this.cbbTieudoan.Size = new System.Drawing.Size(161, 21);
            this.cbbTieudoan.TabIndex = 5;
            // 
            // cbbLudoan
            // 
            this.cbbLudoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbLudoan.FormattingEnabled = true;
            this.cbbLudoan.Items.AddRange(new object[] {
            "Lữ đoàn 1",
            "Lữ đoàn 2",
            "Lữ đoàn 3"});
            this.cbbLudoan.Location = new System.Drawing.Point(707, 253);
            this.cbbLudoan.Name = "cbbLudoan";
            this.cbbLudoan.Size = new System.Drawing.Size(161, 21);
            this.cbbLudoan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đội";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiểu đoàn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lữ đoàn";
            // 
            // FormDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLudoan);
            this.Controls.Add(this.cbbTieudoan);
            this.Controls.Add(this.cbbDoi);
            this.Controls.Add(this.DelDV);
            this.Controls.Add(this.ModifyDV);
            this.Controls.Add(this.AddDV);
            this.Controls.Add(this.dtgvDV);
            this.Name = "FormDV";
            this.Text = "Danh mục đơn vị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDV;
        private System.Windows.Forms.Button AddDV;
        private System.Windows.Forms.Button ModifyDV;
        private System.Windows.Forms.Button DelDV;
        private System.Windows.Forms.ComboBox cbbDoi;
        private System.Windows.Forms.ComboBox cbbTieudoan;
        private System.Windows.Forms.ComboBox cbbLudoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}