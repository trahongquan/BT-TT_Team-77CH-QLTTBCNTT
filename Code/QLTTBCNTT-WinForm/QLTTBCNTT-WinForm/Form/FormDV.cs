using QLTTBCNTT_WinForm.Object;
using QLTTBCNTT_WinForm.suport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    public partial class FormDV : Form
    {
        QueryDonvi QueryDV = new QueryDonvi();
        public FormDV()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void FormDV_Load(object sender, EventArgs e)
        {
            Reload();
            dtgvDV.Columns[0].HeaderText = "IDDV";
            dtgvDV.Columns[1].HeaderText = "Đội";
            dtgvDV.Columns[2].HeaderText = "Tiểu đoàn";
            dtgvDV.Columns[3].HeaderText = "Lữ đoàn";
        }


        #region Button Funcion
        private void AddDV_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                QueryDV.Insert(GetDV());
                Reload();
                dtgvDV.Refresh();
            }
        }
        private void ModifyDV_Click(object sender, EventArgs e)
        {
            if (dtgvDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng");
                return;
            }

            DialogResult dlr = new DialogResult();

            dlr = (DialogResult)MessageBox.Show("Sửa đổi thông tin?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr.Equals(DialogResult.No))
            {
                return;
            }

            try
            {
                QueryDV.Modify(GetDV(), int.Parse(dtgvDV.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelTDV_Click(object sender, EventArgs e)
        {
            if (dtgvDV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn dòng");
                return;
            }
            DialogResult dlr = new DialogResult();

            dlr = (DialogResult)MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlr.Equals(DialogResult.No))
            {
                return;
            }
            try
            {
                QueryDV.Delete(int.Parse(dtgvDV.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private Donvi GetDV()
        {
            Donvi DV = new Donvi(cbbDoi.Text, cbbTieudoan.Text, cbbLudoan.Text);
            return DV;
        }
        private bool Input()
        {
            if (cbbLudoan.Text == "") { 
                MessageBox.Show("Không được để trống cấp Lữ đoàn");
                return false; }
            return true;
        }
        private void Clear()
        {
            cbbDoi.GetItemText(0);
            cbbTieudoan.GetItemText(0);
            cbbLudoan.GetItemText(0);
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvDV.DataSource = QueryDV.getDS_Donvi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var DV = dtgvDV.SelectedRows[0];
            cbbDoi.Text = DV.Cells[1].Value.ToString();
            cbbTieudoan.Text = DV.Cells[2].Value.ToString();
            cbbLudoan.Text = DV.Cells[3].Value.ToString();
        }

        private void dtgvDV_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }
        
        #endregion
    }

}
