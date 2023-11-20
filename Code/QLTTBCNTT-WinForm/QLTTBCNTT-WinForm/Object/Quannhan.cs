using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class Quannhan
    {
        private int idQuannhan, idDonvi;
        private string CMTQD, Ten, Capbac, Chucvu;

        public Quannhan()
        {
        }

        public Quannhan(string cMTQD, string ten, string capbac, string chucvu)
        {
            CMTQD = cMTQD;
            Ten = ten;
            Capbac = capbac;
            Chucvu = chucvu;
        }

        public Quannhan(/*int idQuannhan, */ string cMTQD, string ten, string capbac, string chucvu, int idDonvi)
        {
            //this.idQuannhan = idQuannhan;
            this.idDonvi = idDonvi;
            CMTQD = cMTQD;
            Ten = ten;
            Capbac = capbac;
            Chucvu = chucvu;
        }

        public int IdQuannhan { get => idQuannhan; set => idQuannhan = value; }
        public int IdDonvi { get => idDonvi; set => idDonvi = value; }
        public string CMTQD1 { get => CMTQD; set => CMTQD = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string Capbac1 { get => Capbac; set => Capbac = value; }
        public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
    }
}
