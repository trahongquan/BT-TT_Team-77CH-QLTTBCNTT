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
    public partial class FormDMLTB : Form
    {
        QueryDashBoard Q = new QueryDashBoard();
        public FormDMLTB()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void FormDMLTB_Load(object sender, EventArgs e)
        {
            dtgvDMLTB.DataSource = Q.getDSLTB();
        }
    }
}
