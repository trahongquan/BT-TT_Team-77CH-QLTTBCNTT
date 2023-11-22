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
            if (_KindOfAcc.Equals("1"))
            {
                accMgrToolStripMenuItem.Visible = true;
            }
            if (i == 2)
            {
                accMgrToolStripMenuItem.Visible = false;
                btnTB.Visible = false;
                btnQN.Visible = false;
                btnDV.Visible = false;
                btnTBQN.Visible = false;
                btnTBDV.Visible = false;
                btnLTB.Visible = false;
            }
            if (i == 3)
            {
                accMgrToolStripMenuItem.Visible = false;
                btnDB.Visible = false;
            }

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        
        

        #region bổ trợ
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    //DisnableButton();
                    //Color color = SelectThemeColor();
                    //btnCloseChildForm.Visible = true;
                    currentButton = (Button)btnSender;
                    //currentButton.BackColor = Color.Pink;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            //this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region button header
        private void btnChildFormTB_Click(object sender, EventArgs e)
        {
        }

        private void btnChildFormQN_Click(object sender, EventArgs e)
        {
            FormQN FormQN = new FormQN();
            OpenChildForm(FormQN, sender);
        }

        private void btnChildFormTBDV_Click(object sender, EventArgs e)
        {
        }

        private void btnChildFormDMTB_Click(object sender, EventArgs e)
        {
            FormDMLTB FormDMLTB = new FormDMLTB();
            OpenChildForm(FormDMLTB, sender);
        }

        private void btnChildFormDV_Click(object sender, EventArgs e)
        {
            FormDV FormDV = new FormDV();
            OpenChildForm(FormDV, sender);
        }

        private void btnChildFormTBQN_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccMgr frm = new FormAccMgr();
            //this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ChangePass frm = new Frm_ChangePass(user);
            //this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
