namespace QLTTBCNTT_WinForm
{
    partial class FormDMLTB
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
            this.dtgvDMLTB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMLTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDMLTB
            // 
            this.dtgvDMLTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgvDMLTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDMLTB.Location = new System.Drawing.Point(13, 13);
            this.dtgvDMLTB.Name = "dtgvDMLTB";
            this.dtgvDMLTB.Size = new System.Drawing.Size(582, 425);
            this.dtgvDMLTB.TabIndex = 0;
            // 
            // FormDMLTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.dtgvDMLTB);
            this.Name = "FormDMLTB";
            this.Text = "FormDMLTB";
            this.Load += new System.EventHandler(this.FormDMLTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMLTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDMLTB;
    }
}