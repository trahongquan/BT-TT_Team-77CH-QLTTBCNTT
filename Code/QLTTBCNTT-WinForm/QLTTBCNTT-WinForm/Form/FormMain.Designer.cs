using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    partial class FormMain
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnQN = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.btnTBQN = new System.Windows.Forms.Button();
            this.btnTBDV = new System.Windows.Forms.Button();
            this.btnLTB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accMgrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::QLTTBCNTT_WinForm.Properties.Resources.BG;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Location = new System.Drawing.Point(166, 7);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(960, 654);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDB.Location = new System.Drawing.Point(1, 41);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(159, 82);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "Trang chủ";
            this.btnDB.UseVisualStyleBackColor = false;
            this.btnDB.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // btnTB
            // 
            this.btnTB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTB.Location = new System.Drawing.Point(1, 129);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(159, 82);
            this.btnTB.TabIndex = 3;
            this.btnTB.Text = "Thiết bị";
            this.btnTB.UseVisualStyleBackColor = false;
            this.btnTB.Click += new System.EventHandler(this.btnChildFormTB_Click);
            // 
            // btnQN
            // 
            this.btnQN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQN.Location = new System.Drawing.Point(1, 217);
            this.btnQN.Name = "btnQN";
            this.btnQN.Size = new System.Drawing.Size(159, 82);
            this.btnQN.TabIndex = 4;
            this.btnQN.Text = "Quân nhân";
            this.btnQN.UseVisualStyleBackColor = false;
            this.btnQN.Click += new System.EventHandler(this.btnChildFormQN_Click);
            // 
            // btnDV
            // 
            this.btnDV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDV.Location = new System.Drawing.Point(1, 305);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(159, 82);
            this.btnDV.TabIndex = 5;
            this.btnDV.Text = "Đơn vị";
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnChildFormDV_Click);
            // 
            // btnTBQN
            // 
            this.btnTBQN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTBQN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBQN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTBQN.Location = new System.Drawing.Point(1, 393);
            this.btnTBQN.Name = "btnTBQN";
            this.btnTBQN.Size = new System.Drawing.Size(159, 82);
            this.btnTBQN.TabIndex = 6;
            this.btnTBQN.Text = "Quân nhân - Thiết bị";
            this.btnTBQN.UseVisualStyleBackColor = false;
            this.btnTBQN.Click += new System.EventHandler(this.btnChildFormTBQN_Click);
            // 
            // btnTBDV
            // 
            this.btnTBDV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTBDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBDV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTBDV.Location = new System.Drawing.Point(1, 481);
            this.btnTBDV.Name = "btnTBDV";
            this.btnTBDV.Size = new System.Drawing.Size(159, 82);
            this.btnTBDV.TabIndex = 7;
            this.btnTBDV.Text = "Đơn vị - Thiết bị";
            this.btnTBDV.UseVisualStyleBackColor = false;
            this.btnTBDV.Click += new System.EventHandler(this.btnChildFormTBDV_Click);
            // 
            // btnLTB
            // 
            this.btnLTB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLTB.Location = new System.Drawing.Point(1, 569);
            this.btnLTB.Name = "btnLTB";
            this.btnLTB.Size = new System.Drawing.Size(159, 82);
            this.btnLTB.TabIndex = 8;
            this.btnLTB.Text = "Loại thiết bị";
            this.btnLTB.UseVisualStyleBackColor = false;
            this.btnLTB.Click += new System.EventHandler(this.btnChildFormDMTB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccToolStripMenuItem
            // 
            this.AccToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accMgrToolStripMenuItem,
            this.changePassToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.AccToolStripMenuItem.Name = "AccToolStripMenuItem";
            this.AccToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.AccToolStripMenuItem.Text = "Tài khoản";
            // 
            // accMgrToolStripMenuItem
            // 
            this.accMgrToolStripMenuItem.Name = "accMgrToolStripMenuItem";
            this.accMgrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accMgrToolStripMenuItem.Text = "Quản lý tài khoản";
            this.accMgrToolStripMenuItem.Visible = false;
            this.accMgrToolStripMenuItem.Click += new System.EventHandler(this.accMgrToolStripMenuItem_Click);
            // 
            // changePassToolStripMenuItem
            // 
            this.changePassToolStripMenuItem.Name = "changePassToolStripMenuItem";
            this.changePassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePassToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePassToolStripMenuItem.Click += new System.EventHandler(this.changePassToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLTB);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnTBDV);
            this.Controls.Add(this.btnTB);
            this.Controls.Add(this.btnTBQN);
            this.Controls.Add(this.btnQN);
            this.Controls.Add(this.btnDV);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Quản lý Trang thiết bị CNTT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktopPane;
        private Button btnDB;
        private Button btnTB;
        private Button btnQN;
        private Button btnDV;
        private Button btnTBQN;
        private Button btnTBDV;
        private Button btnLTB;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AccToolStripMenuItem;
        private ToolStripMenuItem accMgrToolStripMenuItem;
        private ToolStripMenuItem changePassToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

