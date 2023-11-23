namespace QLTTBCNTT_WinForm
{
    partial class Report
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
            this.reportTB = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReportTB = new System.Windows.Forms.Button();
            this.btnTB_tonkho = new System.Windows.Forms.Button();
            this.btnTBQN = new System.Windows.Forms.Button();
            this.btnTBDV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportTB
            // 
            this.reportTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTB.Location = new System.Drawing.Point(12, 71);
            this.reportTB.Name = "reportTB";
            this.reportTB.ServerReport.BearerToken = null;
            this.reportTB.Size = new System.Drawing.Size(776, 367);
            this.reportTB.TabIndex = 1;
            // 
            // btnReportTB
            // 
            this.btnReportTB.Location = new System.Drawing.Point(21, 12);
            this.btnReportTB.Name = "btnReportTB";
            this.btnReportTB.Size = new System.Drawing.Size(75, 23);
            this.btnReportTB.TabIndex = 2;
            this.btnReportTB.Text = "Ds Thiết bị";
            this.btnReportTB.UseVisualStyleBackColor = true;
            this.btnReportTB.Click += new System.EventHandler(this.btnReportTB_Click);
            // 
            // btnTB_tonkho
            // 
            this.btnTB_tonkho.Location = new System.Drawing.Point(21, 41);
            this.btnTB_tonkho.Name = "btnTB_tonkho";
            this.btnTB_tonkho.Size = new System.Drawing.Size(116, 23);
            this.btnTB_tonkho.TabIndex = 3;
            this.btnTB_tonkho.Text = "Ds TB còn tồn kho";
            this.btnTB_tonkho.UseVisualStyleBackColor = true;
            this.btnTB_tonkho.Click += new System.EventHandler(this.btnTB_tonkho_Click);
            // 
            // btnTBQN
            // 
            this.btnTBQN.Enabled = false;
            this.btnTBQN.Location = new System.Drawing.Point(161, 12);
            this.btnTBQN.Name = "btnTBQN";
            this.btnTBQN.Size = new System.Drawing.Size(161, 23);
            this.btnTBQN.TabIndex = 4;
            this.btnTBQN.Text = "Ds TB cho Quân nhân mượn";
            this.btnTBQN.UseVisualStyleBackColor = true;
            this.btnTBQN.Click += new System.EventHandler(this.btnTBQN_Click);
            // 
            // btnTBDV
            // 
            this.btnTBDV.Enabled = false;
            this.btnTBDV.Location = new System.Drawing.Point(161, 41);
            this.btnTBDV.Name = "btnTBDV";
            this.btnTBDV.Size = new System.Drawing.Size(161, 23);
            this.btnTBDV.TabIndex = 5;
            this.btnTBDV.Text = "Ds TB cho Đơn vị mượn";
            this.btnTBDV.UseVisualStyleBackColor = true;
            this.btnTBDV.Click += new System.EventHandler(this.btnTBDV_Click);
            // 
            // Report
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTBDV);
            this.Controls.Add(this.btnTBQN);
            this.Controls.Add(this.btnTB_tonkho);
            this.Controls.Add(this.btnReportTB);
            this.Controls.Add(this.reportTB);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportTB;
        private System.Windows.Forms.Button btnReportTB;
        private System.Windows.Forms.Button btnTB_tonkho;
        private System.Windows.Forms.Button btnTBQN;
        private System.Windows.Forms.Button btnTBDV;
    }
}