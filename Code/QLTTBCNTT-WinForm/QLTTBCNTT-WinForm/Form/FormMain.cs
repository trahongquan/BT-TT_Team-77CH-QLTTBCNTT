using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;
        QueryTK SQL = new QueryTK();
        private string KindOfAcc = "1";
        string user = "";
        public FormMain()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public FormMain(string _user)
        {
            InitializeComponent();
            user = _user;
            string _KindOfAcc;

            _KindOfAcc = SQL.FindByUser(_user).Rows[0][0].ToString();
            int i = int.Parse(_KindOfAcc);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
