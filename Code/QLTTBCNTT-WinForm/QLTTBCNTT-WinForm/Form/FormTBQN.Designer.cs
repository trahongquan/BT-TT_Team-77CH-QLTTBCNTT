namespace QLTTBCNTT_WinForm
{
    partial class FormTBQN
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
            this.dtgvTBQN = new System.Windows.Forms.DataGridView();
            this.DelTBQN = new System.Windows.Forms.Button();
            this.ModifyTBQN = new System.Windows.Forms.Button();
            this.AddTBQN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbIDQN = new System.Windows.Forms.ComboBox();
            this.cbbIDTB = new System.Windows.Forms.ComboBox();
            this.DateBorrow = new System.Windows.Forms.DateTimePicker();
            this.DateReturn = new System.Windows.Forms.DateTimePicker();
            this.qLTTBCNTTDataSet = new QLTTBCNTT_WinForm.QLTTBCNTTDataSet();
            this.dMQuanNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_QuanNhanTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_QuanNhanTableAdapter();
            this.dMThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ThietBiTableAdapter = new QLTTBCNTT_WinForm.QLTTBCNTTDataSetTableAdapters.DM_ThietBiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTBQN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTBQN
            // 
            this.dtgvTBQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvTBQN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgvTBQN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTBQN.Location = new System.Drawing.Point(13, 13);
            this.dtgvTBQN.Name = "dtgvTBQN";
            this.dtgvTBQN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTBQN.Size = new System.Drawing.Size(554, 425);
            this.dtgvTBQN.TabIndex = 0;
            this.dtgvTBQN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvTBQN_MouseClick);
            // 
            // DelTBQN
            // 
            this.DelTBQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelTBQN.Location = new System.Drawing.Point(795, 48);
            this.DelTBQN.Name = "DelTBQN";
            this.DelTBQN.Size = new System.Drawing.Size(75, 23);
            this.DelTBQN.TabIndex = 1;
            this.DelTBQN.Text = "Xóa";
            this.DelTBQN.UseVisualStyleBackColor = true;
            this.DelTBQN.Click += new System.EventHandler(this.DelTBQN_Click);
            // 
            // ModifyTBQN
            // 
            this.ModifyTBQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyTBQN.Location = new System.Drawing.Point(692, 48);
            this.ModifyTBQN.Name = "ModifyTBQN";
            this.ModifyTBQN.Size = new System.Drawing.Size(75, 23);
            this.ModifyTBQN.TabIndex = 2;
            this.ModifyTBQN.Text = "Sửa";
            this.ModifyTBQN.UseVisualStyleBackColor = true;
            this.ModifyTBQN.Click += new System.EventHandler(this.ModifyTBQN_Click);
            // 
            // AddTBQN
            // 
            this.AddTBQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTBQN.Location = new System.Drawing.Point(591, 48);
            this.AddTBQN.Name = "AddTBQN";
            this.AddTBQN.Size = new System.Drawing.Size(75, 23);
            this.AddTBQN.TabIndex = 3;
            this.AddTBQN.Text = "Thêm";
            this.AddTBQN.UseVisualStyleBackColor = true;
            this.AddTBQN.Click += new System.EventHandler(this.AddTBQN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quân nhân";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thiết bị";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày biên chế";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trả biên chế";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm kiếm";
            // 
            // cbbIDQN
            // 
            this.cbbIDQN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIDQN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMQuanNhanBindingSource, "IDQuannhan", true));
            this.cbbIDQN.DataSource = this.dMQuanNhanBindingSource;
            this.cbbIDQN.DisplayMember = "Ten";
            this.cbbIDQN.FormattingEnabled = true;
            this.cbbIDQN.Location = new System.Drawing.Point(669, 118);
            this.cbbIDQN.Name = "cbbIDQN";
            this.cbbIDQN.Size = new System.Drawing.Size(129, 21);
            this.cbbIDQN.TabIndex = 10;
            this.cbbIDQN.ValueMember = "IDQuannhan";
            this.cbbIDQN.TextChanged += new System.EventHandler(this.ccbidQN_TextChanged);
            // 
            // cbbIDTB
            // 
            this.cbbIDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbIDTB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMThietBiBindingSource, "IdThietBi", true));
            this.cbbIDTB.DataSource = this.dMThietBiBindingSource;
            this.cbbIDTB.DisplayMember = "TenTB";
            this.cbbIDTB.FormattingEnabled = true;
            this.cbbIDTB.Location = new System.Drawing.Point(669, 156);
            this.cbbIDTB.Name = "cbbIDTB";
            this.cbbIDTB.Size = new System.Drawing.Size(129, 21);
            this.cbbIDTB.TabIndex = 11;
            this.cbbIDTB.ValueMember = "IdThietBi";
            this.cbbIDTB.TextChanged += new System.EventHandler(this.cbbidTB_TextChanged);
            // 
            // DateBorrow
            // 
            this.DateBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBorrow.Location = new System.Drawing.Point(669, 197);
            this.DateBorrow.Name = "DateBorrow";
            this.DateBorrow.Size = new System.Drawing.Size(129, 20);
            this.DateBorrow.TabIndex = 14;
            // 
            // DateReturn
            // 
            this.DateReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateReturn.Location = new System.Drawing.Point(669, 236);
            this.DateReturn.Name = "DateReturn";
            this.DateReturn.Size = new System.Drawing.Size(129, 20);
            this.DateReturn.TabIndex = 15;
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
            // dMThietBiBindingSource
            // 
            this.dMThietBiBindingSource.DataMember = "DM_ThietBi";
            this.dMThietBiBindingSource.DataSource = this.qLTTBCNTTDataSet;
            // 
            // dM_ThietBiTableAdapter
            // 
            this.dM_ThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // FormTBQN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 451);
            this.Controls.Add(this.DateReturn);
            this.Controls.Add(this.DateBorrow);
            this.Controls.Add(this.cbbIDTB);
            this.Controls.Add(this.cbbIDQN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTBQN);
            this.Controls.Add(this.ModifyTBQN);
            this.Controls.Add(this.DelTBQN);
            this.Controls.Add(this.dtgvTBQN);
            this.Name = "FormTBQN";
            this.Text = "FormTBQN";
            this.Load += new System.EventHandler(this.FormTBQN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTBQN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTBCNTTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMQuanNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMThietBiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTBQN;
        private System.Windows.Forms.Button DelTBQN;
        private System.Windows.Forms.Button ModifyTBQN;
        private System.Windows.Forms.Button AddTBQN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbIDQN;
        private System.Windows.Forms.ComboBox cbbIDTB;
        private System.Windows.Forms.DateTimePicker DateBorrow;
        private System.Windows.Forms.DateTimePicker DateReturn;
        private QLTTBCNTTDataSet qLTTBCNTTDataSet;
        private System.Windows.Forms.BindingSource dMQuanNhanBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_QuanNhanTableAdapter dM_QuanNhanTableAdapter;
        private System.Windows.Forms.BindingSource dMThietBiBindingSource;
        private QLTTBCNTTDataSetTableAdapters.DM_ThietBiTableAdapter dM_ThietBiTableAdapter;
    }
}