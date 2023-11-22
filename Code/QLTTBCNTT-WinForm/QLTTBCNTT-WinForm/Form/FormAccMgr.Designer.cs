namespace QLTTBCNTT_WinForm
{
    partial class FormAccMgr
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
            this.dtgvAcc = new System.Windows.Forms.DataGridView();
            this.cbbQN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbKindOfAcc = new System.Windows.Forms.ComboBox();
            this.labelPQ = new System.Windows.Forms.Label();
            this.labelCMTQD = new System.Windows.Forms.Label();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDelAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAccActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLTTBCNTTDataSet = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet();
            this.dMQuanNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_QuanNhanTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_QuanNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAcc
            // 
            this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcc.Location = new System.Drawing.Point(29, 117);
            this.dtgvAcc.Name = "dtgvAcc";
            this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAcc.Size = new System.Drawing.Size(549, 193);
            this.dtgvAcc.TabIndex = 1;
            this.dtgvAcc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvAcc_MouseClick_1);
            // 
            // cbbQN
            // 
            this.cbbQN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMQuanNhanBindingSource, "IDQuannhan", true));
            this.cbbQN.DataSource = this.dMQuanNhanBindingSource;
            this.cbbQN.DisplayMember = "Ten";
            this.cbbQN.FormattingEnabled = true;
            this.cbbQN.Location = new System.Drawing.Point(408, 37);
            this.cbbQN.Name = "cbbQN";
            this.cbbQN.Size = new System.Drawing.Size(161, 21);
            this.cbbQN.TabIndex = 2;
            this.cbbQN.ValueMember = "IDQuannhan";
            this.cbbQN.TextChanged += new System.EventHandler(this.cbbQN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(143, 34);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(133, 20);
            this.txtTK.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(143, 62);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(133, 20);
            this.txtMK.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại tài khoản";
            // 
            // cbbKindOfAcc
            // 
            this.cbbKindOfAcc.FormattingEnabled = true;
            this.cbbKindOfAcc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbKindOfAcc.Location = new System.Drawing.Point(408, 67);
            this.cbbKindOfAcc.Name = "cbbKindOfAcc";
            this.cbbKindOfAcc.Size = new System.Drawing.Size(84, 21);
            this.cbbKindOfAcc.TabIndex = 9;
            // 
            // labelPQ
            // 
            this.labelPQ.AutoSize = true;
            this.labelPQ.Location = new System.Drawing.Point(498, 62);
            this.labelPQ.Name = "labelPQ";
            this.labelPQ.Size = new System.Drawing.Size(70, 52);
            this.labelPQ.TabIndex = 10;
            this.labelPQ.Text = "Phần quyền: \r\n1- Admin; \r\n2- Operator; \r\n3- Engineer";
            // 
            // labelCMTQD
            // 
            this.labelCMTQD.AutoSize = true;
            this.labelCMTQD.Location = new System.Drawing.Point(57, 98);
            this.labelCMTQD.Name = "labelCMTQD";
            this.labelCMTQD.Size = new System.Drawing.Size(0, 13);
            this.labelCMTQD.TabIndex = 11;
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // listDelAccToolStripMenuItem
            // 
            this.listDelAccToolStripMenuItem.Name = "listDelAccToolStripMenuItem";
            this.listDelAccToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.listDelAccToolStripMenuItem.Text = "ListDelAcc";
            this.listDelAccToolStripMenuItem.Click += new System.EventHandler(this.listDelAccToolStripMenuItem_Click);
            // 
            // listAccActiveToolStripMenuItem
            // 
            this.listAccActiveToolStripMenuItem.Name = "listAccActiveToolStripMenuItem";
            this.listAccActiveToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.listAccActiveToolStripMenuItem.Text = "ListAccActive";
            this.listAccActiveToolStripMenuItem.Click += new System.EventHandler(this.listAccActiveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.listDelAccToolStripMenuItem,
            this.listAccActiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLTTBCNTTDataSet
            // 
            this.qLTTBCNTTDataSet.DataSetName = "QLTTBCNTTDataSet";
            this.qLTTBCNTTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMQuanNhanBindingSource
            // 
            this.dMQuanNhanBindingSource.DataMember = "DM_QuanNhan";
            this.dMQuanNhanBindingSource.DataSource = this.qLTTBCNTTDataSet;
            // 
            // dM_QuanNhanTableAdapter
            // 
            this.dM_QuanNhanTableAdapter.ClearBeforeFill = true;
            // 
            // FormAccMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.labelCMTQD);
            this.Controls.Add(this.labelPQ);
            this.Controls.Add(this.cbbKindOfAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbQN);
            this.Controls.Add(this.dtgvAcc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccMgr";
            this.Text = "FormAccMgr";
            this.Load += new System.EventHandler(this.FormAccMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvAcc;
        private System.Windows.Forms.ComboBox cbbQN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbKindOfAcc;
        private System.Windows.Forms.Label labelPQ;
        private System.Windows.Forms.Label labelCMTQD;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDelAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAccActiveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private QLTTBCNTTDataSet qLTTBCNTTDataSet;
        private System.Windows.Forms.BindingSource dMQuanNhanBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_QuanNhanTableAdapter dM_QuanNhanTableAdapter;
    }
}