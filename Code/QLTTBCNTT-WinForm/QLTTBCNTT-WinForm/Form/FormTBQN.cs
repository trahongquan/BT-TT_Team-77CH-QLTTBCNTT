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
    public partial class FormTBQN : Form
    {
        public FormTBQN()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        QueryTBQN QueryTBQN = new QueryTBQN();

        private void FormTBQN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_ThietBi' table. You can move, or remove it, as needed.
            this.dM_ThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_ThietBi);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_QuanNhan' table. You can move, or remove it, as needed.
            this.dM_QuanNhanTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_QuanNhan);
            Reload();
            dtgvTBQN.Columns[0].HeaderText = "IDTBQN";
            dtgvTBQN.Columns[1].HeaderText = "ID Quân nhân";
            dtgvTBQN.Columns[2].HeaderText = "ID Thiết bị";
            dtgvTBQN.Columns[3].HeaderText = "Ngày biên chế";
            dtgvTBQN.Columns[4].HeaderText = "Ngày trả biên chế";

        }

        #region Button Funcion
        private void AddTBQN_Click(object sender, EventArgs e)
        {
            if (CheckIDTB_TBDV())
            {
                if (Input())
                {
                    QueryTBQN.Insert(GetTBQN());
                    Reload();
                    dtgvTBQN.Refresh();
                }
            }
            else { return; }
        }
        private void ModifyTBQN_Click(object sender, EventArgs e)
        {
            if (dtgvTBQN.SelectedRows.Count == 0)
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
                QueryTBQN.Modify(GetTBQN(), int.Parse(dtgvTBQN.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelTBQN_Click(object sender, EventArgs e)
        {
            if (dtgvTBQN.SelectedRows.Count == 0)
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
                QueryTBQN.Delete(int.Parse(dtgvTBQN.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private TBQN GetTBQN()
        {
            int idQN = int.Parse(cbbIDQN.SelectedValue.ToString());
            int idTB = int.Parse(cbbIDTB.SelectedValue.ToString());
            TBQN TBDV = new TBQN(idQN, idTB, DateBorrow.Value.ToString(), DateReturn.Value.ToString());
            return TBDV;
        }
        private bool Input()
        {
            if (cbbIDQN.Text == "" || cbbIDTB.Text == "")
            {
                MessageBox.Show("Không được để trống trường đơn vị và thiết bị");
                return false;
            }
            return true;
        }
        private void Clear()
        {
            //txtQN.Text = "";
            cbbIDQN.Text = "";
            //txtTB.Text = "";
            cbbIDTB.Text = "";
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvTBQN.DataSource = QueryTBQN.getDS_TBQN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var TBQN = dtgvTBQN.SelectedRows[0];
            cbbIDQN.SelectedValue = TBQN.Cells[1].Value;
            cbbIDTB.SelectedValue = TBQN.Cells[2].Value;
            if (TBQN.Cells[3].Value.ToString() != "") DateBorrow.Value = Convert.ToDateTime(TBQN.Cells[3].Value.ToString());
            if (TBQN.Cells[4].Value.ToString() != "") DateReturn.Value = Convert.ToDateTime(TBQN.Cells[4].Value.ToString());
        }

        private void dtgvTBQN_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }
        private void ccbidQN_TextChanged(object sender, EventArgs e)
        {
           // if (cbbIDQN.Text != "") txtQN.Text = QueryTBQN.getTBQN_idQN(cbbIDQN.Text);
        }

        private Boolean CheckIDTB_TBDV()
        {
            string ds = QueryTBQN.getTBQN_idTB_check(cbbIDTB.Text);
            if (ds != "")
            {
                MessageBox.Show("Thiết bị đã được biên chế hoặc được cho mượn. Xin vui lòng chọn thiết bị khác!");
                cbbIDTB.Text = "";
                return false;
            }
            else return true;
        }
        private void cbbidTB_TextChanged(object sender, EventArgs e)
        {
           // if (cbbIDTB.Text != "") txtTB.Text = QueryTBQN.getTBDV_idTB(cbbIDTB.Text);
        }

        #endregion

    }
}
