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
    public partial class Frm_ChangePass : Form
    {
        public Frm_ChangePass()
        {
            InitializeComponent();
        }
        private QueryTK SQL = new QueryTK();
        private string user, pass;

        public Frm_ChangePass(string _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pass = txtPassMoi.Text;
            if (!SQL.isTruePassword(user, txtPassCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else
            {
                if (!pass.Equals(txtXacNhan.Text))
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                }
                else
                {
                    SQL.ModifyPass(user, pass);
                    MessageBox.Show("Thành công");
                }
            }
        }
    }
}
