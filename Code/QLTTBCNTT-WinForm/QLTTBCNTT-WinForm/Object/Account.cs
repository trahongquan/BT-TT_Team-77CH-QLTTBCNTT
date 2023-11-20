using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class Account
    {
        private int IDQuannhan;
        private string UserLogin;
        private string PassLogin;
        private int Active;
        private int KindOfAcc;
        private string TenQN;
        private string CMTQD;

        public Account() { }
        public Account(int iDQuannhan, string userLogin, string passLogin, int active, int kindOfAcc, string tenQN, string cMTQD)
        {
            IDQuannhan = iDQuannhan;
            UserLogin = userLogin;
            PassLogin = passLogin;
            Active = active;
            KindOfAcc = kindOfAcc;
            TenQN = tenQN;
            CMTQD = cMTQD;
        }

        public int IDQuannhan1 { get => IDQuannhan; set => IDQuannhan = value; }
        public string UserLogin1 { get => UserLogin; set => UserLogin = value; }
        public string PassLogin1 { get => PassLogin; set => PassLogin = value; }
        public int Active1 { get => Active; set => Active = value; }
        public int KindOfAcc1 { get => KindOfAcc; set => KindOfAcc = value; }
        public string TenQN1 { get => TenQN; set => TenQN = value; }
        public string CMTQD1 { get => CMTQD; set => CMTQD = value; }
    }
}
