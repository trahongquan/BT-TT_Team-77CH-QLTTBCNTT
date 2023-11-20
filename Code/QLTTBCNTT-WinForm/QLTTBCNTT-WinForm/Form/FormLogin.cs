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
    public partial class FormLogin : Form
    {
        private string account = "", pass = "";
        private QueryTK SQL = new QueryTK();
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {

            account = txtAcc.Text;
            pass = txtPass.Text;
            bool b = false;
            FormMain fm = new FormMain(account);

            try
            {
                b = SQL.isTruePassword(account, pass);
            }
            catch
            {
                this.Close();
            }
               // MessageBox.Show(b.ToString());

            if (b)
            {
                txtPass.Text = "●●●●●●";
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                fm.Close();
                MessageBox.Show("Thông tin đăng nhập không chính xác");
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                txtPass.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
