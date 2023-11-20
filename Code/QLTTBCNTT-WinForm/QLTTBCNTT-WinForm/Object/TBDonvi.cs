using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class TBDonvi
    {
        private int idTBDV, idDV, idTB;
        private string DateBorrow, DateReturn;
        public TBDonvi() { }

        public TBDonvi(/*int idTBDV,*/ int idDonvi, int idTBDonvi, string dateBorrow, string dateReturn)
        {
            //this.idTBDV = idTBDV;
            idDV = idDonvi;
            idTB = idTBDonvi;
            DateBorrow = dateBorrow;
            DateReturn = dateReturn;
        }

        public int IdTBDV { get => idTBDV; set => idTBDV = value; }
        public int IdDV { get => idDV; set => idDV = value; }
        public int IdTB { get => idTB; set => idTB = value; }
        
        public string DateBorrow1 { get => DateBorrow; set => DateBorrow = value; }
        public string DateReturn1 { get => DateReturn; set => DateReturn = value; }
    }
}
