namespace QLTTBCNTT_WinForm
{
    partial class Dashboard
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
            this.dtgvDashboard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchTenTB = new System.Windows.Forms.TextBox();
            this.txtSearchTenQN = new System.Windows.Forms.TextBox();
            this.txtSearchDV = new System.Windows.Forms.TextBox();
            this.btnBRG_DB = new System.Windows.Forms.Button();
            this.btnTBQN_DB = new System.Windows.Forms.Button();
            this.btnTBDV_DB = new System.Windows.Forms.Button();
            this.RB_Doi = new System.Windows.Forms.RadioButton();
            this.RB_TieuDoan = new System.Windows.Forms.RadioButton();
            this.RB_LuDoan = new System.Windows.Forms.RadioButton();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDashboard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDashboard
            // 
            this.dtgvDashboard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDashboard.Location = new System.Drawing.Point(2, 2);
            this.dtgvDashboard.Name = "dtgvDashboard";
            this.dtgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDashboard.Size = new System.Drawing.Size(589, 572);
            this.dtgvDashboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo tên thiết bị";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo tên quân nhân";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm theo đơn vị";
            // 
            // txtSearchTenTB
            // 
            this.txtSearchTenTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchTenTB.Location = new System.Drawing.Point(28, 80);
            this.txtSearchTenTB.Name = "txtSearchTenTB";
            this.txtSearchTenTB.Size = new System.Drawing.Size(142, 20);
            this.txtSearchTenTB.TabIndex = 4;
            this.txtSearchTenTB.TextChanged += new System.EventHandler(this.txtSearchTenTB_TextChanged);
            // 
            // txtSearchTenQN
            // 
            this.txtSearchTenQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchTenQN.Location = new System.Drawing.Point(28, 142);
            this.txtSearchTenQN.Name = "txtSearchTenQN";
            this.txtSearchTenQN.Size = new System.Drawing.Size(142, 20);
            this.txtSearchTenQN.TabIndex = 5;
            this.txtSearchTenQN.TextChanged += new System.EventHandler(this.txtSearchTenQN_TextChanged);
            // 
            // txtSearchDV
            // 
            this.txtSearchDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchDV.Location = new System.Drawing.Point(28, 214);
            this.txtSearchDV.Name = "txtSearchDV";
            this.txtSearchDV.Size = new System.Drawing.Size(142, 20);
            this.txtSearchDV.TabIndex = 6;
            this.txtSearchDV.TextChanged += new System.EventHandler(this.txtSearchDV_TextChanged);
            // 
            // btnBRG_DB
            // 
            this.btnBRG_DB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBRG_DB.Location = new System.Drawing.Point(3, 10);
            this.btnBRG_DB.Name = "btnBRG_DB";
            this.btnBRG_DB.Size = new System.Drawing.Size(84, 23);
            this.btnBRG_DB.TabIndex = 7;
            this.btnBRG_DB.Text = "Bảng rút gọn";
            this.btnBRG_DB.UseVisualStyleBackColor = true;
            this.btnBRG_DB.Click += new System.EventHandler(this.btnBRG_DB_Click);
            // 
            // btnTBQN_DB
            // 
            this.btnTBQN_DB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTBQN_DB.Location = new System.Drawing.Point(3, 49);
            this.btnTBQN_DB.Name = "btnTBQN_DB";
            this.btnTBQN_DB.Size = new System.Drawing.Size(84, 23);
            this.btnTBQN_DB.TabIndex = 8;
            this.btnTBQN_DB.Text = "QN mượn";
            this.btnTBQN_DB.UseVisualStyleBackColor = true;
            this.btnTBQN_DB.Click += new System.EventHandler(this.btnTBQN_DB_Click);
            // 
            // btnTBDV_DB
            // 
            this.btnTBDV_DB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTBDV_DB.Location = new System.Drawing.Point(104, 49);
            this.btnTBDV_DB.Name = "btnTBDV_DB";
            this.btnTBDV_DB.Size = new System.Drawing.Size(84, 23);
            this.btnTBDV_DB.TabIndex = 9;
            this.btnTBDV_DB.Text = "ĐV mượn";
            this.btnTBDV_DB.UseVisualStyleBackColor = true;
            this.btnTBDV_DB.Click += new System.EventHandler(this.btnTBDV_DB_Click);
            // 
            // RB_Doi
            // 
            this.RB_Doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RB_Doi.AutoSize = true;
            this.RB_Doi.Location = new System.Drawing.Point(1, 240);
            this.RB_Doi.Name = "RB_Doi";
            this.RB_Doi.Size = new System.Drawing.Size(41, 17);
            this.RB_Doi.TabIndex = 10;
            this.RB_Doi.TabStop = true;
            this.RB_Doi.Text = "Đội";
            this.RB_Doi.UseVisualStyleBackColor = true;
            // 
            // RB_TieuDoan
            // 
            this.RB_TieuDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RB_TieuDoan.AutoSize = true;
            this.RB_TieuDoan.Location = new System.Drawing.Point(48, 240);
            this.RB_TieuDoan.Name = "RB_TieuDoan";
            this.RB_TieuDoan.Size = new System.Drawing.Size(74, 17);
            this.RB_TieuDoan.TabIndex = 11;
            this.RB_TieuDoan.TabStop = true;
            this.RB_TieuDoan.Text = "Tiểu đoàn";
            this.RB_TieuDoan.UseVisualStyleBackColor = true;
            // 
            // RB_LuDoan
            // 
            this.RB_LuDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RB_LuDoan.AutoSize = true;
            this.RB_LuDoan.Location = new System.Drawing.Point(128, 240);
            this.RB_LuDoan.Name = "RB_LuDoan";
            this.RB_LuDoan.Size = new System.Drawing.Size(66, 17);
            this.RB_LuDoan.TabIndex = 12;
            this.RB_LuDoan.TabStop = true;
            this.RB_LuDoan.Text = "Lữ Đoàn";
            this.RB_LuDoan.UseVisualStyleBackColor = true;
            // 
            // btnThongke
            // 
            this.btnThongke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongke.Location = new System.Drawing.Point(681, 437);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(84, 23);
            this.btnThongke.TabIndex = 13;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.Location = new System.Drawing.Point(104, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 23);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBRG_DB);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnTBQN_DB);
            this.groupBox1.Controls.Add(this.btnTBDV_DB);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(630, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 82);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtSearchDV);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RB_LuDoan);
            this.groupBox2.Controls.Add(this.RB_TieuDoan);
            this.groupBox2.Controls.Add(this.txtSearchTenTB);
            this.groupBox2.Controls.Add(this.RB_Doi);
            this.groupBox2.Controls.Add(this.txtSearchTenQN);
            this.groupBox2.Location = new System.Drawing.Point(633, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 299);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.dtgvDashboard);
            this.Name = "Dashboard";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDashboard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchTenTB;
        private System.Windows.Forms.TextBox txtSearchTenQN;
        private System.Windows.Forms.TextBox txtSearchDV;
        private System.Windows.Forms.Button btnBRG_DB;
        private System.Windows.Forms.Button btnTBQN_DB;
        private System.Windows.Forms.Button btnTBDV_DB;
        private System.Windows.Forms.RadioButton RB_Doi;
        private System.Windows.Forms.RadioButton RB_TieuDoan;
        private System.Windows.Forms.RadioButton RB_LuDoan;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}