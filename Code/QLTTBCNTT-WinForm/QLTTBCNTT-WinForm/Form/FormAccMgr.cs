using QLTTBCNTT_WinForm.Object;
using QLTTBCNTT_WinForm.suport;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    public partial class FormAccMgr : Form
    {
        private QueryTK SQL = new QueryTK();
        public FormAccMgr()
        {
            InitializeComponent();
        }

        private void FormAccMgr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_QuanNhan' table. You can move, or remove it, as needed.
            this.dM_QuanNhanTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_QuanNhan);
            dtgvAcc.DataSource = SQL.getTableAccount();

        }

        #region Bổ trợ
        private void ScrClr()
        {
            txtTK.Text = "";
            txtMK.Text = "";
            cbbQN.Text = "";
        }
        private void Display()
        {
            try
            {
                var x = dtgvAcc.SelectedRows[0];
                txtTK.Text = x.Cells[2].Value.ToString();
                txtMK.Text = x.Cells[3].Value.ToString();
                cbbQN.Text = x.Cells[6].Value.ToString();
                cbbKindOfAcc.Text = x.Cells[5].Value.ToString();
                labelCMTQD.Text = x.Cells[7].Value.ToString();  
            }
            catch
            {
                ScrClr();
            }

        }
        private string fixString(string sent)
        {
            sent = sent.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            sent = trimmer.Replace(sent, " ");

            return sent;
        }
        private Account getAcc()
        {

            txtMK.Text = fixString(txtMK.Text);
            txtTK.Text = fixString(txtTK.Text);

            int idQN = int.Parse(cbbQN.SelectedValue.ToString());
            int KindOfAcc = int.Parse(cbbKindOfAcc.Text);


            return new Account(idQN, txtTK.Text, txtMK.Text, 1, KindOfAcc, cbbQN.Text, labelCMTQD.Text);
        }

        #endregion

        #region Thêm, Sửa, Xoá
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new QueryQuannhan().getDS_Quannhan();
            DataRow[] rows = dataTable.Select("CMTQD = '" + getAcc().CMTQD1 + "'");
            if (rows.Length > 0)
            {
                MessageBox.Show("Tài khoản này đã được cấp, xin vui lòng kiểm tra lại");
            }
            else
            {
                try
                {
                    SQL.Insert(getAcc());
                    dtgvAcc.DataSource = SQL.getTableAccount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvAcc.SelectedRows.Count > 0)
            {
                try
                {
                    SQL.ModifyInfo(txtTK.Text, cbbQN.Text, labelCMTQD.Text, cbbKindOfAcc.Text, dtgvAcc.SelectedRows[0].Cells[0].Value.ToString());
                    dtgvAcc.DataSource = SQL.getTableAccount();
                    MessageBox.Show("Thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng");
            }
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvAcc.SelectedRows.Count > 0)
            {
                try
                {
                    SQL.Delete(dtgvAcc.SelectedRows[0].Cells[0].Value.ToString());
                    dtgvAcc.DataSource = SQL.getTableAccount();
                    MessageBox.Show("Thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng");
            }
        }
        #endregion
        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvAcc_MouseClick_1(object sender, MouseEventArgs e)
        {
            Display() ;
        }

        private void listDelAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgvAcc.DataSource = SQL.getTabDeletedAcc();
            thêmToolStripMenuItem.Enabled = false;
            xóaToolStripMenuItem.Enabled = false;
            sửaToolStripMenuItem.Enabled = false;
        }

        private void listAccActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgvAcc.DataSource = SQL.getTableAccount();
            thêmToolStripMenuItem.Enabled = true;
            xóaToolStripMenuItem.Enabled= true;
            sửaToolStripMenuItem.Enabled = true;
        }

        private void cbbQN_TextChanged(object sender, EventArgs e)
        {
            labelCMTQD.Text = "Số CMTQĐ: " + new QueryQuannhan().FindCMTQDbyidQN(int.Parse(cbbQN.SelectedValue.ToString()));
        }
    }
}
