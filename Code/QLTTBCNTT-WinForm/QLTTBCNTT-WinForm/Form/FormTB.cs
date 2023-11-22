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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLTTBCNTT_WinForm
{
    public partial class FormTB : Form
    {
        QueryTB QueryTB = new QueryTB();
        public FormTB()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void FormTB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_Donvi' table. You can move, or remove it, as needed.
            this.dM_DonviTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_Donvi);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_QuanNhan' table. You can move, or remove it, as needed.
            this.dM_QuanNhanTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_QuanNhan);
            // TODO: This line of code loads data into the 'qLTTBCNTTDataSet.DM_LoaiThietBi' table. You can move, or remove it, as needed.
            this.dM_LoaiThietBiTableAdapter.Fill(this.qLTTBCNTTDataSet.DM_LoaiThietBi);

            Reload();
            dtgvTB.Columns[0].HeaderText = "IDTB";
            dtgvTB.Columns[1].HeaderText = "Loại";
            dtgvTB.Columns[2].HeaderText = "Tên";
            dtgvTB.Columns[3].HeaderText = "Số Seri";
            dtgvTB.Columns[4].HeaderText = "MAC";
            dtgvTB.Columns[5].HeaderText = "CoreCPU";
            dtgvTB.Columns[6].HeaderText = "RAM";
            dtgvTB.Columns[7].HeaderText = "HardDisk";
            dtgvTB.Columns[8].HeaderText = "Màn hình";
            dtgvTB.Columns[9].HeaderText = "IDQN";
            dtgvTB.Columns[10].HeaderText = "IDDV";
            dtgvTB.Columns[11].HeaderText = "Tình trạng";
            dtgvTB.Columns[12].HeaderText = "Tồn kho";
        }

        #region Button Funcion
        private void AddTB_Click(object sender, EventArgs e)
        {
            if(Input()) {
                MessageBox.Show("idqn = " + cbbidQN.Text + "và idDV = " + cbbidDV.Text);
                if(cbTonkho.Checked == false && cbbidQN.Text == "" ) { MessageBox.Show("Bạn cần chọn biên chế cho thiết bị\nHoặc bạn cần đặt thiết bị còn trong kho"); return; }
                if(cbTonkho.Checked == false && cbbidDV.Text == "" ) { MessageBox.Show("Bạn cần chọn biên chế cho thiết bị\nHoặc bạn cần đặt thiết bị còn trong kho"); return; }
                QueryTB.Insert(GetDMTB());
                Reload();
                dtgvTB.Refresh();
            }
        }
        private void ModifyTB_Click(object sender, EventArgs e)
        {
            if (dtgvTB.SelectedRows.Count == 0)
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
                QueryTB.Modify(GetDMTB(), int.Parse(dtgvTB.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelTB_Click(object sender, EventArgs e)
        {
            if (dtgvTB.SelectedRows.Count == 0)
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
                QueryTB.Delete(int.Parse(dtgvTB.SelectedRows[0].Cells[0].Value.ToString()));
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Bổ trợ

        private Thietbi GetDMTB()
        {
            int idLTB = int.Parse(cbbIDLTB.SelectedValue.ToString());
            if (cbTonkho.Checked)
            {
                Thietbi DMTB = new Thietbi(idLTB,
                                    txtTenTB.Text, txtSeri.Text, txtMAC.Text, txtCoreCPU.Text,
                                    cbbRAM.Text, cbbHardDisk.Text, txtMonitor.Text,
                                    1, cbbTinhtrang.Text);
                return DMTB;
            }
            else
            {
                int idDV = int.Parse(cbbidDV.SelectedValue.ToString());
                int idQN = int.Parse(cbbidQN.SelectedValue.ToString());
                Thietbi DMTB = new Thietbi(idLTB, idQN, idDV,
                                    txtTenTB.Text, txtSeri.Text, txtMAC.Text, txtCoreCPU.Text,
                                    cbbRAM.Text, cbbHardDisk.Text, txtMonitor.Text, 0, cbbTinhtrang.Text);
                return DMTB;

            }


        }
        private bool Input()
        {
            if (txtTenTB.Text == "" || txtSeri.Text == "" || cbbIDLTB.Text == "") { 
                MessageBox.Show("Bạn cần nhập đủ trường Tên, Seri và Id loại thiết bị");
                return false; }
            return true;
        }
        private void Clear()
        {
            cbbIDLTB.GetItemText(0);
            cbbidQN.Text = "";
            txtDonvi.Text = "";
            cbbidDV.Text = "";
            txtTenTB.Text = "";
            txtSeri.Text = "";
            txtMAC.Text = "";
            txtCoreCPU.Text = "";
            cbbRAM.GetItemText(0);
            cbbHardDisk.GetItemText(0);
            txtMonitor.Text = "";
            cbTonkho.Checked = true;
            cbbTinhtrang.SelectedIndex = 0;
        }

        private void Reload()
        {
            Clear();
            try
            {
                dtgvTB.DataSource = QueryTB.getDS_Thietbi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Display()
        {
            var TB = dtgvTB.SelectedRows[0];
            cbbIDLTB.SelectedValue = TB.Cells[1].Value;
            if (!TB.Cells[9].Value.ToString().Equals("")) { cbbidQN.SelectedValue = TB.Cells[9].Value.ToString(); } else { cbbidQN.Text = ""; }
            
            cbbidDV.Text = TB.Cells[10].Value.ToString();
            txtTenTB.Text = TB.Cells[2].Value.ToString();
            txtSeri.Text = TB.Cells[3].Value.ToString();
            txtMAC.Text = TB.Cells[4].Value.ToString();
            txtCoreCPU.Text = TB.Cells[5].Value.ToString();
            cbbRAM.Text = TB.Cells[6].Value.ToString();
            cbbHardDisk.Text = TB.Cells[7].Value.ToString();
            txtMonitor.Text = TB.Cells[8].Value.ToString();
            cbbTinhtrang.Text = TB.Cells[11].Value.ToString();
            CheckTonkho(TB.Cells[12].Value.ToString());
        }

        private void dtgvTB_MouseClick(object sender, MouseEventArgs e)
        {
            Display();
        }

        #endregion

        #region TextChanged
        private void ccbidQN_TextChanged(object sender, EventArgs e)
        {
            if (cbbidQN.Text != "")
            {
                //txtQN.Text = QueryTB.getQN_Thietbi(cbbidQN.SelectedValue.ToString()).Tables[0].Rows[0][0].ToString();
                txtDonvi.Enabled = false;
                cbbidDV.Enabled = false;
                cbbidDV.Text = QueryTB.getQN_Thietbi(cbbidQN.SelectedValue.ToString()).Tables[0].Rows[0][1].ToString();
            }
        }

        private void cbbidDV_TextChanged(object sender, EventArgs e)
        {
            if (cbbidDV.Text != "") txtDonvi.Text = QueryTB.getDV_Thietbi(cbbidDV.Text).Tables[0].Rows[0][0].ToString() + ", " + QueryTB.getDV_Thietbi(cbbidDV.Text).Tables[0].Rows[0][1].ToString() + ", " + QueryTB.getDV_Thietbi(cbbidDV.Text).Tables[0].Rows[0][2].ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTonkho.Checked)
            {
                txtDonvi.Clear(); cbbidDV.Text = "";
                cbbidQN.Enabled = true;
                txtDonvi.Enabled = true;
                cbbidDV.Enabled = true;
            } else
            {
                txtDonvi.Clear(); cbbidDV.Text = "";
                cbbidQN.Enabled = false;
                txtDonvi.Enabled = false;
                cbbidDV.Enabled = false;
            }
        }
        #endregion

        public bool CheckTonkho(string _s)
        {
            if (_s.Equals("1"))
            {
                return cbTonkho.Checked = true;
            }
            else
            {
                return cbTonkho.Checked = false;
            }
        }
    }
}
